using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XA_SESSIONLib;
using XingBot.tr;

namespace XingBot
{
    public class SessionEvents : _IXASessionEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("SessionEvent");

        private readonly IXASession _session;
        private readonly Action _loginAction;

        public SessionEvents(Action loginAction)
        {
            this._loginAction = loginAction;

            int dwCookie;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;

            _session = new XASession();

            icpc = (IConnectionPointContainer)_session;
            Guid IID_SessionEvents = typeof(_IXASessionEvents).GUID;
            icpc.FindConnectionPoint(ref IID_SessionEvents, out icp);
            icp.Advise(this, out dwCookie);
        }

        ~SessionEvents()
        {
            _session.Logout();
        }

        public void Login(string username, string userpass, string certpass)
        {
            _session.ConnectServer("api.ebestsec.co.kr", 20001);
            _session.Login(username, userpass, certpass, (int)XA_SESSIONLib.XA_SERVER_TYPE.XA_SIMUL_SERVER, true);
        }

        void _IXASessionEvents.Login(string szCode, string szMsg)
        {
            LOG.Debug($"login s- szCode: {szCode} szMsg: {szMsg}");
            _loginAction();
            LOG.Debug("login e");
        }

        void _IXASessionEvents.Logout()
        {
            LOG.Debug("logout");
        }

        void _IXASessionEvents.Disconnect()
        {
            LOG.Debug("disconnect");
        }
    }
}