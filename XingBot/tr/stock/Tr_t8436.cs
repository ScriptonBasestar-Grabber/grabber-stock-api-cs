using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.tr
{
    public class Tr_t8436
    {
        public static readonly InBlockQuery InBlock_t8436 = (szTrCode, query, inBlock, dict) =>
        {
            inBlock.Rows.ForEach(delegate(Row row)
            {
                query.SetFieldData(inBlock.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t8436 = (szTrCode, query, outBlock, writer) =>
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t8436OutBlock()
                {
                    hname = query.GetFieldData(outBlock.Name, "hname", i),
                    shcode = query.GetFieldData(outBlock.Name, "shcode", i),
                    expcode = query.GetFieldData(outBlock.Name, "expcode", i),
                    etfgubun = query.GetFieldData(outBlock.Name, "etfgubun", i),
                    uplmtprice = long.Parse(query.GetFieldData(outBlock.Name, "uplmtprice", i)),
                    dnlmtprice = long.Parse(query.GetFieldData(outBlock.Name, "dnlmtprice", i)),
                    jnilclose = long.Parse(query.GetFieldData(outBlock.Name, "jnilclose", i)),
                    memedan = query.GetFieldData(outBlock.Name, "memedan", i),
                    recprice = long.Parse(query.GetFieldData(outBlock.Name, "recprice", i)),
                    gubun = query.GetFieldData(outBlock.Name, "gubun", i),
                    bu12gubun = query.GetFieldData(outBlock.Name, "bu12gubun", i),
                    spac_gubun = query.GetFieldData(outBlock.Name, "spac_gubun", i),
                    filler = query.GetFieldData(outBlock.Name, "filler", i),
                };
                writer.WriteRecord(result);
            }
        };
    }
}