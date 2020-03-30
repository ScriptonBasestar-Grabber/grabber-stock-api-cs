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
        public void InBlock_t9907()
        {
            string szTrCode = "t9907";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        private void OutBlock_t9907(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t9907OutBlock1 outData;
                outData.lastym = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "lastym", i);
                outData.lastnm = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "lastnm", i);
            }
        }
    }
}