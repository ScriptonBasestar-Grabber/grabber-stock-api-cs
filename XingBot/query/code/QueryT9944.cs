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
    public class QueryT9944 : QueryCodeBase
    {
        //private _t9944InBlock _inBlock;

        public QueryT9944() : base("t9944")
        {
            LOG.Info("Constructor QueryT9944");
        }

        public void Start(Action action)
        {
            LOG.Debug("t9944 start");
            _action = action;
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
            _query.SetFieldData(block.Name, "dummy", 0, "");
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t9944OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t9944OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeOptions.Add(result.shcode, new CodeOptions()
                {
                    UnderlyingAssetsCategory = "KOSPI200",
                    UnderlyingAssetsCode = "101",
                    Category = "DEFAULT",
                    Name = result.hname,
                    Code = result.shcode,
                    ExpandedCode = result.expcode,
                    //TODO Listing, Expirationdate
                    ListingDate = "",
                    ExpirationDate = "",
                });
            }
        }

    }
}