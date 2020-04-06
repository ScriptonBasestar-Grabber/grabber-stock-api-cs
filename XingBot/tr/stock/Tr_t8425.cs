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
    public class Tr_t8425
    {
        private readonly IXAQuery _query;

        public Tr_t8425(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t8425()
        {
            string szTrCode = "t8425";
            _query.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        public void OutBlock_t8425(string szTrCode, Action<_t8425OutBlock> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8425OutBlock()
                {
                    tmname = _query.GetFieldData(szTrCode + "OutBlock", "tmname", i),
                    tmcode = _query.GetFieldData(szTrCode + "OutBlock", "tmcode", i)
                };
                action(result);
            }
        }
    }
}