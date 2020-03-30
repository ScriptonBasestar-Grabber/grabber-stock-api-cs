using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot
{
    public partial class QueryCtrl : _IXAQueryEvents
    {
        public void InBlock_t9942()
        {
            string szTrCode = "t9942";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        private void OutBlock_t9942(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t1981OutBlock1 outData;
                outData.hname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "hname", i);
                outData.shcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "shcode", i);
                outData.expcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "expcode", i);
            }
        }
    }
}