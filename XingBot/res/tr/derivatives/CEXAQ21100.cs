namespace XingBot.res
{
    // EUREX 야간옵션 주문체결내역 조회 ( SERVICE=CEXAQ21100,HEADTYPE=B,CREATOR=이시종,CREDATE=2012/07/02 21:01:29 )
    internal struct _CEXAQ21100InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 34, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 35, Length 1
    }

    internal struct _CEXAQ21100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 34, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 35, Length 1
    }

    internal struct _CEXAQ21100OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 45, Length 16
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 61, Length 16
    }

    internal struct _CEXAQ21100OutBlock3
    {
        public string AcntNo1; // [AcntNo1,   20] 계좌번호1                       StartPos 0, Length 20
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 20, Length 8
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 28, Length 10
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 38, Length 10
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 48, Length 9
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 57, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 69, Length 40
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 109, Length 10
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 119, Length 1
        public string MrcTpNm; // [MrcTpNm,   10] 정정취소구분명                  StartPos 120, Length 10
        public string ErxPrcCndiTpCode; // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 130, Length 1
        public string FnoOrdprcPtnNm; // [FnoOrdprcPtnNm,   40] 선물옵션호가유형명              StartPos 131, Length 40
        public double OrdCndiPrc; // [OrdCndiPrc, 25.8] 주문조건가격                    StartPos 171, Length 25
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 196, Length 13
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 209, Length 16
        public string OrdTpNm; // [OrdTpNm,   10] 주문구분명                      StartPos 225, Length 10
        public double ExecPrc; // [ExecPrc, 13.2] 체결가                          StartPos 235, Length 13
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 248, Length 16
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 264, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 280, Length 2
        public string CommdaNm; // [CommdaNm,   40] 통신매체명                      StartPos 282, Length 40
    }
}