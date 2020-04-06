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
        public void InBlock_BMT(string upcode)
        {
            string szTrCode = "BM_";
            _realDict[szTrCode].SetFieldData("InBlock", "upcode", upcode);
        }

        private void OutBlock_BMT(string szTrCode)
        {
            _BMT_OutBlock outData;
            outData.tjjtime = _realDict[szTrCode].GetFieldData("OutBlock", "tjjtime");

            outData.tjjcode1 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode1");
            outData.msvolume1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume1"));
            outData.mdvolume1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume1"));
            outData.msvol1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol1"));
            outData.msvalue1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue1"));
            outData.mdvalue1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue1"));
            outData.msval1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval1"));

            outData.tjjcode2 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode2");
            outData.msvolume2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume2"));
            outData.mdvolume2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume2"));
            outData.msvol2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol2"));
            outData.msvalue2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue2"));
            outData.mdvalue2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue2"));
            outData.msval2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval2"));

            outData.tjjcode3 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode3");
            outData.msvolume3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume3"));
            outData.mdvolume3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume3"));
            outData.msvol3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol3"));
            outData.msvalue3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue3"));
            outData.mdvalue3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue3"));
            outData.msval3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval3"));

            outData.tjjcode4 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode4");
            outData.msvolume4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume4"));
            outData.mdvolume4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume4"));
            outData.msvol4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol4"));
            outData.msvalue4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue4"));
            outData.mdvalue4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue4"));
            outData.msval4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval4"));

            outData.tjjcode5 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode5");
            outData.msvolume5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume5"));
            outData.mdvolume5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume5"));
            outData.msvol5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol5"));
            outData.msvalue5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue5"));
            outData.mdvalue5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue5"));
            outData.msval5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval5"));

            outData.tjjcode6 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode6");
            outData.msvolume6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume6"));
            outData.mdvolume6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume6"));
            outData.msvol6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol6"));
            outData.msvalue6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue6"));
            outData.mdvalue6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue6"));
            outData.msval6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval6"));

            outData.tjjcode7 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode7");
            outData.msvolume7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume7"));
            outData.mdvolume7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume7"));
            outData.msvol7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol7"));
            outData.msvalue7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue7"));
            outData.mdvalue7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue7"));
            outData.msval7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval7"));

            outData.tjjcode8 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode8");
            outData.msvolume8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume8"));
            outData.mdvolume8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume8"));
            outData.msvol8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol8"));
            outData.msvalue8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue8"));
            outData.mdvalue8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue8"));
            outData.msval8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval8"));

            outData.tjjcode9 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode9");
            outData.msvolume9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume9"));
            outData.mdvolume9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume9"));
            outData.msvol9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol9"));
            outData.msvalue9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue9"));
            outData.mdvalue9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue9"));
            outData.msval9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval9"));

            outData.tjjcode10 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode10");
            outData.msvolume10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume10"));
            outData.mdvolume10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume10"));
            outData.msvol10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol10"));
            outData.msvalue10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue10"));
            outData.mdvalue10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue10"));
            outData.msval10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval10"));

            outData.tjjcode11 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode11");
            outData.msvolume11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume11"));
            outData.mdvolume11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume11"));
            outData.msvol11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol11"));
            outData.msvalue11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue11"));
            outData.mdvalue11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue11"));
            outData.msval11 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval11"));

            outData.upcode = _realDict[szTrCode].GetFieldData("OutBlock", "upcode");
            outData.tjjcode0 = _realDict[szTrCode].GetFieldData("OutBlock", "tjjcode0");
            outData.msvolume0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvolume0"));
            outData.mdvolume0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvolume0"));
            outData.msvol0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvol0"));
            outData.msvalue0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msvalue0"));
            outData.mdvalue0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mdvalue0"));
            outData.msval0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "msval0"));
        }
    }
}
