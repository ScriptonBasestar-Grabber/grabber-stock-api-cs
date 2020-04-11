namespace XingBot.res
{
    // 선물옵션가정산예탁금상세 ( SERVICE=CFOEQ11100,HEADTYPE=B,CREATOR=김정현,CREDATE=2012/03/16 14:04:41 )
    public class _CFOEQ11100InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BnsDt{ get; set; } // [BnsDt,    8] 매매일                          StartPos 33, Length 8
    }

    public class _CFOEQ11100OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
        public string BnsDt{ get; set; } // [BnsDt,    8] 매매일                          StartPos 33, Length 8
    }

    public class _CFOEQ11100OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long OpnmkDpsamtTotamt{ get; set; } // [OpnmkDpsamtTotamt  ,   16] 개장시예탁금총액                StartPos 45, Length 16
        public long OpnmkDps{ get; set; } // [OpnmkDps  ,   16] 개장시예수금                    StartPos 61, Length 16
        public long OpnmkMnyrclAmt{ get; set; } // [OpnmkMnyrclAmt  ,   16] 개장시현금미수금                StartPos 77, Length 16
        public long OpnmkSubstAmt{ get; set; } // [OpnmkSubstAmt  ,   16] 개장시대용금액                  StartPos 93, Length 16
        public long TotAmt{ get; set; } // [TotAmt  ,   16] 총금액                          StartPos 109, Length 16
        public long Dps{ get; set; } // [Dps  ,   16] 예수금                          StartPos 125, Length 16
        public long MnyrclAmt{ get; set; } // [MnyrclAmt  ,   16] 현금미수금액                    StartPos 141, Length 16
        public long SubstDsgnAmt{ get; set; } // [SubstDsgnAmt  ,   16] 대용지정금액                    StartPos 157, Length 16
        public long CsgnMgn{ get; set; } // [CsgnMgn  ,   16] 위탁증거금액                    StartPos 173, Length 16
        public long MnyCsgnMgn{ get; set; } // [MnyCsgnMgn  ,   16] 현금위탁증거금액                StartPos 189, Length 16
        public long MaintMgn{ get; set; } // [MaintMgn  ,   16] 유지증거금액                    StartPos 205, Length 16
        public long MnyMaintMgn{ get; set; } // [MnyMaintMgn  ,   16] 현금유지증거금액                StartPos 221, Length 16
        public long OutAbleAmt{ get; set; } // [OutAbleAmt  ,   16] 출금가능총액                    StartPos 237, Length 16
        public long MnyoutAbleAmt{ get; set; } // [MnyoutAbleAmt  ,   16] 출금가능금액                    StartPos 253, Length 16
        public long SubstOutAbleAmt{ get; set; } // [SubstOutAbleAmt  ,   16] 출금가능대용                    StartPos 269, Length 16
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 285, Length 16
        public long MnyOrdAbleAmt{ get; set; } // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 301, Length 16
        public string AddMgnOcrTpCode{ get; set; } // [AddMgnOcrTpCode,    1] 추가증거금구분                  StartPos 317, Length 1
        public long AddMgn{ get; set; } // [AddMgn  ,   16] 추가증거금액                    StartPos 318, Length 16
        public long MnyAddMgn{ get; set; } // [MnyAddMgn  ,   16] 현금추가증거금액                StartPos 334, Length 16
        public long NtdayTotAmt{ get; set; } // [NtdayTotAmt  ,   16] 익일예탁총액                    StartPos 350, Length 16
        public long NtdayDps{ get; set; } // [NtdayDps  ,   16] 익일예탁현금                    StartPos 366, Length 16
        public long NtdayMnyrclAmt{ get; set; } // [NtdayMnyrclAmt  ,   16] 익일미수금                      StartPos 382, Length 16
        public long NtdaySubstAmt{ get; set; } // [NtdaySubstAmt  ,   16] 익일예탁대용                    StartPos 398, Length 16
        public long NtdayCsgnMgn{ get; set; } // [NtdayCsgnMgn  ,   16] 익일위탁증거금                  StartPos 414, Length 16
        public long NtdayMnyCsgnMgn{ get; set; } // [NtdayMnyCsgnMgn  ,   16] 익일위탁증거금현금              StartPos 430, Length 16
        public long NtdayMaintMgn{ get; set; } // [NtdayMaintMgn  ,   16] 익일유지증거금                  StartPos 446, Length 16
        public long NtdayMnyMaintMgn{ get; set; } // [NtdayMnyMaintMgn  ,   16] 익일유지증거금현금              StartPos 462, Length 16
        public long NtdayOutAbleAmt{ get; set; } // [NtdayOutAbleAmt  ,   16] 익일인출가능금액                StartPos 478, Length 16
        public long NtdayMnyoutAbleAmt{ get; set; } // [NtdayMnyoutAbleAmt  ,   16] 익일인출가능금액                StartPos 494, Length 16

        public long
            NtdaySubstOutAbleAmt{ get; set; } // [NtdaySubstOutAbleAmt  ,   16] 익일인출가능대용                StartPos 510, Length 16

        public long NtdayOrdAbleAmt{ get; set; } // [NtdayOrdAbleAmt  ,   16] 익일주문가능금액                StartPos 526, Length 16
        public long NtdayMnyOrdAbleAmt{ get; set; } // [NtdayMnyOrdAbleAmt  ,   16] 익일주문가능현금                StartPos 542, Length 16
        public string NtdayAddMgnTp{ get; set; } // [NtdayAddMgnTp,    1] 익일추가증거금구분              StartPos 558, Length 1
        public long NtdayAddMgn{ get; set; } // [NtdayAddMgn  ,   16] 익일추가증거금                  StartPos 559, Length 16
        public long NtdayMnyAddMgn{ get; set; } // [NtdayMnyAddMgn  ,   16] 익일추가증거금현금              StartPos 575, Length 16
        public long NtdaySettAmt{ get; set; } // [NtdaySettAmt  ,   16] 익일결제금액                    StartPos 591, Length 16
        public long EvalDpsamtTotamt{ get; set; } // [EvalDpsamtTotamt  ,   15] 평가예탁금총액                  StartPos 607, Length 15
        public long MnyEvalDpstgAmt{ get; set; } // [MnyEvalDpstgAmt  ,   15] 현금평가예탁금액                StartPos 622, Length 15

        public long
            DpsamtUtlfeeGivPrergAmt{ get; set; } // [DpsamtUtlfeeGivPrergAmt  ,   16] 예탁금이용료지급예정금액        StartPos 637, Length 16

        public long TaxAmt{ get; set; } // [TaxAmt  ,   16] 세금                            StartPos 653, Length 16
        public decimal CsgnMgnrat{ get; set; } // [CsgnMgnrat,  7.2] 위탁증거금 비율                 StartPos 669, Length 7
        public decimal CsgnMnyMgnrat{ get; set; } // [CsgnMnyMgnrat,  7.2] 위탁증거금현금비율              StartPos 676, Length 7
        public long DpstgTotamtLackAmt{ get; set; } // [DpstgTotamtLackAmt  ,   16] 예탁총액부족금액(위탁증거금기준 StartPos 683, Length 16
        public long DpstgMnyLackAmt{ get; set; } // [DpstgMnyLackAmt  ,   16] 예탁현금부족금액(위탁증거금기준 StartPos 699, Length 16
        public long RealInAmt{ get; set; } // [RealInAmt  ,   16] 실입금액                        StartPos 715, Length 16
        public long InAmt{ get; set; } // [InAmt  ,   16] 입금액                          StartPos 731, Length 16
        public long OutAmt{ get; set; } // [OutAmt  ,   16] 출금액                          StartPos 747, Length 16
        public long FutsAdjstDfamt{ get; set; } // [FutsAdjstDfamt  ,   16] 선물정산차금                    StartPos 763, Length 16
        public long FutsThdayDfamt{ get; set; } // [FutsThdayDfamt  ,   16] 선물당일차금                    StartPos 779, Length 16
        public long FutsUpdtDfamt{ get; set; } // [FutsUpdtDfamt  ,   16] 선물갱신차금                    StartPos 795, Length 16
        public long FutsLastSettDfamt{ get; set; } // [FutsLastSettDfamt  ,   16] 선물최종결제차금                StartPos 811, Length 16
        public long OptSettDfamt{ get; set; } // [OptSettDfamt  ,   16] 옵션결제차금                    StartPos 827, Length 16
        public long OptBuyAmt{ get; set; } // [OptBuyAmt  ,   16] 옵션매수금액                    StartPos 843, Length 16
        public long OptSellAmt{ get; set; } // [OptSellAmt  ,   16] 옵션매도금액                    StartPos 859, Length 16
        public long OptXrcDfamt{ get; set; } // [OptXrcDfamt  ,   16] 옵션행사차금                    StartPos 875, Length 16
        public long OptAsgnDfamt{ get; set; } // [OptAsgnDfamt  ,   16] 옵션배정차금                    StartPos 891, Length 16
        public long RealGdsUndAmt{ get; set; } // [RealGdsUndAmt  ,   16] 실물인수도금액                  StartPos 907, Length 16
        public long RealGdsUndAsgnAmt{ get; set; } // [RealGdsUndAsgnAmt  ,   16] 실물인수도배정대금              StartPos 923, Length 16
        public long RealGdsUndXrcAmt{ get; set; } // [RealGdsUndXrcAmt  ,   16] 실물인수도행사대금              StartPos 939, Length 16
        public long CmsnAmt{ get; set; } // [CmsnAmt  ,   16] 수수료                          StartPos 955, Length 16
        public long FutsCmsn{ get; set; } // [FutsCmsn  ,   16] 선물수수료                      StartPos 971, Length 16
        public long OptCmsn{ get; set; } // [OptCmsn  ,   16] 옵션수수료                      StartPos 987, Length 16
        public long FutsCtrctQty{ get; set; } // [FutsCtrctQty  ,   16] 선물약정수량                    StartPos 1003, Length 16
        public long FutsCtrctAmt{ get; set; } // [FutsCtrctAmt  ,   16] 선물약정금액                    StartPos 1019, Length 16
        public long OptCtrctQty{ get; set; } // [OptCtrctQty  ,   16] 옵션약정수량                    StartPos 1035, Length 16
        public long OptCtrctAmt{ get; set; } // [OptCtrctAmt  ,   16] 옵션약정금액                    StartPos 1051, Length 16
        public long FutsUnsttQty{ get; set; } // [FutsUnsttQty  ,   16] 선물미결제수량                  StartPos 1067, Length 16
        public long FutsUnsttAmt{ get; set; } // [FutsUnsttAmt  ,   16] 선물미결제금액                  StartPos 1083, Length 16
        public long OptUnsttQty{ get; set; } // [OptUnsttQty  ,   16] 옵션미결제수량                  StartPos 1099, Length 16
        public long OptUnsttAmt{ get; set; } // [OptUnsttAmt  ,   16] 옵션미결제금액                  StartPos 1115, Length 16
        public long FutsBuyUnsttQty{ get; set; } // [FutsBuyUnsttQty  ,   16] 선물매수미결제수량              StartPos 1131, Length 16
        public long FutsBuyUnsttAmt{ get; set; } // [FutsBuyUnsttAmt  ,   16] 선물매수미결제금액              StartPos 1147, Length 16
        public long FutsSellUnsttQty{ get; set; } // [FutsSellUnsttQty  ,   16] 선물매도미결제수량              StartPos 1163, Length 16
        public long FutsSellUnsttAmt{ get; set; } // [FutsSellUnsttAmt  ,   16] 선물매도미결제금액              StartPos 1179, Length 16
        public long OptBuyUnsttQty{ get; set; } // [OptBuyUnsttQty  ,   16] 옵션매수미결제수량              StartPos 1195, Length 16
        public long OptBuyUnsttAmt{ get; set; } // [OptBuyUnsttAmt  ,   16] 옵션매수미결제금액              StartPos 1211, Length 16
        public long OptSellUnsttQty{ get; set; } // [OptSellUnsttQty  ,   16] 옵션매도미결제수량              StartPos 1227, Length 16
        public long OptSellUnsttAmt{ get; set; } // [OptSellUnsttAmt  ,   16] 옵션매도미결제금액              StartPos 1243, Length 16
        public long FutsBuyctrQty{ get; set; } // [FutsBuyctrQty  ,   16] 선물매수약정수량                StartPos 1259, Length 16
        public long FutsBuyctrAmt{ get; set; } // [FutsBuyctrAmt  ,   16] 선물매수약정금액                StartPos 1275, Length 16
        public long FutsSlctrQty{ get; set; } // [FutsSlctrQty  ,   16] 선물매도약정수량                StartPos 1291, Length 16
        public long FutsSlctrAmt{ get; set; } // [FutsSlctrAmt  ,   16] 선물매도약정금액                StartPos 1307, Length 16
        public long OptBuyctrQty{ get; set; } // [OptBuyctrQty  ,   16] 옵션매수약정수량                StartPos 1323, Length 16
        public long OptBuyctrAmt{ get; set; } // [OptBuyctrAmt  ,   16] 옵션매수약정금액                StartPos 1339, Length 16
        public long OptSlctrQty{ get; set; } // [OptSlctrQty  ,   16] 옵션매도약정수량                StartPos 1355, Length 16
        public long OptSlctrAmt{ get; set; } // [OptSlctrAmt  ,   16] 옵션매도약정금액                StartPos 1371, Length 16
        public long FutsBnsplAmt{ get; set; } // [FutsBnsplAmt  ,   16] 선물매매손익금액                StartPos 1387, Length 16
        public long OptBnsplAmt{ get; set; } // [OptBnsplAmt  ,   16] 옵션매매손익금액                StartPos 1403, Length 16
        public long FutsEvalPnlAmt{ get; set; } // [FutsEvalPnlAmt  ,   16] 선물평가손익금액                StartPos 1419, Length 16
        public long OptEvalPnlAmt{ get; set; } // [OptEvalPnlAmt  ,   16] 옵션평가손익금액                StartPos 1435, Length 16
        public long FutsEvalAmt{ get; set; } // [FutsEvalAmt  ,   16] 선물평가금액                    StartPos 1451, Length 16
        public long OptEvalAmt{ get; set; } // [OptEvalAmt  ,   16] 옵션평가금액                    StartPos 1467, Length 16
        public long MktEndAfMnyInAmt{ get; set; } // [MktEndAfMnyInAmt  ,   16] 장종료후현금입금금액            StartPos 1483, Length 16
        public long MktEndAfMnyOutAmt{ get; set; } // [MktEndAfMnyOutAmt  ,   16] 장종료후현금출금금액            StartPos 1499, Length 16

        public long
            MktEndAfSubstDsgnAmt{ get; set; } // [MktEndAfSubstDsgnAmt  ,   16] 장종료후대용지정금액            StartPos 1515, Length 16

        public long
            MktEndAfSubstAbndAmt{ get; set; } // [MktEndAfSubstAbndAmt  ,   16] 장종료후대용해지금액            StartPos 1531, Length 16
    }
}