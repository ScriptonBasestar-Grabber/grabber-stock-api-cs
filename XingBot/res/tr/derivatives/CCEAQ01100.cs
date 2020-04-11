namespace XingBot.res_derivatives
{
    // 선물옵션 CME 매매거래현황 조회 ( SERVICE=CCEAQ01100,HEADTYPE=B,CREATOR=원종혁,CREDATE=2019/04/03 16:08:04 )
    public class _CCEAQ01100InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt{ get; set; } // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt{ get; set; } // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string StnlnSeqTp{ get; set; } // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 49, Length 1
    }

    public class _CCEAQ01100OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 45, Length 16
        public long FnoCtrctAmt{ get; set; } // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 61, Length 16
        public long CmsnAmtSumAmt{ get; set; } // [CmsnAmtSumAmt  ,   16] 수수료합계금액                  StartPos 77, Length 16
    }

    public class _CCEAQ01100OutBlock3
    {
        public string BnsDt{ get; set; } // [BnsDt,    8] 매매일                          StartPos 0, Length 8
        public long OrdNo{ get; set; } // [OrdNo  ,   10] 주문번호                        StartPos 8, Length 10
        public long CtrctNo{ get; set; } // [CtrctNo  ,   10] 약정번호                        StartPos 18, Length 10
        public long ExecNo{ get; set; } // [ExecNo  ,   10] 체결번호                        StartPos 28, Length 10
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 38, Length 12
        public string IsuNm{ get; set; } // [IsuNm,   40] 종목명                          StartPos 50, Length 40
        public string BnsTpCode{ get; set; } // [BnsTpCode,    1] 매매구분                        StartPos 90, Length 1
        public string BnsTpNm{ get; set; } // [BnsTpNm,   10] 매매구분                        StartPos 91, Length 10
        public decimal BgnCtrctIdxExecPrc{ get; set; } // [BgnCtrctIdxExecPrc, 13.2] 당초약정지수체결가              StartPos 101, Length 13
        public long BgnAmt{ get; set; } // [BgnAmt  ,   16] 당초금액                        StartPos 114, Length 16
        public long CtrctQty{ get; set; } // [CtrctQty  ,   16] 약정수량                        StartPos 130, Length 16
        public decimal ExecPrc{ get; set; } // [ExecPrc, 13.2] 체결가                          StartPos 146, Length 13
        public long CtrctAmt{ get; set; } // [CtrctAmt  ,   16] 약정금액                        StartPos 159, Length 16
        public long CmsnAmt{ get; set; } // [CmsnAmt  ,   16] 수수료금액                      StartPos 175, Length 16
        public long BnsplAmt{ get; set; } // [BnsplAmt  ,   16] 매매손익금액                    StartPos 191, Length 16
        public string CmsnAddupCode{ get; set; } // [CmsnAddupCode,    2] 수수료합산코드                  StartPos 207, Length 2
        public string CommdaCodeNm{ get; set; } // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 209, Length 40
    }
}