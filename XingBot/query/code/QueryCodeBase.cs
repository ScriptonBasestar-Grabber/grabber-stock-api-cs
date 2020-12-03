using System;
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
    public abstract class QueryCodeBase : _IXAQueryEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("QueryCodeBase");
        protected readonly IXAQuery _query;
        protected readonly ResModel _resModel;

        protected Action _action;

        public QueryCodeBase(string szTrCode)
        {
            var resFileName = Path.Combine(Settings.Default.root_path, "Res", szTrCode + ".res");
            _resModel = ReadResFile.Read(resFileName);

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

            LOG.Info($"QueryCodeBase 생성자완료 szTrCode: {szTrCode}");
        }

        protected abstract void InBlock();

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            LOG.Info($"_IXAQueryEvents.ReceiveData szTrCode: {szTrCode}");
            FileInfo fi = new FileInfo(Path.Combine(Settings.Default.data_path, szTrCode + ".csv"));
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }

            // TODO write date to ~~
            using (var writer = new StreamWriter(fi.OpenWrite()))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                OutBlock(_resModel, _query, csv);
            }
            if (_action != null) {
                Thread.Sleep(1000/_query.GetTRCountPerSec(szTrCode) + 10);
                _action();
            }
        }

        protected abstract void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer);
        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            LOG.Info($"_IXAQueryEvents.ReceiveMessage biSystemError: {bIsSystemError}, nMessageCode: {nMessageCode}, szMessage: {szMessage}");
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            LOG.Info($"_IXAQueryEvents.ReceiveChartRealData szTrCode: {szTrCode}");
            //OutBlock(_resModel, _query, csv);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            LOG.Info($"_IXAQueryEvents.ReceiveSearchRealData szTrCode: {szTrCode}");
            //OutBlock(_resModel, _query, csv);
        }
    }
}