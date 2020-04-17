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
    public class Tr_t1717
    {
        public static readonly InBlockQuery InBlock_t1717 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1717 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1717OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1717OutBlock()
                {
                    date = query.GetFieldData(block.Name, "date", i),
                    close = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sign = query.GetFieldData(block.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0000_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0001_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0002_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0003_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0004_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0005_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0006_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0007_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0008_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0009_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0010_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0011_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0018_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0016_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0017_vol = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0000_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0001_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0002_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0003_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0004_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0005_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0006_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0007_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0008_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0009_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0010_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0011_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0018_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0016_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    tjj0017_dan = long.Parse(query.GetFieldData(block.Name, "date", i)),

                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}