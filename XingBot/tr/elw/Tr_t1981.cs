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
        public static readonly InBlockQuery InBlock_t1981 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate(Row row)
            {
                Console.WriteLine("inblock.Name :"+ inBlock.Name + "   row.Name :" + row.Name + "  dict[row.Name] :" + dict[row.Name] );
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
            });
            // query.SetFieldData("t1981InBlock", "mkt_gb", 0, "0");
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1981 = (szTrCode, query, outBlock, writer) =>
        {
            Console.WriteLine("1981 inside");
            Console.WriteLine(query);
            Console.WriteLine(outBlock);
            Console.WriteLine(writer);
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t1981OutBlock()
                {
                    ksp_cnt = query.GetFieldData(szTrCode + "OutBlock", "ksp_cnt", i),
                    ksd_cnt = query.GetFieldData(szTrCode + "OutBlock", "ksd_cnt", i),
                };
            }

            writer.WriteHeader<_t1981OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock1"); i++)
            {
                var result = new _t1981OutBlock1()
                {
                    shcode = query.GetFieldData(szTrCode + "OutBlock1", "shcode", i),
                    expcode = query.GetFieldData(szTrCode + "OutBlock1", "expcode", i),
                    hname = query.GetFieldData(szTrCode + "OutBlock1", "hname", i),
                    price = query.GetFieldData(szTrCode + "OutBlock1", "price", i),
                    sign = query.GetFieldData(szTrCode + "OutBlock1", "sign", i),
                    change = query.GetFieldData(szTrCode + "OutBlock1", "change", i),
                    rate = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock1", "rate", i)),
                    volume = query.GetFieldData(szTrCode + "OutBlock1", "volume", i),
                    value = query.GetFieldData(szTrCode + "OutBlock1", "value", i),
                    mkt_gb = query.GetFieldData(szTrCode + "OutBlock1", "mkt_gb", i),
                };
                Console.WriteLine(result.shcode);
                writer.NextRecord();
                writer.WriteRecord<_t1981OutBlock1>(result);
            }
        };
    }
}