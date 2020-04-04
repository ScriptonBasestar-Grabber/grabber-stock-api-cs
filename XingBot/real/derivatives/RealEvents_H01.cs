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
        public void InBlock_H01(string futcode)
        {
            // string szTrCode = "H01";
            // _RealDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_H01(string szTrCode)
        {
            _H01_OutBlock outData;
            outData.lineseq = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lineseq"));
            outData.accno = _RealDict[szTrCode].GetFieldData("OutBlock", "accno");
            outData.user = _RealDict[szTrCode].GetFieldData("OutBlock", "user");
            outData.seq = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "seq"));
            outData.trcode = _RealDict[szTrCode].GetFieldData("OutBlock", "trcode");
            outData.megrpno = _RealDict[szTrCode].GetFieldData("OutBlock", "megrpno");
            outData.boardid = _RealDict[szTrCode].GetFieldData("OutBlock", "boardid");
            outData.memberno = _RealDict[szTrCode].GetFieldData("OutBlock", "memberno");
            outData.bpno = _RealDict[szTrCode].GetFieldData("OutBlock", "bpno");
            outData.ordno = _RealDict[szTrCode].GetFieldData("OutBlock", "ordno");
            outData.orgordno = _RealDict[szTrCode].GetFieldData("OutBlock", "orgordno");
            outData.expcode = _RealDict[szTrCode].GetFieldData("OutBlock", "expcode");
            outData.dosugb = _RealDict[szTrCode].GetFieldData("OutBlock", "dosugb");
            outData.mocagb = _RealDict[szTrCode].GetFieldData("OutBlock", "mocagb");
            outData.accno1 = _RealDict[szTrCode].GetFieldData("OutBlock", "accno1");
            outData.qty2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "qty2"));
            outData.price = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.ordgb = _RealDict[szTrCode].GetFieldData("OutBlock", "ordgb");
            outData.hogagb = _RealDict[szTrCode].GetFieldData("OutBlock", "hogagb");
            outData.sihogagb = _RealDict[szTrCode].GetFieldData("OutBlock", "sihogagb");
            outData.tradid = _RealDict[szTrCode].GetFieldData("OutBlock", "tradid");
            outData.treacode = _RealDict[szTrCode].GetFieldData("OutBlock", "treacode");
            outData.askcode = _RealDict[szTrCode].GetFieldData("OutBlock", "askcode");
            outData.creditcode = _RealDict[szTrCode].GetFieldData("OutBlock", "creditcode");
            outData.jakigb = _RealDict[szTrCode].GetFieldData("OutBlock", "jakigb");
            outData.trustnum = _RealDict[szTrCode].GetFieldData("OutBlock", "trustnum");
            outData.ptgb = _RealDict[szTrCode].GetFieldData("OutBlock", "ptgb");
            outData.substonum = _RealDict[szTrCode].GetFieldData("OutBlock", "substonum");
            outData.accgb = _RealDict[szTrCode].GetFieldData("OutBlock", "accgb");
            outData.accmarggb = _RealDict[szTrCode].GetFieldData("OutBlock", "accmarggb");
            outData.nationcode = _RealDict[szTrCode].GetFieldData("OutBlock", "nationcode");
            outData.investgb = _RealDict[szTrCode].GetFieldData("OutBlock", "investgb");
            outData.forecode = _RealDict[szTrCode].GetFieldData("OutBlock", "forecode");
            outData.medcode = _RealDict[szTrCode].GetFieldData("OutBlock", "medcode");
            outData.ordid = _RealDict[szTrCode].GetFieldData("OutBlock", "ordid");
            outData.macid = _RealDict[szTrCode].GetFieldData("OutBlock", "macid");
            outData.orddate = _RealDict[szTrCode].GetFieldData("OutBlock", "orddate");
            outData.rcvtime = _RealDict[szTrCode].GetFieldData("OutBlock", "rcvtime");
            outData.mem_filler = _RealDict[szTrCode].GetFieldData("OutBlock", "mem_filler");
            outData.mem_accno = _RealDict[szTrCode].GetFieldData("OutBlock", "mem_accno");
            outData.mem_filler1 = _RealDict[szTrCode].GetFieldData("OutBlock", "mem_filler1");
            outData.ordacpttm = _RealDict[szTrCode].GetFieldData("OutBlock", "ordacpttm");
            outData.qty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "qty"));
            outData.autogb = _RealDict[szTrCode].GetFieldData("OutBlock", "autogb");
            outData.rejcode = _RealDict[szTrCode].GetFieldData("OutBlock", "rejcode");
            outData.prgordde = _RealDict[szTrCode].GetFieldData("OutBlock", "prgordde");
        }
    }
}