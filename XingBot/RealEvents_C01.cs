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
        public void InBlock_C01(string futcode)
        {
            // string szTrCode = "C01";
            // _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_C01(string szTrCode)
        {
            _C01_OutBlock outData;
            outData.lineseq = long.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "lineseq"));
            outData.accno = _RealDict[szTrCode].GetFieldData( "OutBlock", "accno");
            outData.user = _RealDict[szTrCode].GetFieldData( "OutBlock", "user");
            outData.seq = long.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "seq"));
            outData.trcode = _RealDict[szTrCode].GetFieldData( "OutBlock", "trcode");
            outData.megrpno = _RealDict[szTrCode].GetFieldData( "OutBlock", "megrpno");
            outData.boardid = _RealDict[szTrCode].GetFieldData( "OutBlock", "boardid");
            outData.memberno = _RealDict[szTrCode].GetFieldData( "OutBlock", "memberno");
            outData.bpno = _RealDict[szTrCode].GetFieldData( "OutBlock", "bpno");
            outData.ordno = _RealDict[szTrCode].GetFieldData( "OutBlock", "ordno");
            outData.orgordno = _RealDict[szTrCode].GetFieldData( "OutBlock", "orgordno");
            outData.expcode = _RealDict[szTrCode].GetFieldData( "OutBlock", "expcode");
            outData.yakseq = _RealDict[szTrCode].GetFieldData( "OutBlock", "yakseq");

            outData.cheprice = float.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "cheprice"));
            outData.chevol = long.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "chevol"));

            outData.sessionid = _RealDict[szTrCode].GetFieldData( "OutBlock", "sessionid");
            outData.chedate = _RealDict[szTrCode].GetFieldData( "OutBlock", "chedate");
            outData.chetime = _RealDict[szTrCode].GetFieldData( "OutBlock", "chetime");

            outData.spdprc1 = float.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "spdprc1"));
            outData.spdprc2 = float.Parse(_RealDict[szTrCode].GetFieldData( "OutBlock", "spdprc2"));

            outData.dosugb = _RealDict[szTrCode].GetFieldData( "OutBlock", "dosugb");
            outData.accno1 = _RealDict[szTrCode].GetFieldData( "OutBlock", "yakseq");
            outData.sihogagb = _RealDict[szTrCode].GetFieldData( "OutBlock", "sihogagb");
            outData.jakino = _RealDict[szTrCode].GetFieldData( "OutBlock", "jakino");
            outData.daeyong = _RealDict[szTrCode].GetFieldData( "OutBlock", "daeyong");
            outData.mem_filler = _RealDict[szTrCode].GetFieldData( "OutBlock", "mem_filler");
            outData.mem_accno = _RealDict[szTrCode].GetFieldData( "OutBlock", "mem_accno");
            outData.mem_filler1 = _RealDict[szTrCode].GetFieldData( "OutBlock", "mem_filler1");
        }
    }
}
