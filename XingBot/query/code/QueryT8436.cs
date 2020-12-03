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
using XingBot.tr;

namespace XingBot.query
{
    public class QueryT8436 : QueryCodeBase
    {
        private _t8436InBlock _inBlock;

        public QueryT8436() : base("t8436")
        {
            LOG.Info("Constructor QueryT8436");
        }

        public void Start(Action action)
        {
            LOG.Debug("t8436 start");
            _action = action;
            _inBlock.gubun = "0";
            InBlock();
        }

        protected override void InBlock()
        {
            var szTrCode = _resModel.Name;
            LOG.Debug($"trCountLimit : {_query.GetTRCountLimit(szTrCode)}, trCountRequest : {_query.GetTRCountRequest(szTrCode)}, trCountBaseSec : {_query.GetTRCountBaseSec(szTrCode)}, trCountPerSec : {_query.GetTRCountPerSec(szTrCode)}");
            if (_query.GetTRCountLimit(szTrCode) != 0)
            {
                while (_query.GetTRCountLimit(szTrCode) <= _query.GetTRCountRequest(szTrCode))
                {
                    LOG.Debug($"sleep {szTrCode} {_query.GetTRCountLimit(szTrCode)}, {_query.GetTRCountRequest(szTrCode)}");
                    Thread.Sleep(1000);
                }
            }
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            _query.SetFieldData(block.Name, "gubun", 0, _inBlock.gubun);
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8436OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8436OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                    etfgubun = query.GetFieldData(block.Name, "etfgubun", i),
                    uplmtprice = long.Parse(query.GetFieldData(block.Name, "uplmtprice", i)),
                    dnlmtprice = long.Parse(query.GetFieldData(block.Name, "dnlmtprice", i)),
                    jnilclose = long.Parse(query.GetFieldData(block.Name, "jnilclose", i)),
                    memedan = query.GetFieldData(block.Name, "memedan", i),
                    recprice = long.Parse(query.GetFieldData(block.Name, "recprice", i)),
                    gubun = query.GetFieldData(block.Name, "gubun", i),
                    bu12gubun = query.GetFieldData(block.Name, "bu12gubun", i),
                    spac_gubun = query.GetFieldData(block.Name, "spac_gubun", i),
                    filler = query.GetFieldData(block.Name, "filler", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeStocks.Add(result.shcode, new CodeStock()
                {
                    Name = result.hname,
                    Code = result.shcode,
                    ExpandedCode = result.expcode,
                    EtfGubun = result.etfgubun,
                    SpacGubun = result.spac_gubun,
                    MarketGubun = result.gubun,
                    Bu12Gubun = result.bu12gubun,
                });
            }
        }

    }
}