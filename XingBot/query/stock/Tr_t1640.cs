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
    public class Tr_t1640
    {
        public static readonly InBlockQuery InBlock_t1640 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1640 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1640OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1640OutBlock()
                {
                    offervolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    bidvolume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    offerdiff = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    biddiff = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    sundiff = long.Parse(query.GetFieldData(block.Name, "date", i)),
                    basis = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    offervalue = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    bidvalue = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    value = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    offervaldiff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    bidvaldiff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                    sunvaldiff = decimal.Parse(query.GetFieldData(block.Name, "date", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}