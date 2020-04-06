using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using CsvHelper;
using DataLib.util;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.real.res;
using XingBot.tr;

namespace XingBot.tr
{
    public class QueryEvents : _IXAQueryEvents
    {
        private readonly IXAQuery _ixa;
        private readonly ResModel _resModel;
        private readonly string _szTrCode;

        public QueryEvents(string szTrCode)
        {
            this._szTrCode = szTrCode;

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;

            this._ixa = new XAQuery
            {
                ResFileName = Settings.Default.root_path + @"\Res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer) _ixa;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            // Console.WriteLine(Settings.Default.root_path);
            // Console.WriteLine(Settings.Default.root_path.ToString());
            // Console.WriteLine(Path.Combine(Settings.Default.root_path.ToString(), @"\Res\", szTrCode + ".res"));
            _resModel = ReadResFile.Read(Settings.Default.root_path + @"\Res\" + szTrCode + ".res");
        }

        public void InBlock(InBlockQuery action, StringDict sdict)
        {
            action(_szTrCode, _ixa, _resModel.Blocks[_szTrCode + "InBlock"], sdict);
        }

        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            switch (szTrCode)
            {
                case "t1981":
                    OutBlock(szTrCode, Tr_t1981.OutBlock_t1981);
                    break;
                case "t8424":
                    OutBlock(szTrCode, Tr_t8424.OutBlock_t8424);
                    break;
                case "t8432":
                    OutBlock(szTrCode, Tr_t8432.OutBlock_t8432);
                    break;
                case "t8433":
                    OutBlock(szTrCode, Tr_t8433.OutBlock_t8433);
                    break;
                case "t8435":
                    OutBlock(szTrCode, Tr_t8435.OutBlock_t8435);
                    break;
                case "t8436":
                    OutBlock(szTrCode, Tr_t8436.OutBlock_t8436);
                    break;
                case "t9907":
                    OutBlock(szTrCode, Tr_t9907.OutBlock_t9907);
                    break;
                case "t9942":
                    OutBlock(szTrCode, Tr_t9942.OutBlock_t9942);
                    break;
                default:
                    break;
            }
        }

        private void OutBlock(string szTrCode, OutBlockQuery action)
        {
            Console.WriteLine("=======================OutBLock Write===============================");
            Console.WriteLine(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv");
            FileInfo fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv");
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }
            // using (var writer = new StreamWriter(fi.OpenWrite()))
            using (var writer = new StreamWriter(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                int cnt;
                Console.WriteLine("===============1981 receive");
                cnt = _ixa.GetBlockCount(szTrCode + "OutBlock");
                for (var i = 0; i < cnt; i++)
                {
                    var result = new _t1981OutBlock()
                    {
                        ksp_cnt = _ixa.GetFieldData(szTrCode + "OutBlock", "ksp_cnt", i),
                        ksd_cnt = _ixa.GetFieldData(szTrCode + "OutBlock", "ksd_cnt", i),
                    };
                    Console.WriteLine(result.ksp_cnt);
                    Console.WriteLine(result.ksd_cnt);
                    Console.WriteLine("f9f9f9f9f9");
                }
                
                csv.WriteHeader<_t1981OutBlock1>();
                cnt = _ixa.GetBlockCount(szTrCode + "OutBlock1");
                for (var i = 0; i < cnt; i++)
                {
                    Console.WriteLine("라인수:"+i);
                    var result = new _t1981OutBlock1()
                    {
                        shcode = _ixa.GetFieldData(szTrCode + "OutBlock1", "shcode", i),
                        expcode = _ixa.GetFieldData(szTrCode + "OutBlock1", "expcode", i),
                        hname = _ixa.GetFieldData(szTrCode + "OutBlock1", "hname", i),
                        price = _ixa.GetFieldData(szTrCode + "OutBlock1", "price", i),
                        sign = _ixa.GetFieldData(szTrCode + "OutBlock1", "sign", i),
                        change = _ixa.GetFieldData(szTrCode + "OutBlock1", "change", i),
                        rate = decimal.Parse(_ixa.GetFieldData(szTrCode + "OutBlock1", "rate", i)),
                        volume = _ixa.GetFieldData(szTrCode + "OutBlock1", "volume", i),
                        value = _ixa.GetFieldData(szTrCode + "OutBlock1", "value", i),
                        mkt_gb = _ixa.GetFieldData(szTrCode + "OutBlock1", "mkt_gb", i),
                    };
                    Console.WriteLine(result.shcode);
                    csv.WriteRecord<_t1981OutBlock1>(result);
                    // csv.NextRecord();
                }
                // action(szTrCode, _ixa, _resModel.Blocks["OutBlock"], csv);
                Console.WriteLine("+80990u09uj080uj9");
            }
        }

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveMessage  ");
            Console.WriteLine(bIsSystemError);
            Console.WriteLine(nMessageCode);
            Console.WriteLine(szMessage);
            // ptForm.lblMessage.Text = nMessageCode;
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            if (szTrCode == "t1981")
            {
                OutBlock(szTrCode, Tr_t1981.OutBlock_t1981);
            }
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode); if (szTrCode == "t1981")
            {
                OutBlock(szTrCode, Tr_t1981.OutBlock_t1981);
            }
        }
    }
}