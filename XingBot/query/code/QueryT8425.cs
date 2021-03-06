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
    public class QueryT8425 : QueryCodeBase
    {
        //private _t8425InBlock _inBlock;
        public QueryT8425() : base("t8425")
        {
            LOG.Info("Constructor QueryT8425");
        }

        public void Start(Action action)
        {
            LOG.Debug("t8425 start");
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
                    Thread.Sleep(10000);
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
            writer.WriteHeader<_t8425OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8425OutBlock()
                {
                    tmcode = query.GetFieldData(block.Name, "tmcode", i),
                    tmname = query.GetFieldData(block.Name, "tmname", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeThemes.Add(result.tmcode, new CodeTheme()
                {
                    Code = result.tmcode,
                    Name = result.tmname,
                });
            }
        }

    }
}