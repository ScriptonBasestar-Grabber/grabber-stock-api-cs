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
    public class Tr_t1826
    {
        public static readonly InBlockQuery InBlock_t1826 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1826 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1826OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1826OutBlock()
                {
                    search_cd = query.GetFieldData(block.Name, "date", i),
                    search_nm = query.GetFieldData(block.Name, "date", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}