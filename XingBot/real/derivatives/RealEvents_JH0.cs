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
        public void InBlock_JH0(string futcode)
        {
            string szTrCode = "JH0";
            _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_JH0(string szTrCode)
        {
            _JH0_OutBlock outData;
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");

            outData.bidho1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));
            outData.offercnt1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt1"));
            outData.bidcnt1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt1"));

            outData.bidho2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho2"));
            outData.offerrem2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem2"));
            outData.bidrem2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem2"));
            outData.offercnt2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt2"));
            outData.bidcnt2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt2"));

            outData.bidho3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho3"));
            outData.offerrem3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem3"));
            outData.bidrem3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem3"));
            outData.offercnt3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt3"));
            outData.bidcnt3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt3"));

            outData.bidho4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho4"));
            outData.offerrem4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem4"));
            outData.bidrem4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem4"));
            outData.offercnt4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt4"));
            outData.bidcnt4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt4"));

            outData.bidho5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho5"));
            outData.offerrem5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem5"));
            outData.bidrem5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem5"));
            outData.offercnt5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt5"));
            outData.bidcnt5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt5"));

            outData.bidho6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho6"));
            outData.offerrem6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem6"));
            outData.bidrem6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem6"));
            outData.offercnt6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt6"));
            outData.bidcnt6 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt6"));

            outData.bidho7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho7"));
            outData.offerrem7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem7"));
            outData.bidrem7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem7"));
            outData.offercnt7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt7"));
            outData.bidcnt7 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt7"));

            outData.bidho8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho8"));
            outData.offerrem8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem8"));
            outData.bidrem8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem8"));
            outData.offercnt8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt8"));
            outData.bidcnt8 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt8"));

            outData.bidho9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho9"));
            outData.offerrem9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem9"));
            outData.bidrem9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem9"));
            outData.offercnt9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt9"));
            outData.bidcnt9 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt9"));

            outData.bidho10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidho10"));
            outData.offerrem10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offerrem10"));
            outData.bidrem10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidrem10"));
            outData.offercnt10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offercnt10"));
            outData.bidcnt10 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bidcnt10"));

            outData.totofferrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totofferrem"));
            outData.totbidrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totbidrem"));
            outData.totoffercnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totoffercnt"));
            outData.totbidcnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "totbidcnt"));
            outData.futcode = _realDict[szTrCode].GetFieldData("OutBlock", "futcode");
            outData.danhochk = _realDict[szTrCode].GetFieldData("OutBlock", "danhochk");
            outData.alloc_gubun = _realDict[szTrCode].GetFieldData("OutBlock", "alloc_gubun");
        }
    }
}

