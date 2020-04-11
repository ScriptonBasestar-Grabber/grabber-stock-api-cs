namespace XingBot.res
{
    // 선물옵션 계좌예탁금증거금조회 ( ENCRYPT,SERVICE=CFOBQ10500,HEADTYPE=B,CREATOR=정명기,CREDATE=2012/03/12 15:03:11 )
    public class _CFOBQ10500InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
    }

    public class _CFOBQ10500OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string Pwd{ get; set; } // [Pwd,    8] 비밀번호                        StartPos 25, Length 8
    }

    public class _CFOBQ10500OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public long DpsamtTotamt{ get; set; } // [DpsamtTotamt  ,   16] 예탁금총액                      StartPos 45, Length 16
        public long Dps{ get; set; } // [Dps  ,   16] 예수금                          StartPos 61, Length 16
        public long SubstAmt{ get; set; } // [SubstAmt  ,   16] 대용금액                        StartPos 77, Length 16
        public long FilupDpsamtTotamt{ get; set; } // [FilupDpsamtTotamt  ,   16] 충당예탁금총액                  StartPos 93, Length 16
        public long FilupDps{ get; set; } // [FilupDps  ,   16] 충당예수금                      StartPos 109, Length 16
        public long FutsPnlAmt{ get; set; } // [FutsPnlAmt  ,   16] 선물손익금액                    StartPos 125, Length 16
        public long WthdwAbleAmt{ get; set; } // [WthdwAbleAmt  ,   16] 인출가능금액                    StartPos 141, Length 16
        public long PsnOutAbleCurAmt{ get; set; } // [PsnOutAbleCurAmt  ,   16] 인출가능현금액                  StartPos 157, Length 16
        public long PsnOutAbleSubstAmt{ get; set; } // [PsnOutAbleSubstAmt  ,   16] 인출가능대용금액                StartPos 173, Length 16
        public long Mgn{ get; set; } // [Mgn  ,   16] 증거금액                        StartPos 189, Length 16
        public long MnyMgn{ get; set; } // [MnyMgn  ,   16] 현금증거금액                    StartPos 205, Length 16
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 221, Length 16
        public long MnyOrdAbleAmt{ get; set; } // [MnyOrdAbleAmt  ,   16] 현금주문가능금액                StartPos 237, Length 16
        public long AddMgn{ get; set; } // [AddMgn  ,   16] 추가증거금액                    StartPos 253, Length 16
        public long MnyAddMgn{ get; set; } // [MnyAddMgn  ,   16] 현금추가증거금액                StartPos 269, Length 16
        public long AmtPrdayChckInAmt{ get; set; } // [AmtPrdayChckInAmt  ,   16] 금전일수표입금액                StartPos 285, Length 16
        public long FnoPrdaySubstSellAmt{ get; set; } // [FnoPrdaySubstSellAmt  ,   16] 선물옵션전일대용매도금액        StartPos 301, Length 16
        public long FnoCrdaySubstSellAmt{ get; set; } // [FnoCrdaySubstSellAmt  ,   16] 선물옵션금일대용매도금액        StartPos 317, Length 16
        public long FnoPrdayFdamt{ get; set; } // [FnoPrdayFdamt  ,   16] 선물옵션전일가입금액            StartPos 333, Length 16
        public long FnoCrdayFdamt{ get; set; } // [FnoCrdayFdamt  ,   16] 선물옵션금일가입금액            StartPos 349, Length 16
        public long FcurrSubstAmt{ get; set; } // [FcurrSubstAmt  ,   16] 외화대용금액                    StartPos 365, Length 16
        public string FnoAcntAfmgnNm{ get; set; } // [FnoAcntAfmgnNm,   20] 선물옵션계좌사후증거금명        StartPos 381, Length 20
    }

    public class _CFOBQ10500OutBlock3
    {
        public string PdGrpCodeNm{ get; set; } // [PdGrpCodeNm,   20] 상품군코드명                    StartPos 0, Length 20
        public long NetRiskMgn{ get; set; } // [NetRiskMgn  ,   16] 순위험증거금액                  StartPos 20, Length 16
        public long PrcMgn{ get; set; } // [PrcMgn  ,   16] 가격증거금액                    StartPos 36, Length 16
        public long SprdMgn{ get; set; } // [SprdMgn  ,   16] 스프레드증거금액                StartPos 52, Length 16
        public long PrcFlctMgn{ get; set; } // [PrcFlctMgn  ,   16] 가격변동증거금액                StartPos 68, Length 16
        public long MinMgn{ get; set; } // [MinMgn  ,   16] 최소증거금액                    StartPos 84, Length 16
        public long OrdMgn{ get; set; } // [OrdMgn  ,   16] 주문증거금액                    StartPos 100, Length 16
        public long OptNetBuyAmt{ get; set; } // [OptNetBuyAmt  ,   16] 옵션순매수금액                  StartPos 116, Length 16
        public long CsgnMgn{ get; set; } // [CsgnMgn  ,   16] 위탁증거금액                    StartPos 132, Length 16
        public long MaintMgn{ get; set; } // [MaintMgn  ,   16] 유지증거금액                    StartPos 148, Length 16
        public long FutsBuyExecAmt{ get; set; } // [FutsBuyExecAmt  ,   16] 선물매수체결금액                StartPos 164, Length 16
        public long FutsSellExecAmt{ get; set; } // [FutsSellExecAmt  ,   16] 선물매도체결금액                StartPos 180, Length 16
        public long OptBuyExecAmt{ get; set; } // [OptBuyExecAmt  ,   16] 옵션매수체결금액                StartPos 196, Length 16
        public long OptSellExecAmt{ get; set; } // [OptSellExecAmt  ,   16] 옵션매도체결금액                StartPos 212, Length 16
        public long FutsPnlAmt{ get; set; } // [FutsPnlAmt  ,   16] 선물손익금액                    StartPos 228, Length 16
        public long TotRiskCsgnMgn{ get; set; } // [TotRiskCsgnMgn  ,   16] 총위험위탁증거금                StartPos 244, Length 16
        public long UndCsgnMgn{ get; set; } // [UndCsgnMgn  ,   16] 인수도위탁증거금                StartPos 260, Length 16
        public long MgnRdctAmt{ get; set; } // [MgnRdctAmt  ,   16] 증거금감면금액                  StartPos 276, Length 16
    }
}