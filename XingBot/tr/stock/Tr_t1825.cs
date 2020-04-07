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
    public class Tr_t1825
    {
        public static readonly InBlockQuery InBlock_t1825 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1825 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1825OutBlock()
                {
                    JongCnt = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1825OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1825OutBlock1()
                {
                    shcode = query.GetFieldData(block1.Name, "date", i),
                    hname = query.GetFieldData(block1.Name, "date", i),
                    sign = query.GetFieldData(block1.Name, "date", i),
                    signcnt = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    close = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    change = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    volumerate = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}