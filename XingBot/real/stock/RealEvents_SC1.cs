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
        public void InBlock_SC1(string shcode)
        {
            string szTrCode = "SC1";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
            //TODO ...
        }

        private void OutBlock_SC1(string szTrCode)
        {
            _SC1_OutBlock outData;
            //TODO ...
        }
    }
}