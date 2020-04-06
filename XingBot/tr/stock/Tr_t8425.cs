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
        public static readonly InBlockQuery InBlock_t8425 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8425 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8425OutBlock()
                {
                    tmname = query.GetFieldData(szTrCode + "OutBlock", "tmname", i),
                    tmcode = query.GetFieldData(szTrCode + "OutBlock", "tmcode", i)
                };
                writer.WriteRecord(result);
            }
        };
}
}