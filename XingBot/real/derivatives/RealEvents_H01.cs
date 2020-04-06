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
        public void InBlock_H01(string futcode)
        {
            // string szTrCode = "H01";
            // _realDict[szTrCode].SetFieldData("InBlock", "futcode", futcode);
        }

        private void OutBlock_H01(string szTrCode)
        {
            _H01_OutBlock outData;
            outData.lineseq = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lineseq"));
            outData.accno = _realDict[szTrCode].GetFieldData("OutBlock", "accno");
            outData.user = _realDict[szTrCode].GetFieldData("OutBlock", "user");
            outData.seq = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "seq"));
            outData.trcode = _realDict[szTrCode].GetFieldData("OutBlock", "trcode");
            outData.megrpno = _realDict[szTrCode].GetFieldData("OutBlock", "megrpno");
            outData.boardid = _realDict[szTrCode].GetFieldData("OutBlock", "boardid");
            outData.memberno = _realDict[szTrCode].GetFieldData("OutBlock", "memberno");
            outData.bpno = _realDict[szTrCode].GetFieldData("OutBlock", "bpno");
            outData.ordno = _realDict[szTrCode].GetFieldData("OutBlock", "ordno");
            outData.orgordno = _realDict[szTrCode].GetFieldData("OutBlock", "orgordno");
            outData.expcode = _realDict[szTrCode].GetFieldData("OutBlock", "expcode");
            outData.dosugb = _realDict[szTrCode].GetFieldData("OutBlock", "dosugb");
            outData.mocagb = _realDict[szTrCode].GetFieldData("OutBlock", "mocagb");
            outData.accno1 = _realDict[szTrCode].GetFieldData("OutBlock", "accno1");
            outData.qty2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "qty2"));
            outData.price = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "price"));
            outData.ordgb = _realDict[szTrCode].GetFieldData("OutBlock", "ordgb");
            outData.hogagb = _realDict[szTrCode].GetFieldData("OutBlock", "hogagb");
            outData.sihogagb = _realDict[szTrCode].GetFieldData("OutBlock", "sihogagb");
            outData.tradid = _realDict[szTrCode].GetFieldData("OutBlock", "tradid");
            outData.treacode = _realDict[szTrCode].GetFieldData("OutBlock", "treacode");
            outData.askcode = _realDict[szTrCode].GetFieldData("OutBlock", "askcode");
            outData.creditcode = _realDict[szTrCode].GetFieldData("OutBlock", "creditcode");
            outData.jakigb = _realDict[szTrCode].GetFieldData("OutBlock", "jakigb");
            outData.trustnum = _realDict[szTrCode].GetFieldData("OutBlock", "trustnum");
            outData.ptgb = _realDict[szTrCode].GetFieldData("OutBlock", "ptgb");
            outData.substonum = _realDict[szTrCode].GetFieldData("OutBlock", "substonum");
            outData.accgb = _realDict[szTrCode].GetFieldData("OutBlock", "accgb");
            outData.accmarggb = _realDict[szTrCode].GetFieldData("OutBlock", "accmarggb");
            outData.nationcode = _realDict[szTrCode].GetFieldData("OutBlock", "nationcode");
            outData.investgb = _realDict[szTrCode].GetFieldData("OutBlock", "investgb");
            outData.forecode = _realDict[szTrCode].GetFieldData("OutBlock", "forecode");
            outData.medcode = _realDict[szTrCode].GetFieldData("OutBlock", "medcode");
            outData.ordid = _realDict[szTrCode].GetFieldData("OutBlock", "ordid");
            outData.macid = _realDict[szTrCode].GetFieldData("OutBlock", "macid");
            outData.orddate = _realDict[szTrCode].GetFieldData("OutBlock", "orddate");
            outData.rcvtime = _realDict[szTrCode].GetFieldData("OutBlock", "rcvtime");
            outData.mem_filler = _realDict[szTrCode].GetFieldData("OutBlock", "mem_filler");
            outData.mem_accno = _realDict[szTrCode].GetFieldData("OutBlock", "mem_accno");
            outData.mem_filler1 = _realDict[szTrCode].GetFieldData("OutBlock", "mem_filler1");
            outData.ordacpttm = _realDict[szTrCode].GetFieldData("OutBlock", "ordacpttm");
            outData.qty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "qty"));
            outData.autogb = _realDict[szTrCode].GetFieldData("OutBlock", "autogb");
            outData.rejcode = _realDict[szTrCode].GetFieldData("OutBlock", "rejcode");
            outData.prgordde = _realDict[szTrCode].GetFieldData("OutBlock", "prgordde");
        }
    }
}