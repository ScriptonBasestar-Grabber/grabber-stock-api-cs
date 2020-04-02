using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물옵션 CME 정정주문 ( SERVICE=CCEAT00200,HEADTYPE=B,CREATOR=이호섭,CREDATE=2012/04/10 10:07:08 )
    struct _CCEAT00200InBlock1
    {
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 0, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 20, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 28, Length 12
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 40, Length 10
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 50, Length 2
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 52, Length 15
        public long MdfyQty; // [MdfyQty  ,   16] 정정수량                        StartPos 67, Length 16
    }

    struct _CCEAT00200OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 5, Length 2
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 7, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 27, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 35, Length 12
        public string FnoOrdPtnCode; // [FnoOrdPtnCode,    2] 선물옵션주문유형코드            StartPos 47, Length 2
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 49, Length 10
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 59, Length 2
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 61, Length 15
        public long MdfyQty; // [MdfyQty  ,   16] 정정수량                        StartPos 76, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 92, Length 2
        public string DscusBnsCmpltTime; // [DscusBnsCmpltTime,    9] 협의매매완료시각                StartPos 94, Length 9
        public string GrpId; // [GrpId,   20] 그룹ID                          StartPos 103, Length 20
        public long OrdSeqno; // [OrdSeqno  ,   10] 주문일련번호                    StartPos 123, Length 10
        public long PtflNo; // [PtflNo  ,   10] 포트폴리오번호                  StartPos 133, Length 10
        public long BskNo; // [BskNo  ,   10] 바스켓번호                      StartPos 143, Length 10
        public long TrchNo; // [TrchNo  ,   10] 트렌치번호                      StartPos 153, Length 10
        public long ItemNo; // [ItemNo  ,   10] 아이템번호                      StartPos 163, Length 10
        public string MgempNo; // [MgempNo,    9] 관리사원번호                    StartPos 173, Length 9
        public string FundId; // [FundId,   12] 펀드ID                          StartPos 182, Length 12
        public long FundOrgOrdNo; // [FundOrgOrdNo  ,   10] 펀드원주문번호                  StartPos 194, Length 10
        public long FundOrdNo; // [FundOrdNo  ,   10] 펀드주문번호                    StartPos 204, Length 10
    }

    struct _CCEAT00200OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 15, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 55, Length 40
        public string IsuNm; // [IsuNm,   50] 종목명                          StartPos 95, Length 50
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 145, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 161, Length 16
        public long OrdMgn; // [OrdMgn  ,   16] 주문증거금액                    StartPos 177, Length 16
        public long MnyOrdMgn; // [MnyOrdMgn  ,   16] 현금주문증거금액                StartPos 193, Length 16
        public long OrdAbleQty; // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 209, Length 16
    }
}