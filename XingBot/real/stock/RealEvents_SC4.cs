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
        public void InBlock_SC4(string shcode)
        {
            string szTrCode = "SC4";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
            //TODO ...
        }

        private void OutBlock_SC4(string szTrCode)
        {
            _SC4_OutBlock outData;
            //TODO ...
        }
    }
}