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
        public void InBlock_JD0(string futcode)
        {
            string szTrCode = "JD0";
            _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_JD0(string szTrCode)
        {
            _JD0_OutBlock outData;
            outData.gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.dy_gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "dy_gubun");
            outData.dy_uplmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dy_uplmtprice"));
            outData.dy_dnlmtprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dy_dnlmtprice"));
            outData.futcode = _RealDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}