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
        public void InBlock_NC0(string futcode)
        {
            string szTrCode = "NC0";
            _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_NC0(string szTrCode)
        {
            _NC0_OutBlock outData;
            outData.chetime = _RealDict[szTrCode].GetFieldData("OutBlock", "futcode");
            outData.chetime1 = _RealDict[szTrCode].GetFieldData("OutBlock", "chetime");
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.drate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.price = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.open = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "open"));
            outData.high = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "high"));
            outData.low = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "low"));
            outData.cgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "cgubun");
            outData.cvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvolume"));
            outData.volume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "volume"));
            outData.value = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "value"));
            outData.mdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdvolume"));
            outData.mdchecnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdchecnt"));
            outData.msvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msvolume"));
            outData.mschecnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mschecnt"));
            outData.cpower = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cpower"));
            outData.offerho1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.openyak = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "openyak"));
            outData.k200jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "k200jisu"));
            outData.theoryprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "theoryprice"));
            outData.kasis = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "kasis"));
            outData.sbasis = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sbasis"));
            outData.ibasis = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ibasis"));
            outData.openyakcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "openyakcha"));
            outData.jgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "jgubun");
            outData.jnilvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.futcode = _RealDict[szTrCode].GetFieldData("OutBlock", "basprice");
        }
    }
}
