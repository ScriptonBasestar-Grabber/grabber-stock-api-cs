namespace XingBot.res
{
    // 선물옵션 CME 주문가능 수량/금액 조회 ( SERVICE=CCEAQ10100,HEADTYPE=B,CREATOR=김효종,CREDATE=2012/04/17 13:38:18 )
    public struct _CCEAQ10100InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QryTp{ get; set; } // [QryTp,    1] 조회구분                        StartPos 33, Length 1
        public long OrdAmt{ get; set; } // [OrdAmt  ,   16] 주문금액                        StartPos 34, Length 16
        public decimal RatVal{ get; set; } // [RatVal, 19.8] 비율값                          StartPos 50, Length 19
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 69, Length 12
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 81, Length 1
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 82, Length 13
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 95, Length 2
    }

    public struct _CCEAQ10100OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QryTp{ get; set; } // [QryTp,    1] 조회구분                        StartPos 33, Length 1
        public long OrdAmt{ get; set; } // [OrdAmt  ,   16] 주문금액                        StartPos 34, Length 16
        public decimal RatVal{ get; set; } // [RatVal, 19.8] 비율값                          StartPos 50, Length 19
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 69, Length 12
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 81, Length 1
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 82, Length 13
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 95, Length 2
    }

    public struct _CCEAQ10100OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public string QryDt{ get; set; } // [QryDt,    8] 조회일                          StartPos 45, Length 8
        public decimal NowPrc{ get; set; } // [NowPrc, 15.2] 현재가                          StartPos 53, Length 15
        public long OrdAbleQty{ get; set; } // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 68, Length 16
        public long NewOrdAbleQty{ get; set; } // [NewOrdAbleQty  ,   16] 신규주문가능수량                StartPos 84, Length 16
        public long LqdtOrdAbleQty{ get; set; } // [LqdtOrdAbleQty  ,   16] 청산주문가능수량                StartPos 100, Length 16
        public long UsePreargMgn{ get; set; } // [UsePreargMgn  ,   16] 사용예정증거금액                StartPos 116, Length 16
        public long UsePreargMnyMgn{ get; set; } // [UsePreargMnyMgn  ,   16] 사용예정현금증거금액            StartPos 132, Length 16
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 148, Length 16
        public long MnyOrdAbleAmt{ get; set; } // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 164, Length 16
    }
}