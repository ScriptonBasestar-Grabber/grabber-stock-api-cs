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
    public class Tr_t1752
    {
        public static readonly InBlockQuery InBlock_t1752 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1752 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1752OutBlock()
                {
                    fwdvl = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    fwsvl = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    cts_idx = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1752OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1752OutBlock1()
                {
                    tradname = query.GetFieldData(block1.Name, "date", i),
                    tradmdvol = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmsvol = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradmssvol = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    wintrd = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    winrat = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    tradno = query.GetFieldData(block1.Name, "date", i),
                    wgubun = query.GetFieldData(block1.Name, "date", i),
                    swinrat = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}