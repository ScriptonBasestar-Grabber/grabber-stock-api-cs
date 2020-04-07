namespace XingBot.res
{
    // 선물옵션 기간별 계좌 수익률 현황 ( SERVICE=FOCCQ33700,HEADTYPE=B,CREATOR=이석희,CREDATE=2013/01/08 10:45:28 )
    public struct _FOCCQ33700InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp{ get; set; } // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string BaseAmtTp{ get; set; } // [BaseAmtTp,    1] 기준금액구분                    StartPos 50, Length 1
        public string QryTermTp{ get; set; } // [QryTermTp,    1] 조회기간구분                    StartPos 51, Length 1
        public string PnlCalcTpCode{ get; set; } // [PnlCalcTpCode,    1] 손익산출구분코드                StartPos 52, Length 1
    }

    public struct _FOCCQ33700OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp{ get; set; } // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string BaseAmtTp{ get; set; } // [BaseAmtTp,    1] 기준금액구분                    StartPos 50, Length 1
        public string QryTermTp{ get; set; } // [QryTermTp,    1] 조회기간구분                    StartPos 51, Length 1
        public string PnlCalcTpCode{ get; set; } // [PnlCalcTpCode,    1] 손익산출구분코드                StartPos 52, Length 1
    }

    public struct _FOCCQ33700OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long InAmt{ get; set; } // [InAmt  ,   16] 입금액                          StartPos 45, Length 16
        public long OutAmt{ get; set; } // [OutAmt  ,   16] 출금액                          StartPos 61, Length 16
        public long FnoCtrctAmt{ get; set; } // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 77, Length 16
        public long InvstPramtAvrbalAmt{ get; set; } // [InvstPramtAvrbalAmt  ,   16] 투자원금평잔금액                StartPos 93, Length 16
        public long FutsAdjstDfamt{ get; set; } // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 109, Length 16
        public long OptBsnPnlAmt{ get; set; } // [OptBsnPnlAmt  ,   16] 옵션매매손익금액                StartPos 125, Length 16
        public long OptEvalPnlAmt{ get; set; } // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 141, Length 16
        public long InvstPlAmt{ get; set; } // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 157, Length 16
        public decimal ErnRat{ get; set; } // [ErnRat, 12.6] 수익률                          StartPos 173, Length 12
    }

    public struct _FOCCQ33700OutBlock3
    {
        public string TrdDt{ get; set; } // [TrdDt,    8] 거래일                          StartPos 0, Length 8
        public long FdDpsastAmt{ get; set; } // [FdDpsastAmt  ,   16] 기초예탁자산금액                StartPos 8, Length 16
        public long EotDpsastAmt{ get; set; } // [EotDpsastAmt  ,   16] 기말예탁자산금액                StartPos 24, Length 16
        public long InAmt{ get; set; } // [InAmt  ,   16] 입금액                          StartPos 40, Length 16
        public long OutAmt{ get; set; } // [OutAmt  ,   16] 출금액                          StartPos 56, Length 16
        public long InvstAvrbalPramt{ get; set; } // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 72, Length 16
        public long InvstPlAmt{ get; set; } // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 88, Length 16
        public decimal Ernrat{ get; set; } // [Ernrat, 12.6] 수익률                          StartPos 104, Length 12
        public long FnoCtrctAmt{ get; set; } // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 116, Length 16
        public decimal Trnrat{ get; set; } // [Trnrat, 12.6] 회전율                          StartPos 132, Length 12
        public long FutsAdjstDfamt{ get; set; } // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 144, Length 16
        public long OptBsnPnlAmt{ get; set; } // [OptBsnPnlAmt  ,   16] 옵션매매손익금액                StartPos 160, Length 16
        public long OptEvalPnlAmt{ get; set; } // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 176, Length 16
    }
}