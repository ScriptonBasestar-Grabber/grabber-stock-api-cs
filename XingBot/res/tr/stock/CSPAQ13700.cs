using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 현물계좌 주문체결내역 조회(API) ( SERVICE=CSPAQ13700,HEADTYPE=B,CREATOR=이상은,CREDATE=2015/04/13 08:39:53 )
    struct _CSPAQ13700InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 33, Length 2
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 35, Length 1
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 36, Length 12
        public string ExecYn; // [ExecYn,    1] 체결여부                        StartPos 48, Length 1
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 49, Length 8
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public string BkseqTpCode; // [BkseqTpCode,    1] 역순구분                        StartPos 67, Length 1
        public string OrdPtnCode; // [OrdPtnCode,    2] 주문유형코드                    StartPos 68, Length 2
    }

    struct _CSPAQ13700OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd; // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 33, Length 2
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 35, Length 1
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 36, Length 12
        public string ExecYn; // [ExecYn,    1] 체결여부                        StartPos 48, Length 1
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 49, Length 8
        public long SrtOrdNo2; // [SrtOrdNo2  ,   10] 시작주문번호2                   StartPos 57, Length 10
        public string BkseqTpCode; // [BkseqTpCode,    1] 역순구분                        StartPos 67, Length 1
        public string OrdPtnCode; // [OrdPtnCode,    2] 주문유형코드                    StartPos 68, Length 2
    }

    struct _CSPAQ13700OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long SellExecAmt; // [SellExecAmt  ,   16] 매도체결금액                    StartPos 5, Length 16
        public long BuyExecAmt; // [BuyExecAmt  ,   16] 매수체결금액                    StartPos 21, Length 16
        public long SellExecQty; // [SellExecQty  ,   16] 매도체결수량                    StartPos 37, Length 16
        public long BuyExecQty; // [BuyExecQty  ,   16] 매수체결수량                    StartPos 53, Length 16
        public long SellOrdQty; // [SellOrdQty  ,   16] 매도주문수량                    StartPos 69, Length 16
        public long BuyOrdQty; // [BuyOrdQty  ,   16] 매수주문수량                    StartPos 85, Length 16
    }

    struct _CSPAQ13700OutBlock3
    {
        public string OrdDt; // [OrdDt,    8] 주문일                          StartPos 0, Length 8
        public string MgmtBrnNo; // [MgmtBrnNo,    3] 관리지점번호                    StartPos 8, Length 3
        public string OrdMktCode; // [OrdMktCode,    2] 주문시장코드                    StartPos 11, Length 2
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 13, Length 10
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 23, Length 10
        public string IsuNo; // [IsuNo,   12] 종목번호                        StartPos 33, Length 12
        public string IsuNm; // [IsuNm,   40] 종목명                          StartPos 45, Length 40
        public string BnsTpCode; // [BnsTpCode,    1] 매매구분                        StartPos 85, Length 1
        public string BnsTpNm; // [BnsTpNm,   10] 매매구분                        StartPos 86, Length 10
        public string OrdPtnCode; // [OrdPtnCode,    2] 주문유형코드                    StartPos 96, Length 2
        public string OrdPtnNm; // [OrdPtnNm,   40] 주문유형명                      StartPos 98, Length 40
        public long OrdTrxPtnCode; // [OrdTrxPtnCode  ,    9] 주문처리유형코드                StartPos 138, Length 9
        public string OrdTrxPtnNm; // [OrdTrxPtnNm,   50] 주문처리유형명                  StartPos 147, Length 50
        public string MrcTpCode; // [MrcTpCode,    1] 정정취소구분                    StartPos 197, Length 1
        public string MrcTpNm; // [MrcTpNm,   10] 정정취소구분명                  StartPos 198, Length 10
        public long MrcQty; // [MrcQty  ,   16] 정정취소수량                    StartPos 208, Length 16
        public long MrcAbleQty; // [MrcAbleQty  ,   16] 정정취소가능수량                StartPos 224, Length 16
        public long OrdQty; // [OrdQty  ,   16] 주문수량                        StartPos 240, Length 16
        public double OrdPrc; // [OrdPrc, 15.2] 주문가격                        StartPos 256, Length 15
        public long ExecQty; // [ExecQty  ,   16] 체결수량                        StartPos 271, Length 16
        public double ExecPrc; // [ExecPrc, 15.2] 체결가                          StartPos 287, Length 15
        public string ExecTrxTime; // [ExecTrxTime,    9] 체결처리시각                    StartPos 302, Length 9
        public string LastExecTime; // [LastExecTime,    9] 최종체결시각                    StartPos 311, Length 9
        public string OrdprcPtnCode; // [OrdprcPtnCode,    2] 호가유형코드                    StartPos 320, Length 2
        public string OrdprcPtnNm; // [OrdprcPtnNm,   40] 호가유형명                      StartPos 322, Length 40
        public string OrdCndiTpCode; // [OrdCndiTpCode,    1] 주문조건구분                    StartPos 362, Length 1
        public long AllExecQty; // [AllExecQty  ,   16] 전체체결수량                    StartPos 363, Length 16
        public string RegCommdaCode; // [RegCommdaCode,    2] 통신매체코드                    StartPos 379, Length 2
        public string CommdaNm; // [CommdaNm,   40] 통신매체명                      StartPos 381, Length 40
        public string MbrNo; // [MbrNo,    3] 회원번호                        StartPos 421, Length 3
        public string RsvOrdYn; // [RsvOrdYn,    1] 예약주문여부                    StartPos 424, Length 1
        public string LoanDt; // [LoanDt,    8] 대출일                          StartPos 425, Length 8
        public string OrdTime; // [OrdTime,    9] 주문시각                        StartPos 433, Length 9
        public string OpDrtnNo; // [OpDrtnNo,   12] 운용지시번호                    StartPos 442, Length 12
        public string OdrrId; // [OdrrId,   16] 주문자ID                        StartPos 454, Length 16
    }
}