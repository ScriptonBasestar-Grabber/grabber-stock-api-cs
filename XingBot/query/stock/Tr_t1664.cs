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
    public class Tr_t1664
    {
        public static readonly InBlockQuery InBlock_t1664 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1664 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1664OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1664OutBlock1()
                {
                    dt = query.GetFieldData(block.Name, "date", i),
                    tjj01 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj02 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj03 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj04 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj05 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj06 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj07 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj08 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj17 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj18 = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    cha = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    bicha = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    totcha = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    basis = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}