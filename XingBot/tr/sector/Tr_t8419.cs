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
        public static readonly InBlockQuery InBlock_t8419 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
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

        public static readonly OutBlockQuery OutBlock_t8435 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8419OutBlock()
                {
                    shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    jisiga = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jisiga", i)),
                    jihigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jihigh", i)),
                    jilow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jilow", i)),
                    jiclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jiclose", i)),
                    jivolume = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "jivolume", i)),
                    disiga = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "disiga", i)),
                    dihigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "dihigh", i)),
                    dilow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "dilow", i)),
                    diclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "diclose", i)),
                    disvalue = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "disvalue", i)),
                    cts_date = query.GetFieldData(szTrCode + "OutBlock", "cts_date", i),
                    s_time = query.GetFieldData(szTrCode + "OutBlock", "s_time", i),
                    e_time = query.GetFieldData(szTrCode + "OutBlock", "e_time", i),
                    dshmin = query.GetFieldData(szTrCode + "OutBlock", "dshmin", i),
                    rec_count = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "rec_count", i)),
                };
                writer.WriteRecord(result);
            }
        };

        public static readonly OutBlockQuery OutBlock1_t8435 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8419OutBlock1()
                {
                    date = query.GetFieldData(szTrCode + "OutBlock", "date", i),
                    open = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "open", i)),
                    high = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jiclose", i)),
                    low = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "low", i)),
                    close = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "jdiff_vol", i)),
                    value = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "value", i)),
                };
                writer.WriteRecord(result);
            }
        };
    }
}