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
        public void InBlock_YK3(string updnlmtgubun)
        {
            string szTrCode = "YK3";
            _realDict[szTrCode].SetFieldData("InBlock", "updnlmtgubun", updnlmtgubun);
        }

        private void OutBlock_YK3(string szTrCode)
        {
            _YK3_OutBlock outData;
            outData.hotime = _realDict[szTrCode].GetFieldData("OutBlock", "hotime");
            outData.yeprice = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yeprice"));
            outData.yevolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yevolume"));
            outData.jnilysign = _realDict[szTrCode].GetFieldData("OutBlock", "jnilysign");
            outData.preychange = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "preychange"));
            outData.jnilydrate = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jnilydrate"));
            outData.yofferho0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yofferho0"));
            outData.ybidho0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ybidho0"));
            outData.yofferrem0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "yofferrem0"));
            outData.ybidrem0 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ybidrem0"));
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}