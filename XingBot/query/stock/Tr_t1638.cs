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
    public class Tr_t1638
    {
        public static readonly InBlockQuery InBlock_t1638 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1638 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1638OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1638OutBlock()
                {
                    rank = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    hname = query.GetFieldData(block.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sign = query.GetFieldData(block.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    sigatotrt = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    obuyvol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    buyrem = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    psgvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sellrem = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    pdgvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sigatot = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    shcode = query.GetFieldData(block.Name, "date", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}