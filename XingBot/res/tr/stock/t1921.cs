namespace XingBot.res
{
    // 신용거래동향 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1921InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    1] 융자대주구분                    StartPos 7, Length 1
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 9, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 18, Length 4
    }

    public class _t1921OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] CNT                             StartPos 0, Length 4
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 5, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 14, Length 4
    }

    public class _t1921OutBlock1
    {
        public string mmdate{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long jchange{ get; set; } // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long nvolume{ get; set; } // [long  ,    8] 신규                            StartPos 36, Length 8
        public long svolume{ get; set; } // [long  ,    8] 상환                            StartPos 45, Length 8
        public long jvolume{ get; set; } // [long  ,    8] 잔고                            StartPos 54, Length 8
        public long price{ get; set; } // [long  ,    8] 금액                            StartPos 63, Length 8
        public long change{ get; set; } // [long  ,    8] 대비                            StartPos 72, Length 8
        public decimal gyrate{ get; set; } // [float ,  6.2] 공여율                          StartPos 81, Length 6
        public decimal jkrate{ get; set; } // [float ,  6.2] 잔고율                          StartPos 88, Length 6
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 95, Length 6
    }
}