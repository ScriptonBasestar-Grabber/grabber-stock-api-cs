namespace XingBot.res
{
    // 선물옵션 CME 정상주문 ( SERVICE=CCEAT00100,HEADTYPE=B,CREATOR=이호섭,CREDATE=2012/04/10 10:02:33 )
    internal struct _CCEAT00100InBlock1
    {
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 40, Length 1
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 41, Length 2
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 43, Length 15
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 58, Length 16
    }

    internal struct _CCEAT00100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 5, Length 2
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 7, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 27, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 35, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 47, Length 1
        public string FnoOrdPtnCode; // [FnoOrdPtnCode,    2] 선물옵션주문유형코드            StartPos 48, Length 2
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 50, Length 2
        public string FnoTrdPtnCode; // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 52, Length 2
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 54, Length 15
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 69, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 85, Length 2
        public string DscusBnsCmpltTime; // [DscusBnsCmpltTime,    9] 협의매매완료시각                StartPos 87, Length 9
        public string GrpId; // [GrpId,   20] 그룹ID                          StartPos 96, Length 20
        public long OrdSeqno; // [OrdSeqno  ,   10] 주문일련번호                    StartPos 116, Length 10
        public long PtflNo; // [PtflNo  ,   10] 포트폴리오번호                  StartPos 126, Length 10
        public long BskNo; // [BskNo  ,   10] 바스켓번호                      StartPos 136, Length 10
        public long TrchNo; // [TrchNo  ,   10] 트렌치번호                      StartPos 146, Length 10
        public long ItemNo; // [ItemNo  ,   16] 항목번호                        StartPos 156, Length 16
        public string OpDrtnNo; // [OpDrtnNo,   12] 운용지시번호                    StartPos 172, Length 12
        public string MgempNo; // [MgempNo,    9] 관리사원번호                    StartPos 184, Length 9
        public string FundId; // [FundId,   12] 펀드ID                          StartPos 193, Length 12
        public long FundOrdNo; // [FundOrdNo  ,   10] 펀드주문번호                    StartPos 205, Length 10
    }

    internal struct _CCEAT00100OutBlock2
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