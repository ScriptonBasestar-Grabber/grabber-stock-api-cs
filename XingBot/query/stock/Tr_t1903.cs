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
    public class Tr_t1903
    {
        public static readonly InBlockQuery InBlock_t1903 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1903 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1903OutBlock()
                {
                    date = query.GetFieldData(block.Name, "shcode", i),
                    hname = query.GetFieldData(block.Name, "shcode", i),
                    upname = query.GetFieldData(block.Name, "shcode", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1903OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1903OutBlock1()
                {
                    hname = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "time", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    volume = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    navdiff = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    nav = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    navchange = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    crate = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    grate = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    jisu = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    jichange = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    jirate = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}