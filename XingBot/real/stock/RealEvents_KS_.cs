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
        public void InBlock_KS_(string shcode)
        {
            string szTrCode = "KS_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_KS_(string szTrCode)
        {
            _KS__OutBlock outData;
            outData.offerho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.bidho = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}