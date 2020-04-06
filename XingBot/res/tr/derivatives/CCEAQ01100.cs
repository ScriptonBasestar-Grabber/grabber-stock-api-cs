namespace XingBot.res_derivatives
{
    // 선물옵션 CME 매매거래현황 조회 ( SERVICE=CCEAQ01100,HEADTYPE=B,CREATOR=원종혁,CREDATE=2019/04/03 16:08:04 )
    public struct _CCEAQ01100InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 33, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 41, Length 8
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 49, Length 1
    }

    public struct _CCEAQ01100OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long BnsplAmt; // [BnsplAmt  ,   16] 매매손익금액                    StartPos 45, Length 16
        public long FnoCtrctAmt; // [FnoCtrctAmt  ,   16] 선물옵션약정금액                StartPos 61, Length 16
        public long CmsnAmtSumAmt; // [CmsnAmtSumAmt  ,   16] 수수료합계금액                  StartPos 77, Length 16
    }

    public struct _CCEAQ01100OutBlock3
    {
        public string BnsDt; // [BnsDt,    8] 매매일                          StartPos 0, Length 8
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 8, Length 10
        public long CtrctNo; // [CtrctNo  ,   10] 약정번호                        StartPos 18, Length 10
        public long ExecNo; // [ExecNo  ,   10] 체결번호                        StartPos 28, Length 10
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 38, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 50, Length 40
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 90, Length 1
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 91, Length 10
        public decimal BgnCtrctIdxExecPrc; // [BgnCtrctIdxExecPrc, 13.2] 당초약정지수체결가              StartPos 101, Length 13
        public long BgnAmt; // [BgnAmt  ,   16] 당초금액                        StartPos 114, Length 16
        public long CtrctQty; // [CtrctQty  ,   16] 약정수량                        StartPos 130, Length 16
        public decimal ExecPrc; // [ExecPrc, 13.2] 체결가                          StartPos 146, Length 13
        public long CtrctAmt; // [CtrctAmt  ,   16] 약정금액                        StartPos 159, Length 16
        public long CmsnAmt; // [CmsnAmt  ,   16] 수수료금액                      StartPos 175, Length 16
        public long BnsplAmt; // [BnsplAmt  ,   16] 매매손익금액                    StartPos 191, Length 16
        public string CmsnAddupCode; // [CmsnAddupCode,    2] 수수료합산코드                  StartPos 207, Length 2
        public string CommdaCodeNm; // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 209, Length 40
    }
}