using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using DataLib.model;
using GrabberManager.util;
using XA_DATASETLib;
using XingBot.real;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t8425
    {
        public static readonly InBlockQuery InBlock_t8425 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8425 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8425OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8425OutBlock()
                {
                tmname = query.GetFieldData(block.Name, "tmname", i),
                tmcode = query.GetFieldData(block.Name, "tmcode", i)
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeThemes.Add(result.tmcode, new CodeTheme()
                {
                    Name = result.tmname,
                    Code = result.tmcode,
                });
            }
        };
}
}