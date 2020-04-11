namespace XingBot.res
{
    // 예상지수 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1485InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 0, Length 3
        public string gubun{ get; set; } // [string,    1] 조회구분                        StartPos 4, Length 1
    }

    public class _t1485OutBlock
    {
        public decimal pricejisu{ get; set; } // [float , 10.2] 현재지수                        StartPos 0, Length 10
        public string sign{ get; set; } // [string,    1] 지수전일대비구분                StartPos 11, Length 1
        public decimal change{ get; set; } // [float , 10.2] 전일대비                        StartPos 13, Length 10
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 24, Length 12
        public long yhighjo{ get; set; } // [long  ,    4] 상승종목수                      StartPos 37, Length 4
        public long yupjo{ get; set; } // [long  ,    4] 상한종목수                      StartPos 42, Length 4
        public long yunchgjo{ get; set; } // [long  ,    4] 보합종목수                      StartPos 47, Length 4
        public long ylowjo{ get; set; } // [long  ,    4] 하락종목수                      StartPos 52, Length 4
        public long ydownjo{ get; set; } // [long  ,    4] 하한종목수                      StartPos 57, Length 4
        public long ytrajo{ get; set; } // [long  ,    4] 거래형성수                      StartPos 62, Length 4
    }

    public class _t1485OutBlock1
    {
        public string chetime{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public decimal jisu{ get; set; } // [float , 10.2] 예상지수                        StartPos 7, Length 10
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public decimal change{ get; set; } // [float , 10.2] 전일대비                        StartPos 20, Length 10
        public long volume{ get; set; } // [long  ,   12] 예상체결량                      StartPos 31, Length 12
        public long volcha{ get; set; } // [long  ,   12] 예상체결량직전대비              StartPos 44, Length 12
    }
}