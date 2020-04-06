using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using XA_DATASETLib;
using XingBot.real.res;
using XingBot.tr;

namespace XingBot.real.tr
{
    public class QueryInit : _IXAQueryEvents
    {
        private readonly Dictionary<string, QueryEvents> _queryDict = new Dictionary<string, QueryEvents>();

        public QueryInit()
        {
            string code;

            // ========================= t1981 =========================
            code = "t1981";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "mkt_gb", 0, "1");
            });
            Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "mkt_gb", 0, "2");
            });
            Thread.Sleep(1000);
            // ========================= t8424 업종코드 =========================
            code = "t8424";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun1", 0, "1");
            });
            Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun1", 0, "2");
            });
            Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun1", 0, "3");
            });
            Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun1", 0, "4");
            });
            Thread.Sleep(1000);
            // ========================= t8425 테마전체조회 =========================
            code = "t8425";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
            });
            Thread.Sleep(1000);
            // ========================= t8432 지수선물마스터조회 API용 =========================
            code = "t8432";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
            });
            Thread.Sleep(1000);
            // ========================= t8433 지수옵션마스터조회 API용 =========================
            code = "t8433";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
            });
            Thread.Sleep(1000);
            // ========================= t8435 파생종목마스터조회 API용 =========================
            code = "t8435";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun", 0, "MF");
            });
            Thread.Sleep(1000);
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun", 0, "MO");
            });
            Thread.Sleep(1000);
            // ========================= t8436 주식종목조회 API용 =========================
            code = "t8436";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "gubun", 0, "0");
            });
            Thread.Sleep(1000);
            // ========================= t9907 만기월조회 =========================
            code = "t9907";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
            });
            Thread.Sleep(1000);
            // ========================= t9942 ELW마스터조회 API용 =========================
            code = "t9942";
            this._queryDict[code] = new QueryEvents(code);
            this._queryDict[code].InBlock((szTrCode, inBlock, ixa) =>
            {
                ixa.SetFieldData(szTrCode + "InBlock", "dummy", 0, "");
            });
            Thread.Sleep(1000);
            Console.WriteLine("QueryCtrl 생성자완료");
        }

        // Query
        void _IXAQueryEvents.ReceiveData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveData " + szTrCode);
            // ========================= t1981 =========================
            if (szTrCode == "t1981")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t1981OutBlock1()
                        {
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            price = query.GetFieldData(szTrCode + "OutBlock", "price", i),
                            sign = query.GetFieldData(szTrCode + "OutBlock", "sign", i),
                            change = query.GetFieldData(szTrCode + "OutBlock", "change", i),
                            rate = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "rate", i)),
                            volume = query.GetFieldData(szTrCode + "OutBlock", "volume", i),
                            value = query.GetFieldData(szTrCode + "OutBlock", "value", i),
                            mkt_gb = query.GetFieldData(szTrCode + "OutBlock", "mkt_gb", i),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t8425 =========================
            else if (szTrCode == "t8424")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t8424OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            upcode = query.GetFieldData(szTrCode + "OutBlock", "upcode", i)
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t8432 =========================
            else if (szTrCode == "t8432")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t8432OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                            uplmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                            dnlmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                            jnilclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                            jnilhigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                            jnillow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                            recprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t8433 =========================
            else if (szTrCode == "t8433")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t8433OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                            hprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "hprice", i)),
                            lprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "lprice", i)),
                            jnilclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                            jnilhigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                            jnillow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                            recprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t8435 =========================
            else if (szTrCode == "t8435")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t8435OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                            uplmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                            dnlmtprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                            jnilclose = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                            jnilhigh = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i)),
                            jnillow = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnillow", i)),
                            recprice = decimal.Parse(query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t8436 =========================
            else if (szTrCode == "t8436")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t8436OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                            etfgubun = query.GetFieldData(szTrCode + "OutBlock", "etfgubun", i),
                            uplmtprice = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i)),
                            dnlmtprice = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i)),
                            jnilclose = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i)),
                            memedan = query.GetFieldData(szTrCode + "OutBlock", "memedan", i),
                            recprice = long.Parse(query.GetFieldData(szTrCode + "OutBlock", "recprice", i)),
                            gubun = query.GetFieldData(szTrCode + "OutBlock", "gubun", i),
                            bu12gubun = query.GetFieldData(szTrCode + "OutBlock", "bu12gubun", i),
                            spac_gubun = query.GetFieldData(szTrCode + "OutBlock", "spac_gubun", i),
                            filler = query.GetFieldData(szTrCode + "OutBlock", "filler", i),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t9907 =========================
            else if (szTrCode == "t9907")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t9907OutBlock1()
                        {
                            lastym = query.GetFieldData(szTrCode + "OutBlock", "lastym", i),
                            lastnm = query.GetFieldData(szTrCode + "OutBlock", "lastnm", i),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
            // ========================= t9942 =========================
            else if (szTrCode == "t9942")
            {
                _queryDict[szTrCode].OutBlock(szTrCode, (code, block, query) =>
                {
                    for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
                    {
                        var result = new _t9942OutBlock()
                        {
                            hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i),
                            shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i),
                            expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i),
                        };
                    }
                }, (code, block, query) =>
                {

                });
            }
        }

        void _IXAQueryEvents.ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveMessage ");
            // ptForm.lblMessage.Text = nMessageCode;
            Console.WriteLine(nMessageCode + "  " + szMessage);
        }

        void _IXAQueryEvents.ReceiveChartRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveChartRealData " + szTrCode);
            // var result = _queryDict[szTrCode].GetFieldChartRealData(szTrCode + "OutBlock", "shcode");
            // Console.WriteLine(result);
        }

        void _IXAQueryEvents.ReceiveSearchRealData(string szTrCode)
        {
            Console.WriteLine("_IXAQueryEvents.ReceiveSearchRealData " + szTrCode);
        }
    }
}