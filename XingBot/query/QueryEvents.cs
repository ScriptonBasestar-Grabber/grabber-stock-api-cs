using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using CsvHelper;
using DataLib.util;
using log4net;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.tr
{
    public class QueryEvents : _IXAQueryEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("QueryEvents");
        private readonly IXAQuery _ixa;
        private readonly ResModel _resModel;
        private readonly OutBlockQuery _receiveAction;

        public QueryEvents(string szTrCode, OutBlockQuery receiveAction)
        {
            _resModel = ReadResFile.Read(Settings.Default.root_path + @"\Res\" + szTrCode + ".res");
            _receiveAction = receiveAction;

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;

            _ixa = new XAQuery
            {
                ResFileName = Settings.Default.root_path + @"\Res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer) _ixa;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            LOG.Info("QueryEvents 생성자완료");
        }

        public void InBlock(StringDict sdict)
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { _ixa.SetFieldData(block.Name, row.Name, 0, sdict[row.Name]); });
            _ixa.Request(false);
        }

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveData " + szTrCode);
            OutBlock(szTrCode);
        }

        private void OutBlock(string szTrCode)
        {
            FileInfo fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv");
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }

            using (var writer = new StreamWriter(fi.OpenWrite()))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                _receiveAction(_resModel, _ixa, csv);
            }
        }

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            LOG.Info("_IXAQueryEvents.ReceiveMessage  ");
            LOG.Info(bIsSystemError);
            LOG.Info(nMessageCode);
            LOG.Info(szMessage);
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            OutBlock(szTrCode);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            LOG.Info("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
            OutBlock(szTrCode);
        }
    }
}