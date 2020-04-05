namespace XingBot.res
{
    // EUREX 야간옵션 기간주문체결조회 ( SERVICE=CEXAQ44200,HEADTYPE=B,CREATOR=,CREDATE=2012/11/08 17:10:28 )
    internal struct _CEXAQ44200InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 50, Length 1
        public string FnoTrdPtnCode; // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 51, Length 2
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 53, Length 10
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 63, Length 1
    }

    internal struct _CEXAQ44200OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string ChoicInptTpCode; // [ChoicInptTpCode,    1] 선택입력구분                    StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 6, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 26, Length 8
        public string QrySrtDt; // [QrySrtDt,    8] 조회시작일                      StartPos 34, Length 8
        public string QryEndDt; // [QryEndDt,    8] 조회종료일                      StartPos 42, Length 8
        public string PrdtExecTpCode; // [PrdtExecTpCode,    1] 체결구분                        StartPos 50, Length 1
        public string FnoTrdPtnCode; // [FnoTrdPtnCode,    2] 선물옵션거래유형코드            StartPos 51, Length 2
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 53, Length 10
        public string StnlnSeqTp; // [StnlnSeqTp,    1] 정렬순서구분                    StartPos 63, Length 1
    }

    internal struct _CEXAQ44200OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 5, Length 16
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 21, Length 16
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 37, Length 16
        public double ExecPrc; // [ExecPrc, 15.2] 체결가                          StartPos 53, Length 15
    }

    internal struct _CEXAQ44200OutBlock3
    {
        public string AcntNo1; // [AcntNo1,   20] 계좌번호1                       StartPos 0, Length 20
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 20, Length 40
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 60, Length 8
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 68, Length 10
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 78, Length 10
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 88, Length 9
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 97, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 109, Length 40
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 149, Length 10
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 159, Length 1
        public string ErxOrdprcTpCode; // [ErxOrdprcTpCode,    1] 유렉스호가구분코드              StartPos 160, Length 1
        public string MrcTpNm; // [MrcTpNm,   10] 정정취소구분명                  StartPos 161, Length 10
        public string ErxPrcCndiTpCode; // [ErxPrcCndiTpCode,    1] 유렉스가격조건구분코드          StartPos 171, Length 1
        public string CodeNm; // [CodeNm,   40] 코드명                          StartPos 172, Length 40
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 212, Length 13
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 225, Length 16
        public string FnoRjtRsnCode; // [FnoRjtRsnCode,    3] 선물옵션거부사유코드            StartPos 241, Length 3
        public string OrdTpNm; // [OrdTpNm,   10] 주문구분명                      StartPos 244, Length 10
        public string ExecTpNm; // [ExecTpNm,   10] 체결구분명                      StartPos 254, Length 10
        public double ExecPrc; // [ExecPrc, 13.2] 체결가                          StartPos 264, Length 13
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 277, Length 16
        public string ExecTime; // [ExecTime,    9] 체결시각                        StartPos 293, Length 9
        public long ExecNo; // [ExecNo  ,   10] 체결번호                        StartPos 302, Length 10
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 312, Length 16
        public string UserId; // [UserId,   16] 사용자ID                        StartPos 328, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 344, Length 2
        public string CommdaCodeNm; // [CommdaCodeNm,   40] 통신매체코드명                  StartPos 346, Length 40
        public string IpAddr; // [IpAddr,   16] IP주소                          StartPos 386, Length 16
        public string TrdPtnTpNm; // [TrdPtnTpNm,   20] 거래유형구분                    StartPos 402, Length 20
        public string ErxOrdStatCode; // [ErxOrdStatCode,    1] 유렉스주문상태코드              StartPos 422, Length 1
        public string CodeNm0; // [CodeNm0,   40] 코드명0                         StartPos 423, Length 40
        public string ExchRcptTime; // [ExchRcptTime,   30] 거래소접수시각                  StartPos 463, Length 30
    }
}