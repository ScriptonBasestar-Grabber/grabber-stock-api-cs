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
        public void InBlock_OX0(string optcode)
        {
            string szTrCode = "OX0";
            _realDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OX0(string szTrCode)
        {
            _OX0_OutBlock outData;
            outData.upstep = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.dnstep = _realDict[szTrCode].GetFieldData("OutBlock", "dnstep");
            outData.uplmtprice = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.dnlmtprice = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.opttcode = _realDict[szTrCode].GetFieldData("OutBlock", "opttcode");
        }
    }
}