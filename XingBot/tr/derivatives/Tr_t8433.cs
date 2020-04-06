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
    public class Tr_t8433
    {
        private readonly IXAQuery _query;

        public Tr_t8433(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t8433()
        {
            string szTrCode = "t8433";
            _query.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        public void OutBlock_t8433(string szTrCode)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8433OutBlock()
                {
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = _query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                    hprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "hprice", i)),
                    lprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "lprice", i)),
                    jnilclose = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                    jnilhigh = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                    jnillow = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                    recprice = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                };
            }
        }
    }
}