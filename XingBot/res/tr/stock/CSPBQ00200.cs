namespace XingBot.res
{
    // 현물계좌 증거금률별 주문가능수량 조회 ( SERVICE=CSPBQ00200,HEADTYPE=B,CREATOR=이상은,CREDATE=2011/12/12 09:22:25 )
    public struct _CSPBQ00200InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 6, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 26, Length 8
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 34, Length 12
        public decimal OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 46, Length 15
        public string RegCommdaCode; // [RegCommdaCode,    2] 통신매체코드                    StartPos 61, Length 2
    }

    public struct _CSPBQ00200OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 5, Length 1
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 6, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 26, Length 8
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 34, Length 12
        public decimal OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 46, Length 15
        public string RegCommdaCode; // [RegCommdaCode,    2] 통신매체코드                    StartPos 61, Length 2
    }

    public struct _CSPBQ00200OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 45, Length 40
        public long Dps; // [Dps  ,   16] 예수금                          StartPos 85, Length 16
        public long SubstAmt; // [SubstAmt  ,   16] 대용금액                        StartPos 101, Length 16
        public long CrdtPldgRuseAmt; // [CrdtPldgRuseAmt  ,   16] 신용담보재사용금액              StartPos 117, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 133, Length 16
        public long SubstOrdAbleAmt; // [SubstOrdAbleAmt  ,   16] 대용주문가능금액                StartPos 149, Length 16
        public long MnyMgn; // [MnyMgn  ,   16] 현금증거금액                    StartPos 165, Length 16
        public long SubstMgn; // [SubstMgn  ,   16] 대용증거금액                    StartPos 181, Length 16
        public long SeOrdAbleAmt; // [SeOrdAbleAmt  ,   16] 거래소금액                      StartPos 197, Length 16
        public long KdqOrdAbleAmt; // [KdqOrdAbleAmt  ,   16] 코스닥금액                      StartPos 213, Length 16
        public long PrsmptDpsD1; // [PrsmptDpsD1  ,   16] 추정예수금(D+1)                 StartPos 229, Length 16
        public long PrsmptDpsD2; // [PrsmptDpsD2  ,   16] 추정예수금(D+2)                 StartPos 245, Length 16
        public long MnyoutAbleAmt; // [MnyoutAbleAmt  ,   16] 출금가능금액                    StartPos 261, Length 16
        public long RcvblAmt; // [RcvblAmt  ,   16] 미수금액                        StartPos 277, Length 16
        public decimal CmsnRat; // [CmsnRat, 15.5] 수수료율                        StartPos 293, Length 15
        public long AddLevyAmt; // [AddLevyAmt  ,   16] 추가징수금액                    StartPos 308, Length 16
        public long RuseObjAmt; // [RuseObjAmt  ,   16] 재사용대상금액                  StartPos 324, Length 16
        public long MnyRuseObjAmt; // [MnyRuseObjAmt  ,   16] 현금재사용대상금액              StartPos 340, Length 16
        public decimal FirmMgnRat; // [FirmMgnRat,  7.4] 이용사증거금률                  StartPos 356, Length 7
        public long SubstRuseObjAmt; // [SubstRuseObjAmt  ,   16] 대용재사용대상금액              StartPos 363, Length 16
        public decimal IsuMgnRat; // [IsuMgnRat,  7.4] 종목증거금률                    StartPos 379, Length 7
        public decimal AcntMgnRat; // [AcntMgnRat,  7.4] 계좌증거금률                    StartPos 386, Length 7
        public decimal TrdMgnrt; // [TrdMgnrt,  7.4] 거래증거금률                    StartPos 393, Length 7
        public long Cmsn; // [Cmsn  ,   16] 수수료                          StartPos 400, Length 16
        public long MgnRat20pctOrdAbleAmt; // [MgnRat20pctOrdAbleAmt  ,   16] 증거금률20퍼센트주문가능금액    StartPos 416, Length 16
        public long MgnRat20OrdAbleQty; // [MgnRat20OrdAbleQty  ,   16] 증거금률100퍼센트현금주문가능수 StartPos 432, Length 16
        public long MgnRat30pctOrdAbleAmt; // [MgnRat30pctOrdAbleAmt  ,   16] 증거금률30퍼센트주문가능금액    StartPos 448, Length 16
        public long MgnRat30OrdAbleQty; // [MgnRat30OrdAbleQty  ,   16] 증거금률30퍼센트주문가능수량??  StartPos 464, Length 16
        public long MgnRat40pctOrdAbleAmt; // [MgnRat40pctOrdAbleAmt  ,   16] 증거금률40퍼센트주문가능금액    StartPos 480, Length 16
        public long MgnRat40OrdAbleQty; // [MgnRat40OrdAbleQty  ,   16] 증거금률40퍼센트주문가능수량??  StartPos 496, Length 16

        public long
            MgnRat100pctOrdAbleAmt; // [MgnRat100pctOrdAbleAmt  ,   16] 증거금률100퍼센트주문가능금액   StartPos 512, Length 16

        public long MgnRat100OrdAbleQty; // [MgnRat100OrdAbleQty  ,   16] 증거금률100퍼센트주문가능수량?? StartPos 528, Length 16

        public long
            MgnRat100MnyOrdAbleAmt; // [MgnRat100MnyOrdAbleAmt  ,   16] 증거금률100퍼센트현금주문가능금 StartPos 544, Length 16

        public long
            MgnRat100MnyOrdAbleQty; // [MgnRat100MnyOrdAbleQty  ,   16] 증거금률100퍼센트현금주문가능수 StartPos 560, Length 16

        public long
            MgnRat20pctRuseAbleAmt; // [MgnRat20pctRuseAbleAmt  ,   16] 증거금률20퍼센트재사용가능금액  StartPos 576, Length 16

        public long
            MgnRat30pctRuseAbleAmt; // [MgnRat30pctRuseAbleAmt  ,   16] 증거금률30퍼센트재사용가능금액  StartPos 592, Length 16

        public long
            MgnRat40pctRuseAbleAmt; // [MgnRat40pctRuseAbleAmt  ,   16] 증거금률40퍼센트재사용가능금액  StartPos 608, Length 16

        public long
            MgnRat100pctRuseAbleAmt; // [MgnRat100pctRuseAbleAmt  ,   16] 증거금률100퍼센트재사용가능금액 StartPos 624, Length 16

        public long OrdAbleQty; // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 640, Length 16
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 656, Length 16
    }
}