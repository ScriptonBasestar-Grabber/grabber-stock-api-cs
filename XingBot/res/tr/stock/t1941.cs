namespace XingBot.res
{
    // 종목별대차거래일간추이 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1941InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string sdate{ get; set; } // [string,    8] 시작일자                        StartPos 7, Length 8
        public string edate{ get; set; } // [string,    8] 종료일자                        StartPos 16, Length 8
    }

    public class _t1941OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public long price{ get; set; } // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign{ get; set; } // [string,    1] 대비구분                        StartPos 18, Length 1
        public long change{ get; set; } // [long  ,    8] 대비                            StartPos 20, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 36, Length 12
        public long upvolume{ get; set; } // [long  ,   12] 당일체결                        StartPos 49, Length 12
        public long dnvolume{ get; set; } // [long  ,   12] 당일상환                        StartPos 62, Length 12
        public long tovolume{ get; set; } // [long  ,   12] 당일잔고                        StartPos 75, Length 12
        public long tovalue{ get; set; } // [long  ,   12] 잔고금액                        StartPos 88, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 101, Length 6
        public long tovoldif{ get; set; } // [long  ,   12] 대차증감                        StartPos 108, Length 12
    }
}