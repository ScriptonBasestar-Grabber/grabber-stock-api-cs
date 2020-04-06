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
        public void InBlock_S2_(string shcode)
        {
            string szTrCode = "S2_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_S2_(string szTrCode)
        {
            _S2__OutBlock outData;
            outData.offerho = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho"));
            outData.bidho = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}