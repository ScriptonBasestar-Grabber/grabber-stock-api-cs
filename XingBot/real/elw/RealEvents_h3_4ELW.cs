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
        public void InBlock_h3_4ELW(string shcode)
        {
            string szTrCode = "h3_4ELW";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_h3_4ELW(string szTrCode)
        {
            _h3_4ELW_OutBlock outData;
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));
            outData.lp_offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho1"));
            outData.lp_bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));
            outData.lp_offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho1"));
            outData.lp_bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho1"));

            outData.offerho2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho2"));
            outData.bidho2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho2"));
            outData.offerrem2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem2"));
            outData.bidrem2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem2"));
            outData.lp_offerho2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho2"));
            outData.lp_bidho2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho2"));

            outData.offerho3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho3"));
            outData.bidho3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho3"));
            outData.offerrem3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem3"));
            outData.bidrem3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem3"));
            outData.lp_offerho3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho3"));
            outData.lp_bidho3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho3"));

            outData.offerho4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho4"));
            outData.bidho4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho4"));
            outData.offerrem4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem4"));
            outData.bidrem4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem4"));
            outData.lp_offerho4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho4"));
            outData.lp_bidho4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho4"));

            outData.offerho5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho5"));
            outData.bidho5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho5"));
            outData.offerrem5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem5"));
            outData.bidrem5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem5"));
            outData.lp_offerho5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho5"));
            outData.lp_bidho5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho5"));

            outData.offerho6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho6"));
            outData.bidho6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho6"));
            outData.offerrem6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem6"));
            outData.bidrem6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem6"));
            outData.lp_offerho6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho6"));
            outData.lp_bidho6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho6"));

            outData.offerho7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho7"));
            outData.bidho7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho7"));
            outData.offerrem7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem7"));
            outData.bidrem7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem7"));
            outData.lp_offerho7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho7"));
            outData.lp_bidho7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho7"));

            outData.offerho8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho8"));
            outData.bidho8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho8"));
            outData.offerrem8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem8"));
            outData.bidrem8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem8"));
            outData.lp_offerho8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho8"));
            outData.lp_bidho8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho8"));

            outData.offerho9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho9"));
            outData.bidho9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho9"));
            outData.offerrem9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem9"));
            outData.bidrem9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem9"));
            outData.lp_offerho9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho9"));
            outData.lp_bidho9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho9"));

            outData.offerho10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho10"));
            outData.bidho10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho10"));
            outData.offerrem10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem10"));
            outData.bidrem10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem10"));
            outData.lp_offerho10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_offerho10"));
            outData.lp_bidho10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lp_bidho10"));

            outData.totofferrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totofferrem"));
            outData.totbidrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totbidrem"));

            outData.donsigubun = _realDict[szTrCode].GetFieldData("OutBlock", "donsigubun");
            outData.spread = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "spread"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}