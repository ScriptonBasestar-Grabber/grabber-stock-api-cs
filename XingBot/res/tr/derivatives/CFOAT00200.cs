namespace XingBot.res
{
    // 선물옵션 정정주문 ( SERVICE=CFOAT00200,ENCRYPT,SIGNATURE,HEADTYPE=B,CREATOR=이인희,CREDATE=2012/03/12 13:31:21 )
    public class _CFOAT00200InBlock1
    {
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 40, Length 10
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 50, Length 2
        public decimal OrdPrc{ get; set; } // [OrdPrc, 15.2] 주문가격                        StartPos 52, Length 15
        public long MdfyQty{ get; set; } // [MdfyQty  ,   16] 정정수량                        StartPos 67, Length 16
    }

    public class _CFOAT00200OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 5, Length 2
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 7, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 27, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 35, Length 12
        public string FnoOrdPtnCode{ get; set; } // [FnoOrdPtnCode,    2] 선물옵션주문유형코드            StartPos 47, Length 2
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 49, Length 10
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 59, Length 2
        public decimal OrdPrc{ get; set; } // [OrdPrc, 15.2] 주문가격                        StartPos 61, Length 15
        public long MdfyQty{ get; set; } // [MdfyQty  ,   16] 정정수량                        StartPos 76, Length 16
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 92, Length 2
        public string DscusBnsCmpltTime{ get; set; } // [DscusBnsCmpltTime,    9] 협의매매완료시각                StartPos 94, Length 9
        public string GrpId{ get; set; } // [GrpId,   20] 그룹ID                          StartPos 103, Length 20
        public long OrdSeqno{ get; set; } // [OrdSeqno  ,   10] 주문일련번호                    StartPos 123, Length 10
        public long PtflNo{ get; set; } // [PtflNo  ,   10] 포트폴리오번호                  StartPos 133, Length 10
        public long BskNo{ get; set; } // [BskNo  ,   10] 바스켓번호                      StartPos 143, Length 10
        public long TrchNo{ get; set; } // [TrchNo  ,   10] 트렌치번호                      StartPos 153, Length 10
        public long ItemNo{ get; set; } // [ItemNo  ,   10] 아이템번호                      StartPos 163, Length 10
        public string MgempNo{ get; set; } // [MgempNo,    9] 관리사원번호                    StartPos 173, Length 9
        public string FundId{ get; set; } // [FundId,   12] 펀드ID                          StartPos 182, Length 12
        public long FundOrgOrdNo{ get; set; } // [FundOrgOrdNo  ,   10] 펀드원주문번호                  StartPos 194, Length 10
        public long FundOrdNo{ get; set; } // [FundOrdNo  ,   10] 펀드주문번호                    StartPos 204, Length 10
    }

    public class _CFOAT00200OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string BrnNm{ get; set; } // [BrnNm,   40] 지점명                          StartPos 15, Length 40
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 55, Length 40
        public string IsuNm{ get; set; } // [IsuNm,   50] 종목명                          StartPos 95, Length 50
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 145, Length 16
        public long MnyOrdAbleAmt{ get; set; } // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 161, Length 16
        public long OrdMgn{ get; set; } // [OrdMgn  ,   16] 주문증거금액                    StartPos 177, Length 16
        public long MnyOrdMgn{ get; set; } // [MnyOrdMgn  ,   16] 현금주문증거금액                StartPos 193, Length 16
        public long OrdAbleQty{ get; set; } // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 209, Length 16
    }
}