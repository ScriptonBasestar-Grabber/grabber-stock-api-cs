﻿namespace XingBot.res
{
    // 선물옵션 취소주문 ( SERVICE=CFOAT00300,ENCRYPT,SIGNATURE,HEADTYPE=B,CREATOR=이인희,CREDATE=2011/12/19 17:39:04 )
    public class _CFOAT00300InBlock1
    {
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 40, Length 10
        public long CancQty{ get; set; } // [CancQty  ,   16] 취소수량                        StartPos 50, Length 16
    }

    public class _CFOAT00300OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 5, Length 2
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 7, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 27, Length 8
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 35, Length 12
        public string FnoOrdPtnCode{ get; set; } // [FnoOrdPtnCode,    2] 선물옵션주문유형코드            StartPos 47, Length 2
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 49, Length 10
        public long CancQty{ get; set; } // [CancQty  ,   16] 취소수량                        StartPos 59, Length 16
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 75, Length 2
        public string DscusBnsCmpltTime{ get; set; } // [DscusBnsCmpltTime,    9] 협의매매완료시각                StartPos 77, Length 9
        public string GrpId{ get; set; } // [GrpId,   20] 그룹ID                          StartPos 86, Length 20
        public long OrdSeqno{ get; set; } // [OrdSeqno  ,   10] 주문일련번호                    StartPos 106, Length 10
        public long PtflNo{ get; set; } // [PtflNo  ,   10] 포트폴리오번호                  StartPos 116, Length 10
        public long BskNo{ get; set; } // [BskNo  ,   10] 바스켓번호                      StartPos 126, Length 10
        public long TrchNo{ get; set; } // [TrchNo  ,   10] 트렌치번호                      StartPos 136, Length 10
        public long ItemNo{ get; set; } // [ItemNo  ,   10] 아이템번호                      StartPos 146, Length 10
        public string MgempNo{ get; set; } // [MgempNo,    9] 관리사원번호                    StartPos 156, Length 9
        public string FundId{ get; set; } // [FundId,   12] 펀드ID                          StartPos 165, Length 12
        public long FundOrgOrdNo{ get; set; } // [FundOrgOrdNo  ,   10] 펀드원주문번호                  StartPos 177, Length 10
        public long FundOrdNo{ get; set; } // [FundOrdNo  ,   10] 펀드주문번호                    StartPos 187, Length 10
    }

    public class _CFOAT00300OutBlock2
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