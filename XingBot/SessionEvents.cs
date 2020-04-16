using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XA_SESSIONLib;
using XingBot.tr;

namespace XingBot
{
    public class SessionEvents : _IXASessionEvents
    {
        private readonly IXASession _session;
        private readonly Action _loginAction;

        public SessionEvents(Action loginAction)
        {
            this._loginAction = loginAction;

            int dwCookie;
            UCOMIConnectionPoint icp;
            UCOMIConnectionPointContainer icpc;

            _session = new XASession();

            icpc = (UCOMIConnectionPointContainer) _session;
            Guid IID_SessionEvents = typeof(_IXASessionEvents).GUID;
            icpc.FindConnectionPoint(ref IID_SessionEvents, out icp);
            icp.Advise(this, out dwCookie);
        }

        ~SessionEvents()
        {
            _session.Logout();
        }

        public void Login(string UserName, string UserPass, string CertPass)
        {
            _session.ConnectServer("api.ebestsec.co.kr", 20001);
            _session.Login(UserName, UserPass, CertPass, (int) XA_SESSIONLib.XA_SERVER_TYPE.XA_SIMUL_SERVER, true);
        }

        void _IXASessionEvents.Login(string szCode, string szMsg)
        {
            Console.WriteLine("login");
            Console.WriteLine(szCode);
            Console.WriteLine(szMsg);
            _loginAction();
            Console.WriteLine("call query init next line");
        }

        void _IXASessionEvents.Logout()
        {
            Console.WriteLine("logout");
        }

        void _IXASessionEvents.Disconnect()
        {
            Console.WriteLine("disconnected");
            //TODO reconnect
        }
    }
}