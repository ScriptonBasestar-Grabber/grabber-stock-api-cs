using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_MK2(string upcode)
        {
            string szTrCode = "MK2";
            _realDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_MK2(string szTrCode)
        {
            _MK2_OutBlock outData;
            outData.date = _realDict[szTrCode].GetFieldData("OutBlock", "date");
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.kodate = _realDict[szTrCode].GetFieldData("OutBlock", "kodate");
            outData.kotime = _realDict[szTrCode].GetFieldData("OutBlock", "kotime");
            outData.open = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.high = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.low = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.price = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.uprate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "uprate"));
            outData.bidho = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.bidrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem"));
            outData.offerho = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.offerrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem"));
            outData.volume = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.xsymbol = _realDict[szTrCode].GetFieldData("OutBlock", "xsymbol");
            outData.cvolume = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
        }
    }
}
