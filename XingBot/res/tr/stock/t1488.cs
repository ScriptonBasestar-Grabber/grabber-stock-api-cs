namespace XingBot.res
{
    // 예상체결가 등락율 상위조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1488InBlock
    {
        public string gubun{ get; set; } // [string,    1] 거래소구분                      StartPos 0, Length 1
        public string sign{ get; set; } // [string,    1] 상하락구분                      StartPos 2, Length 1
        public string jgubun{ get; set; } // [string,    1] 장구분                          StartPos 4, Length 1
        public string jongchk{ get; set; } // [string,   12] 종목체크                        StartPos 6, Length 12
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 19, Length 4
        public string volume{ get; set; } // [string,    1] 거래량                          StartPos 24, Length 1
        public long yesprice{ get; set; } // [long  ,    8] 예상체결시작가격                StartPos 26, Length 8
        public long yeeprice{ get; set; } // [long  ,    8] 예상체결종료가격                StartPos 35, Length 8
        public long yevolume{ get; set; } // [long  ,   12] 예상체결량                      StartPos 44, Length 12
    }

    public class _t1488OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public class _t1488OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long offerrem{ get; set; } // [long  ,    8] 매도잔량                        StartPos 61, Length 8
        public long offerho{ get; set; } // [long  ,    8] 매도호가                        StartPos 70, Length 8
        public long bidho{ get; set; } // [long  ,    8] 매수호가                        StartPos 79, Length 8
        public long bidrem{ get; set; } // [long  ,    8] 매수잔량                        StartPos 88, Length 8
        public long cnt{ get; set; } // [long  ,    4] 연속일수                        StartPos 97, Length 4
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 102, Length 6
        public string jkrate{ get; set; } // [string,    3] 증거금율                        StartPos 109, Length 3
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 113, Length 12
    }
}