using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DataLib.model;
using GrabberManager.util;
using XA_DATASETLib;
using XingBot.real;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t9905
    {
        public static readonly InBlockQuery InBlock_t9905 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t9905 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t9905OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock1"); i++)
            {
                var result = new _t9905OutBlock1()
                {
                    shcode = query.GetFieldData(block1.Name, "shcode", i),
                    expcode = query.GetFieldData(block1.Name, "expcode", i),
                    hname = query.GetFieldData(block1.Name, "hname", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeElwBases.Add(result.shcode, new CodeElwBase()
                {
                    Name = result.hname,
                    Code = result.shcode,
                    ExpCode = result.expcode,
                });
            }
        };
    }
}