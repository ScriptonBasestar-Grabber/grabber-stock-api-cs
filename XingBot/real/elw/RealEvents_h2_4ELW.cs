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
        public void InBlock_h2_4ELW(string shcode)
        {
            string szTrCode = "h2_4ELW";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_h2_4ELW(string szTrCode)
        {
            _h2_4ELW_OutBlock outData;
            outData.hotime = _RealDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.tmofferrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tmofferrem"));
            outData.tmbidrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tmbidrem"));
            outData.pretmoffercha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "pretmoffercha"));
            outData.pretmbidcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "pretmbidcha"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}