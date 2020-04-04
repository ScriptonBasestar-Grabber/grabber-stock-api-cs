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
        public void InBlock_JX0(string futcode)
        {
            string szTrCode = "JX0";
            _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_JX0(string szTrCode)
        {
            _JX0_OutBlock outData;
            outData.upstep = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.dnstep = _RealDict[szTrCode].GetFieldData("OutBlock", "dnstep");
            outData.uplmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "uplmtprice"));
            outData.dnlmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
            outData.futcode = _RealDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}