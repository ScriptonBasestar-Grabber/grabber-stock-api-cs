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
    public class Tr_t1941
    {
        public static readonly InBlockQuery InBlock_t1941 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1941 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1941OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1941OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "time", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    upvolume = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    dnvolume = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    tovolume = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    tovalue = long.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    shcode = query.GetFieldData(block1.Name, "time", i),
                    tovoldif = long.Parse(query.GetFieldData(block1.Name, "ratevalue", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}