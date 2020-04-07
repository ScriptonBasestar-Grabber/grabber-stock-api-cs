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
    public class Tr_t1771
    {
        public static readonly InBlockQuery InBlock_t1771 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1771 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1771OutBlock()
                {
                    cts_idx = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1771OutBlock2>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1771OutBlock2()
                {
                    traddate = query.GetFieldData(block1.Name, "date", i),
                    tradtime = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmdcha = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmscha = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmdval = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmsval = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmsscha = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmttvolume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradavg = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmttavg = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}