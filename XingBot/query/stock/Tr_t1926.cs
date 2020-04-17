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
    public class Tr_t1926
    {
        public static readonly InBlockQuery InBlock_t1926 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1926 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1926OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1926OutBlock()
                {
                    ynvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    ysvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    yjvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    yvchange = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    ygrate = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    yjrate = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    ynprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    ysprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    yjprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    yachange = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dnvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dsvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    djvolume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dvchange = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dgrate = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    djrate = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    dnprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dsprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    djprice = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    dachange = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    mmdate = query.GetFieldData(block.Name, "shcode", i),
                    close = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    value = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    pr5days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    pr20days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    yj5days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    yj20days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    dj5days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    dj20days = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}