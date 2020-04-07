namespace XingBot.res
{
    // 선물옵션 계좌주문체결내역 조회 ( ENCRYPT,SERVICE=CFOAQ00600,HEADTYPE=B,CREATOR=정명기,CREDATE=2012/03/12 16:35:20 )
    public struct _CFOAQ00600InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string FnoClssCode{ get; set; } // [FnoClssCode,    2] 선물옵션분류코드                StartPos 49, Length 2
        public string PrdgrpCode{ get; set; } // [PrdgrpCode,    2] 상품군코드                      StartPos 51, Length 2
        public string PrdtExecTpCode{ get; set; } // [PrdtExecTpCode,    1] 체결구분                        StartPos 53, Length 1
        public string StnlnSeqTp{ get; set; } // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 54, Length 1
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 55, Length 2
    }

    public struct _CFOAQ00600OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string FnoClssCode{ get; set; } // [FnoClssCode,    2] 선물옵션분류코드                StartPos 49, Length 2
        public string PrdgrpCode{ get; set; } // [PrdgrpCode,    2] 상품군코드                      StartPos 51, Length 2
        public string PrdtExecTpCode{ get; set; } // [PrdtExecTpCode,    1] 체결구분                        StartPos 53, Length 1
        public string StnlnSeqTp{ get; set; } // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 54, Length 1
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 55, Length 2
    }

    public struct _CFOAQ00600OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsOrdQty{ get; set; } // [FutsOrdQty  ,   16] 선물주문수량                    StartPos 45, Length 16
        public long FutsExecQty{ get; set; } // [FutsExecQty  ,   16] 선물체결수량                    StartPos 61, Length 16
        public long OptOrdQty{ get; set; } // [OptOrdQty  ,   16] 옵션주문수량                    StartPos 77, Length 16
        public long OptExecQty{ get; set; } // [OptExecQty  ,   16] 옵션체결수량                    StartPos 93, Length 16
    }

    public struct _CFOAQ00600OutBlock3
    {
        public string OrdDt{ get; set; } // [OrdDt,    8] 주문일                          StartPos 0, Length 8
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 8, Length 10
        public long OrgOrdNo{ get; set; } // [OrgOrdNo  ,   10] 원주문번호                      StartPos 18, Length 10
        public string OrdTime{ get; set; } // [OrdTime,    9] 주문시각                        StartPos 28, Length 9
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 37, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 49, Length 40
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 89, Length 10
        public string MrcTpNm{ get; set; } // [MrcTpNm,   10] 정정취소구분명                  StartPos 99, Length 10
        public string FnoOrdprcPtnCode{ get; set; } // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 109, Length 2
        public string FnoOrdprcPtnNm{ get; set; } // [FnoOrdprcPtnNm,   40] 선물옵션호가유형명              StartPos 111, Length 40
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 151, Length 13
        public long OrdQty{ get; set; } // [OrdQty  ,   16] 주문수량                        StartPos 164, Length 16
        public string OrdTpNm{ get; set; } // [OrdTpNm,   10] 주문구분명                      StartPos 180, Length 10
        public string ExecTpNm{ get; set; } // [ExecTpNm,   10] 체결구분명                      StartPos 190, Length 10
        public decimal ExecPrc{ get; set; } // [ExecPrc, 13.2] 체결가                          StartPos 200, Length 13
        public long ExecQty{ get; set; } // [ExecQty  ,   16] 체결수량                        StartPos 213, Length 16
        public string CtrctTime{ get; set; } // [CtrctTime,    9] 약정시각                        StartPos 229, Length 9
        public long CtrctNo{ get; set; } // [CtrctNo  ,   10] 약정번호                        StartPos 238, Length 10
        public long ExecNo{ get; set; } // [ExecNo  ,   10] 체결번호                        StartPos 248, Length 10
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 258, Length 16
        public long UnercQty{ get; set; } // [UnercQty  ,   16] 미체결수량                      StartPos 274, Length 16
        public string UserId{ get; set; } // [UserId,   16] 사용자ID                        StartPos 290, Length 16
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 306, Length 2
        public string CommdaCodeNm{ get; set; } // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 308, Length 40
    }
}