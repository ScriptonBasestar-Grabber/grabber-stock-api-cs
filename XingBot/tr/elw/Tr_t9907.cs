using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t9907
    {
        public static readonly InBlockQuery InBlock_t9907 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t9907 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t9907OutBlock1()
                {
                    lastym = query.GetFieldData(szTrCode + "OutBlock", "lastym", i),
                    lastnm = query.GetFieldData(szTrCode + "OutBlock", "lastnm", i),
                };
                writer.WriteRecord(result);
            }
        };
    }
}