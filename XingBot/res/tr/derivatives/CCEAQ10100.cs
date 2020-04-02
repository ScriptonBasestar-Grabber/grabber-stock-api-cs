using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물옵션 CME 주문가능 수량/금액 조회 ( SERVICE=CCEAQ10100,HEADTYPE=B,CREATOR=김효종,CREDATE=2012/04/17 13:38:18 )
    struct _CCEAQ10100InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 33, Length 1
        public long OrdAmt; // [OrdAmt  ,   16] 주문금액                        StartPos 34, Length 16
        public double RatVal; // [RatVal, 19.8] 비율값                          StartPos 50, Length 19
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 69, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 81, Length 1
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 82, Length 13
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 95, Length 2
    }

    struct _CCEAQ10100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string QryTp; // [QryTp,    1] 조회구분                        StartPos 33, Length 1
        public long OrdAmt; // [OrdAmt  ,   16] 주문금액                        StartPos 34, Length 16
        public double RatVal; // [RatVal, 19.8] 비율값                          StartPos 50, Length 19
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 69, Length 12
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 81, Length 1
        public double OrdPrc; // [OrdPrc, 13.2] 주문가                          StartPos 82, Length 13
        public string FnoOrdprcPtnCode; // [FnoOrdprcPtnCode,    2] 선물옵션호가유형코드            StartPos 95, Length 2
    }

    struct _CCEAQ10100OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public string QryDt; // [QryDt,    8] 조회일                          StartPos 45, Length 8
        public double NowPrc; // [NowPrc, 15.2] 현재가                          StartPos 53, Length 15
        public long OrdAbleQty; // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 68, Length 16
        public long NewOrdAbleQty; // [NewOrdAbleQty  ,   16] 신규주문가능수량                StartPos 84, Length 16
        public long LqdtOrdAbleQty; // [LqdtOrdAbleQty  ,   16] 청산주문가능수량                StartPos 100, Length 16
        public long UsePreargMgn; // [UsePreargMgn  ,   16] 사용예정증거금액                StartPos 116, Length 16
        public long UsePreargMnyMgn; // [UsePreargMnyMgn  ,   16] 사용예정현금증거금액            StartPos 132, Length 16
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 148, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 164, Length 16
    }
}