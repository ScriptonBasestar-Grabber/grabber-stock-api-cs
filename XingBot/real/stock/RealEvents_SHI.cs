using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_SHI(string updnlmtgubun)
        {
            string szTrCode = "SHI";
            _realDict[szTrCode].SetFieldData("InBlock", "updnlmtgubun", updnlmtgubun);
        }

        private void OutBlock_SHI(string szTrCode)
        {
            _SHI_OutBlock outData;
            outData.sijanggubun = _realDict[szTrCode].GetFieldData("OutBlock", "sijanggubun");
            outData.hname = _realDict[szTrCode].GetFieldData("OutBlock", "hname");
            outData.price = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.volincrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volincrate"));
            outData.totofferrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totofferrem"));
            outData.totbidrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totbidrem"));
            outData.updnlmtstime = _realDict[szTrCode].GetFieldData("OutBlock", "updnlmtstime");
            outData.updnlmtdaycnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "updnlmtdaycnt"));
            outData.jnilvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.gwangubun = _realDict[szTrCode].GetFieldData("OutBlock", "gwangubun");
            outData.undergubun = _realDict[szTrCode].GetFieldData("OutBlock", "undergubun");
            outData.tgubun = _realDict[szTrCode].GetFieldData("OutBlock", "tgubun");
            outData.wgubun = _realDict[szTrCode].GetFieldData("OutBlock", "wgubun");
            outData.dishonest = _realDict[szTrCode].GetFieldData("OutBlock", "dishonest");
            outData.jkrate = _realDict[szTrCode].GetFieldData("OutBlock", "jkrate");
        }
    }
}