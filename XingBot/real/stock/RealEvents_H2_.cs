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
        public void InBlock_H2_(string shcode)
        {
            string szTrCode = "H2_";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_H2_(string szTrCode)
        {
            _H2__OutBlock outData;
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.tmofferrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tmofferrem"));
            outData.tmbidrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tmbidrem"));
            outData.pretmoffercha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "pretmoffercha"));
            outData.pretmbidcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "pretmbidcha"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}