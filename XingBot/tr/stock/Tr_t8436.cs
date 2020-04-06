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
    public class Tr_t8436
    {
        private readonly IXAQuery _query;

        public Tr_t8436(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t8436(string gubun = "0")
        {
            string szTrCode = "t8436";
            _query.SetFieldData(szTrCode + "InBlock", "gubun", 0, gubun);
        }

        public void OutBlock_t8436(string szTrCode, Action<_t8436OutBlock> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8436OutBlock()
                {
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = _query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                    etfgubun = _query.GetFieldData(szTrCode + "OutBlock", "etfgubun", i),
                    uplmtprice = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                    dnlmtprice = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                    jnilclose = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                    memedan = _query.GetFieldData(szTrCode + "OutBlock", "memedan", i),
                    recprice = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                    gubun = _query.GetFieldData(szTrCode + "OutBlock", "gubun", i),
                    bu12gubun = _query.GetFieldData(szTrCode + "OutBlock", "bu12gubun", i),
                    spac_gubun = _query.GetFieldData(szTrCode + "OutBlock", "spac_gubun", i),
                    filler = _query.GetFieldData(szTrCode + "OutBlock", "filler", i),
                };
                action(result);
            }
        }
    }
}