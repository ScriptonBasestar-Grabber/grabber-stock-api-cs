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
        public void InBlock_BM_(string upcode)
        {
            string szTrCode = "BM_";
            _realDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_BM_(string szTrCode)
        {
            _BM__OutBlock outData;
            outData.tjjcode = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode");
            outData.tjjtime = _realDict[szTrCode].GetFieldData("OutBlock", "tjjtime");
            outData.msvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume"));
            outData.mdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume"));
            outData.msvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol"));
            outData.p_msvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_msvol"));
            outData.msvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue"));
            outData.mdvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue"));
            outData.msval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval"));
            outData.p_msval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_msval"));
            outData.upcode = _realDict[szTrCode].GetFieldData("OutBlock", "upcode");
        }
    }
}
