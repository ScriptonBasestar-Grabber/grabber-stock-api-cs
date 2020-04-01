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
        public void InBlock_BM_(string upcode)
        {
            string szTrCode = "BM_";
            _RealDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_BM_(string szTrCode)
        {
            _BM__OutBlock outData;
            outData.tjjcode = _RealDict[szTrCode].GetFieldData("OutBlock", "tjjcode");
            outData.tjjtime = _RealDict[szTrCode].GetFieldData("OutBlock", "tjjtime");
            outData.msvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msvolume"));
            outData.mdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdvolume"));
            outData.msvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msvol"));
            outData.p_msvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_msvol"));
            outData.msvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msvalue"));
            outData.mdvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mdvalue"));
            outData.msval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "msval"));
            outData.p_msval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_msval"));
            outData.upcode = _RealDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}
