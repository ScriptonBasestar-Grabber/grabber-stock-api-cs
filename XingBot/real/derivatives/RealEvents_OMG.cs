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
        public void InBlock_OMG(string optcode)
        {
            string szTrCode = "OMG";
            _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OMG(string szTrCode)
        {
            _OMG_OutBlock outData;
            outData.chetime = _RealDict[szTrCode].GetFieldData("OutBlock", "chetime");
            outData.actprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "actprice"));
            outData.k200jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "k200jisu"));
            outData.fut200jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "fut200jisu"));
            outData.price = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.capimpv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "capimpv"));
            outData.impv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "impv"));
            outData.delt = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "delt"));
            outData.gama = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "gama"));
            outData.ceta = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ceta"));
            outData.vega = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "vega"));
            outData.rhox = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "rhox"));
            outData.theoryprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "theoryprice"));
            outData.bimpv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bimpv"));
            outData.offerimpv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerimpv"));
            outData.bidimpv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidimpv"));
            outData.optcode = _RealDict[szTrCode].GetFieldData("OutBlock", "optcode");
        }
    }
}
