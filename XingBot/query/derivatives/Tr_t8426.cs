using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DataLib.model;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real;
using XingBot.real.Properties;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t8426
    {
        public static readonly InBlockQuery InBlock_t8426 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8426 = (resModel, query, writer) =>
        {
        };
    }
}