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
        public void InBlock_HB_(string shcode)
        {
            string szTrCode = "HB_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_HB_(string szTrCode)
        {
            _HB__OutBlock outData;
            outData.hotime = _RealDict[szTrCode].GetFieldData("OutBlock", "hotime");

            outData.tmofferrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tmofferrem"));
            outData.tmbidrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tmbidrem"));
            outData.pretmoffercha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "pretmoffercha"));
            outData.pretmbidcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "pretmbidcha"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}