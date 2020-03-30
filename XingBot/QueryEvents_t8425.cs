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
        public void InBlock_t8425()
        {
            string szTrCode = "t8425";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        private void OutBlock_t8425(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8425OutBlock outData;
                outData.tmname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "tmname", i);
                outData.tmcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "tmcode", i);
            }
        }
    }
}