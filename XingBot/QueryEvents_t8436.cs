using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot
{
    public partial class QueryCtrl : _IXAQueryEvents
    {
        public void InBlock_t8436(string gubun = "0")
        {
            string szTrCode = "t8436";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "gubun", 0, gubun);
        }

        private void OutBlock_t8436(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8436OutBlock outData;
                outData.hname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "hname", i);
                outData.shcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "shcode", i);
                outData.expcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "expcode", i);
                outData.etfgubun = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "etfgubun", i);
                outData.uplmtprice =
                    long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "uplmtprice", i));
                outData.dnlmtprice =
                    long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i));
                outData.jnilclose =
                    long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jnilclose", i));
                outData.memedan = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "memedan", i);
                outData.recprice = long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "recprice", i));
                outData.gubun = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "gubun", i);
                outData.bu12gubun = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "bu12gubun", i);
                outData.spac_gubun = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "spac_gubun", i);
                outData.filler = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "filler", i);
            }
        }
    }
}