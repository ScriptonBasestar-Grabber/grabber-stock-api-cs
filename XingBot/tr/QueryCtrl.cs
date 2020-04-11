﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using DataLib.util;
using XA_DATASETLib;
using XingBot.real;
using XingBot.tr;

namespace XingBot.tr
{
    public class QueryCtrl
    {
        private readonly Dictionary<string, QueryEvents> _queryDict = new Dictionary<string, QueryEvents>();

        public void QueryInit()
        {
            string code;
            // TODO 순차적 이벤트 완료되는거 확인하고 다음걸로 하려면 콜백지옥?
            // ========================= t9905 기초자산리스트조회 =========================
            code = "t9905";
            Constants.queryInitNext = false;
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) =>
                {
                    Tr_t9905.OutBlock_t9905(model, query, writer);
                    Constants.queryInitNext = true;
                }));
            this._queryDict[code].InBlock(Tr_t9905.InBlock_t9905, new StringDict()
            {
                ["dummy"] = ""
            });
            // ========================= t8424 업종코드 =========================
            code = "t8424";
            Constants.queryInitNext = false;
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) =>
                {
                    Tr_t8424.OutBlock_t8424(model, query, writer);
                    Constants.queryInitNext = true;
                }));
            this._queryDict[code].InBlock(Tr_t8424.InBlock_t8424, new StringDict()
            {
                ["gubun1"] = "0"
            });
            // ========================= t8425 테마전체조회 =========================
            code = "t8425";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t8425.OutBlock_t8425(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t8425.InBlock_t8425, new StringDict()
            {
                ["dummy"] = ""
            });
            // ========================= t8435 파생종목마스터조회 API용 =========================
            code = "t8435";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t8435.OutBlock_t8435(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            {
                ["gubun"] = "MF"
            });
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t8435.OutBlock_t8435(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            {
                ["gubun"] = "MO"
            });
            // Thread.Sleep(1000);
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            // {
            //     ["gubun"] = "WK"
            // });
            // ========================= t8436 주식종목조회 API용 =========================
            code = "t8436";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t8436.OutBlock_t8436(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t8436.InBlock_t8436, new StringDict()
            {
                ["gubun"] = "0"
            });
            // // ========================= t9907 만기월조회 =========================
            // code = "t9907";
            // this._queryDict[code] = new QueryEvents(code, ((model, query, writer) =>
            // {
            //     Tr_t9907.OutBlock_t9907(model, query, writer);
            // }));
            // this._queryDict[code].InBlock(Tr_t9907.InBlock_t9907, new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // ========================= t9942 ELW마스터조회 API용 =========================
            code = "t9942";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t9942.OutBlock_t9942(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t9942.InBlock_t9942, new StringDict()
            {
                ["dummy"] = ""
            });
            // ========================= t9943 지수선물마스터조회 API용 =========================
            code = "t9943";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t9943.OutBlock_t9943(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t9943.InBlock_t9943, new StringDict()
            {
                ["gubun"] = "V"
            });
            // Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t9943.OutBlock_t9943(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t9943.InBlock_t9943, new StringDict()
            {
                ["gubun"] = "S"
            });
            // ========================= t9944 지수옵션마스터조회 API용 =========================
            code = "t9944";
            this._queryDict[code] = new QueryEvents(code,
                ((model, query, writer) => { Tr_t9944.OutBlock_t9944(model, query, writer); }));
            this._queryDict[code].InBlock(Tr_t9944.InBlock_t9944, new StringDict()
            {
                ["dummy"] = ""
            });
            Console.WriteLine("QueryInit 생성자완료");
        }
    }
}