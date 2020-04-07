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
    public class Tr_t1901
    {
        public static readonly InBlockQuery InBlock_t1901 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate(Row row) { query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]); });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1901 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t1901OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1901OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "date", i),
                    price = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    sign = query.GetFieldData(block.Name, "date", i),
                    change = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    volume = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    recprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    avg = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    uplmtprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dnlmtprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    jnilvolume = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    volumediff = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    open = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    opentime = query.GetFieldData(block.Name, "date", i),
                    high = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    hightime = query.GetFieldData(block.Name, "date", i),
                    low = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lowtime = query.GetFieldData(block.Name, "date", i),
                    high52w = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    high52wdate = query.GetFieldData(block.Name, "date", i),
                    low52w = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    low52wdate = query.GetFieldData(block.Name, "date", i),
                    exhratio = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    flmtvol = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    per = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    listing = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    jkrate = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    vol = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    shcode = query.GetFieldData(block.Name, "date", i),
                    value = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    highyear = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    highyeardate = query.GetFieldData(block.Name, "date", i),
                    lowyear = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lowyeardate = query.GetFieldData(block.Name, "date", i),
                    upname = query.GetFieldData(block.Name, "date", i),
                    upcode = query.GetFieldData(block.Name, "date", i),
                    upprice = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    upsign = query.GetFieldData(block.Name, "date", i),
                    upchange = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    updiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    futname = query.GetFieldData(block.Name, "date", i),
                    futcode = query.GetFieldData(block.Name, "date", i),
                    futprice = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    futsign = query.GetFieldData(block.Name, "date", i),
                    futchange = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    futdiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    nav = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    navsign = query.GetFieldData(block.Name, "date", i),
                    navchange = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    navdiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    cocrate = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    kasis = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    subprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerno1 = query.GetFieldData(block.Name, "date", i),
                    bidno1 = query.GetFieldData(block.Name, "date", i),
                    dvol1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    svol1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dcha1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    scha1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ddiff1 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    sdiff1 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    offerno2 = query.GetFieldData(block.Name, "date", i),
                    bidno2 = query.GetFieldData(block.Name, "date", i),
                    dvol2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    svol2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dcha2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    scha2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ddiff2 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    sdiff2 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    offerno3 = query.GetFieldData(block.Name, "date", i),
                    bidno3 = query.GetFieldData(block.Name, "date", i),
                    dvol3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    svol3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dcha3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    scha3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ddiff3 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    sdiff3 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    offerno4 = query.GetFieldData(block.Name, "date", i),
                    bidno4 = query.GetFieldData(block.Name, "date", i),
                    dvol4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    svol4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dcha4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    scha4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ddiff4 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    sdiff4 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    offerno5 = query.GetFieldData(block.Name, "date", i),
                    bidno5 = query.GetFieldData(block.Name, "date", i),
                    dvol5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    svol5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dcha5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    scha5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ddiff5 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    sdiff5 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    fwdvl = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ftradmdcha = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ftradmddiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    fwsvl = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ftradmscha = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ftradmsdiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    upname2 = query.GetFieldData(block.Name, "date", i),
                    upcode2 = query.GetFieldData(block.Name, "date", i),
                    upprice2 = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    jnilnav = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    jnilnavsign = query.GetFieldData(block.Name, "date", i),
                    jnilnavchange = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    jnilnavdiff = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    etftotcap = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    spread = decimal.Parse(query.GetFieldData(block.Name, "low", i)),
                    leverage = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    taxgubun = query.GetFieldData(block.Name, "date", i),
                    opcom_nmk = query.GetFieldData(block.Name, "date", i),
                    lp_nm1 = query.GetFieldData(block.Name, "date", i),
                    lp_nm2 = query.GetFieldData(block.Name, "date", i),
                    lp_nm3 = query.GetFieldData(block.Name, "date", i),
                    lp_nm4 = query.GetFieldData(block.Name, "date", i),
                    lp_nm5 = query.GetFieldData(block.Name, "date", i),
                    etf_cp = query.GetFieldData(block.Name, "date", i),
                    etf_kind = query.GetFieldData(block.Name, "date", i),
                    vi_gubun = query.GetFieldData(block.Name, "date", i),
                    etn_kind_cd = query.GetFieldData(block.Name, "date", i),
                    lastymd = query.GetFieldData(block.Name, "date", i),
                    payday = query.GetFieldData(block.Name, "date", i),
                    lastdate = query.GetFieldData(block.Name, "date", i),
                    issuernmk = query.GetFieldData(block.Name, "date", i),
                    last_sdate = query.GetFieldData(block.Name, "date", i),
                    last_edate = query.GetFieldData(block.Name, "date", i),
                    lp_holdvol = query.GetFieldData(block.Name, "date", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}