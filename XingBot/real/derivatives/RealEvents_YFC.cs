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
        public void InBlock_YFC(string futcode)
        {
            string szTrCode = "YFC";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_YFC(string szTrCode)
        {
            _YFC_OutBlock outData;
            outData.ychetime = _realDict[szTrCode].GetFieldData("OutBlock", "ychetime");
            outData.yeprice = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}