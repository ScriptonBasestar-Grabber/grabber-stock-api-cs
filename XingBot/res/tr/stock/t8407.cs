namespace XingBot.res
{
    // 주식멀티현재가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8407InBlock
    {
        public long nrec{ get; set; } // [long  ,    3] 건수                            StartPos 0, Length 3
        public string shcode{ get; set; } // [string,  300] 종목코드                        StartPos 4, Length 300
    }

    public class _t8407OutBlock1
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 7, Length 40
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 48, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 57, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 59, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 68, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 75, Length 12
        public long offerho{ get; set; } // [long  ,    8] 매도호가                        StartPos 88, Length 8
        public long bidho{ get; set; } // [long  ,    8] 매수호가                        StartPos 97, Length 8
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 106, Length 8
        public decimal chdegree{ get; set; } // [float ,  9.2] 체결강도                        StartPos 115, Length 9
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 125, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 134, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 143, Length 8
        public long value{ get; set; } // [long  ,   12] 거래대금(백만)                  StartPos 152, Length 12
        public long offerrem{ get; set; } // [long  ,   12] 우선매도잔량                    StartPos 165, Length 12
        public long bidrem{ get; set; } // [long  ,   12] 우선매수잔량                    StartPos 178, Length 12
        public long totofferrem{ get; set; } // [long  ,   12] 총매도잔량                      StartPos 191, Length 12
        public long totbidrem{ get; set; } // [long  ,   12] 총매수잔량                      StartPos 204, Length 12
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 217, Length 8
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 226, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 235, Length 8
    }
}