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
    public class Tr_t9942
    {
        private readonly IXAQuery _query;

        public Tr_t9942(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t9942()
        {
            string szTrCode = "t9942";
            _query.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        public void OutBlock_t9942(string szTrCode, Action<_t9942OutBlock> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t9942OutBlock()
                {
                    hname = _query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    shcode = _query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = _query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                };
                action(result);
            }
        }
    }
}