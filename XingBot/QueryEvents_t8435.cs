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
        public void InBlock_t8435(string gubun = "MF")
        {
            // MF, MO
            string szTrCode = "t8435";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
        }

        private void OutBlock_t8435(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8435OutBlock outData;
                outData.hname = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "hname", i);
                outData.shcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "shcode", i);
                outData.expcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "expcode", i);
                outData.uplmtprice =
                    float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "uplmtprice", i));
                outData.dnlmtprice =
                    float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i));
                outData.jnilclose =
                    float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jnilclose", i));
                outData.jnilhigh = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jnilhigh", i));
                outData.jnillow = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jnillow", i));
                outData.recprice = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "recprice", i));
            }
        }
    }
}