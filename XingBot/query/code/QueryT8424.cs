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
    public class QueryT8424 : QueryCodeBase
    {
        private _t8424InBlock _inBlock;

        public QueryT8424() : base("t8424")
        {
        }

        public void Start(_t8424InBlock inBlock)
        {
            _inBlock = inBlock;
            InBlock();
        }

        protected override void InBlock()
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks[szTrCode + "InBlock"];
            _query.SetFieldData(block.Name, "gubun1", 0, _inBlock.gubun1);
            _query.Request(false);
        }

        protected override void OutBlock(ResModel resModel, IXAQuery query, CsvHelper.CsvWriter writer)
        {
            var szTrCode = resModel.Name;
            var block = resModel.Blocks[szTrCode + "OutBlock"];
            writer.WriteHeader<_t8424OutBlock>();
            for (var i = 0; i < query.GetBlockCount(block.Name); i++)
            {
                var result = new _t8424OutBlock()
                {
                    hname = query.GetFieldData(block.Name, "hname", i),
                    upcode = query.GetFieldData(block.Name, "upcode", i),
                };
                writer.NextRecord();
                writer.WriteRecord(result);

                string category;
                switch (_inBlock.gubun1)
                {
                    case "1":
                        category = "KOSPI";
                        break;
                    case "2":
                        category = "KOSDAQ";
                        break;
                    case "3":
                        category = "KRX";
                        break;
                    case "4":
                        category = "ETC";
                        break;
                    default:
                        category = "ALL";
                        //TODO error
                        break;
                }
                Constants.CodeSectors.Add(result.upcode, new CodeSector()
                {
                    Category = category, 
                    Name = result.hname,
                    Code = result.upcode,
                });
            }
        }

    }
}