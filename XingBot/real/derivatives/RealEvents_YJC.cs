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
        public void InBlock_YJC(string futcode)
        {
            string szTrCode = "YJC";
            _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_YJC(string szTrCode)
        {
            _YJC_OutBlock outData;
            outData.ychetime = _RealDict[szTrCode].GetFieldData("OutBlock", "ychetime");
            outData.yeprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.jnilysign = _RealDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.futcode = _RealDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}