namespace XingBot.res
{
    // 선물옵션 계좌주문체결내역 조회 ( ENCRYPT,SERVICE=CFOAQ00600,HEADTYPE=B,CREATOR=정명기,CREDATE=2012/03/12 16:35:20 )
    internal struct _CFOAQ00600InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string FnoClssCode; // [FnoClssCode,    2] 선물옵션분류코드                StartPos 49, Length 2
        public string PrdgrpCode; // [PrdgrpCode,    2] 상품군코드                      StartPos 51, Length 2
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 53, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 54, Length 1
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 55, Length 2
    }

    internal struct _CFOAQ00600OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string FnoClssCode; // [FnoClssCode,    2] 선물옵션분류코드                StartPos 49, Length 2
        public string PrdgrpCode; // [PrdgrpCode,    2] 상품군코드                      StartPos 51, Length 2
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 53, Length 1
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 54, Length 1
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 55, Length 2
    }

    internal struct _CFOAQ00600OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsOrdQty; // [FutsOrdQty  ,   16] 선물주문수량                    StartPos 45, Length 16
        public long FutsExecQty; // [FutsExecQty  ,   16] 선물체결수량                    StartPos 61, Length 16
        public long OptOrdQty; // [OptOrdQty  ,   16] 옵션주문수량                    StartPos 77, Length 16
        public long OptExecQty; // [OptExecQty  ,   16] 옵션체결수량                    StartPos 93, Length 16
    }

    internal struct _CFOAQ00600OutBlock3
    {
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 0, Length 8
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 8, Length 10
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 18, Length 10
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 28, Length 9
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 37, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 49, Length 40
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 89, Length 10
        public string MrcTpNm; // [MrcTpNm,   10] 정정취소구분명                  StartPos 99, Length 10
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 109, Length 2
        public string FnoOrdprcPtnNm; // [FnoOrdprcPtnNm,   40] 선물옵션호가유형명              StartPos 111, Length 40
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 151, Length 13
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 164, Length 16
        public string OrdTpNm; // [OrdTpNm,   10] 주문구분명                      StartPos 180, Length 10
        public string ExecTpNm; // [ExecTpNm,   10] 체결구분명                      StartPos 190, Length 10
        public double ExecPrc; // [ExecPrc, 13.2] 체결가                          StartPos 200, Length 13
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 213, Length 16
        public string CtrctTime; // [CtrctTime,    9] 약정시각                        StartPos 229, Length 9
        public long CtrctNo; // [CtrctNo  ,   10] 약정번호                        StartPos 238, Length 10
        public long ExecNo; // [ExecNo  ,   10] 체결번호                        StartPos 248, Length 10
        public long BnsplAmt; // [BnsplAmt  ,   16] 매매손익금액                    StartPos 258, Length 16
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 274, Length 16
        public string UserId; // [UserId,   16] 사용자ID                        StartPos 290, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 306, Length 2
        public string CommdaCodeNm; // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 308, Length 40
    }
}