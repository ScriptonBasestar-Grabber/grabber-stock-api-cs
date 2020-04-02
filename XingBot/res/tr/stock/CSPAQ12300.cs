using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 현물계좌 잔고내역 조회(API) ( SERVICE=CSPAQ12300,HEADTYPE=B,CREATOR=이상은,CREDATE=2015/04/13 08:43:20 )
    struct _CSPAQ12300InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 33, Length 1
        public string CmsnAppTpCode; // [CmsnAppTpCode,    1] 수수료적용구분                  StartPos 34, Length 1
        public string D2balBaseQryTp; // [D2balBaseQryTp,    1] D2잔고기준조회구분              StartPos 35, Length 1
        public string UprcTpCode; // [UprcTpCode,    1] 단가구분                        StartPos 36, Length 1
    }

    struct _CSPAQ12300OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BalCreTp; // [BalCreTp,    1] 잔고생성구분                    StartPos 33, Length 1
        public string CmsnAppTpCode; // [CmsnAppTpCode,    1] 수수료적용구분                  StartPos 34, Length 1
        public string D2balBaseQryTp; // [D2balBaseQryTp,    1] D2잔고기준조회구분              StartPos 35, Length 1
        public string UprcTpCode; // [UprcTpCode,    1] 단가구분                        StartPos 36, Length 1
    }

    struct _CSPAQ12300OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 5, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 45, Length 40
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 85, Length 16
        public long MnyoutAbleAmt; // [MnyoutAbleAmt  ,   16] 출금가능금액                    StartPos 101, Length 16
        public long SeOrdAbleAmt; // [SeOrdAbleAmt  ,   16] 거래소금액                      StartPos 117, Length 16
        public long KdqOrdAbleAmt; // [KdqOrdAbleAmt  ,   16] 코스닥금액                      StartPos 133, Length 16
        public long HtsOrdAbleAmt; // [HtsOrdAbleAmt  ,   16] HTS주문가능금액                 StartPos 149, Length 16

        public long
            MgnRat100pctOrdAbleAmt; // [MgnRat100pctOrdAbleAmt  ,   16] 증거금률100퍼센트주문가능금액   StartPos 165, Length 16

        public long BalEvalAmt; // [BalEvalAmt  ,   16] 잔고평가금액                    StartPos 181, Length 16
        public long PchsAmt; // [PchsAmt  ,   16] 매입금액                        StartPos 197, Length 16
        public long RcvblAmt; // [RcvblAmt  ,   16] 미수금액                        StartPos 213, Length 16
        public double PnlRat; // [PnlRat, 18.6] 손익율                          StartPos 229, Length 18
        public long InvstOrgAmt; // [InvstOrgAmt  ,   20] 투자원금                        StartPos 247, Length 20
        public long InvstPlAmt; // [InvstPlAmt  ,   16] 투자손익금액                    StartPos 267, Length 16
        public long CrdtPldgOrdAmt; // [CrdtPldgOrdAmt  ,   16] 신용담보주문금액                StartPos 283, Length 16
        public long Dps; // [Dps  ,   16] 예수금                          StartPos 299, Length 16
        public long D1Dps; // [D1Dps  ,   16] D1예수금                        StartPos 315, Length 16
        public long D2Dps; // [D2Dps  ,   16] D2예수금                        StartPos 331, Length 16
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 347, Length 8
        public long MnyMgn; // [MnyMgn  ,   16] 현금증거금액                    StartPos 355, Length 16
        public long SubstMgn; // [SubstMgn  ,   16] 대용증거금액                    StartPos 371, Length 16
        public long SubstAmt; // [SubstAmt  ,   16] 대용금액                        StartPos 387, Length 16
        public long PrdayBuyExecAmt; // [PrdayBuyExecAmt  ,   16] 전일매수체결금액                StartPos 403, Length 16
        public long PrdaySellExecAmt; // [PrdaySellExecAmt  ,   16] 전일매도체결금액                StartPos 419, Length 16
        public long CrdayBuyExecAmt; // [CrdayBuyExecAmt  ,   16] 금일매수체결금액                StartPos 435, Length 16
        public long CrdaySellExecAmt; // [CrdaySellExecAmt  ,   16] 금일매도체결금액                StartPos 451, Length 16
        public long EvalPnlSum; // [EvalPnlSum  ,   15] 평가손익합계                    StartPos 467, Length 15
        public long DpsastTotamt; // [DpsastTotamt  ,   16] 예탁자산총액                    StartPos 482, Length 16
        public long Evrprc; // [Evrprc  ,   19] 제비용                          StartPos 498, Length 19
        public long RuseAmt; // [RuseAmt  ,   16] 재사용금액                      StartPos 517, Length 16
        public long EtclndAmt; // [EtclndAmt  ,   16] 기타대여금액                    StartPos 533, Length 16
        public long PrcAdjstAmt; // [PrcAdjstAmt  ,   16] 가정산금액                      StartPos 549, Length 16
        public long D1CmsnAmt; // [D1CmsnAmt  ,   16] D1수수료                        StartPos 565, Length 16
        public long D2CmsnAmt; // [D2CmsnAmt  ,   16] D2수수료                        StartPos 581, Length 16
        public long D1EvrTax; // [D1EvrTax  ,   16] D1제세금                        StartPos 597, Length 16
        public long D2EvrTax; // [D2EvrTax  ,   16] D2제세금                        StartPos 613, Length 16
        public long D1SettPrergAmt; // [D1SettPrergAmt  ,   16] D1결제예정금액                  StartPos 629, Length 16
        public long D2SettPrergAmt; // [D2SettPrergAmt  ,   16] D2결제예정금액                  StartPos 645, Length 16
        public long PrdayKseMnyMgn; // [PrdayKseMnyMgn  ,   16] 전일KSE현금증거금               StartPos 661, Length 16
        public long PrdayKseSubstMgn; // [PrdayKseSubstMgn  ,   16] 전일KSE대용증거금               StartPos 677, Length 16
        public long PrdayKseCrdtMnyMgn; // [PrdayKseCrdtMnyMgn  ,   16] 전일KSE신용현금증거금           StartPos 693, Length 16

        public long
            PrdayKseCrdtSubstMgn; // [PrdayKseCrdtSubstMgn  ,   16] 전일KSE신용대용증거금           StartPos 709, Length 16

        public long CrdayKseMnyMgn; // [CrdayKseMnyMgn  ,   16] 금일KSE현금증거금               StartPos 725, Length 16
        public long CrdayKseSubstMgn; // [CrdayKseSubstMgn  ,   16] 금일KSE대용증거금               StartPos 741, Length 16
        public long CrdayKseCrdtMnyMgn; // [CrdayKseCrdtMnyMgn  ,   16] 금일KSE신용현금증거금           StartPos 757, Length 16

        public long
            CrdayKseCrdtSubstMgn; // [CrdayKseCrdtSubstMgn  ,   16] 금일KSE신용대용증거금           StartPos 773, Length 16

        public long PrdayKdqMnyMgn; // [PrdayKdqMnyMgn  ,   16] 전일코스닥현금증거금            StartPos 789, Length 16
        public long PrdayKdqSubstMgn; // [PrdayKdqSubstMgn  ,   16] 전일코스닥대용증거금            StartPos 805, Length 16
        public long PrdayKdqCrdtMnyMgn; // [PrdayKdqCrdtMnyMgn  ,   16] 전일코스닥신용현금증거금        StartPos 821, Length 16
        public long PrdayKdqCrdtSubstMgn; // [PrdayKdqCrdtSubstMgn  ,   16] 전일코스닥신용대용증거금        StartPos 837, Length 16
        public long CrdayKdqMnyMgn; // [CrdayKdqMnyMgn  ,   16] 금일코스닥현금증거금            StartPos 853, Length 16
        public long CrdayKdqSubstMgn; // [CrdayKdqSubstMgn  ,   16] 금일코스닥대용증거금            StartPos 869, Length 16
        public long CrdayKdqCrdtMnyMgn; // [CrdayKdqCrdtMnyMgn  ,   16] 금일코스닥신용현금증거금        StartPos 885, Length 16
        public long CrdayKdqCrdtSubstMgn; // [CrdayKdqCrdtSubstMgn  ,   16] 금일코스닥신용대용증거금        StartPos 901, Length 16
        public long PrdayFrbrdMnyMgn; // [PrdayFrbrdMnyMgn  ,   16] 전일프리보드현금증거금          StartPos 917, Length 16
        public long PrdayFrbrdSubstMgn; // [PrdayFrbrdSubstMgn  ,   16] 전일프리보드대용증거금          StartPos 933, Length 16
        public long CrdayFrbrdMnyMgn; // [CrdayFrbrdMnyMgn  ,   16] 금일프리보드현금증거금          StartPos 949, Length 16
        public long CrdayFrbrdSubstMgn; // [CrdayFrbrdSubstMgn  ,   16] 금일프리보드대용증거금          StartPos 965, Length 16
        public long PrdayCrbmkMnyMgn; // [PrdayCrbmkMnyMgn  ,   16] 전일장외현금증거금              StartPos 981, Length 16
        public long PrdayCrbmkSubstMgn; // [PrdayCrbmkSubstMgn  ,   16] 전일장외대용증거금              StartPos 997, Length 16
        public long CrdayCrbmkMnyMgn; // [CrdayCrbmkMnyMgn  ,   16] 금일장외현금증거금              StartPos 1013, Length 16
        public long CrdayCrbmkSubstMgn; // [CrdayCrbmkSubstMgn  ,   16] 금일장외대용증거금              StartPos 1029, Length 16
        public long DpspdgQty; // [DpspdgQty  ,   16] 예탁담보수량                    StartPos 1045, Length 16
        public long BuyAdjstAmtD2; // [BuyAdjstAmtD2  ,   16] 매수정산금(D+2)                 StartPos 1061, Length 16
        public long SellAdjstAmtD2; // [SellAdjstAmtD2  ,   16] 매도정산금(D+2)                 StartPos 1077, Length 16
        public long RepayRqrdAmtD1; // [RepayRqrdAmtD1  ,   16] 변제소요금(D+1)                 StartPos 1093, Length 16
        public long RepayRqrdAmtD2; // [RepayRqrdAmtD2  ,   16] 변제소요금(D+2)                 StartPos 1109, Length 16
        public long LoanAmt; // [LoanAmt  ,   16] 대출금액                        StartPos 1125, Length 16
    }

    struct _CSPAQ12300OutBlock3
    {
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 0, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public string SecBalPtnCode; // [SecBalPtnCode,    2] 유가증권잔고유형코드            StartPos 52, Length 2
        public string SecBalPtnNm; // [SecBalPtnNm,   40] 유가증권잔고유형명              StartPos 54, Length 40
        public long BalQty; // [BalQty  ,   16] 잔고수량                        StartPos 94, Length 16
        public long BnsBaseBalQty; // [BnsBaseBalQty  ,   16] 매매기준잔고수량                StartPos 110, Length 16
        public long CrdayBuyExecQty; // [CrdayBuyExecQty  ,   16] 금일매수체결수량                StartPos 126, Length 16
        public long CrdaySellExecQty; // [CrdaySellExecQty  ,   16] 금일매도체결수량                StartPos 142, Length 16
        public double SellPrc; // [SellPrc, 21.4] 매도가                          StartPos 158, Length 21
        public double BuyPrc; // [BuyPrc, 21.4] 매수가                          StartPos 179, Length 21
        public long SellPnlAmt; // [SellPnlAmt  ,   16] 매도손익금액                    StartPos 200, Length 16
        public double PnlRat; // [PnlRat, 18.6] 손익율                          StartPos 216, Length 18
        public double NowPrc; // [NowPrc, 15.2] 현재가                          StartPos 234, Length 15
        public long CrdtAmt; // [CrdtAmt  ,   16] 신용금액                        StartPos 249, Length 16
        public string DueDt; // [DueDt,    8] 만기일                          StartPos 265, Length 8
        public double PrdaySellExecPrc; // [PrdaySellExecPrc, 13.2] 전일매도체결가                  StartPos 273, Length 13
        public long PrdaySellQty; // [PrdaySellQty  ,   16] 전일매도수량                    StartPos 286, Length 16
        public double PrdayBuyExecPrc; // [PrdayBuyExecPrc, 13.2] 전일매수체결가                  StartPos 302, Length 13
        public long PrdayBuyQty; // [PrdayBuyQty  ,   16] 전일매수수량                    StartPos 315, Length 16
        public string LoanDt; // [LoanDt,    8] 대출일                          StartPos 331, Length 8
        public double AvrUprc; // [AvrUprc, 13.2] 평균단가                        StartPos 339, Length 13
        public long SellAbleQty; // [SellAbleQty  ,   16] 매도가능수량                    StartPos 352, Length 16
        public long SellOrdQty; // [SellOrdQty  ,   16] 매도주문수량                    StartPos 368, Length 16
        public long CrdayBuyExecAmt; // [CrdayBuyExecAmt  ,   16] 금일매수체결금액                StartPos 384, Length 16
        public long CrdaySellExecAmt; // [CrdaySellExecAmt  ,   16] 금일매도체결금액                StartPos 400, Length 16
        public long PrdayBuyExecAmt; // [PrdayBuyExecAmt  ,   16] 전일매수체결금액                StartPos 416, Length 16
        public long PrdaySellExecAmt; // [PrdaySellExecAmt  ,   16] 전일매도체결금액                StartPos 432, Length 16
        public long BalEvalAmt; // [BalEvalAmt  ,   16] 잔고평가금액                    StartPos 448, Length 16
        public long EvalPnl; // [EvalPnl  ,   16] 평가손익                        StartPos 464, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 480, Length 16
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 496, Length 16
        public long SellUnercQty; // [SellUnercQty  ,   16] 매도미체결수량                  StartPos 512, Length 16
        public long SellUnsttQty; // [SellUnsttQty  ,   16] 매도미결제수량                  StartPos 528, Length 16
        public long BuyUnercQty; // [BuyUnercQty  ,   16] 매수미체결수량                  StartPos 544, Length 16
        public long BuyUnsttQty; // [BuyUnsttQty  ,   16] 매수미결제수량                  StartPos 560, Length 16
        public long UnsttQty; // [UnsttQty  ,   16] 미결제수량                      StartPos 576, Length 16
        public long UnercQty; // [UnercQty  ,   16] 미체결수량                      StartPos 592, Length 16
        public double PrdayCprc; // [PrdayCprc, 15.2] 전일종가                        StartPos 608, Length 15
        public long PchsAmt; // [PchsAmt  ,   16] 매입금액                        StartPos 623, Length 16
        public string RegMktCode; // [RegMktCode,    2] 등록시장코드                    StartPos 639, Length 2
        public string LoanDtlClssCode; // [LoanDtlClssCode,    2] 대출상세분류코드                StartPos 641, Length 2
        public long DpspdgLoanQty; // [DpspdgLoanQty  ,   16] 예탁담보대출수량                StartPos 643, Length 16
    }
}