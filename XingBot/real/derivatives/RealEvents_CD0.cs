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
        public void InBlock_CD0(string futcode)
        {
            string szTrCode = "CD0";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_CD0(string szTrCode)
        {
            _CD0_OutBlock outData;
            outData.gubun = _realDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.dy_gubun = _realDict[szTrCode].GetFieldData("OutBlock", "dy_gubun");
            outData.dy_uplmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dy_uplmtprice"));
            outData.dy_dnlmtprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dy_dnlmtprice"));
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}
