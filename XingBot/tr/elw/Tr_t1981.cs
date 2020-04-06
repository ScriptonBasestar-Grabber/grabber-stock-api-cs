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
    public class Tr_t1981
    {
        private readonly IXAQuery _query;

        public Tr_t1981(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t1981()
        {
            string szTrCode = "t1981";
            _query.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        public void OutBlock_t1981(string szTrCode, Action<_t1981OutBlock1> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t1981OutBlock1()
                {
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = _query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    price = _query.GetFieldData(szTrCode + "OutBlock", "price", i),
                    sign = _query.GetFieldData(szTrCode + "OutBlock", "sign", i),
                    change = _query.GetFieldData(szTrCode + "OutBlock", "change", i),
                    rate = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "rate", i)),
                    volume = _query.GetFieldData(szTrCode + "OutBlock", "volume", i),
                    value = _query.GetFieldData(szTrCode + "OutBlock", "value", i),
                    mkt_gb = _query.GetFieldData(szTrCode + "OutBlock", "mkt_gb", i),
                };
                action(result);
            }
        }
    }
}