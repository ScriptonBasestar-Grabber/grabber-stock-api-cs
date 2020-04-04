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
        public void InBlock_s2_4ELW(string shcode)
        {
            string szTrCode = "s2_4ELW";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_s2_4ELW(string szTrCode)
        {
            _s2_4ELW_OutBlock outData;
            outData.offerho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.bidho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}