namespace XingBot.res
{
    // 주식 계좌 기간별 수익률 상세 ( SERVICE=FOCCQ33600,HEADTYPE=B,CREATOR=유종우,CREDATE=2012/03/15 11:06:33 )
    public class _FOCCQ33600InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string TermTp{ get; set; } // [TermTp,    1] 기간구분                        StartPos 49, Length 1
    }

    public class _FOCCQ33600OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string TermTp{ get; set; } // [TermTp,    1] 기간구분                        StartPos 49, Length 1
    }

    public class _FOCCQ33600OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long BnsctrAmt{ get; set; } // [BnsctrAmt  ,   16] 매매약정금액                    StartPos 45, Length 16
        public long MnyinAmt{ get; set; } // [MnyinAmt  ,   16] 입금금액                        StartPos 61, Length 16
        public long MnyoutAmt{ get; set; } // [MnyoutAmt  ,   16] 출금금액                        StartPos 77, Length 16
        public long InvstAvrbalPramt{ get; set; } // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 93, Length 16
        public long InvstPlAmt{ get; set; } // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 109, Length 16
        public decimal InvstErnrat{ get; set; } // [InvstErnrat,  9.2] 투자수익률                      StartPos 125, Length 9
    }

    public class _FOCCQ33600OutBlock3
    {
        public string BaseDt{ get; set; } // [BaseDt,    8] 기준일                          StartPos 0, Length 8
        public long FdEvalAmt{ get; set; } // [FdEvalAmt  ,   19] 기초평가금액                    StartPos 8, Length 19
        public long EotEvalAmt{ get; set; } // [EotEvalAmt  ,   19] 기말평가금액                    StartPos 27, Length 19
        public long InvstAvrbalPramt{ get; set; } // [InvstAvrbalPramt  ,   16] 투자원금평잔금액                StartPos 46, Length 16
        public long BnsctrAmt{ get; set; } // [BnsctrAmt  ,   16] 매매약정금액                    StartPos 62, Length 16
        public long MnyinSecinAmt{ get; set; } // [MnyinSecinAmt  ,   16] 입금고액                        StartPos 78, Length 16
        public long MnyoutSecoutAmt{ get; set; } // [MnyoutSecoutAmt  ,   16] 출금고액                        StartPos 94, Length 16
        public long EvalPnlAmt{ get; set; } // [EvalPnlAmt  ,   16] 평가손익금액                    StartPos 110, Length 16
        public decimal TermErnrat{ get; set; } // [TermErnrat, 11.3] 기간수익률                      StartPos 126, Length 11
        public decimal Idx{ get; set; } // [Idx, 13.2] 지수                            StartPos 137, Length 13
    }
}