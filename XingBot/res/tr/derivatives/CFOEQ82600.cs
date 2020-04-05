namespace XingBot.res
{
    // 선물옵션 일별 계좌손익내역 ( SERVICE=CFOEQ82600,HEADTYPE=B,CREATOR=황규석,CREDATE=2013/01/06 17:48:51 ) 
    internal struct _CFOEQ82600InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 50, Length 1
        public string FnoBalEvalTpCode; // [FnoBalEvalTpCode,    1] 선물옵션잔고평가구분코드        StartPos 51, Length 1
    }

    internal struct _CFOEQ82600OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 50, Length 1
        public string FnoBalEvalTpCode; // [FnoBalEvalTpCode,    1] 선물옵션잔고평가구분코드        StartPos 51, Length 1
    }

    internal struct _CFOEQ82600OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long FutsAdjstDfamt; // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 5, Length 16
        public long OptBnsplAmt; // [OptBnsplAmt  ,   16] 옵션매매손익금액                StartPos 21, Length 16
        public long FnoCmsnAmt; // [FnoCmsnAmt  ,   16] 선물옵션수수료                  StartPos 37, Length 16
        public long PnlSumAmt; // [PnlSumAmt  ,   16] 손익합계금액                    StartPos 53, Length 16
        public long MnyinSumAmt; // [MnyinSumAmt  ,   16] 입금합계금액                    StartPos 69, Length 16
        public long MnyoutSumAmt; // [MnyoutSumAmt  ,   16] 출금합계금액                    StartPos 85, Length 16
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 101, Length 40
    }

    internal struct _CFOEQ82600OutBlock3
    {
        public string QryDt; // [QryDt,    8] 조회일                          StartPos 0, Length 8
        public long DpstgTotamt; // [DpstgTotamt  ,   16] 예탁총액                        StartPos 8, Length 16
        public long DpstgMny; // [DpstgMny  ,   16] 예탁현금                        StartPos 24, Length 16
        public long FnoMgn; // [FnoMgn  ,   16] 선물옵션증거금액                StartPos 40, Length 16
        public long FutsPnlAmt; // [FutsPnlAmt  ,   16] 선물손익금액                    StartPos 56, Length 16
        public long OptBsnPnlAmt; // [OptBsnPnlAmt  ,   16] 옵션매매손익금액                StartPos 72, Length 16
        public long OptEvalPnlAmt; // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 88, Length 16
        public long CmsnAmt; // [CmsnAmt  ,   16] 수수료                          StartPos 104, Length 16
        public long SumAmt1; // [SumAmt1  ,   16] 합계금액1                       StartPos 120, Length 16
        public long SumAmt2; // [SumAmt2  ,   16] 합계금액                        StartPos 136, Length 16
        public long PnlSumAmt; // [PnlSumAmt  ,   16] 손익합계금액                    StartPos 152, Length 16
        public long FutsBuyAmt; // [FutsBuyAmt  ,   16] 선물매수금액                    StartPos 168, Length 16
        public long FutsSellAmt; // [FutsSellAmt  ,   16] 선물매도금액                    StartPos 184, Length 16
        public long OptBuyAmt; // [OptBuyAmt  ,   16] 옵션매수금액                    StartPos 200, Length 16
        public long OptSellAmt; // [OptSellAmt  ,   16] 옵션매도금액                    StartPos 216, Length 16
        public long InAmt; // [InAmt  ,   16] 입금액                          StartPos 232, Length 16
        public long OutAmt; // [OutAmt  ,   16] 출금액                          StartPos 248, Length 16
        public long EvalAmt; // [EvalAmt  ,   16] 평가금액                        StartPos 264, Length 16
        public long AddupEvalAmt; // [AddupEvalAmt  ,   16] 합산평가금액                    StartPos 280, Length 16
        public long Amt2; // [Amt2  ,   16] 금액2                           StartPos 296, Length 16
    }
}