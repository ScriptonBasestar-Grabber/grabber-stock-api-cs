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
        public void InBlock_OH0(string optcode)
        {
            string szTrCode = "OH0";
            _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_OH0(string szTrCode)
        {
            _OH0_OutBlock outData;
            outData.hotime = _RealDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.offerho1 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho1"));
            outData.bidho1 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));
            outData.offercnt1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt1"));
            outData.bidcnt1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt1"));
            outData.offerho2 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho2"));
            outData.bidho2 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho2"));
            outData.offerrem2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem2"));
            outData.bidrem2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem2"));
            outData.offercnt2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt2"));
            outData.bidcnt2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt2"));
            outData.offerho3 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho3"));
            outData.bidho3 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho3"));
            outData.offerrem3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem3"));
            outData.bidrem3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem3"));
            outData.offercnt3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt3"));
            outData.bidcnt3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt3"));
            outData.offerho4 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho4"));
            outData.bidho4 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho4"));
            outData.offerrem4 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem4"));
            outData.bidrem4 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem4"));
            outData.offercnt4 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt4"));
            outData.bidcnt4 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt4"));
            outData.offerho5 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho5"));
            outData.bidho5 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho5"));
            outData.offerrem5 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem5"));
            outData.bidrem5 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem5"));
            outData.offercnt5 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt5"));
            outData.bidcnt5 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt5"));

            outData.totofferrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "totofferrem"));
            outData.totbidrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "totbidrem"));
            outData.totoffercnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "totoffercnt"));
            outData.totbidcnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "totbidcnt"));
            outData.optcode = _RealDict[szTrCode].GetFieldData("OutBlock", "optcode");
            outData.danhochk = _RealDict[szTrCode].GetFieldData("OutBlock", "danhochk");
            outData.alloc_gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "alloc_gubun");
        }
    }
}
