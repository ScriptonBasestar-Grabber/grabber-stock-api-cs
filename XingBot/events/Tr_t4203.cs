using DataLib.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.tr
{
    public class Tr_t4203 : QueryBase
    {
        private _t4203InBlock _inBlock;

        public Tr_t4203(_t4203InBlock inBlock) : base("t4203")
        {
            _inBlock = inBlock;
        }

        public override void InBlock()
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            _query.SetFieldData(block.Name, "shcode", 0, _inBlock.shcode);
            _query.SetFieldData(block.Name, "gubun", 0, _inBlock.gubun);
            _query.SetFieldData(block.Name, "ncnt", 0, _inBlock.ncnt.ToString());
            _query.SetFieldData(block.Name, "qrycnt", 0, _inBlock.qrycnt.ToString());
            _query.SetFieldData(block.Name, "tdgb", 0, _inBlock.tdgb);
            _query.SetFieldData(block.Name, "sdate", 0, _inBlock.sdate);
            _query.SetFieldData(block.Name, "edate", 0, _inBlock.edate);
            _query.SetFieldData(block.Name, "cts_date", 0, _inBlock.cts_date);
            _query.SetFieldData(block.Name, "cts_time", 0, _inBlock.cts_time);
            _query.SetFieldData(block.Name, "cts_daygb", 0, _inBlock.cts_daygb);
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            var meta = new _t4203OutBlock()
            {
                shcode = query.GetFieldData(block.Name, "shcode", 0),
                jisiga = long.Parse(query.GetFieldData(block.Name, "jisiga", 0)),
                jihigh = long.Parse(query.GetFieldData(block.Name, "jihigh", 0)),
                jilow = long.Parse(query.GetFieldData(block.Name, "jilow", 0)),
                jiclose = long.Parse(query.GetFieldData(block.Name, "jiclose", 0)),
                jivolume = long.Parse(query.GetFieldData(block.Name, "jivolume", 0)),
                disiga = long.Parse(query.GetFieldData(block.Name, "disiga", 0)),
                dihigh = long.Parse(query.GetFieldData(block.Name, "dihigh", 0)),
                dilow = long.Parse(query.GetFieldData(block.Name, "dilow", 0)),
                diclose = long.Parse(query.GetFieldData(block.Name, "diclose", 0)),
                disvalue = long.Parse(query.GetFieldData(block.Name, "disvalue", 0)),
                cts_date = query.GetFieldData(block.Name, "cts_date", 0),
                cts_time = query.GetFieldData(block.Name, "cts_time", 0),
                cts_daygb = query.GetFieldData(block.Name, "cts_daygb", 0),
            };

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t4203OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t4203OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    time = query.GetFieldData(block1.Name, "time", i),
                    open = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    high = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    low = long.Parse(query.GetFieldData(block1.Name, "low", i)),
                    close = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    value = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }

            Thread.Sleep(6000);
            _inBlock.cts_date = meta.cts_date;
            _inBlock.cts_time = meta.cts_time;
            _inBlock.cts_daygb = meta.cts_daygb;
            InBlock();
        }

    }
}