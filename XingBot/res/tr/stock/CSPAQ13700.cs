namespace XingBot.res
{
    // 현물계좌 주문체결내역 조회(API) ( SERVICE=CSPAQ13700,HEADTYPE=B,CREATOR=이상은,CREDATE=2015/04/13 08:39:53 )
    public struct _CSPAQ13700InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 33, Length 2
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 35, Length 1
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 36, Length 12
        public string ExecYn{ get; set; } // [ExecYn,    1] 체결여부                        StartPos 48, Length 1
        public string OrdDt{ get; set; } // [OrdDt,    8] 주문일                          StartPos 49, Length 8
        public long SrtOrdNo2{ get; set; } // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public string BkseqTpCode{ get; set; } // [BkseqTpCode,    1] 역순구분                        StartPos 67, Length 1
        public string OrdPtnCode{ get; set; } // [OrdPtnCode,    2] 주문유형코드                    StartPos 68, Length 2
    }

    public struct _CSPAQ13700OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 33, Length 2
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 35, Length 1
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 36, Length 12
        public string ExecYn{ get; set; } // [ExecYn,    1] 체결여부                        StartPos 48, Length 1
        public string OrdDt{ get; set; } // [OrdDt,    8] 주문일                          StartPos 49, Length 8
        public long SrtOrdNo2{ get; set; } // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public string BkseqTpCode{ get; set; } // [BkseqTpCode,    1] 역순구분                        StartPos 67, Length 1
        public string OrdPtnCode{ get; set; } // [OrdPtnCode,    2] 주문유형코드                    StartPos 68, Length 2
    }

    public struct _CSPAQ13700OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long SellExecAmt{ get; set; } // [SellExecAmt  ,   16] 매도체결금액                    StartPos 5, Length 16
        public long BuyExecAmt{ get; set; } // [BuyExecAmt  ,   16] 매수체결금액                    StartPos 21, Length 16
        public long SellExecQty{ get; set; } // [SellExecQty  ,   16] 매도체결수량                    StartPos 37, Length 16
        public long BuyExecQty{ get; set; } // [BuyExecQty  ,   16] 매수체결수량                    StartPos 53, Length 16
        public long SellOrdQty{ get; set; } // [SellOrdQty  ,   16] 매도주문수량                    StartPos 69, Length 16
        public long BuyOrdQty{ get; set; } // [BuyOrdQty  ,   16] 매수주문수량                    StartPos 85, Length 16
    }

    public struct _CSPAQ13700OutBlock3
    {
        public string OrdDt{ get; set; } // [OrdDt,    8] 주문일                          StartPos 0, Length 8
        public string MgmtBrnNo{ get; set; } // [MgmtBrnNo,    3] 관리지점번호                    StartPos 8, Length 3
        public string OrdMktCode{ get; set; } // [OrdMktCode,    2] 주문시장코드                    StartPos 11, Length 2
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 13, Length 10
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 23, Length 10
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 33, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 45, Length 40
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 85, Length 1
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 86, Length 10
        public string OrdPtnCode{ get; set; } // [OrdPtnCode,    2] 주문유형코드                    StartPos 96, Length 2
        public string OrdPtnNm{ get; set; } // [OrdPtnNm,   40] 주문유형명                      StartPos 98, Length 40
        public long OrdTrxPtnCode{ get; set; } // [OrdTrxPtnCode  ,    9] 주문처리유형코드                StartPos 138, Length 9
        public string OrdTrxPtnNm{ get; set; } // [OrdTrxPtnNm,   50] 주문처리유형명                  StartPos 147, Length 50
        public string MrcTpCode{ get; set; } // [MrcTpCode,    1] 정정취소구분                    StartPos 197, Length 1
        public string MrcTpNm{ get; set; } // [MrcTpNm,   10] 정정취소구분명                  StartPos 198, Length 10
        public long MrcQty{ get; set; } // [MrcQty  ,   16] 정정취소수량                    StartPos 208, Length 16
        public long MrcAbleQty{ get; set; } // [MrcAbleQty  ,   16] 정정취소가능수량                StartPos 224, Length 16
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 240, Length 16
        public decimal OrdPrc{ get; set; } // [OrdPrc, 15.2] 주문가격                        StartPos 256, Length 15
        public long ExecQty{ get; set; } // [ExecQty  ,   16] 체결수량                        StartPos 271, Length 16
        public decimal ExecPrc{ get; set; } // [ExecPrc, 15.2] 체결가                          StartPos 287, Length 15
        public string ExecTrxTime{ get; set; } // [ExecTrxTime,    9] 체결처리시각                    StartPos 302, Length 9
        public string LastExecTime{ get; set; } // [LastExecTime,    9] 최종체결시각                    StartPos 311, Length 9
        public string OrdprcPtnCode{ get; set; } // [OrdprcPtnCode,    2] 호가유형코드                    StartPos 320, Length 2
        public string OrdprcPtnNm{ get; set; } // [OrdprcPtnNm,   40] 호가유형명                      StartPos 322, Length 40
        public string OrdCndiTpCode{ get; set; } // [OrdCndiTpCode,    1] 주문조건구분                    StartPos 362, Length 1
        public long AllExecQty{ get; set; } // [AllExecQty  ,   16] 전체체결수량                    StartPos 363, Length 16
        public string RegCommdaCode{ get; set; } // [RegCommdaCode,    2] 통신매체코드                    StartPos 379, Length 2
        public string CommdaNm{ get; set; } // [CommdaNm,   40] 통신매체명                      StartPos 381, Length 40
        public string MbrNo{ get; set; } // [MbrNo,    3] 회원번호                        StartPos 421, Length 3
        public string RsvOrdYn{ get; set; } // [RsvOrdYn,    1] 예약주문여부                    StartPos 424, Length 1
        public string LoanDt{ get; set; } // [LoanDt,    8] 대출일                          StartPos 425, Length 8
        public string OrdTime{ get; set; } // [OrdTime,    9] 주문시각                        StartPos 433, Length 9
        public string OpDrtnNo{ get; set; } // [OpDrtnNo,   12] 운용지시번호                    StartPos 442, Length 12
        public string OdrrId{ get; set; } // [OdrrId,   16] 주문자ID                        StartPos 454, Length 16
    }
}