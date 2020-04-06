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
    public class Tr_t8424
    {
        private readonly IXAQuery _query;

        public Tr_t8424(IXAQuery query)
        {
            _query = query;
        }

        /**
         * gubun 0, 1 KOSPI,2 KOSDAQ, 3, 4
         */
        public void InBlock_t8424(string gubun = "0")
        {
            string szTrCode = "t8424";
            _query.SetFieldData(szTrCode + "InBlock", "gubun1", 0, gubun);
        }

        public void OutBlock_t8424(string szTrCode, Action<_t8424OutBlock> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8424OutBlock()
                {
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    upcode = _query.GetFieldData(szTrCode + "OutBlock", "upcode", i)
                };
                action(result);
            }
        }
    }
}