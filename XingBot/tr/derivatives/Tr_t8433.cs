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
    public class Tr_t8433
    {
        public static readonly InBlockQuery InBlock_t8433 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8433 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8433OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                    hprice = decimal.Parse(query.GetFieldData(block.Name, "hprice", i)),
                    lprice = decimal.Parse(query.GetFieldData(block.Name, "lprice", i)),
                    jnilclose = decimal.Parse(query.GetFieldData(block.Name, "jnilclose", i)),
                    jnilhigh = decimal.Parse(query.GetFieldData(block.Name, "jnilhigh", i)),
                    jnillow = decimal.Parse(query.GetFieldData(block.Name, "jnillow", i)),
                    recprice = decimal.Parse(query.GetFieldData(block.Name, "recprice", i)),
                };
                writer.WriteRecord(result);
            }
        };
    }
}