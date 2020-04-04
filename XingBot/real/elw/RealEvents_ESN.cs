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
        public void InBlock_ESN(string shcode)
        {
            string szTrCode = "ESN";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_ESN(string szTrCode)
        {
            _ESN_OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.theoryprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "theoryprice"));
            outData.delt = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "delt"));
            outData.gama = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "gama"));
            outData.ceta = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ceta"));
            outData.vega = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "vega"));
            outData.rhox = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "rhox"));
            outData.impv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "impv"));
            outData.egearing = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "egearing"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.elwclose = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "elwclose"));
            outData.sign = _RealDict[szTrCode].GetFieldData("OutBlock", "sign");
            outData.change = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.date = _RealDict[szTrCode].GetFieldData("OutBlock", "date");
            outData.tickvalue = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tickvalue"));
            outData.lp_impv = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lp_impv"));
        }
    }
}