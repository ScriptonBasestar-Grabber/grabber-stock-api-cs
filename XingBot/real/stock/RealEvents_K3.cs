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
        public void InBlock_K3_(string shcode)
        {
            string szTrCode = "K3_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_K3_(string szTrCode)
        {
            _K3__OutBlock outData;
            outData.chetime = _RealDict[szTrCode].GetFieldData("OutBlock", "chetime");
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.price = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.opentime = _RealDict[szTrCode].GetFieldData("OutBlock", "opentime");
            outData.open = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.hightime = _RealDict[szTrCode].GetFieldData("OutBlock", "hightime");
            outData.high = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.lowtime = _RealDict[szTrCode].GetFieldData("OutBlock", "lowtime");
            outData.low = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.cgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "cgubun");
            outData.cvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.mdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdvolume"));
            outData.mdchecnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdchecnt"));
            outData.msvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msvolume"));
            outData.mschecnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mschecnt"));
            outData.cpower = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cpower"));
            outData.w_avrg = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "w_avrg"));
            outData.offerho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.bidho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.status = _RealDict[szTrCode].GetFieldData("OutBlock", "status");
            outData.jnilvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}