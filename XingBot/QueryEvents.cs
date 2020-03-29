using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;
using XingBot.Properties;

namespace XingBot
{
    public partial class QueryCtrl : _IXAQueryEvents
    {
        private Dictionary<string, IXAQuery> _QueryDict = new Dictionary<string, IXAQuery>();


        public QueryCtrl()
        {
            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid IID_QueryEvents = typeof(_IXAQueryEvents).GUID;


            _QueryDict["1901"] = new XAQuery
            {
                ResFileName = Properties.Settings.Default.root_path + @"res\t1901.res" //ETF현재가
            };
            icpc = (IConnectionPointContainer)_QueryDict["1901"];
            icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            Console.WriteLine("QueryCtrl생성자완료");
        }

        // Query
        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine(szTrCode);
            string Code = m_Query.GetFieldData(szTrCode + "OutBlock", "shcode", 0);

            for (int i = 0; i < 28; i++)
            {
                row[i + 3] = m_Queryt1901.GetFieldData(szTrCode + "OutBlock", strArrt1901Name[i], 0);
            }

            for (int i = 30; i < 99; i++)
            {
                row[i + 3] = m_Queryt1901.GetFieldData(szTrCode + "OutBlock", strArrt1901Name[i], 0);
            }

            dt1901.Rows.Add(row);
        }

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            // ptForm.lblMessage.Text = nMessageCode;
            Console.WriteLine(nMessageCode + "  " + szMessage);
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            m_Queryt1901.GetFieldChartRealData(szTrCode + "OutBlock", "shcode");
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
        }
    }
}