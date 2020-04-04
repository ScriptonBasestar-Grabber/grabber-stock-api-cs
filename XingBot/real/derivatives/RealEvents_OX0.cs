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
        public void InBlock_OX0(string optcode)
        {
            string szTrCode = "OX0";
            _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OX0(string szTrCode)
        {
            _OX0_OutBlock outData;
            outData.upstep = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.dnstep = _RealDict[szTrCode].GetFieldData("OutBlock", "dnstep");
            outData.uplmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.dnlmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.opttcode = _RealDict[szTrCode].GetFieldData("OutBlock", "opttcode");
        }
    }
}