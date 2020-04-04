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
        public void InBlock_MK2(string upcode)
        {
            string szTrCode = "MK2";
            _RealDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_MK2(string szTrCode)
        {
            _MK2_OutBlock outData;
            outData.date = _RealDict[szTrCode].GetFieldData("OutBlock", "date");
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.kodate = _RealDict[szTrCode].GetFieldData("OutBlock", "kodate");
            outData.kotime = _RealDict[szTrCode].GetFieldData("OutBlock", "kotime");
            outData.open = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.high = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.low = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.price = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.uprate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "uprate"));
            outData.bidho = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.bidrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem"));
            outData.offerho = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.offerrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem"));
            outData.volume = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.xsymbol = _RealDict[szTrCode].GetFieldData("OutBlock", "xsymbol");
            outData.cvolume = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
        }
    }
}
