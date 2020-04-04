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
        public void InBlock_I5_(string shcode)
        {
            string szTrCode = "I5_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_I5_(string szTrCode)
        {
            _I5__OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");

            outData.price = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));

            outData.volume = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.navdiff = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "navdiff"));
            outData.nav = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "nav"));
            outData.navchange = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "navchange"));
            outData.crate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "crate"));
            outData.grate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "grate"));
            outData.jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.jichange = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jichange"));
            outData.jirate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jirate"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}