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
        public void InBlock_JIF(string jangubun)
        {
            string szTrCode = "JIF";
            _RealDict[szTrCode].SetFieldData("InBlock", "jangubun", jangubun);
        }

        private void OutBlock_JIF(string szTrCode)
        {
            _JIF_OutBlock outData;
            outData.jangubun = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
            outData.jstatus = _RealDict[szTrCode].GetFieldData("OutBlock", "upstep");
        }
    }
}