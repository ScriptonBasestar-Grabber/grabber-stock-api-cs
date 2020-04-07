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
    public class Tr_t1921
    {
        public static readonly InBlockQuery InBlock_t1921 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1921 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1921OutBlock()
                {
                    cnt = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    date = query.GetFieldData(block.Name, "shcode", i),
                    idx = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1921OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1921OutBlock1()
                {
                    mmdate = query.GetFieldData(block1.Name, "date", i),
                    close = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "time", i),
                    jchange = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    nvolume = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    svolume = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    jvolume = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    price = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    change = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    gyrate = decimal.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    jkrate = decimal.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    shcode = query.GetFieldData(block1.Name, "time", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}