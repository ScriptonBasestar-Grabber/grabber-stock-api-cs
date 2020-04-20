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
    public class QueryT8426 : QueryCodeBase
    {
        //private _t8426InBlock _inBlock;
        public QueryT8426() : base("t8426")
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
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8426OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8426OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    shcode = query.GetFieldData(block.Name, "shcode", i),
                    expcode = query.GetFieldData(block.Name, "expcode", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);
                Constants.CodeFutures.Add(result.shcode, new CodeFutures()
                {
                    UnderlyingAssetsCategory = "COMMODITY",
                    UnderlyingAssetsCode = "",
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