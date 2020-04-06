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
        public void InBlock_FX0(string futcode)
        {
            string szTrCode = "FX0";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_FX0(string szTrCode)
        {
            _FX0_OutBlock outData;
            outData.upstep = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.dnstep = _realDict[szTrCode].GetFieldData("OutBlock", "dnstep");
            outData.uplmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.dnlmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}