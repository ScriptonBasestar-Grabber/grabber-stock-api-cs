namespace XingBot.res
{
    // 주식당일매매일지/수수료 ( TUXCODE=T0150, HEADTYPE=C )
    public class _t0150InBlock
    {
        public string accno{ get; set; } // [accno,   11] 계좌번호                        StartPos 0, Length 11
        public string cts_medosu{ get; set; } // [cts_medosu,    1] CTS_매매구분                    StartPos 11, Length 1
        public string cts_expcode{ get; set; } // [cts_expcode,   12] CTS_종목번호                    StartPos 12, Length 12
        public string cts_price{ get; set; } // [cts_price,    9] CTS_단가                        StartPos 24, Length 9
        public string cts_middiv{ get; set; } // [cts_middiv,    2] CTS_매체                        StartPos 33, Length 2
    }

    public class _t0150OutBlock
    {
        public long mdqty{ get; set; } // [mdqty  ,    9] 매도수량                        StartPos 0, Length 9
        public long mdamt{ get; set; } // [mdamt  ,   18] 매도약정금액                    StartPos 9, Length 18
        public long mdfee{ get; set; } // [mdfee  ,   18] 매도수수료                      StartPos 27, Length 18
        public long mdtax{ get; set; } // [mdtax  ,   18] 매도거래세                      StartPos 45, Length 18
        public long mdargtax{ get; set; } // [mdargtax  ,   18] 매도농특세                      StartPos 63, Length 18
        public long tmdtax{ get; set; } // [tmdtax  ,   18] 매도제비용합                    StartPos 81, Length 18
        public long mdadjamt{ get; set; } // [mdadjamt  ,   18] 매도정산금액                    StartPos 99, Length 18
        public long msqty{ get; set; } // [msqty  ,    9] 매수수량                        StartPos 117, Length 9
        public long msamt{ get; set; } // [msamt  ,   18] 매수약정금액                    StartPos 126, Length 18
        public long msfee{ get; set; } // [msfee  ,   18] 매수수수료                      StartPos 144, Length 18
        public long tmstax{ get; set; } // [tmstax  ,   18] 매수제비용합                    StartPos 162, Length 18
        public long msadjamt{ get; set; } // [msadjamt  ,   18] 매수정산금액                    StartPos 180, Length 18
        public long tqty{ get; set; } // [tqty  ,    9] 합계수량                        StartPos 198, Length 9
        public long tamt{ get; set; } // [tamt  ,   18] 합계약정금액                    StartPos 207, Length 18
        public long tfee{ get; set; } // [tfee  ,   18] 합계수수료                      StartPos 225, Length 18
        public long tottax{ get; set; } // [tottax  ,   18] 합계거래세                      StartPos 243, Length 18
        public long targtax{ get; set; } // [targtax  ,   18] 합계농특세                      StartPos 261, Length 18
        public long ttax{ get; set; } // [ttax  ,   18] 합계제비용합                    StartPos 279, Length 18
        public long tadjamt{ get; set; } // [tadjamt  ,   18] 합계정산금액                    StartPos 297, Length 18
        public string cts_medosu{ get; set; } // [cts_medosu,    1] CTS_매매구분                    StartPos 315, Length 1
        public string cts_expcode{ get; set; } // [cts_expcode,   12] CTS_종목번호                    StartPos 316, Length 12
        public string cts_price{ get; set; } // [cts_price,    9] CTS_단가                        StartPos 328, Length 9
        public string cts_middiv{ get; set; } // [cts_middiv,    2] CTS_매체                        StartPos 337, Length 2
    }

    public class _t0150OutBlock1
    {
        public string medosu{ get; set; } // [medosu,   10] 매매구분                        StartPos 0, Length 10
        public string expcode{ get; set; } // [expcode,   12] 종목번호                        StartPos 10, Length 12
        public long qty{ get; set; } // [qty  ,    9] 수량                            StartPos 22, Length 9
        public long price{ get; set; } // [price  ,    9] 단가                            StartPos 31, Length 9
        public long amt{ get; set; } // [amt  ,   18] 약정금액                        StartPos 40, Length 18
        public long fee{ get; set; } // [fee  ,   18] 수수료                          StartPos 58, Length 18
        public long tax{ get; set; } // [tax  ,   18] 거래세                          StartPos 76, Length 18
        public long argtax{ get; set; } // [argtax  ,   18] 농특세                          StartPos 94, Length 18
        public long adjamt{ get; set; } // [adjamt  ,   18] 정산금액                        StartPos 112, Length 18
        public string middiv{ get; set; } // [middiv,   20] 매체                            StartPos 130, Length 20
    }
}