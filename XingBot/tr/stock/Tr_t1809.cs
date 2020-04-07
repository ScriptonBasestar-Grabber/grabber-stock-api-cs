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
    public class Tr_t1809
    {
        public static readonly InBlockQuery InBlock_t1809 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1809 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1809OutBlock()
                {
                    cts = query.GetFieldData(block.Name, "date", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1809OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1809OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    time = query.GetFieldData(block1.Name, "date", i),
                    signal_id = query.GetFieldData(block1.Name, "date", i),
                    signal_desc = query.GetFieldData(block1.Name, "date", i),
                    point = query.GetFieldData(block1.Name, "date", i),
                    keyword = query.GetFieldData(block1.Name, "date", i),
                    seq = query.GetFieldData(block1.Name, "date", i),
                    gubun = query.GetFieldData(block1.Name, "date", i),
                    jmcode = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "date", i),
                    chgrate = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    datetime = query.GetFieldData(block1.Name, "date", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}