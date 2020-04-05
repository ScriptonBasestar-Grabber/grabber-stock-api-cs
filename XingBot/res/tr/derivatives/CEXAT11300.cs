﻿namespace XingBot.res
{
    // EUREX 야간옵션 취소주문 ( SERVICE=CEXAT11300,HEADTYPE=B,CREATOR=이시종,CREDATE=2012/06/27 21:31:41 )

    internal struct _CEXAT11300InBlock1
    {
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 0, Length 10
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 10, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 30, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 38, Length 12
    }

    internal struct _CEXAT11300OutBlock1
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrgOrdNo; // [OrgOrdNo  ,   10] 원주문번호                      StartPos 5, Length 10
        public string AcntNo; // [AcntNo,   20] 계좌번호                        StartPos 15, Length 20
        public string Pwd; // [Pwd,    8] 비밀번호                        StartPos 35, Length 8
        public string FnoIsuNo; // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 43, Length 12
        public long CancQty; // [CancQty  ,   16] 취소수량                        StartPos 55, Length 16
        public string CommdaCode; // [CommdaCode,    2] 통신매체코드                    StartPos 71, Length 2
    }

    internal struct _CEXAT11300OutBlock2
    {
        public long RecCnt; // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public long OrdNo; // [OrdNo  ,   10] 주문번호                        StartPos 5, Length 10
        public string BrnNm; // [BrnNm,   40] 지점명                          StartPos 15, Length 40
        public string AcntNm; // [AcntNm,   40] 계좌명                          StartPos 55, Length 40
        public string IsuNm; // [IsuNm,   50] 종목명                          StartPos 95, Length 50
        public long OrdAbleAmt; // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 145, Length 16
        public long MnyOrdAbleAmt; // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 161, Length 16
        public long OrdMgn; // [OrdMgn  ,   16] 주문증거금액                    StartPos 177, Length 16
        public long MnyOrdMgn; // [MnyOrdMgn  ,   16] 현금주문증거금액                StartPos 193, Length 16
        public long OrdAbleQty; // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 209, Length 16
    }
}