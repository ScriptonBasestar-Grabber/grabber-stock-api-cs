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
        public void InBlock_VI_(string shcode)
        {
            string szTrCode = "VI_";
            _RealDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_VI_(string szTrCode)
        {
            _VI__OutBlock outData;
            outData.vi_gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "vi_gubun");
            outData.svi_recprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "svi_recprice"));
            outData.dvi_recprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dvi_recprice"));
            outData.vi_trgprice = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "vi_trgprice"));
            outData.shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.ref_shcode = _RealDict[szTrCode].GetFieldData("OutBlock", "ref_shcode");
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");
        }
    }
}