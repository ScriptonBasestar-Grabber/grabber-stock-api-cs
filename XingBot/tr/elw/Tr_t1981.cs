using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t1981
    {
        public static readonly InBlockQuery InBlock_t1981 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1981 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t1981OutBlock()
                {
                    ksp_cnt = query.GetFieldData(block.Name, "ksp_cnt", i),
                    ksd_cnt = query.GetFieldData(block.Name, "ksd_cnt", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1981OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock1"); i++)
            {
                var result = new _t1981OutBlock1()
                {
                    shcode = query.GetFieldData(block1.Name, "shcode", i),
                    expcode = query.GetFieldData(block1.Name, "expcode", i),
                    hname = query.GetFieldData(block1.Name, "hname", i),
                    price = query.GetFieldData(block1.Name, "price", i),
                    sign = query.GetFieldData(block1.Name, "sign", i),
                    change = query.GetFieldData(block1.Name, "change", i),
                    rate = decimal.Parse(query.GetFieldData(block1.Name, "rate", i)),
                    volume = query.GetFieldData(block1.Name, "volume", i),
                    value = query.GetFieldData(block1.Name, "value", i),
                    mkt_gb = query.GetFieldData(block1.Name, "mkt_gb", i),
                };
                writer.NextRecord();
                writer.WriteRecord<_t1981OutBlock1>(result);
            }
        };
    }
}