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
        public void InBlock_C01(string futcode)
        {
            // string szTrCode = "C01";
            // _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_C01(string szTrCode)
        {
            _C01_OutBlock outData;
            outData.lineseq = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "lineseq"));
            outData.accno = _realDict[szTrCode].GetFieldData( "OutBlock", "accno");
            outData.user = _realDict[szTrCode].GetFieldData( "OutBlock", "user");
            outData.seq = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "seq"));
            outData.trcode = _realDict[szTrCode].GetFieldData( "OutBlock", "trcode");
            outData.megrpno = _realDict[szTrCode].GetFieldData( "OutBlock", "megrpno");
            outData.boardid = _realDict[szTrCode].GetFieldData( "OutBlock", "boardid");
            outData.memberno = _realDict[szTrCode].GetFieldData( "OutBlock", "memberno");
            outData.bpno = _realDict[szTrCode].GetFieldData( "OutBlock", "bpno");
            outData.ordno = _realDict[szTrCode].GetFieldData( "OutBlock", "ordno");
            outData.orgordno = _realDict[szTrCode].GetFieldData( "OutBlock", "orgordno");
            outData.expcode = _realDict[szTrCode].GetFieldData( "OutBlock", "expcode");
            outData.yakseq = _realDict[szTrCode].GetFieldData( "OutBlock", "yakseq");
        
            outData.cheprice = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "cheprice"));
            outData.chevol = long.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "chevol"));
        
            outData.sessionid = _realDict[szTrCode].GetFieldData( "OutBlock", "sessionid");
            outData.chedate = _realDict[szTrCode].GetFieldData( "OutBlock", "chedate");
            outData.chetime = _realDict[szTrCode].GetFieldData( "OutBlock", "chetime");
        
            outData.spdprc1 = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "spdprc1"));
            outData.spdprc2 = decimal.Parse(_realDict[szTrCode].GetFieldData( "OutBlock", "spdprc2"));
        
            outData.dosugb = _realDict[szTrCode].GetFieldData( "OutBlock", "dosugb");
            outData.accno1 = _realDict[szTrCode].GetFieldData( "OutBlock", "yakseq");
            outData.sihogagb = _realDict[szTrCode].GetFieldData( "OutBlock", "sihogagb");
            outData.jakino = _realDict[szTrCode].GetFieldData( "OutBlock", "jakino");
            outData.daeyong = _realDict[szTrCode].GetFieldData( "OutBlock", "daeyong");
            outData.mem_filler = _realDict[szTrCode].GetFieldData( "OutBlock", "mem_filler");
            outData.mem_accno = _realDict[szTrCode].GetFieldData( "OutBlock", "mem_accno");
            outData.mem_filler1 = _realDict[szTrCode].GetFieldData( "OutBlock", "mem_filler1");
        }
    }
}
