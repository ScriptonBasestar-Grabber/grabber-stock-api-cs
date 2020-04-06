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
        public void InBlock_S4_(string shcode)
        {
            string szTrCode = "S4_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_S4_(string szTrCode)
        {
            _S4__OutBlock outData;
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.price = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.opentime = _realDict[szTrCode].GetFieldData("OutBlock", "opentime");
            outData.open = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.hightime = _realDict[szTrCode].GetFieldData("OutBlock", "hightime");
            outData.high = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.lowtime = _realDict[szTrCode].GetFieldData("OutBlock", "lowtime");
            outData.low = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}