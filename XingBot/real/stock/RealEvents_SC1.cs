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
        public void InBlock_SC1(string shcode)
        {
            string szTrCode = "SC1";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
            //TODO ...
        }

        private void OutBlock_SC1(string szTrCode)
        {
            _SC1_OutBlock outData;
            //TODO ...
        }
    }
}