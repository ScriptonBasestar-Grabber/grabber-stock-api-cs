namespace XingBot.res
{
    // 현물계좌예수금 주문가능금액 총평가2 ( SERVICE=CSPAQ22200,HEADTYPE=B,CREATOR=송우석,CREDATE=2020/02/25 08:21:10 )
    public struct _CSPAQ22200InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string MgmtBrnNo; // [MgmtBrnNo,    3] 관리지점번호                    StartPos 5, Length 3
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 8, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 28, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 36, Length 1
    }

    public struct _CSPAQ22200OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string MgmtBrnNo; // [MgmtBrnNo,    3] 관리지점번호                    StartPos 5, Length 3
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 8, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 28, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 36, Length 1
    }

    public struct _CSPAQ22200OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 5, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 45, Length 40
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 85, Length 16
        public long SubstOrdAbleAmt; // [SubstOrdAbleAmt  ,   16] 대용주문가능금액                StartPos 101, Length 16
        public long SeOrdAbleAmt; // [SeOrdAbleAmt  ,   16] 거래소금액                      StartPos 117, Length 16
        public long KdqOrdAbleAmt; // [KdqOrdAbleAmt  ,   16] 코스닥금액                      StartPos 133, Length 16
        public long CrdtPldgOrdAmt; // [CrdtPldgOrdAmt  ,   16] 신용담보주문금액                StartPos 149, Length 16

        public long
            MgnRat100pctOrdAbleAmt; // [MgnRat100pctOrdAbleAmt  ,   16] 증거금률100퍼센트주문가능금액   StartPos 165, Length 16

        public long MgnRat35ordAbleAmt; // [MgnRat35ordAbleAmt  ,   16] 증거금률35%주문가능금액         StartPos 181, Length 16
        public long MgnRat50ordAbleAmt; // [MgnRat50ordAbleAmt  ,   16] 증거금률50%주문가능금액         StartPos 197, Length 16
        public long CrdtOrdAbleAmt; // [CrdtOrdAbleAmt  ,   16] 신용주문가능금액                StartPos 213, Length 16
        public long Dps; // [Dps  ,   16] 예수금                          StartPos 229, Length 16
        public long SubstAmt; // [SubstAmt  ,   16] 대용금액                        StartPos 245, Length 16
        public long MgnMny; // [MgnMny  ,   16] 증거금현금                      StartPos 261, Length 16
        public long MgnSubst; // [MgnSubst  ,   16] 증거금대용                      StartPos 277, Length 16
        public long D1Dps; // [D1Dps  ,   16] D1예수금                        StartPos 293, Length 16
        public long D2Dps; // [D2Dps  ,   16] D2예수금                        StartPos 309, Length 16
        public long RcvblAmt; // [RcvblAmt  ,   16] 미수금액                        StartPos 325, Length 16
        public long D1ovdRepayRqrdAmt; // [D1ovdRepayRqrdAmt  ,   16] D1연체변제소요금액              StartPos 341, Length 16
        public long D2ovdRepayRqrdAmt; // [D2ovdRepayRqrdAmt  ,   16] D2연체변제소요금액              StartPos 357, Length 16
        public long MloanAmt; // [MloanAmt  ,   16] 융자금액                        StartPos 373, Length 16
        public decimal ChgAfPldgRat; // [ChgAfPldgRat,  9.3] 변경후담보비율                  StartPos 389, Length 9
        public long RqrdPldgAmt; // [RqrdPldgAmt  ,   16] 소요담보금액                    StartPos 398, Length 16
        public long PdlckAmt; // [PdlckAmt  ,   16] 담보부족금액                    StartPos 414, Length 16
        public long OrgPldgSumAmt; // [OrgPldgSumAmt  ,   16] 원담보합계금액                  StartPos 430, Length 16
        public long SubPldgSumAmt; // [SubPldgSumAmt  ,   16] 부담보합계금액                  StartPos 446, Length 16
        public long CrdtPldgAmtMny; // [CrdtPldgAmtMny  ,   16] 신용담보금현금                  StartPos 462, Length 16
        public long CrdtPldgSubstAmt; // [CrdtPldgSubstAmt  ,   16] 신용담보대용금액                StartPos 478, Length 16
        public long Imreq; // [Imreq  ,   16] 신용설정보증금                  StartPos 494, Length 16
        public long CrdtPldgRuseAmt; // [CrdtPldgRuseAmt  ,   16] 신용담보재사용금액              StartPos 510, Length 16
        public long DpslRestrcAmt; // [DpslRestrcAmt  ,   16] 처분제한금액                    StartPos 526, Length 16
        public long PrdaySellAdjstAmt; // [PrdaySellAdjstAmt  ,   16] 전일매도정산금액                StartPos 542, Length 16
        public long PrdayBuyAdjstAmt; // [PrdayBuyAdjstAmt  ,   16] 전일매수정산금액                StartPos 558, Length 16
        public long CrdaySellAdjstAmt; // [CrdaySellAdjstAmt  ,   16] 금일매도정산금액                StartPos 574, Length 16
        public long CrdayBuyAdjstAmt; // [CrdayBuyAdjstAmt  ,   16] 금일매수정산금액                StartPos 590, Length 16
        public long CslLoanAmtdt1; // [CslLoanAmtdt1  ,   16] 매도대금담보대출금액            StartPos 606, Length 16
    }
}