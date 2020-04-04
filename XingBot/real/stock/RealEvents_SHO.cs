using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot
{
    public partial class RealEvents : _IXARealEvents
    {
        public void InBlock_SHO(string updnlmtgubun)
        {
            string szTrCode = "SHO";
            _RealDict[szTrCode].SetFieldData("InBlock", "updnlmtgubun", updnlmtgubun);
        }

        private void OutBlock_SHO(string szTrCode)
        {
            _SHO_OutBlock outData;
            outData.sijanggubun = _RealDict[szTrCode].GetFieldData("OutBlock", "sijanggubun");
            outData.hname = _RealDict[szTrCode].GetFieldData("OutBlock", "hname");
            outData.price = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.volincrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volincrate"));
            outData.updnlmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "updnlmtprice"));
            outData.updnlmtdrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "updnlmtdrate"));
            outData.jnilvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.gwangubun = _RealDict[szTrCode].GetFieldData("OutBlock", "gwangubun");
            outData.undergubun = _RealDict[szTrCode].GetFieldData("OutBlock", "undergubun");
            outData.tgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "tgubun");
            outData.wgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "wgubun");
            outData.dishonest = _RealDict[szTrCode].GetFieldData("OutBlock", "dishonest");
            outData.jkrate = _RealDict[szTrCode].GetFieldData("OutBlock", "jkrate");
        }
    }
}