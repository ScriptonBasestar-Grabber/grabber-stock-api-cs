using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물옵션 CME 계좌잔고 및 평가현황 ( SERVICE=CCEAQ50600,HEADTYPE=B,CREATOR=김승환,CREDATE=2012/05/01 12:18:45 )
    struct _CCEAQ50600InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string BalEvalTp; // [BalEvalTp,    1] 잔고평가구분                    StartPos 33, Length 1
        public string FutsPrcEvalTp; // [FutsPrcEvalTp,    1] 선물가격평가구분                StartPos 34, Length 1
    }

    struct _CCEAQ50600OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string BalEvalTp; // [BalEvalTp,    1] 잔고평가구분                    StartPos 33, Length 1
        public string FutsPrcEvalTp; // [FutsPrcEvalTp,    1] 선물가격평가구분                StartPos 34, Length 1
    }

    struct _CCEAQ50600OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 25, Length 40
        public long EvalDpsamtTotamt; // [EvalDpsamtTotamt  ,   15] 평가예탁금총액                  StartPos 65, Length 15
        public long MnyEvalDpstgAmt; // [MnyEvalDpstgAmt  ,   15] 현금평가예탁금액                StartPos 80, Length 15
        public long DpsamtTotamt; // [DpsamtTotamt  ,   16] 예탁금총액                      StartPos 95, Length 16
        public long DpstgMny; // [DpstgMny  ,   16] 예탁현금                        StartPos 111, Length 16
        public long PsnOutAbleTotAmt; // [PsnOutAbleTotAmt  ,   15] 인출가능총금액                  StartPos 127, Length 15
        public long PsnOutAbleCurAmt; // [PsnOutAbleCurAmt  ,   16] 인출가능현금액                  StartPos 142, Length 16
        public long OrdAbleTotAmt; // [OrdAbleTotAmt  ,   15] 주문가능총금액                  StartPos 158, Length 15
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 173, Length 16
        public long CsgnMgnTotamt; // [CsgnMgnTotamt  ,   16] 위탁증거금총액                  StartPos 189, Length 16
        public long MnyCsgnMgn; // [MnyCsgnMgn  ,   16] 현금위탁증거금액                StartPos 205, Length 16
        public long AddMgnTotamt; // [AddMgnTotamt  ,   15] 추가증거금총액                  StartPos 221, Length 15
        public long MnyAddMgn; // [MnyAddMgn  ,   16] 현금추가증거금액                StartPos 236, Length 16
        public long CmsnAmt; // [CmsnAmt  ,   16] 수수료                          StartPos 252, Length 16
        public long FutsEvalPnlAmt; // [FutsEvalPnlAmt  ,   16] 선물평가손익금액                StartPos 268, Length 16
        public long OptEvalPnlAmt; // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 284, Length 16
        public long OptEvalAmt; // [OptEvalAmt  ,   16] 옵션평가금액                    StartPos 300, Length 16
        public long OptBnsplAmt; // [OptBnsplAmt  ,   16] 옵션매매손익금액                StartPos 316, Length 16
        public long FutsAdjstDfamt; // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 332, Length 16
        public long TotPnlAmt; // [TotPnlAmt  ,   16] 총손익금액                      StartPos 348, Length 16
        public long NetPnlAmt; // [NetPnlAmt  ,   16] 순손익금액                      StartPos 364, Length 16
        public long TotEvalAmt; // [TotEvalAmt  ,   16] 총평가금액                      StartPos 380, Length 16
        public long MnyinAmt; // [MnyinAmt  ,   16] 입금금액                        StartPos 396, Length 16
        public long MnyoutAmt; // [MnyoutAmt  ,   16] 출금금액                        StartPos 412, Length 16
    }

    struct _CCEAQ50600OutBlock3
    {
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 0, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 12, Length 40
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 52, Length 1
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 53, Length 10
        public long UnsttQty; // [UnsttQty  ,   16] 미결제수량                      StartPos 63, Length 16
        public double FnoAvrPrc; // [FnoAvrPrc, 19.8] 평균가                          StartPos 79, Length 19
        public double NowPrc; // [NowPrc, 13.2] 현재가                          StartPos 98, Length 13
        public double CmpPrc; // [CmpPrc, 13.2] 대비가                          StartPos 111, Length 13
        public long EvalPnl; // [EvalPnl  ,   16] 평가손익                        StartPos 124, Length 16
        public double PnlRat; // [PnlRat, 12.6] 손익률                          StartPos 140, Length 12
        public long EvalAmt; // [EvalAmt  ,   16] 평가금액                        StartPos 152, Length 16
    }
}