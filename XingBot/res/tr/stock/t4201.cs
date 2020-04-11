namespace XingBot.res
{
    // 주식차트(종합) ( ATTR,BLOCK,HEADTYPE=A )
    public class _t4201InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    1] 주기구분(0:틱1:분2:일3:주4:월)  StartPos 7, Length 1
        public long ncnt{ get; set; } // [long  ,    4] 틱개수                          StartPos 9, Length 4
        public long qrycnt{ get; set; } // [long  ,    4] 건수(500건이하)                 StartPos 14, Length 4
        public string tdgb{ get; set; } // [string,    1] 당일구분(0:전체1:당일만)        StartPos 19, Length 1
        public string sdate{ get; set; } // [string,    8] 시작일자                        StartPos 21, Length 8
        public string edate{ get; set; } // [string,    8] 종료일자                        StartPos 30, Length 8
        public string cts_date{ get; set; } // [string,    8] 연속일자                        StartPos 39, Length 8
        public string cts_time{ get; set; } // [string,   10] 연속시간                        StartPos 48, Length 10
        public string cts_daygb{ get; set; } // [string,    1] 연속당일구분(0:연속전체1:연속당 StartPos 59, Length 1
    }

    public class _t4201OutBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public long jisiga{ get; set; } // [long  ,    8] 전일시가                        StartPos 7, Length 8
        public long jihigh{ get; set; } // [long  ,    8] 전일고가                        StartPos 16, Length 8
        public long jilow{ get; set; } // [long  ,    8] 전일저가                        StartPos 25, Length 8
        public long jiclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 34, Length 8
        public long jivolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 43, Length 12
        public long disiga{ get; set; } // [long  ,    8] 당일시가                        StartPos 56, Length 8
        public long dihigh{ get; set; } // [long  ,    8] 당일고가                        StartPos 65, Length 8
        public long dilow{ get; set; } // [long  ,    8] 당일저가                        StartPos 74, Length 8
        public long diclose{ get; set; } // [long  ,    8] 당일종가                        StartPos 83, Length 8
        public long highend{ get; set; } // [long  ,    8] 상한가                          StartPos 92, Length 8
        public long lowend{ get; set; } // [long  ,    8] 하한가                          StartPos 101, Length 8
        public string cts_date{ get; set; } // [string,    8] 연속일자                        StartPos 110, Length 8
        public string cts_time{ get; set; } // [string,   10] 연속시간                        StartPos 119, Length 10
        public string cts_daygb{ get; set; } // [string,    1] 연속당일구분                    StartPos 130, Length 1
    }

    public class _t4201OutBlock1
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public string time{ get; set; } // [string,   10] 시간                            StartPos 9, Length 10
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 20, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 29, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 38, Length 8
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 47, Length 8
        public long jdiff_vol{ get; set; } // [long  ,   12] 거래량                          StartPos 56, Length 12
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 69, Length 12
        public long jongchk{ get; set; } // [long  ,   13] 수정구분                        StartPos 82, Length 13
        public decimal rate{ get; set; } // [double,  6.2] 수정비율                        StartPos 96, Length 6
        public long pricechk{ get; set; } // [long  ,   13] 수정주가반영항목                StartPos 103, Length 13
        public long ratevalue{ get; set; } // [long  ,   12] 수정비율반영거래대금            StartPos 117, Length 12
    }
}