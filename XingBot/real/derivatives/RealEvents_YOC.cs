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
        public void InBlock_YOC(string optcode)
        {
            string szTrCode = "YOC";
            _realDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_YOC(string szTrCode)
        {
            _YOC_OutBlock outData;
            outData.ychetime = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.yeprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.preychange = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.jnilydrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
        }
    }
}