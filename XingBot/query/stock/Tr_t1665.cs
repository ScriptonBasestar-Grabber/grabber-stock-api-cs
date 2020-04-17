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
    public class Tr_t1665
    {
        public static readonly InBlockQuery InBlock_t1665 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1665 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1665OutBlock()
                {
                    mcode = query.GetFieldData(block.Name, "open", i),
                    mname = query.GetFieldData(block.Name, "open", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1665OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1665OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    sv_08 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_17 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_18 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_01 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_03 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_04 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_02 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_05 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_06 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_07 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_00 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_09 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_10 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_11 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sv_99 = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_08 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_17 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_18 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_01 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_03 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_04 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_02 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_05 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_06 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_07 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_00 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_09 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_10 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_11 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sa_99 = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    jisu = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}