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
        public void InBlock_YJ_(string upcode)
        {
            string szTrCode = "YJ_";
            _realDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_YJ_(string szTrCode)
        {
            _YJ__OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.jisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.upcode = _realDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}