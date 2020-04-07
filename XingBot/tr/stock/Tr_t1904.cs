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
    public class Tr_t1904
    {
        public static readonly InBlockQuery InBlock_t1904 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1904 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1904OutBlock()
                {
                    chk_tday = query.GetFieldData(block.Name, "shcode", i),
                    date = query.GetFieldData(block.Name, "shcode", i),
                    price = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    sign = query.GetFieldData(block.Name, "shcode", i),
                    change = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    nav = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    navsign = query.GetFieldData(block.Name, "shcode", i),
                    navchange = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    navdiff = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    jnilnav = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    jnilnavsign = query.GetFieldData(block.Name, "shcode", i),
                    jnilnavchange = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    jnilnavdiff = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    upname = query.GetFieldData(block.Name, "shcode", i),
                    upcode = query.GetFieldData(block.Name, "shcode", i),
                    upprice = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    upsign = query.GetFieldData(block.Name, "shcode", i),
                    upchange = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    updiff = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    futname = query.GetFieldData(block.Name, "shcode", i),
                    futcode = query.GetFieldData(block.Name, "shcode", i),
                    futprice = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    futsign = query.GetFieldData(block.Name, "shcode", i),
                    futchange = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    futdiff = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    upname2 = query.GetFieldData(block.Name, "shcode", i),
                    upcode2 = query.GetFieldData(block.Name, "shcode", i),
                    upprice2 = decimal.Parse(query.GetFieldData(block.Name, "pricechk", i)),
                    etftotcap = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    etfnum = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    etfcunum = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    cash = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    opcom_nmk = query.GetFieldData(block.Name, "shcode", i),
                    tot_pval = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    tot_sigatval = long.Parse(query.GetFieldData(block.Name, "open", i)),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1904OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t1904OutBlock1()
                {
                    shcode = query.GetFieldData(block1.Name, "date", i),
                    hname = query.GetFieldData(block1.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    sign = query.GetFieldData(block1.Name, "time", i),
                    change = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    diff = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    volume = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    value = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    icux = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    parprice = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    pvalue = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    sigatvalue = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    profitdate = query.GetFieldData(block1.Name, "time", i),
                    weight = decimal.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    diff2 = decimal.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}