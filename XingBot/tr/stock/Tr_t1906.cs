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
    public class Tr_t1906
    {
        public static readonly InBlockQuery InBlock_t1906 = (resModel, query, dict) =>
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "InBlock"];
            block.Rows.ForEach(delegate (Row row)
            {
                query.SetFieldData(block.Name, row.Name, 0, dict[row.Name]);
            });
            query.Request(false);
        };

        public static readonly OutBlockQuery OutBlock_t1906 = (resModel, query, writer) =>
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t1906OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t1906OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "shcode", i),
                    price = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    sign = query.GetFieldData(block.Name, "shcode", i),
                    change = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    diff = decimal.Parse(query.GetFieldData(block.Name, "open", i)),
                    volume = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    lp_offerrem1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_offerrem10= long.Parse(query.GetFieldData(block.Name, "open", i)),
                    lp_bidrem10= long.Parse(query.GetFieldData(block.Name, "open", i)),

                    jnilclose = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerho1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha1 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha1 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha2 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha2 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha3 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha3 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha4 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha4 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha5 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha5 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha6 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha6 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha7 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha7 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha8 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha8 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha9 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha9 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offerho10 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidho10 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    offerrem10 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bidrem10 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha10 = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha10 = long.Parse(query.GetFieldData(block.Name, "open", i)),

                    offer = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    bid = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    preoffercha = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    prebidcha = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    hotime = query.GetFieldData(block.Name, "shcode", i),
                    yeprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    yevolume = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    yesign = query.GetFieldData(block.Name, "shcode", i),
                    yechange = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    yediff = decimal.Parse(query.GetFieldData(block.Name, "open", i)),
                    tmoffer = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    tmbid = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    ho_status = query.GetFieldData(block.Name, "shcode", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    uplmtprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    dnlmtprice = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    open = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    high = long.Parse(query.GetFieldData(block.Name, "open", i)),
                    low = long.Parse(query.GetFieldData(block.Name, "open", i)),
                 };
                writer.NextRecord();
                writer.WriteRecord(result);
            }
        };
    }
}