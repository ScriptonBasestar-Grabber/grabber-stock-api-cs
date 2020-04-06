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
        public void InBlock_SC2(string shcode)
        {
            string szTrCode = "SC2";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
            //TODO ...
        }

        private void OutBlock_SC2(string szTrCode)
        {
            _SC2_OutBlock outData;
            //TODO ...
        }
    }
}