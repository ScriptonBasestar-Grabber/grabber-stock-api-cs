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
        public void InBlock_FC0(string futcode)
        {
            string szTrCode = "FC0";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_FC0(string szTrCode)
        {
            _FC0_OutBlock outData;
            outData.chetime = _realDict[szTrCode].GetFieldData( "OutBlock", "chetime");
            outData.sign = _realDict[szTrCode].GetFieldData( "OutBlock", "sign");
            outData.change = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "change"));
            outData.drate = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "drate"));
            outData.price = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "price"));
            outData.open = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "open"));
            outData.high = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "high"));
            outData.low = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "low"));
            outData.cgubun = _realDict[szTrCode].GetFieldData( "OutBlock", "cgubun");
            outData.cvolume = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "cvolume"));
            outData.volume = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "volume"));
            outData.value = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "value"));
            outData.mdvolume = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "mdvolume"));
            outData.mdchecnt = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "mdchecnt"));
            outData.msvolume = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "msvolume"));
            outData.mschecnt = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "mschecnt"));
            outData.cpower = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "cpower"));
            outData.offerho1 = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "offerho1"));
            outData.bidho1 = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "bidho1"));
            outData.openyak = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "openyak"));
            outData.k200jisu = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "k200jisu"));
            outData.theoryprice = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "theoryprice"));
            outData.kasis = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "kasis"));
            outData.sbasis = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "sbasis"));
            outData.ibasis = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "ibasis"));
            outData.openyakcha = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "openyakcha"));
            outData.jgubun = _realDict[szTrCode].GetFieldData( "OutBlock", "jgubun");
            outData.jnilvolume = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "jnilvolume"));
            outData.futcode = _realDict[szTrCode].GetFieldData( "OutBlock", "futcode");
        }
    }
}
