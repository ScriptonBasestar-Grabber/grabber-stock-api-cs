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
        public void InBlock_NWS(string nwcode)
        {
            string szTrCode = "NWS";
            _realDict[szTrCode].SetFieldData("InBlock", "nwcode", nwcode);
        }

        private void OutBlock_NWS(string szTrCode)
        {
            _NWS_OutBlock outData;
            outData.date = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.id = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.realkey = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.title = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.code = _realDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.bodysize = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dnlmtprice"));
        }
    }
}