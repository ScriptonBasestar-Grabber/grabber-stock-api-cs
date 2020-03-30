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
        public void InBlock_t1981(string mkt_gb)
        {
            string szTrCode = "t1981";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "mkt_gb", 0, mkt_gb);
        }

        private void OutBlock_t1981(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t1981OutBlock1 outData;
                outData.shcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "shcode", i);
                outData.expcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "expcode", i);
                outData.hname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "hname", i);
                outData.price = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "price", i);
                outData.sign = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "sign", i);
                outData.change = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "change", i);
                outData.rate = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "rate", i));
                outData.volume = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "volume", i);
                outData.value = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "value", i);
                outData.mkt_gb = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "mkt_gb", i);
            }
        }
    }
}