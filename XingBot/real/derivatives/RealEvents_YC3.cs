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
        public void InBlock_YC3(string shcode)
        {
            string szTrCode = "YC3";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_YC3(string szTrCode)
        {
            _YC3_OutBlock outData;
            outData.ychetime = _realDict[szTrCode].GetFieldData("OutBlock", "ychetime");
            outData.yeprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.yevolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yevolume"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}