using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real.Properties;
using XingBot.real.res;

namespace XingBot.tr
{
    public class Tr_t8432
    {
        public static readonly InBlockQuery InBlock_t8432 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate(Row row)
            {
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
            });
        };

        public static readonly OutBlockQuery OutBlock_t8432 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8432OutBlock()
                {
                    hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                    shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                    expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                    uplmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                    dnlmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                    jnilclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                    jnilhigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                    jnillow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                    recprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                };
                writer.WriteRecord(result);
            }
        };
    }
}