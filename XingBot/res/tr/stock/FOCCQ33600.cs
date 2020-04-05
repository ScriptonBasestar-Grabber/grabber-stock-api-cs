namespace XingBot.res.tr
{
    // 주식 계좌 기간별 수익률 상세 ( SERVICE=FOCCQ33600,HEADTYPE=B,CREATOR=유종우,CREDATE=2012/03/15 11:06:33 )
    internal struct _FOCCQ33600InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string TermTp; // [TermTp,    1] 기간구분                        StartPos 49, Length 1
    }

    internal struct _FOCCQ33600OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string TermTp; // [TermTp,    1] 기간구분                        StartPos 49, Length 1
    }

    internal struct _FOCCQ33600OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long BnsctrAmt; // [BnsctrAmt  ,   16] 매매약정금액                    StartPos 45, Length 16
        public long MnyinAmt; // [MnyinAmt  ,   16] 입금금액                        StartPos 61, Length 16
        public long MnyoutAmt; // [MnyoutAmt  ,   16] 출금금액                        StartPos 77, Length 16
        public long InvstAvrbalPramt; // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 93, Length 16
        public long InvstPlAmt; // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 109, Length 16
        public double InvstErnrat; // [InvstErnrat,  9.2] 투자수익률                      StartPos 125, Length 9
    }

    internal struct _FOCCQ33600OutBlock3
    {
        public string BaseDt; // [BaseDt,    8] 기준일                          StartPos 0, Length 8
        public long FdEvalAmt; // [FdEvalAmt  ,   19] 기초평가금액                    StartPos 8, Length 19
        public long EotEvalAmt; // [EotEvalAmt  ,   19] 기말평가금액                    StartPos 27, Length 19
        public long InvstAvrbalPramt; // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 46, Length 16
        public long BnsctrAmt; // [BnsctrAmt  ,   16] 매매약정금액                    StartPos 62, Length 16
        public long MnyinSecinAmt; // [MnyinSecinAmt  ,   16] 입금고액                        StartPos 78, Length 16
        public long MnyoutSecoutAmt; // [MnyoutSecoutAmt  ,   16] 출금고액                        StartPos 94, Length 16
        public long EvalPnlAmt; // [EvalPnlAmt  ,   16] 평가손익금액                    StartPos 110, Length 16
        public double TermErnrat; // [TermErnrat, 11.3] 기간수익률                      StartPos 126, Length 11
        public double Idx; // [Idx, 13.2] 지수                            StartPos 137, Length 13
    }
}