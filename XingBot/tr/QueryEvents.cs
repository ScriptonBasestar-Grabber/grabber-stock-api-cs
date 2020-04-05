using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;

namespace XingBot
{
    public partial class QueryCtrl : _IXAQueryEvents
    {
        private Dictionary<string, IXAQuery> _QueryDict = new Dictionary<string, IXAQuery>();

        public QueryCtrl(string[] codes)
        {
            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid IID_QueryEvents = typeof(_IXAQueryEvents).GUID;

            foreach (var code in codes)
            {
                // dwCookie = 0;
                _QueryDict[code] = new XAQuery
                {
                    ResFileName = Properties.Settings.Default.root_path + @"\res\" + code + ".res"
                };
                icpc = (IConnectionPointContainer) _QueryDict[code];
                icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
                icp.Advise(this, out dwCookie);
            }

            Console.WriteLine("QueryCtrl 생성자완료");
        }

        // Query
        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            if (szTrCode == "t8436")
            {
                OutBlock_t8436(szTrCode);
            }
            else if (szTrCode == "t8425")
            {
                OutBlock_t8425(szTrCode);
            }
            else if (szTrCode == "t8432")
            {
                OutBlock_t8432(szTrCode);
            }
            else if (szTrCode == "t8433")
            {
                OutBlock_t8433(szTrCode);
            }
            else if (szTrCode == "t8435")
            {
                OutBlock_t8435(szTrCode);
            }
            else if (szTrCode == "t8424")
            {
                OutBlock_t8424(szTrCode);
            }
            else if (szTrCode == "t1981")
            {
                OutBlock_t1981(szTrCode);
            }
            else if (szTrCode == "t9942")
            {
                OutBlock_t9942(szTrCode);
            }
            else if (szTrCode == "t9907")
            {
                OutBlock_t9907(szTrCode);
            }
        }

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveMessage ");
            // ptForm.lblMessage.Text = nMessageCode;
            Console.WriteLine(nMessageCode + "  " + szMessage);
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            var result = _QueryDict[szTrCode].GetFieldChartRealData(szTrCode + "OutBlock", "shcode");
            Console.WriteLine(result);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
        }
    }
}