namespace XingBot.res
{
    // EUREX 야간옵션 정상주문 ( SERVICE=CEXAT11100,HEADTYPE=B,CREATOR=이시종,CREDATE=2012/06/27 20:48:05 )
    public class _CEXAT11100InBlock1
    {
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 40, Length 1
        public string ErxPrcCndiTpCode{ get; set; } // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 41, Length 1
        public decimal OrdPrc{ get; set; } // [OrdPrc, 15.2] 주문가격                        StartPos 42, Length 15
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 57, Length 16
    }

    public class _CEXAT11100OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 33, Length 12
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 45, Length 1
        public string ErxPrcCndiTpCode{ get; set; } // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 46, Length 1
        public decimal OrdPrc{ get; set; } // [OrdPrc, 15.2] 주문가격                        StartPos 47, Length 15
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 62, Length 16
        public decimal OrdCndiPrc{ get; set; } // [OrdCndiPrc, 25.8] 주문조건가격                    StartPos 78, Length 25
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 103, Length 2
    }

    public class _CEXAT11100OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string BrnNm{ get; set; } // [BrnNm,   40] 지점명                          StartPos 15, Length 40
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 55, Length 40
        public string IsuNm{ get; set; } // [IsuNm,   50] 종목명                          StartPos 95, Length 50
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 145, Length 16
        public long MnyOrdAbleAmt{ get; set; } // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 161, Length 16
        public long OrdMgn{ get; set; } // [OrdMgn  ,   16] 주문증거금                      StartPos 177, Length 16
        public long MnyOrdMgn{ get; set; } // [MnyOrdMgn  ,   16] 현금주문증거금                  StartPos 193, Length 16
        public long OrdAbleQty{ get; set; } // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 209, Length 16
    }
}