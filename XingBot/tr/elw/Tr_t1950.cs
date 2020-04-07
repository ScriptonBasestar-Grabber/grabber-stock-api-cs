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
    public class Tr_t1950
    {
        public static readonly InBlockQuery InBlock_t1950 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1950 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                var result = new _t1950OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    chetime = query.GetFieldData(block.Name, "chetime", i),
                    price = long.Parse(query.GetFieldData(block.Name, "price", i)),
                    sign = query.GetFieldData(block.Name, "sign", i),
                    change = long.Parse(query.GetFieldData(block.Name, "change", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "diff", i)),
                    cvolume = long.Parse(query.GetFieldData(block.Name, "cvolume", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "volume", i)),
                    recprice = long.Parse(query.GetFieldData(block.Name, "recprice", i)),
                    avg = long.Parse(query.GetFieldData(block.Name, "avg", i)),
                    jnilvolume = decimal.Parse(query.GetFieldData(block.Name, "jnilvolume", i)),
                    jvolume = decimal.Parse(query.GetFieldData(block.Name, "jvolume", i)),
                    jnilclose = long.Parse(query.GetFieldData(block.Name, "jnilclose", i)),
                    volumechg = decimal.Parse(query.GetFieldData(block.Name, "volumechg", i)),
                    volumediff = decimal.Parse(query.GetFieldData(block.Name, "volumediff", i)),
                    open = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    odiff = decimal.Parse(query.GetFieldData(block.Name, "odiff", i)),
                    opentime = query.GetFieldData(block.Name, "opentime", i),
                    high = long.Parse(query.GetFieldData(block.Name, "high", i)),
                    hdiff = decimal.Parse(query.GetFieldData(block.Name, "hdiff", i)),
                    hightime = query.GetFieldData(block.Name, "hightime", i),
                    low = long.Parse(query.GetFieldData(block.Name, "low", i)),
                    ldiff = decimal.Parse(query.GetFieldData(block.Name, "ldiff", i)),
                    lowtime = query.GetFieldData(block.Name, "lowtime", i),
                    high52w = long.Parse(query.GetFieldData(block.Name, "high52w", i)),
                    high52wdiff = decimal.Parse(query.GetFieldData(block.Name, "high52wdiff", i)),
                    high52wdate = query.GetFieldData(block.Name, "high52wdate", i),
                    low52w = long.Parse(query.GetFieldData(block.Name, "low52w", i)),
                    low52wdiff = decimal.Parse(query.GetFieldData(block.Name, "low52wdiff", i)),
                    low52wdate = query.GetFieldData(block.Name, "low52wdate", i),
                    exhratio = decimal.Parse(query.GetFieldData(block.Name, "exhratio", i)),
                    listing = decimal.Parse(query.GetFieldData(block.Name, "listing", i)),
                    memedan = query.GetFieldData(block.Name, "memedan", i),
                    vol = decimal.Parse(query.GetFieldData(block.Name, "vol", i)),
                    parity = decimal.Parse(query.GetFieldData(block.Name, "parity", i)),
                    berate = decimal.Parse(query.GetFieldData(block.Name, "berate", i)),
                    gearing = decimal.Parse(query.GetFieldData(block.Name, "gearing", i)),
                    elwexec = decimal.Parse(query.GetFieldData(block.Name, "elwexec", i)),
                    issueprice = long.Parse(query.GetFieldData(block.Name, "issueprice", i)),
                    convrate = decimal.Parse(query.GetFieldData(block.Name, "convrate", i)),
                    lastdate = query.GetFieldData(block.Name, "lastdate", i),
                    capt = decimal.Parse(query.GetFieldData(block.Name, "capt", i)),
                    egearing = decimal.Parse(query.GetFieldData(block.Name, "egearing", i)),
                    premium = decimal.Parse(query.GetFieldData(block.Name, "premium", i)),
                    spread = decimal.Parse(query.GetFieldData(block.Name, "spread", i)),
                    espread = decimal.Parse(query.GetFieldData(block.Name, "espread", i)),
                    theoryprice = decimal.Parse(query.GetFieldData(block.Name, "theoryprice", i)),
                    impv = decimal.Parse(query.GetFieldData(block.Name, "impv", i)),
                    moneyness = query.GetFieldData(block.Name, "moneyness", i),
                    delt = decimal.Parse(query.GetFieldData(block.Name, "delt", i)),
                    gama = decimal.Parse(query.GetFieldData(block.Name, "gama", i)),
                    vega = decimal.Parse(query.GetFieldData(block.Name, "vega", i)),
                    ceta = decimal.Parse(query.GetFieldData(block.Name, "ceta", i)),
                    rhox = decimal.Parse(query.GetFieldData(block.Name, "rhox", i)),
                    bjandatecnt = long.Parse(query.GetFieldData(block.Name, "bjandatecnt", i)),
                    mmsdate = query.GetFieldData(block.Name, "mmsdate", i),
                    mmedate = query.GetFieldData(block.Name, "mmedate", i),
                    payday = query.GetFieldData(block.Name, "payday", i),
                    listdate = query.GetFieldData(block.Name, "listdate", i),
                    lpmem = query.GetFieldData(block.Name, "lpmem", i),
                    lp_holdvol = decimal.Parse(query.GetFieldData(block.Name, "lp_holdvol", i)),
                    bcode = query.GetFieldData(block.Name, "bcode", i),
                    bgubun = query.GetFieldData(block.Name, "bgubun", i),
                    bprice = long.Parse(query.GetFieldData(block.Name, "bprice", i)),
                    bsign = query.GetFieldData(block.Name, "bsign", i),
                    bchange = long.Parse(query.GetFieldData(block.Name, "bchange", i)),
                    bdiff = decimal.Parse(query.GetFieldData(block.Name, "bdiff", i)),
                    bvolume = decimal.Parse(query.GetFieldData(block.Name, "bvolume", i)),
                    info1 = query.GetFieldData(block.Name, "info1", i),
                    info2 = query.GetFieldData(block.Name, "info2", i),
                    info3 = query.GetFieldData(block.Name, "info3", i),
                    info4 = query.GetFieldData(block.Name, "info4", i),
                    janginfo = query.GetFieldData(block.Name, "janginfo", i),
                    basketgb = query.GetFieldData(block.Name, "basketgb", i),
                    basketcnt = long.Parse(query.GetFieldData(block.Name, "basketcnt", i)),
                    elwtype = query.GetFieldData(block.Name, "elwtype", i),
                    settletype = query.GetFieldData(block.Name, "settletype", i),
                    lpord = query.GetFieldData(block.Name, "lpord", i),
                    elwdetail = query.GetFieldData(block.Name, "elwdetail", i),
                    valuation = query.GetFieldData(block.Name, "valuation", i),
                };
            }

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1950OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1950OutBlock1()
                {
                    bskcode = query.GetFieldData(block.Name, "bskcode", i),
                    bskbno = long.Parse(query.GetFieldData(block.Name, "bskbno", i)),
                    bskprice = long.Parse(query.GetFieldData(block.Name, "bskprice", i)),
                    bsksign = query.GetFieldData(block.Name, "bsksign", i),
                    bskchange = long.Parse(query.GetFieldData(block.Name, "bskchange", i)),
                    bskdiff = decimal.Parse(query.GetFieldData(block.Name, "bskdiff", i)),
                    bskvolume = decimal.Parse(query.GetFieldData(block.Name, "bskvolume", i)),
                    bskjnilclose = long.Parse(query.GetFieldData(block.Name, "bskjnilclose", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}