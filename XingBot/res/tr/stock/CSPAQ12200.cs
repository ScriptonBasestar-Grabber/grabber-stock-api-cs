namespace XingBot.res.tr
{
    // 현물계좌 예수금/주문가능금액/총평가 조회(API) ( SERVICE=CSPAQ12200,HEADTYPE=B,CREATOR=이상은,CREDATE=2015/04/13 08:41:27 )
    internal struct _CSPAQ12200InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string MgmtBrnNo; // [MgmtBrnNo,    3] 관리지점번호                    StartPos 5, Length 3
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 8, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 28, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 36, Length 1
    }

    internal struct _CSPAQ12200OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string MgmtBrnNo; // [MgmtBrnNo,    3] 관리지점번호                    StartPos 5, Length 3
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 8, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 28, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 36, Length 1
    }

    internal struct _CSPAQ12200OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 5, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 45, Length 40
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 85, Length 16
        public long MnyoutAbleAmt; // [MnyoutAbleAmt  ,   16] 출금가능금액                    StartPos 101, Length 16
        public long SeOrdAbleAmt; // [SeOrdAbleAmt  ,   16] 거래소금액                      StartPos 117, Length 16
        public long KdqOrdAbleAmt; // [KdqOrdAbleAmt  ,   16] 코스닥금액                      StartPos 133, Length 16
        public long BalEvalAmt; // [BalEvalAmt  ,   16] 잔고평가금액                    StartPos 149, Length 16
        public long RcvblAmt; // [RcvblAmt  ,   16] 미수금액                        StartPos 165, Length 16
        public long DpsastTotamt; // [DpsastTotamt  ,   16] 예탁자산총액                    StartPos 181, Length 16
        public double PnlRat; // [PnlRat, 18.6] 손익율                          StartPos 197, Length 18
        public long InvstOrgAmt; // [InvstOrgAmt  ,   20] 투자원금                        StartPos 215, Length 20
        public long InvstPlAmt; // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 235, Length 16
        public long CrdtPldgOrdAmt; // [CrdtPldgOrdAmt  ,   16] 신용담보주문금액                StartPos 251, Length 16
        public long Dps; // [Dps  ,   16] 예수금                          StartPos 267, Length 16
        public long SubstAmt; // [SubstAmt  ,   16] 대용금액                        StartPos 283, Length 16
        public long D1Dps; // [D1Dps  ,   16] D1예수금                        StartPos 299, Length 16
        public long D2Dps; // [D2Dps  ,   16] D2예수금                        StartPos 315, Length 16
        public long MnyrclAmt; // [MnyrclAmt  ,   16] 현금미수금액                    StartPos 331, Length 16
        public long MgnMny; // [MgnMny  ,   16] 증거금현금                      StartPos 347, Length 16
        public long MgnSubst; // [MgnSubst  ,   16] 증거금대용                      StartPos 363, Length 16
        public long ChckAmt; // [ChckAmt  ,   16] 수표금액                        StartPos 379, Length 16
        public long SubstOrdAbleAmt; // [SubstOrdAbleAmt  ,   16] 대용주문가능금액                StartPos 395, Length 16

        public long
            MgnRat100pctOrdAbleAmt; // [MgnRat100pctOrdAbleAmt  ,   16] 증거금률100퍼센트주문가능금액   StartPos 411, Length 16

        public long MgnRat35ordAbleAmt; // [MgnRat35ordAbleAmt  ,   16] 증거금률35%주문가능금액         StartPos 427, Length 16
        public long MgnRat50ordAbleAmt; // [MgnRat50ordAbleAmt  ,   16] 증거금률50%주문가능금액         StartPos 443, Length 16
        public long PrdaySellAdjstAmt; // [PrdaySellAdjstAmt  ,   16] 전일매도정산금액                StartPos 459, Length 16
        public long PrdayBuyAdjstAmt; // [PrdayBuyAdjstAmt  ,   16] 전일매수정산금액                StartPos 475, Length 16
        public long CrdaySellAdjstAmt; // [CrdaySellAdjstAmt  ,   16] 금일매도정산금액                StartPos 491, Length 16
        public long CrdayBuyAdjstAmt; // [CrdayBuyAdjstAmt  ,   16] 금일매수정산금액                StartPos 507, Length 16
        public long D1ovdRepayRqrdAmt; // [D1ovdRepayRqrdAmt  ,   16] D1연체변제소요금액              StartPos 523, Length 16
        public long D2ovdRepayRqrdAmt; // [D2ovdRepayRqrdAmt  ,   16] D2연체변제소요금액              StartPos 539, Length 16

        public long
            D1PrsmptWthdwAbleAmt; // [D1PrsmptWthdwAbleAmt  ,   16] D1추정인출가능금액              StartPos 555, Length 16

        public long
            D2PrsmptWthdwAbleAmt; // [D2PrsmptWthdwAbleAmt  ,   16] D2추정인출가능금액              StartPos 571, Length 16

        public long DpspdgLoanAmt; // [DpspdgLoanAmt  ,   16] 예탁담보대출금액                StartPos 587, Length 16
        public long Imreq; // [Imreq  ,   16] 신용설정보증금                  StartPos 603, Length 16
        public long MloanAmt; // [MloanAmt  ,   16] 융자금액                        StartPos 619, Length 16
        public double ChgAfPldgRat; // [ChgAfPldgRat,  9.3] 변경후담보비율                  StartPos 635, Length 9
        public long OrgPldgAmt; // [OrgPldgAmt  ,   16] 원담보금액                      StartPos 644, Length 16
        public long SubPldgAmt; // [SubPldgAmt  ,   16] 부담보금액                      StartPos 660, Length 16
        public long RqrdPldgAmt; // [RqrdPldgAmt  ,   16] 소요담보금액                    StartPos 676, Length 16
        public long OrgPdlckAmt; // [OrgPdlckAmt  ,   16] 원담보부족금액                  StartPos 692, Length 16
        public long PdlckAmt; // [PdlckAmt  ,   16] 담보부족금액                    StartPos 708, Length 16
        public long AddPldgMny; // [AddPldgMny  ,   16] 추가담보현금                    StartPos 724, Length 16
        public long D1OrdAbleAmt; // [D1OrdAbleAmt  ,   16] D1주문가능금액                  StartPos 740, Length 16
        public long CrdtIntdltAmt; // [CrdtIntdltAmt  ,   16] 신용이자미납금액                StartPos 756, Length 16
        public long EtclndAmt; // [EtclndAmt  ,   16] 기타대여금액                    StartPos 772, Length 16
        public long NtdayPrsmptCvrgAmt; // [NtdayPrsmptCvrgAmt  ,   16] 익일추정반대매매금액            StartPos 788, Length 16
        public long OrgPldgSumAmt; // [OrgPldgSumAmt  ,   16] 원담보합계금액                  StartPos 804, Length 16
        public long CrdtOrdAbleAmt; // [CrdtOrdAbleAmt  ,   16] 신용주문가능금액                StartPos 820, Length 16
        public long SubPldgSumAmt; // [SubPldgSumAmt  ,   16] 부담보합계금액                  StartPos 836, Length 16
        public long CrdtPldgAmtMny; // [CrdtPldgAmtMny  ,   16] 신용담보금현금                  StartPos 852, Length 16
        public long CrdtPldgSubstAmt; // [CrdtPldgSubstAmt  ,   16] 신용담보대용금액                StartPos 868, Length 16
        public long AddCrdtPldgMny; // [AddCrdtPldgMny  ,   16] 추가신용담보현금                StartPos 884, Length 16
        public long CrdtPldgRuseAmt; // [CrdtPldgRuseAmt  ,   16] 신용담보재사용금액              StartPos 900, Length 16
        public long AddCrdtPldgSubst; // [AddCrdtPldgSubst  ,   16] 추가신용담보대용                StartPos 916, Length 16
        public long CslLoanAmtdt1; // [CslLoanAmtdt1  ,   16] 매도대금담보대출금액            StartPos 932, Length 16
        public long DpslRestrcAmt; // [DpslRestrcAmt  ,   16] 처분제한금액                    StartPos 948, Length 16
    }
}