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
    public class Tr_t1927
    {
        public static readonly InBlockQuery InBlock_t1927 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1927 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1927OutBlock()
                {
                    date = query.GetFieldData(block.Name, "shcode", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1927OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1927OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "time", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    value = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    gm_vo = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    gm_va = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    gm_per = decimal.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    gm_avg = long.Parse(query.GetFieldData(block1.Name, "ratevalue", i)),
                    gm_vo_sum = long.Parse(query.GetFieldData(block1.Name, "ratevalue", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}