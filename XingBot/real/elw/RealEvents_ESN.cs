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
        public void InBlock_ESN(string shcode)
        {
            string szTrCode = "ESN";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_ESN(string szTrCode)
        {
            _ESN_OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.theoryprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "theoryprice"));
            outData.delt = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "delt"));
            outData.gama = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "gama"));
            outData.ceta = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ceta"));
            outData.vega = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "vega"));
            outData.rhox = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "rhox"));
            outData.impv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "impv"));
            outData.egearing = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "egearing"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.elwclose = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "elwclose"));
            outData.sign = _realDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.date = _realDict[szTrCode].GetFieldData("OutBlock", "date");
            outData.tickvalue = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tickvalue"));
            outData.lp_impv = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_impv"));
        }
    }
}