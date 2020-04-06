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
    public class Tr_t8419
    {
        private readonly IXAQuery _query;

        public Tr_t8419(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t8419()
        {
            string szTrCode = "t8419";
            _query.SetFieldData(szTrCode + "InBlock", "shcode", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "qrycnt", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "sdate", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "edate", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "cts_date", 0, "");
            _query.SetFieldData(szTrCode + "InBlock", "comp_yn", 0, "");
        }

        public void OutBlock_t8419(string szTrCode, Action<_t8419OutBlock> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8419OutBlock()
                {
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    jisiga = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jisiga", i)),
                    jihigh = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jihigh", i)),
                    jilow = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jilow", i)),
                    jiclose = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jiclose", i)),
                    jivolume = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jivolume", i)),
                    disiga = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "disiga", i)),
                    dihigh = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "dihigh", i)),
                    dilow = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "dilow", i)),
                    diclose = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "diclose", i)),
                    disvalue = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "disvalue", i)),
                    cts_date = _query.GetFieldData(szTrCode + "OutBlock", "cts_date", i),
                    s_time = _query.GetFieldData(szTrCode + "OutBlock", "s_time", i),
                    e_time = _query.GetFieldData(szTrCode + "OutBlock", "e_time", i),
                    dshmin = _query.GetFieldData(szTrCode + "OutBlock", "dshmin", i),
                    rec_count = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "rec_count", i)),
                };
                action(result);
            }
        }

        public void OutBlock1_t8419(string szTrCode, Action<_t8419OutBlock1> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8419OutBlock1()
                {
                    date = _query.GetFieldData(szTrCode + "OutBlock", "date", i),
                    open = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "open", i)),
                    high = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jiclose", i)),
                    low = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "low", i)),
                    close = decimal.Parse(_query.GetFieldData(szTrCode + "OutBlock", "close", i)),
                    jdiff_vol = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "jdiff_vol", i)),
                    value = long.Parse(_query.GetFieldData(szTrCode + "OutBlock", "value", i)),
                };
                action(result);
            }
        }
    }
}