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
        public void InBlock_IJ_(string upcode)
        {
            string szTrCode = "IJ_";
            _RealDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_IJ_(string szTrCode)
        {
            _IJ__OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.upjo = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "upjo"));
            outData.highjo = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "highjo"));
            outData.unchgjo = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "unchgjo"));
            outData.lowjo = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lowjo"));
            outData.downjo = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "downjo"));

            outData.upjrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "upjrate"));
            outData.openjisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "openjisu"));
            outData.opentime = _RealDict[szTrCode].GetFieldData("OutBlock", "opentime");
            outData.highjisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "highjisu"));
            outData.hightime = _RealDict[szTrCode].GetFieldData("OutBlock", "hightime");
            outData.lowjisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lowjisu"));
            outData.lowtime = _RealDict[szTrCode].GetFieldData("OutBlock", "lowtime");
            outData.frgsvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "frgsvolume"));
            outData.orgsvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "orgsvolume"));
            outData.frgsvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "frgsvalue"));
            outData.orgsvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "orgsvalue"));
            outData.upcode = _RealDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}