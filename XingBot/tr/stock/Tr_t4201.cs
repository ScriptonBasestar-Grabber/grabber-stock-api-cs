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
    public class Tr_t4201
    {
        public static readonly InBlockQuery InBlock_t4201 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t4201 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t4201OutBlock()
                {
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    jisiga = long.Parse(query.GetFieldData(block.Name, "jisiga", i)),
                    jihigh = long.Parse(query.GetFieldData(block.Name, "jihigh", i)),
                    jilow = long.Parse(query.GetFieldData(block.Name, "jilow", i)),
                    jiclose = long.Parse(query.GetFieldData(block.Name, "jiclose", i)),
                    jivolume = long.Parse(query.GetFieldData(block.Name, "jivolume", i)),
                    disiga = long.Parse(query.GetFieldData(block.Name, "disiga", i)),
                    dihigh = long.Parse(query.GetFieldData(block.Name, "dihigh", i)),
                    dilow = long.Parse(query.GetFieldData(block.Name, "dilow", i)),
                    diclose = long.Parse(query.GetFieldData(block.Name, "diclose", i)),
                    highend = long.Parse(query.GetFieldData(block.Name, "highend", i)),
                    lowend = long.Parse(query.GetFieldData(block.Name, "lowend", i)),
                    cts_date = query.GetFieldData(block.Name, "cts_date", i),
                    cts_time = query.GetFieldData(block.Name, "cts_time", i),
                    cts_daygb = query.GetFieldData(block.Name, "cts_daygb", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t4201OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t4201OutBlock1()
                {
                    date = query.GetFieldData(block.Name, "date", i),
                    time = query.GetFieldData(block.Name, "time", i),
                    open = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    high = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    low = long.Parse(query.GetFieldData(block.Name, "low", i)),
                    close = long.Parse(query.GetFieldData(block.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block.Name, "jdiff_vol", i)),
                    value = long.Parse(query.GetFieldData(block.Name, "value", i)),
                    jongchk = long.Parse(query.GetFieldData(block.Name, "jongchk", i)),
                    rate = decimal.Parse(query.GetFieldData(block.Name, "rate", i)),
                    pricechk = long.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    ratevalue = long.Parse(query.GetFieldData(block.Name, "ratevalue", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}