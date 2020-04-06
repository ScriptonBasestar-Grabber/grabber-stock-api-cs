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
    public class Tr_t8436
    {
        public static readonly InBlockQuery InBlock_t8436 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8436 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8436OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                    etfgubun = query.GetFieldData(block.Name, "etfgubun", i),
                    uplmtprice = long.Parse(query.GetFieldData(block.Name, "uplmtprice", i)),
                    dnlmtprice = long.Parse(query.GetFieldData(block.Name, "dnlmtprice", i)),
                    jnilclose = long.Parse(query.GetFieldData(block.Name, "jnilclose", i)),
                    memedan = query.GetFieldData(block.Name, "memedan", i),
                    recprice = long.Parse(query.GetFieldData(block.Name, "recprice", i)),
                    gubun = query.GetFieldData(block.Name, "gubun", i),
                    bu12gubun = query.GetFieldData(block.Name, "bu12gubun", i),
                    spac_gubun = query.GetFieldData(block.Name, "spac_gubun", i),
                    filler = query.GetFieldData(block.Name, "filler", i),
                };
                writer.WriteRecord(result);
            }
        };
    }
}