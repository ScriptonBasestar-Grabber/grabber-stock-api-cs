namespace XingBot.res
{
    // 선물/옵션 잔고평가(이동평균) ( ATTR,TUXCODE=T0441,HEADTYPE=D )
    public class _t0441InBlock
    {
        public string accno{ get; set; } // [string,   11] 계좌번호                        StartPos 0, Length 11
        public string passwd{ get; set; } // [string,    8] 비밀번호                        StartPos 12, Length 8
        public string cts_expcode{ get; set; } // [string,    8] CTS_종목번호                    StartPos 21, Length 8
        public string cts_medocd{ get; set; } // [string,    1] CTS_매매구분                    StartPos 30, Length 1
    }

    public class _t0441OutBlock
    {
        public long tdtsunik{ get; set; } // [long  ,   18] 매매손익합계                    StartPos 0, Length 18
        public string cts_expcode{ get; set; } // [string,    8] CTS_종목번호                    StartPos 19, Length 8
        public string cts_medocd{ get; set; } // [string,    1] CTS_매매구분                    StartPos 28, Length 1
        public long tappamt{ get; set; } // [long  ,   18] 평가금액                        StartPos 30, Length 18
        public long tsunik{ get; set; } // [long  ,   18] 평가손익                        StartPos 49, Length 18
    }

    public class _t0441OutBlock1
    {
        public string expcode{ get; set; } // [string,    8] 종목번호                        StartPos 0, Length 8
        public string medosu{ get; set; } // [string,    4] 구분                            StartPos 9, Length 4
        public long jqty{ get; set; } // [long  ,   10] 잔고수량                        StartPos 14, Length 10
        public long cqty{ get; set; } // [long  ,   10] 청산가능수량                    StartPos 25, Length 10
        public decimal pamt{ get; set; } // [float , 10.2] 평균단가                        StartPos 36, Length 10
        public long mamt{ get; set; } // [long  ,   18] 총매입금액                      StartPos 47, Length 18
        public string medocd{ get; set; } // [string,    1] 매매구분                        StartPos 66, Length 1
        public long dtsunik{ get; set; } // [long  ,   18] 매매손익                        StartPos 68, Length 18
        public long sysprocseq{ get; set; } // [long  ,   10] 처리순번                        StartPos 87, Length 10
        public decimal price{ get; set; } // [float ,  9.2] 현재가                          StartPos 98, Length 9
        public long appamt{ get; set; } // [long  ,   18] 평가금액                        StartPos 108, Length 18
        public long dtsunik1{ get; set; } // [long  ,   18] 평가손익                        StartPos 127, Length 18
        public decimal sunikrt{ get; set; } // [float , 10.2] 수익율                          StartPos 146, Length 10
    }
}