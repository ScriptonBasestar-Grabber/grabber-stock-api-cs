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
        public void InBlock_YC3(string shcode)
        {
            string szTrCode = "YC3";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_YC3(string szTrCode)
        {
            _YC3_OutBlock outData;
            outData.ychetime = _RealDict[szTrCode].GetFieldData("OutBlock", "ychetime");
            outData.yeprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.yevolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yevolume"));
            outData.jnilysign = _RealDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}