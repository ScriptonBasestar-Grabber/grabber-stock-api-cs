namespace XingBot.real.res
{
    // 선물옵션 CME 주문체결내역 조회 ( SERVICE=CCEAQ06000,HEADTYPE=B,CREATOR=김효종,CREDATE=2012/04/17 17:48:18 )
    public struct _CCEAQ06000InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string FnoClssCode; // [FnoClssCode,    2] 선물옵션분류코드                StartPos 50, Length 2
        public string PrdgrpCode; // [PrdgrpCode,    2] 상품군코드                      StartPos 52, Length 2
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 54, Length 1
        public string FnoTrdPtnCode; // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 55, Length 2
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public long EndNo; // [EndNo  ,   10] 종료번호                        StartPos 67, Length 10
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 77, Length 1
    }

    public struct _CCEAQ06000OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 지점번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string FnoClssCode; // [FnoClssCode,    2] 선물옵션분류코드                StartPos 50, Length 2
        public string PrdgrpCode; // [PrdgrpCode,    2] 상품군코드                      StartPos 52, Length 2
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 54, Length 1
        public string FnoTrdPtnCode; // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 55, Length 2
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public long EndNo; // [EndNo  ,   10] 종료번호                        StartPos 67, Length 10
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 77, Length 1
    }

    public struct _CCEAQ06000OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long FutsOrdQty; // [FutsOrdQty  ,   16] 선물주문수량                    StartPos 45, Length 16
        public long FutsExecQty; // [FutsExecQty  ,   16] 선물체결수량                    StartPos 61, Length 16
    }

    public struct _CCEAQ06000OutBlock3
    {
        public string AcntNo1; // [AcntNo1,   20] 계좌번호1                       StartPos 0, Length 20
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 20, Length 8
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 28, Length 10
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 38, Length 10
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 48, Length 9
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 57, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 69, Length 40
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 109, Length 10
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 119, Length 1
        public string MrcTpNm; // [MrcTpNm,   10] 정정취소구분명                  StartPos 120, Length 10
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 130, Length 2
        public string FnoOrdprcPtnNm; // [FnoOrdprcPtnNm,   40] 선물옵션호가유형명              StartPos 132, Length 40
        public decimal OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 172, Length 13
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 185, Length 16
        public string OrdTpNm; // [OrdTpNm,   10] 주문구분명                      StartPos 201, Length 10
        public string ExecTpNm; // [ExecTpNm,   10] 체결구분명                      StartPos 211, Length 10
        public decimal ExecPrc; // [ExecPrc, 13.2] 체결가                          StartPos 221, Length 13
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 234, Length 16
        public string CtrctTime; // [CtrctTime,    9] 약정시각                        StartPos 250, Length 9
        public long CtrctNo; // [CtrctNo  ,   10] 약정번호                        StartPos 259, Length 10
        public long ExecNo; // [ExecNo  ,   10] 체결번호                        StartPos 269, Length 10
        public long BnsplAmt; // [BnsplAmt  ,   16] 매매손익금액                    StartPos 279, Length 16
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 295, Length 16
        public string UserId; // [UserId,   16] 사용자ID                        StartPos 311, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 327, Length 2
        public string CommdaCodeNm; // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 329, Length 40
        public string IpAddr; // [IpAddr,   16] IP주소                          StartPos 369, Length 16
        public string TrdPtnTpNm; // [TrdPtnTpNm,   20] 거래유형구분                    StartPos 385, Length 20
        public string GrpId; // [GrpId,   20] 그룹ID                          StartPos 405, Length 20
    }
}