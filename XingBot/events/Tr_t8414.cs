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
    public class Tr_t8414 : QueryBase
    {
        private _t8414InBlock _inBlock;

        public Tr_t8414(_t8414InBlock inBlock) : base("t8414")
        {
            _inBlock = inBlock;
        }

        public override void InBlock()
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            _query.SetFieldData(block.Name, "shcode", 0, _inBlock.shcode);
            _query.SetFieldData(block.Name, "ncnt", 0, _inBlock.ncnt.ToString());
            _query.SetFieldData(block.Name, "qrycnt", 0, _inBlock.qrycnt.ToString());
            _query.SetFieldData(block.Name, "nday", 0, _inBlock.nday);
            _query.SetFieldData(block.Name, "sdate", 0, _inBlock.sdate);
            _query.SetFieldData(block.Name, "stime", 0, _inBlock.sdate);
            _query.SetFieldData(block.Name, "edate", 0, _inBlock.edate);
            _query.SetFieldData(block.Name, "etime", 0, _inBlock.edate);
            _query.SetFieldData(block.Name, "cts_date", 0, _inBlock.cts_date);
            _query.SetFieldData(block.Name, "cts_time", 0, _inBlock.cts_time);
            _query.SetFieldData(block.Name, "comp_yn", 0, _inBlock.comp_yn);
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            var meta = new _t8414OutBlock()
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
                highend = long.Parse(query.GetFieldData(block.Name, "highend", 0)),
                lowend = long.Parse(query.GetFieldData(block.Name, "lowend", 0)),
                cts_date = query.GetFieldData(block.Name, "cts_date", 0),
                cts_time = query.GetFieldData(block.Name, "cts_time", 0),
                s_time = query.GetFieldData(block.Name, "s_time", 0),
                e_time = query.GetFieldData(block.Name, "e_time", 0),
                dshmin = query.GetFieldData(block.Name, "dshmin", 0),
                rec_count = long.Parse(query.GetFieldData(block.Name, "rec_count", 0)),
            };

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t8414OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8414OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    time = query.GetFieldData(block1.Name, "time", i),
                    open = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    high = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    low = long.Parse(query.GetFieldData(block1.Name, "low", i)),
                    close = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    openyak = long.Parse(query.GetFieldData(block1.Name, "openyak", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }

            Thread.Sleep(6000);
            _inBlock.cts_date = meta.cts_date;
            _inBlock.cts_time = meta.cts_time;
            InBlock();
        }

    }
}