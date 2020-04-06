using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.tr
{
    public class Tr_t8432
    {
        private readonly IXAQuery _query;

        public Tr_t8432(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t8432()
        {
            string szTrCode = "t8432";
            _query.SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
        }

        public void OutBlock_t8432(string szTrCode)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8432OutBlock()
                {
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = _query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                    uplmtprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                    dnlmtprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                    jnilclose = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                    jnilhigh = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                    jnillow = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                    recprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                };
            }
        }
    }
}