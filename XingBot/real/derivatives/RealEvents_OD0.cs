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
        public void InBlock_OD0(string optcode)
        {
            string szTrCode = "OD0";
            _realDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OD0(string szTrCode)
        {
            _OD0_OutBlock outData;
            outData.gubun = _realDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.dy_gubun = _realDict[szTrCode].GetFieldData("OutBlock", "dy_gubun");
            outData.dy_uplmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dy_uplmtprice"));
            outData.dy_dnlmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dy_dnlmtprice"));
            outData.opttcode = _realDict[szTrCode].GetFieldData("OutBlock", "opttcode");
        }
    }
}
