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
    public class Tr_t8419
    {
        public static readonly InBlockQuery InBlock_t8419 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            // _query.SetFieldData(szTrCode + "InBlock", "shcode", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "qrycnt", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "sdate", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "edate", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "cts_date", 0, "");
            // _query.SetFieldData(szTrCode + "InBlock", "comp_yn", 0, "");
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8435 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8419OutBlock>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8419OutBlock()
                {
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    jisiga = decimal.Parse(query.GetFieldData(block.Name, "jisiga", i)),
                    jihigh = decimal.Parse(query.GetFieldData(block.Name, "jihigh", i)),
                    jilow = decimal.Parse(query.GetFieldData(block.Name, "jilow", i)),
                    jiclose = decimal.Parse(query.GetFieldData(block.Name, "jiclose", i)),
                    jivolume = long.Parse(query.GetFieldData(block.Name, "jivolume", i)),
                    disiga = decimal.Parse(query.GetFieldData(block.Name, "disiga", i)),
                    dihigh = decimal.Parse(query.GetFieldData(block.Name, "dihigh", i)),
                    dilow = decimal.Parse(query.GetFieldData(block.Name, "dilow", i)),
                    diclose = decimal.Parse(query.GetFieldData(block.Name, "diclose", i)),
                    disvalue = long.Parse(query.GetFieldData(block.Name, "disvalue", i)),
                    cts_date = query.GetFieldData(block.Name, "cts_date", i),
                    s_time = query.GetFieldData(block.Name, "s_time", i),
                    e_time = query.GetFieldData(block.Name, "e_time", i),
                    dshmin = query.GetFieldData(block.Name, "dshmin", i),
                    rec_count = long.Parse(query.GetFieldData(block.Name, "rec_count", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };

        public static readonly OutBlockQuery OutBlock1_t8435 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock1"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8419OutBlock1()
                {
                    date = query.GetFieldData(block.Name, "date", i),
                    open = decimal.Parse(query.GetFieldData(block.Name, "open", i)),
                    high = decimal.Parse(query.GetFieldData(block.Name, "jiclose", i)),
                    low = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    close = decimal.Parse(query.GetFieldData(block.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block.Name, "jdiff_vol", i)),
                    value = long.Parse(query.GetFieldData(block.Name, "value", i)),
                };
                writer.WriteRecord(result);
            }
        };
    }
}