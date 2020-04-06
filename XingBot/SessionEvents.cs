using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XA_SESSIONLib;

namespace XingBot.real
{
    public class SessionEvents : _IXASessionEvents
    {
        private IXASession m_Session;
        protected UCOMIConnectionPoint m_icp;
        protected UCOMIConnectionPointContainer m_icpc;

        public SessionEvents()
        {
            int m_dwCookie = 0;
            m_Session = new XASession();
            m_icpc = (UCOMIConnectionPointContainer)m_Session;
            Guid IID_SessionEvents = typeof(_IXASessionEvents).GUID;
            m_icpc.FindConnectionPoint(ref IID_SessionEvents, out m_icp);
            m_icp.Advise(this, out m_dwCookie);
        }

        ~SessionEvents()
        {
            m_Session.Logout();
        }

        public void Login(string UserName, string UserPass, string CertPass)
        {
            m_Session.ConnectServer("api.ebestsec.co.kr", 20001);
            m_Session.Login(UserName, UserPass, CertPass, (int)XA_SESSIONLib.XA_SERVER_TYPE.XA_SIMUL_SERVER, true);
        }
        void _IXASessionEvents.Login(string szCode, string szMsg)
        {
            Console.WriteLine("login");
            Console.WriteLine(szCode);
            Console.WriteLine(szMsg);
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
