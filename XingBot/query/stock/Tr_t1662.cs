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
    public class Tr_t1662
    {
        public static readonly InBlockQuery InBlock_t1662 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1662 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1662OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1662OutBlock()
                {
                    time = query.GetFieldData(block.Name, "date", i),
                    k200jisu = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    sign = query.GetFieldData(block.Name, "date", i),
                    change = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    k200basis = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tot3 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tot1 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tot2 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    cha3 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    cha1 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    cha2 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    bcha3 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    bcha1 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    bcha2 = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}