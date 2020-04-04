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
        public void InBlock_PH_(string shcode)
        {
            string szTrCode = "PH_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_PH_(string szTrCode)
        {
            _PH__OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.price = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.sign = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sign"));
            outData.change = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "drate"));
            outData.cdhrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdhrem"));
            outData.cshrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cshrem"));
            outData.bdhrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdhrem"));
            outData.bshrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bshrem"));
            outData.cdhvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdhvolume"));
            outData.cshvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cshvolume"));
            outData.bdhvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdhvolume"));
            outData.bshvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bshvolume"));
            outData.dwcvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dwcvolume"));
            outData.swcvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "swcvolume"));
            outData.djcvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "djcvolume"));
            outData.sjcvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sjcvolume"));
            outData.tdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tdvolume"));
            outData.tsvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tsvolume"));
            outData.tvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tvol"));
            outData.dwcvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dwcvalue"));
            outData.swcvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "swcvalue"));
            outData.djcvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "djcvalue"));
            outData.sjcvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sjcvalue"));
            outData.tdvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tdvalue"));
            outData.tsvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tsvalue"));
            outData.tval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tval"));
            outData.pdgvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "pdgvolume"));
            outData.psgvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "psgvolume"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}