using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XingBot.real;
using XingBot.res;
using XingBot.tr;

namespace XingBot
{
    public class XingManager
    {
        SessionEvents session;
        QueryCtrl queryCtrl;
        RealCtrl realCtrl;
        Tr_t4201 tr4201;

        Thread thread;
        public XingManager()
        {
            queryCtrl = new QueryCtrl();
            realCtrl = new RealCtrl();
            session = new SessionEvents(() =>
            {
                queryCtrl.QueryInit();
            });

            //query init 끝나고 실행
            tr4201 = new Tr_t4201(new _t4201InBlock()
            {
                shcode = "",
            });
            tr4201.InBlock();
            thread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(6000);
                    queryCtrl.
                }
            });
            thread.Start();

        }

        public void Login()
        {
            session.Login("","","");
        }

        public void Real()
        {

        }

        public void QueryInit()
        {

        }

        public void QueryChart()
        {

        }

    }
}
