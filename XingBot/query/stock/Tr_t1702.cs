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
    public class Tr_t1702
    {
        public static readonly InBlockQuery InBlock_t1702 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1702 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1702OutBlock()
                {
                    cts_idx = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    cts_date = query.GetFieldData(block.Name, "open", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1702OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1702OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    close = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0000 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0001 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0002 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0003 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0004 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0005 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0006 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0007 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0008 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0009 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0010 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0011 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0018 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0088 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    amt0099 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}