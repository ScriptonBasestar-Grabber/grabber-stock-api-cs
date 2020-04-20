using DataLib.model;
using DataLib.util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.real;
using XingBot.res;

namespace XingBot.query
{
    //주식 차트
    public class Tr_t4201 : QueryChartBase
    {
        private _t4201InBlock _inBlock;
        private List<string> codes;

        public Tr_t4201() : base("t4201")
        {
        }

        public void Start()
        {
            codes = Constants.CodeStocks.Select(code0 => code0.Value.Code).ToList();
            var code = codes.ElementAt(_codeIdx);
            InBlock(code);
        }

        protected override void InBlock(string shcode, bool isNext = false)
        {
            var szTrCode = _resModel.Name;
            while (_query.GetTRCountRequest(szTrCode) > _query.GetTRCountLimit(szTrCode) - 1)
            {
                Thread.Sleep(1000);
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
                _inBlock = new _t4201InBlock()
                {
                    shcode = shcode,
                    gubun = "0",
                    ncnt = 1,
                    qrycnt = 500,
                    tdgb = "0",
                    sdate = today.AddDays(-5).ToString("yyyyMMdd"),
                    edate = today.ToString("yyyyMMdd"),
                };
            }

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
            _query.Request(isNext);
            LOG.Info("s==============InBlock=================");
            LOG.Info("===========  GetTrCode");
            LOG.Info(_query.GetTrCode());
            LOG.Info("===========  GetTrDesc");
            LOG.Info(_query.GetTrDesc());
            LOG.Info("===========  InBlock Data");
            LOG.Info(PrintUtil.PrintProperties(_inBlock));
            LOG.Info("e==============InBlock=================");
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;
            LOG.Info("--------------start-------------");
            LOG.Info(szTrCode + "  " + _inBlock.shcode + "  " + _inBlock.cts_date + "   " + _inBlock.cts_time + "   " + _inBlock.cts_daygb);
            //LOG.Info("===========  GetAccountList");
            //LOG.Info(_query.GetAccountList(0));
            //LOG.Info("===========  GetBlockType 더 이상 지원하지 않습니다");
            //LOG.Info(_query.GetBlockType(szTrCode + "InBlock"));
            //LOG.Info("===========  GetResData");
            //LOG.Info(_query.GetResData());
            //LOG.Info("===========  GetBlockSize 더 이상 지원하지 않습니다.");
            //LOG.Info(_query.GetBlockSize(szTrCode + "OutBlock"));
            LOG.Info("===========  GetBlockCount");
            LOG.Info(_query.GetBlockCount(szTrCode + "OutBlock"));
            LOG.Info("===========  GetBlockCount1");
            LOG.Info(_query.GetBlockCount(szTrCode + "OutBlock1"));
            //LOG.Info("===========  GetFieldDescList 더 이상 지원하지 않습니다");
            //LOG.Info(_query.GetFieldDescList(szTrCode + "InBlock"));
            LOG.Info("===========  GetLastError");
            LOG.Info(_query.GetLastError());
            //LOG.Info("===========  GetAccountListCount");
            //LOG.Info(_query.GetAccountListCount());
            LOG.Info("===========  GetTRCountBaseSec");
            LOG.Info(_query.GetTRCountBaseSec(szTrCode));
            LOG.Info("===========  GetTRCountRequest");
            LOG.Info(_query.GetTRCountRequest(szTrCode));
            LOG.Info("===========  GetTRCountLimit");
            LOG.Info(_query.GetTRCountLimit(szTrCode));
            LOG.Info("===========  GetTRCountPerSec");
            LOG.Info(_query.GetTRCountPerSec(szTrCode));
            LOG.Info("===========  IsNext");
            LOG.Info(_query.IsNext);
            LOG.Info("===========  ");
            LOG.Info("------------end---------------");

            var block = resModel.Blocks[szTrCode + "OutBlock"];
            var meta = new _t4201OutBlock()
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
                cts_daygb = query.GetFieldData(block.Name, "cts_daygb", 0),
            };

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t4201OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(block1.Name); i++)
            {
                var result = new _t4201OutBlock1()
                {
                    date = query.GetFieldData(block1.Name, "date", i),
                    time = query.GetFieldData(block1.Name, "time", i),
                    open = long.Parse(query.GetFieldData(block1.Name, "open", i)),
                    high = long.Parse(query.GetFieldData(block1.Name, "high", i)),
                    low = long.Parse(query.GetFieldData(block1.Name, "low", i)),
                    close = long.Parse(query.GetFieldData(block1.Name, "close", i)),
                    jdiff_vol = long.Parse(query.GetFieldData(block1.Name, "jdiff_vol", i)),
                    value = long.Parse(query.GetFieldData(block1.Name, "value", i)),
                    jongchk = long.Parse(query.GetFieldData(block1.Name, "jongchk", i)),
                    rate = decimal.Parse(query.GetFieldData(block1.Name, "rate", i)),
                    pricechk = long.Parse(query.GetFieldData(block1.Name, "pricechk", i)),
                    ratevalue = long.Parse(query.GetFieldData(block1.Name, "ratevalue", i)),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
            }

            Thread.Sleep(1000);
            if (_query.IsNext)
            {
                _inBlock.cts_date = meta.cts_date;
                _inBlock.cts_time = meta.cts_time;
                _inBlock.cts_daygb = meta.cts_daygb;
                InBlock(meta.shcode, _query.IsNext);
            }
            else
            {
                //finish notify
                _codeIdx++;
                if (codes.Count < _codeIdx)
                {
                    var code = codes.ElementAt(_codeIdx);
                    InBlock(code);
                } else
                {
                    //TODO next callback hell
                }
            }
        }

    }
}