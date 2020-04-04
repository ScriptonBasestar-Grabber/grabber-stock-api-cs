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
        public void InBlock_YJ_(string upcode)
        {
            string szTrCode = "YJ_";
            _RealDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_YJ_(string szTrCode)
        {
            _YJ__OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.upcode = _RealDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}