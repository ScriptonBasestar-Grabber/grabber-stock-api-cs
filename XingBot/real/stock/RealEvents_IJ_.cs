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
        public void InBlock_IJ_(string upcode)
        {
            string szTrCode = "IJ_";
            _realDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_IJ_(string szTrCode)
        {
            _IJ__OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.jisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.upjo = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "upjo"));
            outData.highjo = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "highjo"));
            outData.unchgjo = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "unchgjo"));
            outData.lowjo = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lowjo"));
            outData.downjo = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "downjo"));

            outData.upjrate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "upjrate"));
            outData.openjisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "openjisu"));
            outData.opentime = _realDict[szTrCode].GetFieldData("OutBlock", "opentime");
            outData.highjisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "highjisu"));
            outData.hightime = _realDict[szTrCode].GetFieldData("OutBlock", "hightime");
            outData.lowjisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lowjisu"));
            outData.lowtime = _realDict[szTrCode].GetFieldData("OutBlock", "lowtime");
            outData.frgsvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "frgsvolume"));
            outData.orgsvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "orgsvolume"));
            outData.frgsvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "frgsvalue"));
            outData.orgsvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "orgsvalue"));
            outData.upcode = _realDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}