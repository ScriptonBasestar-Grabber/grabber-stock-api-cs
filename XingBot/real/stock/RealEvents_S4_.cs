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
        public void InBlock_S4_(string shcode)
        {
            string szTrCode = "S4_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_S4_(string szTrCode)
        {
            _S4__OutBlock outData;
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
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}