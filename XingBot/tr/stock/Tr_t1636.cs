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
    public class Tr_t1636
    {
        public static readonly InBlockQuery InBlock_t1636 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1636 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1636OutBlock()
                {
                    cts_idx = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1636OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1636OutBlock1()
                {
                    rank = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    hname = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    svalue = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    offervalue = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    stksvalue = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    svolume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    offervolume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    stksvolume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sgta = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    rate = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    shcode = query.GetFieldData(block1.Name, "date", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}