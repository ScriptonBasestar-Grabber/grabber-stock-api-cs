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
    public class QueryT9905 : QueryCodeBase
    {
        //private _t9905InBlock _inBlock;
        public QueryT9905() : base("t9905")
        {
        }

        public void Start()
        {
            InBlock();
        }

        protected override void InBlock()
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            _query.SetFieldData(block.Name, "dummy", 0, "");
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;

            var block1 = resModel.Blocks[szTrCode + "OutBlock1"];
            writer.WriteHeader<_t9905OutBlock1>();
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock1"); i++)
            {
                var result = new _t9905OutBlock1()
                {
                    shcode = query.GetFieldData(block1.Name, "shcode", i),
                    expcode = query.GetFieldData(block1.Name, "expcode", i),
                    hname = query.GetFieldData(block1.Name, "hname", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeElwBases.Add(result.shcode, new CodeElwBase()
                {
                    Name = result.hname,
                    Code = result.shcode,
                    ExpandedCode = result.expcode,
                });
            }
        }
    }
}