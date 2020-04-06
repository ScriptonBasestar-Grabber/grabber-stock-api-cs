namespace XingBot.real.res.tr
{
    // 예탁담보융자가능종목현황조회 ( SERVICE=CLNAQ00100,HEADTYPE=B,CREATOR=이성호,CREDATE=2012/01/10 15:45:49 )
    public struct _CLNAQ00100InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 5, Length 1
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 6, Length 12
        public string SecTpCode; // [SecTpCode,    1] 유가증권구분                    StartPos 18, Length 1
        public string LoanIntrstGrdCode; // [LoanIntrstGrdCode,    2] 대출이자등급코드                StartPos 19, Length 2
        public string LoanTp; // [LoanTp,    1] 대출구분                        StartPos 21, Length 1
    }

    public struct _CLNAQ00100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 5, Length 1
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 6, Length 12
        public string SecTpCode; // [SecTpCode,    1] 유가증권구분                    StartPos 18, Length 1
        public string LoanIntrstGrdCode; // [LoanIntrstGrdCode,    2] 대출이자등급코드                StartPos 19, Length 2
        public string LoanTp; // [LoanTp,    1] 대출구분                        StartPos 21, Length 1
    }

    public struct _CLNAQ00100OutBlock2
    {
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 0, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public decimal Parprc; // [Parprc, 13.2] 액면가                          StartPos 52, Length 13
        public decimal PrdayCprc; // [PrdayCprc, 13.2] 전일종가                        StartPos 65, Length 13
        public decimal RatVal; // [RatVal, 19.8] 비율값                          StartPos 78, Length 19
        public decimal SubstPrc; // [SubstPrc, 13.2] 대용가                          StartPos 97, Length 13
        public string RegTpNm; // [RegTpNm,   20] 등록구분                        StartPos 110, Length 20
        public string SpotMgnLevyClssNm; // [SpotMgnLevyClssNm,   40] 현물증거금징수분류명            StartPos 130, Length 40
        public string FnoTrdStopRsnCnts; // [FnoTrdStopRsnCnts,   40] 거래정지사유                    StartPos 170, Length 40
        public string DgrsPtnNm; // [DgrsPtnNm,   40] 요주의유형명                    StartPos 210, Length 40
        public string AcdPtnNm; // [AcdPtnNm,   40] 사고유형                        StartPos 250, Length 40
        public string MktTpNm; // [MktTpNm,   20] 시장구분                        StartPos 290, Length 20
        public long LmtVal; // [LmtVal  ,   18] 한도값                          StartPos 310, Length 18
        public long AcntLmtVal; // [AcntLmtVal  ,   18] 계좌한도값                      StartPos 328, Length 18
        public string LoanGrdCode; // [LoanGrdCode,    2] 대출등급코드                    StartPos 346, Length 2
        public long LoanAmt; // [LoanAmt  ,   16] 대출금액                        StartPos 348, Length 16
        public decimal LoanAbleRat; // [LoanAbleRat, 26.9] 대출가능율                      StartPos 364, Length 26
        public decimal LoanIntrat1; // [LoanIntrat1, 14.4] 대출이율1                       StartPos 390, Length 14
        public string RegPsnId; // [RegPsnId,   16] 등록자ID                        StartPos 404, Length 16
        public decimal Rat01; // [Rat01, 19.8] 비율값                          StartPos 420, Length 19
        public decimal Rat02; // [Rat02, 19.8] 비율값                          StartPos 439, Length 19
    }

    public struct _CLNAQ00100OutBlock3
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long LrgMnyoutSumAmt; // [LrgMnyoutSumAmt  ,   16] 대출금합계금액                  StartPos 5, Length 16
    }
}