namespace XingBot.res
{
    // EUREX 야간옵션 야간장잔고 및 평가현황 조회 ( SERVICE=CEXAQ31100,HEADTYPE=B,CREATOR=이시종,CREDATE=2012/12/22 14:39:24 )
    public struct _CEXAQ31100InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string IsuCode{ get; set; } // [IsuCode,   12] 종목코드                        StartPos 33, Length 12
        public string BalEvalTp{ get; set; } // [BalEvalTp,    1] 잔고평가구분                    StartPos 45, Length 1
        public string FutsPrcEvalTp{ get; set; } // [FutsPrcEvalTp,    1] 선물가격평가구분                StartPos 46, Length 1
    }

    public struct _CEXAQ31100OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string IsuCode{ get; set; } // [IsuCode,   12] 종목코드                        StartPos 33, Length 12
        public string BalEvalTp{ get; set; } // [BalEvalTp,    1] 잔고평가구분                    StartPos 45, Length 1
        public string FutsPrcEvalTp{ get; set; } // [FutsPrcEvalTp,    1] 선물가격평가구분                StartPos 46, Length 1
    }

    public struct _CEXAQ31100OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 25, Length 40
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 65, Length 16
        public long AdjstDfamt{ get; set; } // [AdjstDfamt  ,   16] 정산차금                        StartPos 81, Length 16
        public long TotEvalAmt{ get; set; } // [TotEvalAmt  ,   16] 총평가금액                      StartPos 97, Length 16
        public long TotPnlAmt{ get; set; } // [TotPnlAmt  ,   16] 총손익금액                      StartPos 113, Length 16
    }

    public struct _CEXAQ31100OutBlock3
    {
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 0, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 52, Length 1
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 53, Length 10
        public long UnsttQty{ get; set; } // [UnsttQty  ,   16] 미결제수량                      StartPos 63, Length 16
        public long LqdtAbleQty{ get; set; } // [LqdtAbleQty  ,   16] 청산가능수량                    StartPos 79, Length 16
        public decimal FnoAvrPrc{ get; set; } // [FnoAvrPrc, 19.8] 평균가                          StartPos 95, Length 19
        public decimal BasePrc{ get; set; } // [BasePrc,30.10] 기준가                          StartPos 114, Length 30
        public decimal NowPrc{ get; set; } // [NowPrc, 13.2] 현재가                          StartPos 144, Length 13
        public decimal CmpPrc{ get; set; } // [CmpPrc, 13.2] 대비가                          StartPos 157, Length 13
        public long EvalAmt{ get; set; } // [EvalAmt  ,   16] 평가금액                        StartPos 170, Length 16
        public long EvalPnl{ get; set; } // [EvalPnl  ,   16] 평가손익                        StartPos 186, Length 16
        public decimal PnlRat{ get; set; } // [PnlRat, 12.6] 손익률                          StartPos 202, Length 12
        public long UnsttAmt{ get; set; } // [UnsttAmt  ,   16] 미결제금액                      StartPos 214, Length 16
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 230, Length 16
    }
}