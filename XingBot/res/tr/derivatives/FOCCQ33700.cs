namespace XingBot.res
{
    // 선물옵션 기간별 계좌 수익률 현황 ( SERVICE=FOCCQ33700,HEADTYPE=B,CREATOR=이석희,CREDATE=2013/01/08 10:45:28 )
    public struct _FOCCQ33700InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string BaseAmtTp; // [BaseAmtTp,    1] 기준금액구분                    StartPos 50, Length 1
        public string QryTermTp; // [QryTermTp,    1] 조회기간구분                    StartPos 51, Length 1
        public string PnlCalcTpCode; // [PnlCalcTpCode,    1] 손익산출구분코드                StartPos 52, Length 1
    }

    public struct _FOCCQ33700OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 49, Length 1
        public string BaseAmtTp; // [BaseAmtTp,    1] 기준금액구분                    StartPos 50, Length 1
        public string QryTermTp; // [QryTermTp,    1] 조회기간구분                    StartPos 51, Length 1
        public string PnlCalcTpCode; // [PnlCalcTpCode,    1] 손익산출구분코드                StartPos 52, Length 1
    }

    public struct _FOCCQ33700OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long InAmt; // [InAmt  ,   16] 입금액                          StartPos 45, Length 16
        public long OutAmt; // [OutAmt  ,   16] 출금액                          StartPos 61, Length 16
        public long FnoCtrctAmt; // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 77, Length 16
        public long InvstPramtAvrbalAmt; // [InvstPramtAvrbalAmt  ,   16] 투자원금평잔금액                StartPos 93, Length 16
        public long FutsAdjstDfamt; // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 109, Length 16
        public long OptBsnPnlAmt; // [OptBsnPnlAmt  ,   16] 옵션매매손익금액                StartPos 125, Length 16
        public long OptEvalPnlAmt; // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 141, Length 16
        public long InvstPlAmt; // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 157, Length 16
        public decimal ErnRat; // [ErnRat, 12.6] 수익률                          StartPos 173, Length 12
    }

    public struct _FOCCQ33700OutBlock3
    {
        public string TrdDt; // [TrdDt,    8] 거래일                          StartPos 0, Length 8
        public long FdDpsastAmt; // [FdDpsastAmt  ,   16] 기초예탁자산금액                StartPos 8, Length 16
        public long EotDpsastAmt; // [EotDpsastAmt  ,   16] 기말예탁자산금액                StartPos 24, Length 16
        public long InAmt; // [InAmt  ,   16] 입금액                          StartPos 40, Length 16
        public long OutAmt; // [OutAmt  ,   16] 출금액                          StartPos 56, Length 16
        public long InvstAvrbalPramt; // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 72, Length 16
        public long InvstPlAmt; // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 88, Length 16
        public decimal Ernrat; // [Ernrat, 12.6] 수익률                          StartPos 104, Length 12
        public long FnoCtrctAmt; // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 116, Length 16
        public decimal Trnrat; // [Trnrat, 12.6] 회전율                          StartPos 132, Length 12
        public long FutsAdjstDfamt; // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 144, Length 16
        public long OptBsnPnlAmt; // [OptBsnPnlAmt  ,   16] 옵션매매손익금액                StartPos 160, Length 16
        public long OptEvalPnlAmt; // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 176, Length 16
    }
}