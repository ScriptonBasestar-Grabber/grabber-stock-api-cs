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
        public void InBlock_FH0(string futcode)
        {
            string szTrCode = "FH0";
            _RealDict[szTrCode].SetFieldData(szTrCode + "InBlock", "futcode", futcode);
        }

        private void OutBlock_FH0(string szTrCode)
        {
            _FH0_OutBlock outData;
            outData.hotime = _RealDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.offerho1 = _RealDict[szTrCode].GetFieldData("OutBlock", "offerho1");
            outData.bidho1 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho1"));
            outData.offerrem1 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem1"));
            outData.bidrem1 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem1"));
            outData.offercnt1 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt1"));
            outData.bidcnt1 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt1"));
            outData.offerho2 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho2"));
            outData.bidho2 = _RealDict[szTrCode].GetFieldData("OutBlock", "bidho2");
            outData.offerrem2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem2"));
            outData.bidrem2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem2"));
            outData.offercnt2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt2"));
            outData.bidcnt2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt2"));
            outData.offerho3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho3"));
            outData.bidho3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho3"));
            outData.offerrem3 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem3"));
            outData.bidrem3 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem3"));
            outData.offercnt3 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt3"));
            outData.bidcnt3 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt3"));
            outData.offerho4 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerho4"));
            outData.bidho4 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidho4"));
            outData.offerrem4 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offerrem4"));
            outData.bidrem4 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidrem4"));
            outData.offercnt4 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offercnt4"));
            outData.bidcnt4 = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bidcnt4"));
            outData.openyakcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "openyakcha"));
            outData.jgubun = _RealDict[szTrCode].GetFieldData("OutBlock", "jgubun");
            outData.jnilvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jnilvolume"));
            outData.futcode = _RealDict[szTrCode].GetFieldData("OutBlock", "futcode");
        }
    }
}
