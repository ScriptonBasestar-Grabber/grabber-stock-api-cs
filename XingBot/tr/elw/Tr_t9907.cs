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
    public class Tr_t9907
    {
        public static readonly InBlockQuery InBlock_t9907 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t9907 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t9907OutBlock1()
                {
                    lastym = query.GetFieldData(block.Name, "lastym", i),
                    lastnm = query.GetFieldData(block.Name, "lastnm", i),
                };
                writer.WriteRecord(result);
            }
        };
    }
}