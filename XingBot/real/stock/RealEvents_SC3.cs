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
        public void InBlock_SC3(string shcode)
        {
            string szTrCode = "SC3";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
            //TODO ...
        }

        private void OutBlock_SC3(string szTrCode)
        {
            _SC3_OutBlock outData;
            //TODO ...
        }
    }
}