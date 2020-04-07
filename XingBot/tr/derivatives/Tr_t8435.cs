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
    public class Tr_t8435
    {
        public static readonly InBlockQuery InBlock_t8435 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8435 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8435OutBlock>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8435OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                    uplmtprice = decimal.Parse(query.GetFieldData(block.Name, "uplmtprice", i)),
                    dnlmtprice = decimal.Parse(query.GetFieldData(block.Name, "dnlmtprice", i)),
                    jnilclose = decimal.Parse(query.GetFieldData(block.Name, "jnilclose", i)),
                    jnilhigh = decimal.Parse(query.GetFieldData(block.Name, "jnilhigh", i)),
                    jnillow = decimal.Parse(query.GetFieldData(block.Name, "jnillow", i)),
                    recprice = decimal.Parse(query.GetFieldData(block.Name, "recprice", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}