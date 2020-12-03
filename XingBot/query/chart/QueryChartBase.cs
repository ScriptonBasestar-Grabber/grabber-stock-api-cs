using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using CsvHelper;
using DataLib.util;
using log4net;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.query
{
    public abstract class QueryChartBase : _IXAQueryEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("QueryChartBase");
        protected readonly IXAQuery _query;
        protected readonly ResModel _resModel;
        protected int _codeIdx;
        protected Action<string> _beforeAction = (szTrCode) => { Console.WriteLine(szTrCode + "empty beforeAction"); };
        public Action<string> BeforeAction { set => _beforeAction = value; }
        protected Action<string> _afterAction = (szTrCode) => { Console.WriteLine(szTrCode + "empty afterAction"); };
        public Action<string> AfterAction { set => _beforeAction = value; }

        protected Action _action;
        protected FileInfo fi;


        public QueryChartBase(string szTrCode)
        {
            var resFileName = Path.Combine(Settings.Default.root_path, "Res", szTrCode + ".res");
            _resModel = ReadResFile.Read(resFileName);
            _codeIdx = 0;

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;

            _query = new XAQuery
            {
                ResFileName = resFileName
            };
            icpc = (IConnectionPointContainer)_query;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            LOG.Info($"QueryChartBase 생성자완료 szTrCode: {szTrCode}");
        }

        protected abstract void InBlock(string shcode, bool isNext = false);

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            _beforeAction(szTrCode);
            LOG.Info($"_IXAQueryEvents.ReceiveData szTrCode: {szTrCode}");
            //using (var writer = new StreamWriter(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv"))
            //using (var writer = new StreamWriter(fi.Open(FileMode.Append)))
            //using (var writer = new StreamWriter(fi.AppendWrite()))
            using (var writer = fi.AppendText())
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                OutBlock(_resModel, _query, csv);
            }
            _afterAction(szTrCode);
            if (_action != null)
            {
                Thread.Sleep(1000 / _query.GetTRCountPerSec(szTrCode) + 10);
                _action();
            }
        }

        protected abstract void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer);

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            LOG.Info("_IXAQueryEvents.ReceiveMessage");
            LOG.Info(bIsSystemError);
            LOG.Info(nMessageCode);
            LOG.Info(szMessage);
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }
    }
}