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
        public void InBlock_S3_(string shcode)
        {
            string szTrCode = "S3_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_S3_(string szTrCode)
        {
            _S3__OutBlock outData;
            outData.chetime = _realDict[szTrCode].GetFieldData("OutBlock", "chetime");
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.price = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.opentime = _realDict[szTrCode].GetFieldData("OutBlock", "opentime");
            outData.open = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.hightime = _realDict[szTrCode].GetFieldData("OutBlock", "hightime");
            outData.high = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.lowtime = _realDict[szTrCode].GetFieldData("OutBlock", "lowtime");
            outData.low = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.cgubun = _realDict[szTrCode].GetFieldData("OutBlock", "cgubun");
            outData.cvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.mdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume"));
            outData.mdchecnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdchecnt"));
            outData.msvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume"));
            outData.mschecnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mschecnt"));
            outData.cpower = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cpower"));
            outData.w_avrg = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "w_avrg"));
            outData.offerho = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.bidho = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.status = _realDict[szTrCode].GetFieldData("OutBlock", "status");
            outData.jnilvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}