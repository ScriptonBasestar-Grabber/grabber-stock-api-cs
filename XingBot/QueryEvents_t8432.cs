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
        public void InBlock_t8432()
        {
            string szTrCode = "t8432";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        private void OutBlock_t8432(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8432OutBlock outData;
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