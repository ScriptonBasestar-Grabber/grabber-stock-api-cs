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
        public void InBlock_I5_(string shcode)
        {
            string szTrCode = "I5_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_I5_(string szTrCode)
        {
            _I5__OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");

            outData.price = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));

            outData.volume = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.navdiff = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "navdiff"));
            outData.nav = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "nav"));
            outData.navchange = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "navchange"));
            outData.crate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "crate"));
            outData.grate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "grate"));
            outData.jisu = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jisu"));
            outData.jichange = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jichange"));
            outData.jirate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jirate"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}