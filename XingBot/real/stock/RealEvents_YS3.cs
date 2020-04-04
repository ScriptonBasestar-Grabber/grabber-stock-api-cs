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
        public void InBlock_YS3(string shcode)
        {
            string szTrCode = "YS3";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_YS3(string szTrCode)
        {
            _YS3_OutBlock outData;
            outData.hotime = _RealDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.yeprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.yevolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yevolume"));
            outData.jnilysign = _RealDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.yofferho0 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yofferho0"));
            outData.ybidho0 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ybidho0"));
            outData.yofferrem0 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yofferrem0"));
            outData.ybidrem0 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ybidrem0"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}