using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using DataLib.util;
using XA_DATASETLib;
using XingBot.tr;

namespace XingBot.tr
{
    public class QueryInit
    {
        private readonly Dictionary<string, QueryEvents> _queryDict = new Dictionary<string, QueryEvents>();

        public QueryInit()
        {
            string code;
            // ========================= t1981 =========================
            code = "t1981";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock(Tr_t1981.InBlock_t1981, new StringDict()
            {
                ["mkt_gb"] = "0"
            });
            // Thread.Sleep(1000);
            // // ========================= t8424 업종코드 =========================
            // code = "t8424";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8424.InBlock_t8424, new StringDict(){
            //     ["gubun1"] = "0"
            // });
            // Thread.Sleep(1000);
            // // ========================= t8425 테마전체조회 =========================
            // code = "t8425";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8425.InBlock_t8425, new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // Thread.Sleep(1000);
            // // ========================= t8432 지수선물마스터조회 API용 =========================
            // code = "t8432";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8432.InBlock_t8432, new StringDict()
            // {
            //     ["gubun"] = "V"
            // });
            // Thread.Sleep(1000);
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8432.InBlock_t8432, new StringDict()
            // {
            //     ["gubun"] = "S"
            // });
            // Thread.Sleep(1000);
            // // ========================= t8433 지수옵션마스터조회 API용 =========================
            // code = "t8433";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8433.InBlock_t8433, new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // Thread.Sleep(1000);
            // // ========================= t8435 파생종목마스터조회 API용 =========================
            // code = "t8435";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            // {
            //     ["gubun"] = "MF"
            // });
            // Thread.Sleep(1000);
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            // {
            //     ["gubun"] = "MO"
            // });
            // Thread.Sleep(1000);
            // // this._queryDict[code] = new QueryEvents(code);
            // // this._queryDict[code].InBlock(Tr_t8435.InBlock_t8435, new StringDict()
            // // {
            // //     ["gubun"] = "WK"
            // // });
            // // Thread.Sleep(1000);
            // // ========================= t8436 주식종목조회 API용 =========================
            // code = "t8436";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t8436.InBlock_t8436, new StringDict()
            // {
            //     ["gubun"] = "0"
            // });
            // Thread.Sleep(1000);
            // // ========================= t9907 만기월조회 =========================
            // code = "t9907";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t9907.InBlock_t9907, new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // Thread.Sleep(1000);
            // // ========================= t9942 ELW마스터조회 API용 =========================
            // code = "t9942";
            // this._queryDict[code] = new QueryEvents(code);
            // this._queryDict[code].InBlock(Tr_t9907.InBlock_t9907, new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // Thread.Sleep(1000);
            Console.WriteLine("QueryInit 생성자완료");
        }

    }
}