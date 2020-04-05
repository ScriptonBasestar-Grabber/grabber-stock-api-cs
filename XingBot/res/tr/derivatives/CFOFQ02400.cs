namespace XingBot.res
{
    // 선물옵션 계좌 미결제 약정현황(평균가) ( SERVICE=CFOFQ02400,HEADTYPE=B,CREATOR=김정현,CREDATE=2012/03/16 14:07:10 )
    internal struct _CFOFQ02400InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string RegMktCode; // [RegMktCode,    2] 등록시장코드                    StartPos 33, Length 2
        public string BuyDt; // [BuyDt,    8] 매수일자                        StartPos 35, Length 8
    }

    internal struct _CFOFQ02400OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string RegMktCode; // [RegMktCode,    2] 등록시장코드                    StartPos 33, Length 2
        public string BuyDt; // [BuyDt,    8] 매수일자                        StartPos 35, Length 8
    }

    internal struct _CFOFQ02400OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsCtrctQty; // [FutsCtrctQty  ,   16] 선물약정수량                    StartPos 45, Length 16
        public long OptCtrctQty; // [OptCtrctQty  ,   16] 옵션약정수량                    StartPos 61, Length 16
        public long CtrctQty; // [CtrctQty  ,   16] 약정수량                        StartPos 77, Length 16
        public long FutsCtrctAmt; // [FutsCtrctAmt  ,   16] 선물약정금액                    StartPos 93, Length 16
        public long FutsBuyctrAmt; // [FutsBuyctrAmt  ,   16] 선물매수약정금액                StartPos 109, Length 16
        public long FutsSlctrAmt; // [FutsSlctrAmt  ,   16] 선물매도약정금액                StartPos 125, Length 16
        public long CalloptCtrctAmt; // [CalloptCtrctAmt  ,   16] 콜옵션약정금액                  StartPos 141, Length 16
        public long CallBuyAmt; // [CallBuyAmt  ,   16] 콜매수금액                      StartPos 157, Length 16
        public long CallSellAmt; // [CallSellAmt  ,   16] 콜매도금액                      StartPos 173, Length 16
        public long PutoptCtrctAmt; // [PutoptCtrctAmt  ,   16] 풋옵션약정금액                  StartPos 189, Length 16
        public long PutBuyAmt; // [PutBuyAmt  ,   16] 풋매수금액                      StartPos 205, Length 16
        public long PutSellAmt; // [PutSellAmt  ,   16] 풋매도금액                      StartPos 221, Length 16
        public long AllCtrctAmt; // [AllCtrctAmt  ,   16] 전체약정금액                    StartPos 237, Length 16
        public long BuyctrAsmAmt; // [BuyctrAsmAmt  ,   16] 매수약정누계금액                StartPos 253, Length 16
        public long SlctrAsmAmt; // [SlctrAsmAmt  ,   16] 매도약정누계금액                StartPos 269, Length 16
        public long FutsPnlSum; // [FutsPnlSum  ,   16] 선물손익합계                    StartPos 285, Length 16
        public long OptPnlSum; // [OptPnlSum  ,   16] 옵션손익합계                    StartPos 301, Length 16
        public long AllPnlSum; // [AllPnlSum  ,   16] 전체손익합계                    StartPos 317, Length 16
    }

    internal struct _CFOFQ02400OutBlock3
    {
        public string FnoClssCode; // [FnoClssCode,    1] 선물옵션품목구분                StartPos 0, Length 1
        public long FutsSellQty; // [FutsSellQty  ,   16] 선물매도수량                    StartPos 1, Length 16
        public long FutsSellPnl; // [FutsSellPnl  ,   16] 선물매도손익                    StartPos 17, Length 16
        public long FutsBuyQty; // [FutsBuyQty  ,   16] 선물매수수량                    StartPos 33, Length 16
        public long FutsBuyPnl; // [FutsBuyPnl  ,   16] 선물매수손익                    StartPos 49, Length 16
        public long CallSellQty; // [CallSellQty  ,   16] 콜매도수량                      StartPos 65, Length 16
        public long CallSellPnl; // [CallSellPnl  ,   16] 콜매도손익                      StartPos 81, Length 16
        public long CallBuyQty; // [CallBuyQty  ,   16] 콜매수수량                      StartPos 97, Length 16
        public long CallBuyPnl; // [CallBuyPnl  ,   16] 콜매수손익                      StartPos 113, Length 16
        public long PutSellQty; // [PutSellQty  ,   16] 풋매도수량                      StartPos 129, Length 16
        public long PutSellPnl; // [PutSellPnl  ,   16] 풋매도손익                      StartPos 145, Length 16
        public long PutBuyQty; // [PutBuyQty  ,   16] 풋매수수량                      StartPos 161, Length 16
        public long PutBuyPnl; // [PutBuyPnl  ,   16] 풋매수손익                      StartPos 177, Length 16
    }

    internal struct _CFOFQ02400OutBlock4
    {
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 0, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 52, Length 1
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 53, Length 10
        public long BalQty; // [BalQty  ,   16] 잔고수량                        StartPos 63, Length 16
        public double FnoAvrPrc; // [FnoAvrPrc, 19.8] 평균가                          StartPos 79, Length 19
        public long BgnAmt; // [BgnAmt  ,   16] 당초금액                        StartPos 98, Length 16
        public long ThdayLqdtQty; // [ThdayLqdtQty  ,   16] 당일청산수량                    StartPos 114, Length 16
        public double Curprc; // [Curprc, 13.2] 현재가                          StartPos 130, Length 13
        public long EvalAmt; // [EvalAmt  ,   16] 평가금액                        StartPos 143, Length 16
        public long EvalPnlAmt; // [EvalPnlAmt  ,   16] 평가손익금액                    StartPos 159, Length 16
        public double EvalErnrat; // [EvalErnrat, 12.6] 평가수익률                      StartPos 175, Length 12
    }
}