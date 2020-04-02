using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물옵션가정산예탁금상세 ( SERVICE=CFOEQ11100,HEADTYPE=B,CREATOR=김정현,CREDATE=2012/03/16 14:04:41 )
    struct _CFOEQ11100InBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BnsDt; // [BnsDt,    8] 매매일                          StartPos 33, Length 8
    }

    struct _CFOEQ11100OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BnsDt; // [BnsDt,    8] 매매일                          StartPos 33, Length 8
    }

    struct _CFOEQ11100OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long OpnmkDpsamtTotamt; // [OpnmkDpsamtTotamt  ,   16] 개장시예탁금총액                StartPos 45, Length 16
        public long OpnmkDps; // [OpnmkDps  ,   16] 개장시예수금                    StartPos 61, Length 16
        public long OpnmkMnyrclAmt; // [OpnmkMnyrclAmt  ,   16] 개장시현금미수금                StartPos 77, Length 16
        public long OpnmkSubstAmt; // [OpnmkSubstAmt  ,   16] 개장시대용금액                  StartPos 93, Length 16
        public long TotAmt; // [TotAmt  ,   16] 총금액                          StartPos 109, Length 16
        public long Dps; // [Dps  ,   16] 예수금                          StartPos 125, Length 16
        public long MnyrclAmt; // [MnyrclAmt  ,   16] 현금미수금액                    StartPos 141, Length 16
        public long SubstDsgnAmt; // [SubstDsgnAmt  ,   16] 대용지정금액                    StartPos 157, Length 16
        public long CsgnMgn; // [CsgnMgn  ,   16] 위탁증거금액                    StartPos 173, Length 16
        public long MnyCsgnMgn; // [MnyCsgnMgn  ,   16] 현금위탁증거금액                StartPos 189, Length 16
        public long MaintMgn; // [MaintMgn  ,   16] 유지증거금액                    StartPos 205, Length 16
        public long MnyMaintMgn; // [MnyMaintMgn  ,   16] 현금유지증거금액                StartPos 221, Length 16
        public long OutAbleAmt; // [OutAbleAmt  ,   16] 출금가능총액                    StartPos 237, Length 16
        public long MnyoutAbleAmt; // [MnyoutAbleAmt  ,   16] 출금가능금액                    StartPos 253, Length 16
        public long SubstOutAbleAmt; // [SubstOutAbleAmt  ,   16] 출금가능대용                    StartPos 269, Length 16
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 285, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 301, Length 16
        public string AddMgnOcrTpCode; // [AddMgnOcrTpCode,    1] 추가증거금구분                  StartPos 317, Length 1
        public long AddMgn; // [AddMgn  ,   16] 추가증거금액                    StartPos 318, Length 16
        public long MnyAddMgn; // [MnyAddMgn  ,   16] 현금추가증거금액                StartPos 334, Length 16
        public long NtdayTotAmt; // [NtdayTotAmt  ,   16] 익일예탁총액                    StartPos 350, Length 16
        public long NtdayDps; // [NtdayDps  ,   16] 익일예탁현금                    StartPos 366, Length 16
        public long NtdayMnyrclAmt; // [NtdayMnyrclAmt  ,   16] 익일미수금                      StartPos 382, Length 16
        public long NtdaySubstAmt; // [NtdaySubstAmt  ,   16] 익일예탁대용                    StartPos 398, Length 16
        public long NtdayCsgnMgn; // [NtdayCsgnMgn  ,   16] 익일위탁증거금                  StartPos 414, Length 16
        public long NtdayMnyCsgnMgn; // [NtdayMnyCsgnMgn  ,   16] 익일위탁증거금현금              StartPos 430, Length 16
        public long NtdayMaintMgn; // [NtdayMaintMgn  ,   16] 익일유지증거금                  StartPos 446, Length 16
        public long NtdayMnyMaintMgn; // [NtdayMnyMaintMgn  ,   16] 익일유지증거금현금              StartPos 462, Length 16
        public long NtdayOutAbleAmt; // [NtdayOutAbleAmt  ,   16] 익일인출가능금액                StartPos 478, Length 16
        public long NtdayMnyoutAbleAmt; // [NtdayMnyoutAbleAmt  ,   16] 익일인출가능금액                StartPos 494, Length 16

        public long
            NtdaySubstOutAbleAmt; // [NtdaySubstOutAbleAmt  ,   16] 익일인출가능대용                StartPos 510, Length 16

        public long NtdayOrdAbleAmt; // [NtdayOrdAbleAmt  ,   16] 익일주문가능금액                StartPos 526, Length 16
        public long NtdayMnyOrdAbleAmt; // [NtdayMnyOrdAbleAmt  ,   16] 익일주문가능현금                StartPos 542, Length 16
        public string NtdayAddMgnTp; // [NtdayAddMgnTp,    1] 익일추가증거금구분              StartPos 558, Length 1
        public long NtdayAddMgn; // [NtdayAddMgn  ,   16] 익일추가증거금                  StartPos 559, Length 16
        public long NtdayMnyAddMgn; // [NtdayMnyAddMgn  ,   16] 익일추가증거금현금              StartPos 575, Length 16
        public long NtdaySettAmt; // [NtdaySettAmt  ,   16] 익일결제금액                    StartPos 591, Length 16
        public long EvalDpsamtTotamt; // [EvalDpsamtTotamt  ,   15] 평가예탁금총액                  StartPos 607, Length 15
        public long MnyEvalDpstgAmt; // [MnyEvalDpstgAmt  ,   15] 현금평가예탁금액                StartPos 622, Length 15

        public long
            DpsamtUtlfeeGivPrergAmt; // [DpsamtUtlfeeGivPrergAmt  ,   16] 예탁금이용료지급예정금액        StartPos 637, Length 16

        public long TaxAmt; // [TaxAmt  ,   16] 세금                            StartPos 653, Length 16
        public double CsgnMgnrat; // [CsgnMgnrat,  7.2] 위탁증거금 비율                 StartPos 669, Length 7
        public double CsgnMnyMgnrat; // [CsgnMnyMgnrat,  7.2] 위탁증거금현금비율              StartPos 676, Length 7
        public long DpstgTotamtLackAmt; // [DpstgTotamtLackAmt  ,   16] 예탁총액부족금액(위탁증거금기준 StartPos 683, Length 16
        public long DpstgMnyLackAmt; // [DpstgMnyLackAmt  ,   16] 예탁현금부족금액(위탁증거금기준 StartPos 699, Length 16
        public long RealInAmt; // [RealInAmt  ,   16] 실입금액                        StartPos 715, Length 16
        public long InAmt; // [InAmt  ,   16] 입금액                          StartPos 731, Length 16
        public long OutAmt; // [OutAmt  ,   16] 출금액                          StartPos 747, Length 16
        public long FutsAdjstDfamt; // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 763, Length 16
        public long FutsThdayDfamt; // [FutsThdayDfamt  ,   16] 선물당일차금                    StartPos 779, Length 16
        public long FutsUpdtDfamt; // [FutsUpdtDfamt  ,   16] 선물갱신차금                    StartPos 795, Length 16
        public long FutsLastSettDfamt; // [FutsLastSettDfamt  ,   16] 선물최종결제차금                StartPos 811, Length 16
        public long OptSettDfamt; // [OptSettDfamt  ,   16] 옵션결제차금                    StartPos 827, Length 16
        public long OptBuyAmt; // [OptBuyAmt  ,   16] 옵션매수금액                    StartPos 843, Length 16
        public long OptSellAmt; // [OptSellAmt  ,   16] 옵션매도금액                    StartPos 859, Length 16
        public long OptXrcDfamt; // [OptXrcDfamt  ,   16] 옵션행사차금                    StartPos 875, Length 16
        public long OptAsgnDfamt; // [OptAsgnDfamt  ,   16] 옵션배정차금                    StartPos 891, Length 16
        public long RealGdsUndAmt; // [RealGdsUndAmt  ,   16] 실물인수도금액                  StartPos 907, Length 16
        public long RealGdsUndAsgnAmt; // [RealGdsUndAsgnAmt  ,   16] 실물인수도배정대금              StartPos 923, Length 16
        public long RealGdsUndXrcAmt; // [RealGdsUndXrcAmt  ,   16] 실물인수도행사대금              StartPos 939, Length 16
        public long CmsnAmt; // [CmsnAmt  ,   16] 수수료                          StartPos 955, Length 16
        public long FutsCmsn; // [FutsCmsn  ,   16] 선물수수료                      StartPos 971, Length 16
        public long OptCmsn; // [OptCmsn  ,   16] 옵션수수료                      StartPos 987, Length 16
        public long FutsCtrctQty; // [FutsCtrctQty  ,   16] 선물약정수량                    StartPos 1003, Length 16
        public long FutsCtrctAmt; // [FutsCtrctAmt  ,   16] 선물약정금액                    StartPos 1019, Length 16
        public long OptCtrctQty; // [OptCtrctQty  ,   16] 옵션약정수량                    StartPos 1035, Length 16
        public long OptCtrctAmt; // [OptCtrctAmt  ,   16] 옵션약정금액                    StartPos 1051, Length 16
        public long FutsUnsttQty; // [FutsUnsttQty  ,   16] 선물미결제수량                  StartPos 1067, Length 16
        public long FutsUnsttAmt; // [FutsUnsttAmt  ,   16] 선물미결제금액                  StartPos 1083, Length 16
        public long OptUnsttQty; // [OptUnsttQty  ,   16] 옵션미결제수량                  StartPos 1099, Length 16
        public long OptUnsttAmt; // [OptUnsttAmt  ,   16] 옵션미결제금액                  StartPos 1115, Length 16
        public long FutsBuyUnsttQty; // [FutsBuyUnsttQty  ,   16] 선물매수미결제수량              StartPos 1131, Length 16
        public long FutsBuyUnsttAmt; // [FutsBuyUnsttAmt  ,   16] 선물매수미결제금액              StartPos 1147, Length 16
        public long FutsSellUnsttQty; // [FutsSellUnsttQty  ,   16] 선물매도미결제수량              StartPos 1163, Length 16
        public long FutsSellUnsttAmt; // [FutsSellUnsttAmt  ,   16] 선물매도미결제금액              StartPos 1179, Length 16
        public long OptBuyUnsttQty; // [OptBuyUnsttQty  ,   16] 옵션매수미결제수량              StartPos 1195, Length 16
        public long OptBuyUnsttAmt; // [OptBuyUnsttAmt  ,   16] 옵션매수미결제금액              StartPos 1211, Length 16
        public long OptSellUnsttQty; // [OptSellUnsttQty  ,   16] 옵션매도미결제수량              StartPos 1227, Length 16
        public long OptSellUnsttAmt; // [OptSellUnsttAmt  ,   16] 옵션매도미결제금액              StartPos 1243, Length 16
        public long FutsBuyctrQty; // [FutsBuyctrQty  ,   16] 선물매수약정수량                StartPos 1259, Length 16
        public long FutsBuyctrAmt; // [FutsBuyctrAmt  ,   16] 선물매수약정금액                StartPos 1275, Length 16
        public long FutsSlctrQty; // [FutsSlctrQty  ,   16] 선물매도약정수량                StartPos 1291, Length 16
        public long FutsSlctrAmt; // [FutsSlctrAmt  ,   16] 선물매도약정금액                StartPos 1307, Length 16
        public long OptBuyctrQty; // [OptBuyctrQty  ,   16] 옵션매수약정수량                StartPos 1323, Length 16
        public long OptBuyctrAmt; // [OptBuyctrAmt  ,   16] 옵션매수약정금액                StartPos 1339, Length 16
        public long OptSlctrQty; // [OptSlctrQty  ,   16] 옵션매도약정수량                StartPos 1355, Length 16
        public long OptSlctrAmt; // [OptSlctrAmt  ,   16] 옵션매도약정금액                StartPos 1371, Length 16
        public long FutsBnsplAmt; // [FutsBnsplAmt  ,   16] 선물매매손익금액                StartPos 1387, Length 16
        public long OptBnsplAmt; // [OptBnsplAmt  ,   16] 옵션매매손익금액                StartPos 1403, Length 16
        public long FutsEvalPnlAmt; // [FutsEvalPnlAmt  ,   16] 선물평가손익금액                StartPos 1419, Length 16
        public long OptEvalPnlAmt; // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 1435, Length 16
        public long FutsEvalAmt; // [FutsEvalAmt  ,   16] 선물평가금액                    StartPos 1451, Length 16
        public long OptEvalAmt; // [OptEvalAmt  ,   16] 옵션평가금액                    StartPos 1467, Length 16
        public long MktEndAfMnyInAmt; // [MktEndAfMnyInAmt  ,   16] 장종료후현금입금금액            StartPos 1483, Length 16
        public long MktEndAfMnyOutAmt; // [MktEndAfMnyOutAmt  ,   16] 장종료후현금출금금액            StartPos 1499, Length 16

        public long
            MktEndAfSubstDsgnAmt; // [MktEndAfSubstDsgnAmt  ,   16] 장종료후대용지정금액            StartPos 1515, Length 16

        public long
            MktEndAfSubstAbndAmt; // [MktEndAfSubstAbndAmt  ,   16] 장종료후대용해지금액            StartPos 1531, Length 16
    }
}