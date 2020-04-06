using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_OMG(string optcode)
        {
            string szTrCode = "OMG";
            _realDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OMG(string szTrCode)
        {
            _OMG_OutBlock outData;
            outData.chetime = _realDict[szTrCode].GetFieldData("OutBlock", "chetime");
            outData.actprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "actprice"));
            outData.k200jisu = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "k200jisu"));
            outData.fut200jisu = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "fut200jisu"));
            outData.price = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.capimpv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "capimpv"));
            outData.impv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "impv"));
            outData.delt = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "delt"));
            outData.gama = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "gama"));
            outData.ceta = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ceta"));
            outData.vega = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "vega"));
            outData.rhox = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "rhox"));
            outData.theoryprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "theoryprice"));
            outData.bimpv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bimpv"));
            outData.offerimpv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerimpv"));
            outData.bidimpv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidimpv"));
            outData.optcode = _realDict[szTrCode].GetFieldData("OutBlock", "optcode");
        }
    }
}
