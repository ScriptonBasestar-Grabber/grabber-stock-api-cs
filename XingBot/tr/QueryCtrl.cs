using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;

namespace XingBot.tr
{
    public class QueryCtrl : _IXAQueryEvents
    {
        // private readonly Dictionary<string, QueryEvents> _queryDict = new Dictionary<string, QueryEvents>();

        // public QueryCtrl()
        // {
        //     string code;
        //
        //     code = "t1901";
        //     this._queryDict[code] = new QueryEvents(code, query =>
        //     {
        //         query.SetFieldData(code+"InBlock", "shcode", 0, "");
        //         ChartIndex.SetFieldData("ChartIndexInBlock", "indexid", 0, "값")
        //     });
        //     Console.WriteLine("QueryCtrl 생성자완료");
        // }
        //
        // void SetInitTr(string szTrCode)
        // {
        //     QueryEvents queryEvents = new QueryEvents("t1981", IXAQuery, delegate(IXAQuery query)
        //     {
        //     });
        // }

        // Query
        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            if (szTrCode == "t1901")
            {
                // _queryDict[szTrCode].OutBlock(szTrCode);
                // OutBlock_t843(szTrCode);
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
            // Console.WriteLine("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            // var result = _queryDict[szTrCode].GetFieldChartRealData(szTrCode + "OutBlock", "shcode");
            // Console.WriteLine(result);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
        }
    }
}