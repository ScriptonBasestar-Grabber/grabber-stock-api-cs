namespace XingBot.res
{
    // EUREX 야간옵션 정상주문 ( SERVICE=CEXAT11100,HEADTYPE=B,CREATOR=이시종,CREDATE=2012/06/27 20:48:05 )
    internal struct _CEXAT11100InBlock1
    {
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 40, Length 1
        public string ErxPrcCndiTpCode; // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 41, Length 1
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 42, Length 15
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 57, Length 16
    }

    internal struct _CEXAT11100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 33, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 45, Length 1
        public string ErxPrcCndiTpCode; // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 46, Length 1
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 47, Length 15
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 62, Length 16
        public double OrdCndiPrc; // [OrdCndiPrc, 25.8] 주문조건가격                    StartPos 78, Length 25
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 103, Length 2
    }

    internal struct _CEXAT11100OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 15, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 55, Length 40
        public string IsuNm; // [IsuNm,   50] 종목명                          StartPos 95, Length 50
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 145, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 161, Length 16
        public long OrdMgn; // [OrdMgn  ,   16] 주문증거금                      StartPos 177, Length 16
        public long MnyOrdMgn; // [MnyOrdMgn  ,   16] 현금주문증거금                  StartPos 193, Length 16
        public long OrdAbleQty; // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 209, Length 16
    }
}