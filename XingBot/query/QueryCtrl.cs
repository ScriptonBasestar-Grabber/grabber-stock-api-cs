using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using DataLib.model;
using DataLib.util;
using log4net;
using XA_DATASETLib;
using XingBot.query;
using XingBot.real;
using XingBot.res;
using XingBot.tr;

namespace XingBot.tr
{
    public class QueryCtrl
    {
        protected static readonly ILog LOG = LogManager.GetLogger("QueryCtrl");

        public void QueryInit()
        {
            LOG.Info("QueryInit start");
            // TODO 순차적 이벤트 완료되는거 확인하고 다음걸로 하려면 콜백지옥?
            string code;
            // ========================= t8436 주식종목조회 API용 =========================
            LOG.Debug("t8436");
            code = "t8436";
            //Thread thread = new Thread(() => {
            
            //});
            var queryT8436 = new QueryT8436();
            // ========================= t8424 업종코드 =========================
            LOG.Debug("t8424");
            code = "t8424";
            var queryT8424 = new QueryT8424();
            queryT8436.Start(() =>
            {
                queryT8424.Start(new _t8424InBlock()
                {
                    gubun1 = "1"
                }, () =>
                {
                    queryT8424.Start(new _t8424InBlock()
                    {
                        gubun1 = "2"
                    }, () =>
                    {
                        queryT8424.Start(new _t8424InBlock()
                        {
                            gubun1 = "3"
                        }, () =>
                        {
                            queryT8424.Start(new _t8424InBlock()
                            {
                                gubun1 = "4"
                            }, () => { });
                        });
                    });
                });
            });
            Thread.Sleep(1000);
            // ========================= t8425 테마전체조회 =========================
            code = "t8425";
            var queryT8425 = new QueryT8425();
            queryT8425.Start(null);
            Thread.Sleep(1000);
            // ========================= t9905 ELW 기초자산리스트조회 =========================
            code = "t9905";
            var queryT9905 = new QueryT9905();
            queryT9905.Start(null);
            Thread.Sleep(1000);
            // ========================= t9943 지수선물마스터조회 API용 =========================
            code = "t9943";
            var queryT9943 = new QueryT9943();
            queryT9943.Start(new _t9943InBlock()
            {
                gubun = "V"
            }, () =>
            {
                queryT9943.Start(new _t9943InBlock()
                {
                    gubun = "S"
                }, () =>
                {
                    queryT9943.Start(new _t9943InBlock()
                    {
                        gubun = ""
                    }, null);
                });
            });
            Thread.Sleep(1000);
            // ========================= t9944 지수옵션마스터조회 API용 =========================
            code = "t9944";
            var queryT9944 = new QueryT9944();
            queryT9944.Start(null);
            Thread.Sleep(1000);
            // ========================= t8435 파생종목마스터조회 API용 =========================
            code = "t8435";
            var queryT8435 = new QueryT8435();
            queryT8435.Start(new _t8435InBlock()
            {
                gubun = "MF"
            }, () =>
            {
                queryT8435.Start(new _t8435InBlock()
                {
                    gubun = "MO"
                }, () =>
                {
                    queryT8435.Start(new _t8435InBlock()
                    {
                        gubun = "WK"
                    }, null);
                });
            });
            Thread.Sleep(1000);
            // ========================= t8401 주식선물 마스터 조회 =========================
            code = "t8401";
            var queryT8401 = new QueryT8401();
            queryT8401.Start(null);
            Thread.Sleep(1000);
            // ========================= t8426 상품선물 마스터 조회 =========================
            code = "t8426";
            var queryT8426 = new QueryT8426();
            queryT8426.Start(null);
            Thread.Sleep(1000);
            // // ========================= t9907 만기월조회 =========================
            // code = "t9907";
            // this._queryDict[code] = new QueryEvents(code, Tr_t9907.OutBlock_t9907);
            // this._queryDict[code].InBlock(new StringDict()
            // {
            //     ["dummy"] = ""
            // });
            // ========================= t9942 ELW마스터조회 API용 =========================
            code = "t9942";
            var queryT9942 = new QueryT9942();
            queryT9942.Start(null);
            Thread.Sleep(1000);
            Console.WriteLine("QueryInit 생성자완료");
        }

        public void QueryT4201()
        {
            // fullscan 만 가능한게 돼 버렸는데 이걸 외부로
            Tr_t4201 tr4201 = new Tr_t4201();
            tr4201.Start(null);
            LOG.Info("finish all");
        }
        public void QueryT4203()
        {
            Tr_t4203 tr4203 = new Tr_t4203();
            tr4203.Start(null);
            LOG.Info("finish all");
        }
        public void QueryT8414()
        {
            Tr_t8414 tr8414 = new Tr_t8414();
            tr8414.Start(null);
            LOG.Info("finish all");
        }
    }
}