namespace XingBot.res
{
    // 업종별 종목시세 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1516InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 0, Length 3
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 4, Length 1
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 6, Length 6
    }

    public class _t1516OutBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public decimal pricejisu{ get; set; } // [float , 12.2] 지수                            StartPos 7, Length 12
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public decimal change{ get; set; } // [float ,  7.2] 전일대비                        StartPos 22, Length 7
        public decimal jdiff{ get; set; } // [float ,  6.2] 등락율                          StartPos 30, Length 6
    }

    public class _t1516OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 61, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 70, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 79, Length 8
        public decimal sojinrate{ get; set; } // [float ,  6.2] 소진율                          StartPos 88, Length 6
        public decimal beta{ get; set; } // [float ,  6.5] 베타계수                        StartPos 95, Length 6
        public decimal perx{ get; set; } // [float ,  8.2] PER                             StartPos 102, Length 8
        public long frgsvolume{ get; set; } // [long  ,   12] 외인순매수                      StartPos 111, Length 12
        public long orgsvolume{ get; set; } // [long  ,   12] 기관순매수                      StartPos 124, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 137, Length 10
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 148, Length 6
        public long total{ get; set; } // [long  ,   12] 시가총액                        StartPos 155, Length 12
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 168, Length 12
    }
}