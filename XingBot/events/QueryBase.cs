using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using CsvHelper;
using DataLib.util;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.tr
{
    public abstract class QueryBase : _IXAQueryEvents
    {
        protected readonly IXAQuery _query;
        protected readonly ResModel _resModel;

        public QueryBase(string szTrCode)
        {
            _resModel = ReadResFile.Read(Settings.Default.root_path + @"\Res\" + szTrCode + ".res");

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            _query = new XAQuery
            {
                ResFileName = Settings.Default.root_path + @"\Res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer)_query;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            Console.WriteLine("QueryEvents 생성자완료");
        }

        public abstract void InBlock();

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            FileInfo fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv");
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }

            // using (var writer = new StreamWriter(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv"))
            using (var writer = new StreamWriter(fi.OpenWrite()))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                OutBlock(_resModel, _query, csv);
            }
        }

        protected abstract void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer);

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveMessage");
            Console.WriteLine(bIsSystemError);
            Console.WriteLine(nMessageCode);
            Console.WriteLine(szMessage);
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
            //OutBlock(_resModel, _query, csv);
        }
    }
}