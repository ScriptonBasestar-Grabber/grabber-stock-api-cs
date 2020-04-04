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
        public void InBlock_YOC(string optcode)
        {
            string szTrCode = "YOC";
            _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_YOC(string szTrCode)
        {
            _YOC_OutBlock outData;
            outData.ychetime = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.yeprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.jnilysign = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.preychange = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.jnilydrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
        }
    }
}