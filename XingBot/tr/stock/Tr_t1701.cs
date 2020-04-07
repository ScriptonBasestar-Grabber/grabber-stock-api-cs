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
    public class Tr_t1701
    {
        public static readonly InBlockQuery InBlock_t1701 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1701 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1701OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1701OutBlock()
                {
                    date = query.GetFieldData(block.Name, "date", i),
                    close = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sign = query.GetFieldData(block.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    psnvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    orgvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    frgvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    frgvolumesum = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    pgmvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    listing = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    listupdn = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sjrate = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}