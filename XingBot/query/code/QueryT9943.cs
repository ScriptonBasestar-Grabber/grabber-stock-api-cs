﻿using DataLib.model;
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
    public class QueryT9943 : QueryCodeBase
    {
        private _t9943InBlock _inBlock;

        public QueryT9943() : base("t9943")
        {
            LOG.Info("Constructor QueryT9943");
        }

        public void Start(_t9943InBlock inBlock, Action action)
        {
            LOG.Debug("t9943 start");
            _action = action;
            _inBlock = inBlock;
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
                    Thread.Sleep(10000);
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
            writer.WriteHeader<_t9943OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t9943OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                switch (_inBlock.gubun)
                {
                    case "V":
                        Constants.CodeFutures.Add(result.shcode, new CodeFutures()
                        {
                            UnderlyingAssetsCategory = "KOSPI200",
                            UnderlyingAssetsCode = "101",
                            Category = "V",
                            Name = result.hname,
                            Code = result.shcode,
                            ExpandedCode = result.expcode,
                            //TODO Listing, Expirationdate
                            ListingDate = "",
                            ExpirationDate = "",
                        });
                        break;
                    case "S":
                        Constants.CodeFutures.Add(result.shcode, new CodeFutures()
                        {
                            UnderlyingAssetsCategory = "KOSPI200",
                            UnderlyingAssetsCode = "101",
                            Category = "S",
                            Name = result.hname,
                            Code = result.shcode,
                            ExpandedCode = result.expcode,
                            //TODO Listing, Expirationdate
                            ListingDate = "",
                            ExpirationDate = "",
                        });
                        break;
                    default:
                        Constants.CodeFutures.Add(result.shcode, new CodeFutures()
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
                        break;
                }
            }
        }

    }
}