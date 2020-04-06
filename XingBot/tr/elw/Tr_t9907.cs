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
    public class Tr_t9907
    {
        private readonly IXAQuery _query;

        public Tr_t9907(IXAQuery query)
        {
            _query = query;
        }

        public void InBlock_t9907()
        {
            string szTrCode = "t9907";
            _query.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
        }

        public void OutBlock_t9907(string szTrCode, Action<_t9907OutBlock1> action)
        {
            for (var i = 0; i < _query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t9907OutBlock1()
                {
                    lastym = _query.GetFieldData(szTrCode + "OutBlock", "lastym", i),
                    lastnm = _query.GetFieldData(szTrCode + "OutBlock", "lastnm", i),
                };
                action(result);
            }
        }
    }
}