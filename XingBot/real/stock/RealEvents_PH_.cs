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
        public void InBlock_PH_(string shcode)
        {
            string szTrCode = "PH_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_PH_(string szTrCode)
        {
            _PH__OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.price = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "sign"));
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.drate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cdhrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdhrem"));
            outData.cshrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cshrem"));
            outData.bdhrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdhrem"));
            outData.bshrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bshrem"));
            outData.cdhvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdhvolume"));
            outData.cshvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cshvolume"));
            outData.bdhvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdhvolume"));
            outData.bshvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bshvolume"));
            outData.dwcvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dwcvolume"));
            outData.swcvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "swcvolume"));
            outData.djcvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "djcvolume"));
            outData.sjcvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "sjcvolume"));
            outData.tdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tdvolume"));
            outData.tsvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tsvolume"));
            outData.tvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tvol"));
            outData.dwcvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dwcvalue"));
            outData.swcvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "swcvalue"));
            outData.djcvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "djcvalue"));
            outData.sjcvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "sjcvalue"));
            outData.tdvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tdvalue"));
            outData.tsvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tsvalue"));
            outData.tval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tval"));
            outData.pdgvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "pdgvolume"));
            outData.psgvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "psgvolume"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}