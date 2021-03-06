﻿namespace XingBot.res
{
    // 현물 취소주문 ( SERVICE=CSPAT00800,ENCRYPT,SIGNATURE,HEADTYPE=B,CREATOR=김기종,CREDATE=2011/12/07 09:23:48 )
    public class _CSPAT00800InBlock1
    {
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 0, Length 10
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 10, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 30, Length 8
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 38, Length 12
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 50, Length 16
    }

    public class _CSPAT00800OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 5, Length 10
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 15, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 35, Length 8
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 43, Length 12
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 55, Length 16
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 71, Length 2
        public string GrpId{ get; set; } // [GrpId,   20] 그룹ID                          StartPos 73, Length 20
        public string StrtgCode{ get; set; } // [StrtgCode,    6] 전략코드                        StartPos 93, Length 6
        public long OrdSeqNo{ get; set; } // [OrdSeqNo  ,   10] 주문회차                        StartPos 99, Length 10
        public long PtflNo{ get; set; } // [PtflNo  ,   10] 포트폴리오번호                  StartPos 109, Length 10
        public long BskNo{ get; set; } // [BskNo  ,   10] 바스켓번호                      StartPos 119, Length 10
        public long TrchNo{ get; set; } // [TrchNo  ,   10] 트렌치번호                      StartPos 129, Length 10
        public long ItemNo{ get; set; } // [ItemNo  ,   10] 아이템번호                      StartPos 139, Length 10
    }

    public class _CSPAT00800OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public long PrntOrdNo{ get; set; } // [PrntOrdNo  ,   10] 모주문번호                      StartPos 15, Length 10
        public string OrdTime{ get; set; } // [OrdTime,    9] 주문시각                        StartPos 25, Length 9
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 34, Length 2
        public string OrdPtnCode{ get; set; } // [OrdPtnCode,    2] 주문유형코드                    StartPos 36, Length 2
        public string ShtnIsuNo{ get; set; } // [ShtnIsuNo,    9] 단축종목번호                    StartPos 38, Length 9
        public string PrgmOrdprcPtnCode{ get; set; } // [PrgmOrdprcPtnCode,    2] 프로그램호가유형코드            StartPos 47, Length 2
        public string StslOrdprcTpCode{ get; set; } // [StslOrdprcTpCode,    1] 공매도호가구분                  StartPos 49, Length 1
        public string StslAbleYn{ get; set; } // [StslAbleYn,    1] 공매도가능여부                  StartPos 50, Length 1
        public string MgntrnCode{ get; set; } // [MgntrnCode,    3] 신용거래코드                    StartPos 51, Length 3
        public string LoanDt{ get; set; } // [LoanDt,    8] 대출일                          StartPos 54, Length 8
        public string CvrgOrdTp{ get; set; } // [CvrgOrdTp,    1] 반대매매주문구분                StartPos 62, Length 1
        public string LpYn{ get; set; } // [LpYn,    1] 유동성공급자여부                StartPos 63, Length 1
        public string MgempNo{ get; set; } // [MgempNo,    9] 관리사원번호                    StartPos 64, Length 9
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 73, Length 1
        public long SpareOrdNo{ get; set; } // [SpareOrdNo  ,   10] 예비주문번호                    StartPos 74, Length 10
        public long CvrgSeqno{ get; set; } // [CvrgSeqno  ,   10] 반대매매일련번호                StartPos 84, Length 10
        public long RsvOrdNo{ get; set; } // [RsvOrdNo  ,   10] 예약주문번호                    StartPos 94, Length 10
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 104, Length 40
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 144, Length 40
    }
}