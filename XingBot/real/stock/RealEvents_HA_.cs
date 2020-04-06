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
        public void InBlock_HA_(string shcode)
        {
            string szTrCode = "HA_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_HA_(string szTrCode)
        {
            _HA__OutBlock outData;
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.offerho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));

            outData.totofferrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totofferrem"));
            outData.donsigubun = _realDict[szTrCode].GetFieldData("OutBlock", "donsigubun");
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
            outData.alloc_gubun = _realDict[szTrCode].GetFieldData("OutBlock", "alloc_gubun");
        }
    }
}