using DataLib.model;
using DataLib.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.res;

namespace XingBot.query
{
    //선물옵션 차트 틱
    public class Tr_t8414 : QueryChartBase
    {
        private _t8414InBlock _inBlock;
        private List<string> codes;
        private DateTime trLimit;

        public Tr_t8414() : base("t8414")
        {
        }

        public void Start()
        {
            var fucodes = Constants.CodeFutures.Select(code0 => code0.Value.Code).ToList();
            var opcodes = Constants.CodeOptions.Select(code0 => code0.Value.Code).ToList();
            codes = fucodes.Concat(opcodes).ToList();
            var code = codes.ElementAt(_codeIdx);
            InBlock(code);
        }

        protected override void InBlock(string shcode, bool isNext = false)
        {
            var szTrCode = _resModel.Name;
            var trCountRequest = _query.GetTRCountRequest(szTrCode);
            var trCountLimit = _query.GetTRCountLimit(szTrCode);
            if (trCountRequest <= 1)
            {
                trLimit = DateTime.Now;
            }
            while (trCountRequest > trCountLimit - 1)
            {
                var sleepSecond = trLimit.AddMinutes(10).Second - DateTime.Now.Second;
                LOG.Info("sleep until :" + sleepSecond);
                Thread.Sleep(sleepSecond);
            }
            if (isNext == false)
            {
                fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + "-" + shcode + ".csv");
                if (fi.Directory != null && !fi.Directory.Exists)
                {
                    System.IO.Directory.CreateDirectory(fi.DirectoryName);
                }
                fi.Delete();
                var today = DateTime.Now;
                _inBlock = new _t8414InBlock()
                {
                    shcode = shcode,
                    ncnt = 1,
                    qrycnt = 500,
                    nday = "0",
                    sdate = today.AddDays(-5).ToString("yyyyMMdd"),
                    edate = today.ToString("yyyyMMdd"),
                    comp_yn = "N",
                };
            }

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
            _query.Request(isNext);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;

            if (query.GetBlockCount(szTrCode+"OutBlock1") == 0)
            {
                Thread.Sleep(1000);
                _codeIdx++;
                var code = codes.ElementAt(_codeIdx);
                InBlock(code);
                return;
            }

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            var meta = new _t8414OutBlock()
            {
                shcode = query.GetFieldData(block.Name, "shcode", 0),
                jisiga = decimal.Parse(query.GetFieldData(block.Name, "jisiga", 0)),
                jihigh = decimal.Parse(query.GetFieldData(block.Name, "jihigh", 0)),
                jilow = decimal.Parse(query.GetFieldData(block.Name, "jilow", 0)),
                jiclose = decimal.Parse(query.GetFieldData(block.Name, "jiclose", 0)),
                jivolume = long.Parse(query.GetFieldData(block.Name, "jivolume", 0)),
                disiga = decimal.Parse(query.GetFieldData(block.Name, "disiga", 0)),
                dihigh = decimal.Parse(query.GetFieldData(block.Name, "dihigh", 0)),
                dilow = decimal.Parse(query.GetFieldData(block.Name, "dilow", 0)),
                diclose = decimal.Parse(query.GetFieldData(block.Name, "diclose", 0)),
                highend = decimal.Parse(query.GetFieldData(block.Name, "highend", 0)),
                lowend = decimal.Parse(query.GetFieldData(block.Name, "lowend", 0)),
                cts_date = query.GetFieldData(block.Name, "cts_date", 0),
                cts_time = query.GetFieldData(block.Name, "cts_time", 0),
                s_time = query.GetFieldData(block.Name, "s_time", 0),
                e_time = query.GetFieldData(block.Name, "e_time", 0),
                dshmin = query.GetFieldData(block.Name, "dshmin", 0),
                rec_count = long.Parse(query.GetFieldData(block.Name, "rec_count", 0)),
            };

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t8414OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t8414OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    time = query.GetFieldData(block1.Name, "time", i),
                    open = decimal.Parse(query.GetFieldData(block1.Name, "open", i)),
                    high = decimal.Parse(query.GetFieldData(block1.Name, "high", i)),
                    low = decimal.Parse(query.GetFieldData(block1.Name, "low", i)),
                    close = decimal.Parse(query.GetFieldData(block1.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    openyak = long.Parse(query.GetFieldData(block1.Name, "openyak", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }

            Thread.Sleep(1000);
            if (_query.IsNext)
            {
                _inBlock.cts_date = meta.cts_date;
                _inBlock.cts_time = meta.cts_time;
                _inBlock.comp_yn = "N";
                InBlock(meta.shcode, _query.IsNext);
            }
            else
            {
                //finish notify
                _codeIdx++;
                if (codes.Count > _codeIdx)
                {
                    var code = codes.ElementAt(_codeIdx);
                    InBlock(code);
                }
                else
                {
                    //TODO next callback hell
                }
            }
        }

    }
}