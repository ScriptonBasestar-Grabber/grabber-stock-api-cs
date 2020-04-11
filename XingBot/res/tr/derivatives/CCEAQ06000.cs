namespace XingBot.res
{
    // 선물옵션 CME 주문체결내역 조회 ( SERVICE=CCEAQ06000,HEADTYPE=B,CREATOR=김효종,CREDATE=2012/04/17 17:48:18 )
    public class _CCEAQ06000InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode{ get; set; } // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo{ get; set; } // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string FnoClssCode{ get; set; } // [FnoClssCode,    2] 선물옵션분류코드                StartPos 50, Length 2
        public string PrdgrpCode{ get; set; } // [PrdgrpCode,    2] 상품군코드                      StartPos 52, Length 2
        public string PrdtExecTpCode{ get; set; } // [PrdtExecTpCode,    1] 체결구분                        StartPos 54, Length 1
        public string FnoTrdPtnCode{ get; set; } // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 55, Length 2
        public long SrtOrdNo2{ get; set; } // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public long EndNo{ get; set; } // [EndNo  ,   10] 종료번호                        StartPos 67, Length 10
        public string StnlnSeqTp{ get; set; } // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 77, Length 1
    }

    public class _CCEAQ06000OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode{ get; set; } // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo{ get; set; } // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string FnoClssCode{ get; set; } // [FnoClssCode,    2] 선물옵션분류코드                StartPos 50, Length 2
        public string PrdgrpCode{ get; set; } // [PrdgrpCode,    2] 상품군코드                      StartPos 52, Length 2
        public string PrdtExecTpCode{ get; set; } // [PrdtExecTpCode,    1] 체결구분                        StartPos 54, Length 1
        public string FnoTrdPtnCode{ get; set; } // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 55, Length 2
        public long SrtOrdNo2{ get; set; } // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public long EndNo{ get; set; } // [EndNo  ,   10] 종료번호                        StartPos 67, Length 10
        public string StnlnSeqTp{ get; set; } // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 77, Length 1
    }

    public class _CCEAQ06000OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsOrdQty{ get; set; } // [FutsOrdQty  ,   16] 선물주문수량                    StartPos 45, Length 16
        public long FutsExecQty{ get; set; } // [FutsExecQty  ,   16] 선물체결수량                    StartPos 61, Length 16
    }

    public class _CCEAQ06000OutBlock3
    {
        public string AcntNo1{ get; set; } // [AcntNo1,   20] 계좌번호1                       StartPos 0, Length 20
        public string OrdDt{ get; set; } // [OrdDt,    8] 주문일                          StartPos 20, Length 8
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 28, Length 10
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 38, Length 10
        public string OrdTime{ get; set; } // [OrdTime,    9] 주문시각                        StartPos 48, Length 9
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 57, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 69, Length 40
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 109, Length 10
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 119, Length 1
        public string MrcTpNm{ get; set; } // [MrcTpNm,   10] 정정취소구분명                  StartPos 120, Length 10
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 130, Length 2
        public string FnoOrdprcPtnNm{ get; set; } // [FnoOrdprcPtnNm,   40] 선물옵션호가유형명              StartPos 132, Length 40
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 172, Length 13
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 185, Length 16
        public string OrdTpNm{ get; set; } // [OrdTpNm,   10] 주문구분명                      StartPos 201, Length 10
        public string ExecTpNm{ get; set; } // [ExecTpNm,   10] 체결구분명                      StartPos 211, Length 10
        public decimal ExecPrc{ get; set; } // [ExecPrc, 13.2] 체결가                          StartPos 221, Length 13
        public long ExecQty{ get; set; } // [ExecQty  ,   16] 체결수량                        StartPos 234, Length 16
        public string CtrctTime{ get; set; } // [CtrctTime,    9] 약정시각                        StartPos 250, Length 9
        public long CtrctNo{ get; set; } // [CtrctNo  ,   10] 약정번호                        StartPos 259, Length 10
        public long ExecNo{ get; set; } // [ExecNo  ,   10] 체결번호                        StartPos 269, Length 10
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 279, Length 16
        public long UnercQty{ get; set; } // [UnercQty  ,   16] 미체결수량                      StartPos 295, Length 16
        public string UserId{ get; set; } // [UserId,   16] 사용자ID                        StartPos 311, Length 16
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 327, Length 2
        public string CommdaCodeNm{ get; set; } // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 329, Length 40
        public string IpAddr{ get; set; } // [IpAddr,   16] IP주소                          StartPos 369, Length 16
        public string TrdPtnTpNm{ get; set; } // [TrdPtnTpNm,   20] 거래유형구분                    StartPos 385, Length 20
        public string GrpId{ get; set; } // [GrpId,   20] 그룹ID                          StartPos 405, Length 20
    }
}