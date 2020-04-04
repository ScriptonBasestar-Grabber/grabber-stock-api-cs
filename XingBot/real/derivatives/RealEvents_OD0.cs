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
        public void InBlock_OD0(string optcode)
        {
            string szTrCode = "OD0";
            _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OD0(string szTrCode)
        {
            _OD0_OutBlock outData;
            outData.gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.dy_gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "dy_gubun");
            outData.dy_uplmtprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dy_uplmtprice"));
            outData.dy_dnlmtprice = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dy_dnlmtprice"));
            outData.opttcode = _RealDict[szTrCode].GetFieldData("OutBlock", "opttcode");
        }
    }
}
