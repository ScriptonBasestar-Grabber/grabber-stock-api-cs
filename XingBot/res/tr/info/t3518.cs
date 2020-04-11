namespace XingBot.res
{
    // 해외실시간지수 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t3518InBlock
    {
        public string kind{ get; set; } // [string,    1] 종목종류                        StartPos 0, Length 1
        public string symbol{ get; set; } // [string,   16] SYMBOL                          StartPos 2, Length 16
        public long cnt{ get; set; } // [long  ,    4] 입력건수                        StartPos 19, Length 4
        public string jgbn{ get; set; } // [string,    1] 조회구분                        StartPos 24, Length 1
        public long nmin{ get; set; } // [long  ,    3] N분                             StartPos 26, Length 3
        public string cts_date{ get; set; } // [string,    8] CTS_DATE                        StartPos 30, Length 8
        public string cts_time{ get; set; } // [string,    6] CTS_TIME                        StartPos 39, Length 6
    }

    public class _t3518OutBlock
    {
        public string cts_date{ get; set; } // [string,    8] CTS_DATE                        StartPos 0, Length 8
        public string cts_time{ get; set; } // [string,    6] CTS_TIME                        StartPos 9, Length 6
    }

    public class _t3518OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    8] 시간                            StartPos 9, Length 8
        public decimal open{ get; set; } // [double,  9.4] 시가                            StartPos 18, Length 9
        public decimal high{ get; set; } // [double,  9.4] 고가                            StartPos 28, Length 9
        public decimal low{ get; set; } // [double,  9.4] 저가                            StartPos 38, Length 9
        public decimal price{ get; set; } // [double,  9.4] 현재가                          StartPos 48, Length 9
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 58, Length 1
        public decimal change{ get; set; } // [double,  9.4] 전일대비                        StartPos 60, Length 9
        public decimal uprate{ get; set; } // [double,  9.4] 등락율                          StartPos 70, Length 9
        public decimal volume{ get; set; } // [double,   12] 누적거래량                      StartPos 80, Length 12
        public decimal bidho{ get; set; } // [double,  9.4] 매수호가                        StartPos 93, Length 9
        public decimal offerho{ get; set; } // [double,  9.4] 매도호가                        StartPos 103, Length 9
        public decimal bidrem{ get; set; } // [double,   12] 매수잔량                        StartPos 113, Length 12
        public decimal offerrem{ get; set; } // [double,   12] 매도잔량                        StartPos 126, Length 12
        public string kind{ get; set; } // [string,    1] 종목종류                        StartPos 139, Length 1
        public string symbol{ get; set; } // [string,   16] SYMBOL                          StartPos 141, Length 16
        public string exid{ get; set; } // [string,    4] EXID                            StartPos 158, Length 4
        public string kodate{ get; set; } // [string,    8] 한국일자                        StartPos 163, Length 8
        public string kotime{ get; set; } // [string,    8] 한국시간                        StartPos 172, Length 8
    }
}