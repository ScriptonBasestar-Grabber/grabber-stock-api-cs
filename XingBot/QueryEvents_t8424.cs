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
        public void InBlock_t8424()
        {
            string szTrCode = "t8424";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "gubun1", 0, "");
        }

        private void OutBlock_t8424(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8424OutBlock outData;
                outData.hname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "hname", i);
                outData.upcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "upcode", i);
            }
        }
    }
}