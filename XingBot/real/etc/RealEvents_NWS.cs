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
        public void InBlock_NWS(string nwcode)
        {
            string szTrCode = "NWS";
            _RealDict[szTrCode].SetFieldData("InBlock", "nwcode", nwcode);
        }

        private void OutBlock_NWS(string szTrCode)
        {
            _NWS_OutBlock outData;
            outData.date = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.id = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.realkey = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.title = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.code = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.bodysize = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
        }
    }
}