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
    public class Tr_t8424
    {
        /**
         * gubun 0, 1 KOSPI,2 KOSDAQ, 3, 4
         */
        public static readonly InBlockQuery InBlock_t8424 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8424 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8424OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    upcode = query.GetFieldData(block.Name, "upcode", i)
                };
                writer.WriteRecord(result);
            }
        };
    }
}