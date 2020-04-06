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
        public void InBlock_Ys3_4ELW(string shcode)
        {
            string szTrCode = "Ys3_4ELW";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_Ys3_4ELW(string szTrCode)
        {
            _Ys3_4ELW_OutBlock outData;
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.yeprice = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.yevolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yevolume"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.yofferho0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yofferho0"));
            outData.ybidho0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ybidho0"));
            outData.yofferrem0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yofferrem0"));
            outData.ybidrem0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ybidrem0"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}