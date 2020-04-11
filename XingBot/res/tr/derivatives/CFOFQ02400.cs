namespace XingBot.res
{
    // 선물옵션 계좌 미결제 약정현황(평균가) ( SERVICE=CFOFQ02400,HEADTYPE=B,CREATOR=김정현,CREDATE=2012/03/16 14:07:10 )
    public class _CFOFQ02400InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string RegMktCode{ get; set; } // [RegMktCode,    2] 등록시장코드                    StartPos 33, Length 2
        public string BuyDt{ get; set; } // [BuyDt,    8] 매수일자                        StartPos 35, Length 8
    }

    public class _CFOFQ02400OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string RegMktCode{ get; set; } // [RegMktCode,    2] 등록시장코드                    StartPos 33, Length 2
        public string BuyDt{ get; set; } // [BuyDt,    8] 매수일자                        StartPos 35, Length 8
    }

    public class _CFOFQ02400OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsCtrctQty{ get; set; } // [FutsCtrctQty  ,   16] 선물약정수량                    StartPos 45, Length 16
        public long OptCtrctQty{ get; set; } // [OptCtrctQty  ,   16] 옵션약정수량                    StartPos 61, Length 16
        public long CtrctQty{ get; set; } // [CtrctQty  ,   16] 약정수량                        StartPos 77, Length 16
        public long FutsCtrctAmt{ get; set; } // [FutsCtrctAmt  ,   16] 선물약정금액                    StartPos 93, Length 16
        public long FutsBuyctrAmt{ get; set; } // [FutsBuyctrAmt  ,   16] 선물매수약정금액                StartPos 109, Length 16
        public long FutsSlctrAmt{ get; set; } // [FutsSlctrAmt  ,   16] 선물매도약정금액                StartPos 125, Length 16
        public long CalloptCtrctAmt{ get; set; } // [CalloptCtrctAmt  ,   16] 콜옵션약정금액                  StartPos 141, Length 16
        public long CallBuyAmt{ get; set; } // [CallBuyAmt  ,   16] 콜매수금액                      StartPos 157, Length 16
        public long CallSellAmt{ get; set; } // [CallSellAmt  ,   16] 콜매도금액                      StartPos 173, Length 16
        public long PutoptCtrctAmt{ get; set; } // [PutoptCtrctAmt  ,   16] 풋옵션약정금액                  StartPos 189, Length 16
        public long PutBuyAmt{ get; set; } // [PutBuyAmt  ,   16] 풋매수금액                      StartPos 205, Length 16
        public long PutSellAmt{ get; set; } // [PutSellAmt  ,   16] 풋매도금액                      StartPos 221, Length 16
        public long AllCtrctAmt{ get; set; } // [AllCtrctAmt  ,   16] 전체약정금액                    StartPos 237, Length 16
        public long BuyctrAsmAmt{ get; set; } // [BuyctrAsmAmt  ,   16] 매수약정누계금액                StartPos 253, Length 16
        public long SlctrAsmAmt{ get; set; } // [SlctrAsmAmt  ,   16] 매도약정누계금액                StartPos 269, Length 16
        public long FutsPnlSum{ get; set; } // [FutsPnlSum  ,   16] 선물손익합계                    StartPos 285, Length 16
        public long OptPnlSum{ get; set; } // [OptPnlSum  ,   16] 옵션손익합계                    StartPos 301, Length 16
        public long AllPnlSum{ get; set; } // [AllPnlSum  ,   16] 전체손익합계                    StartPos 317, Length 16
    }

    public class _CFOFQ02400OutBlock3
    {
        public string FnoClssCode{ get; set; } // [FnoClssCode,    1] 선물옵션품목구분                StartPos 0, Length 1
        public long FutsSellQty{ get; set; } // [FutsSellQty  ,   16] 선물매도수량                    StartPos 1, Length 16
        public long FutsSellPnl{ get; set; } // [FutsSellPnl  ,   16] 선물매도손익                    StartPos 17, Length 16
        public long FutsBuyQty{ get; set; } // [FutsBuyQty  ,   16] 선물매수수량                    StartPos 33, Length 16
        public long FutsBuyPnl{ get; set; } // [FutsBuyPnl  ,   16] 선물매수손익                    StartPos 49, Length 16
        public long CallSellQty{ get; set; } // [CallSellQty  ,   16] 콜매도수량                      StartPos 65, Length 16
        public long CallSellPnl{ get; set; } // [CallSellPnl  ,   16] 콜매도손익                      StartPos 81, Length 16
        public long CallBuyQty{ get; set; } // [CallBuyQty  ,   16] 콜매수수량                      StartPos 97, Length 16
        public long CallBuyPnl{ get; set; } // [CallBuyPnl  ,   16] 콜매수손익                      StartPos 113, Length 16
        public long PutSellQty{ get; set; } // [PutSellQty  ,   16] 풋매도수량                      StartPos 129, Length 16
        public long PutSellPnl{ get; set; } // [PutSellPnl  ,   16] 풋매도손익                      StartPos 145, Length 16
        public long PutBuyQty{ get; set; } // [PutBuyQty  ,   16] 풋매수수량                      StartPos 161, Length 16
        public long PutBuyPnl{ get; set; } // [PutBuyPnl  ,   16] 풋매수손익                      StartPos 177, Length 16
    }

    public class _CFOFQ02400OutBlock4
    {
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 0, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 52, Length 1
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 53, Length 10
        public long BalQty{ get; set; } // [BalQty  ,   16] 잔고수량                        StartPos 63, Length 16
        public decimal FnoAvrPrc{ get; set; } // [FnoAvrPrc, 19.8] 평균가                          StartPos 79, Length 19
        public long BgnAmt{ get; set; } // [BgnAmt  ,   16] 당초금액                        StartPos 98, Length 16
        public long ThdayLqdtQty{ get; set; } // [ThdayLqdtQty  ,   16] 당일청산수량                    StartPos 114, Length 16
        public decimal Curprc{ get; set; } // [Curprc, 13.2] 현재가                          StartPos 130, Length 13
        public long EvalAmt{ get; set; } // [EvalAmt  ,   16] 평가금액                        StartPos 143, Length 16
        public long EvalPnlAmt{ get; set; } // [EvalPnlAmt  ,   16] 평가손익금액                    StartPos 159, Length 16
        public decimal EvalErnrat{ get; set; } // [EvalErnrat, 12.6] 평가수익률                      StartPos 175, Length 12
    }
}