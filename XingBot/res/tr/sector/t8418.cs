namespace XingBot.res
{
    // 업종챠트(N분) ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8418InBlock
    {
        public string shcode{ get; set; } // [string,    3] 단축코드                        StartPos 0, Length 3
        public long ncnt{ get; set; } // [long  ,    4] 단위(n분)                       StartPos 4, Length 4
        public long qrycnt{ get; set; } // [long  ,    4] 요청건수(최대-압축:2000비압축:5 StartPos 9, Length 4
        public string nday{ get; set; } // [string,    1] 조회영업일수(0:미사용1>=사용)   StartPos 14, Length 1
        public string sdate{ get; set; } // [string,    8] 시작일자                        StartPos 16, Length 8
        public string stime{ get; set; } // [string,    6] 시작시간(현재미사용)            StartPos 25, Length 6
        public string edate{ get; set; } // [string,    8] 종료일자                        StartPos 32, Length 8
        public string etime{ get; set; } // [string,    6] 종료시간(현재미사용)            StartPos 41, Length 6
        public string cts_date{ get; set; } // [string,    8] 연속일자                        StartPos 48, Length 8
        public string cts_time{ get; set; } // [string,   10] 연속시간                        StartPos 57, Length 10
        public string comp_yn{ get; set; } // [string,    1] 압축여부(Y:압축N:비압축)        StartPos 68, Length 1
    }

    public class _t8418OutBlock
    {
        public string shcode{ get; set; } // [string,    3] 단축코드                        StartPos 0, Length 3
        public decimal jisiga{ get; set; } // [float ,  7.2] 전일시가                        StartPos 4, Length 7
        public decimal jihigh{ get; set; } // [float ,  7.2] 전일고가                        StartPos 12, Length 7
        public decimal jilow{ get; set; } // [float ,  7.2] 전일저가                        StartPos 20, Length 7
        public decimal jiclose{ get; set; } // [float ,  7.2] 전일종가                        StartPos 28, Length 7
        public long jivolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 36, Length 12
        public decimal disiga{ get; set; } // [float ,  7.2] 당일시가                        StartPos 49, Length 7
        public decimal dihigh{ get; set; } // [float ,  7.2] 당일고가                        StartPos 57, Length 7
        public decimal dilow{ get; set; } // [float ,  7.2] 당일저가                        StartPos 65, Length 7
        public decimal diclose{ get; set; } // [float ,  7.2] 당일종가                        StartPos 73, Length 7
        public long disvalue{ get; set; } // [long  ,   12] 당일거래대금                    StartPos 81, Length 12
        public string cts_date{ get; set; } // [string,    8] 연속일자                        StartPos 94, Length 8
        public string cts_time{ get; set; } // [string,   10] 연속시간                        StartPos 103, Length 10
        public string s_time{ get; set; } // [string,    6] 업종시작시간(HHMMSS)            StartPos 114, Length 6
        public string e_time{ get; set; } // [string,    6] 업종종료시간(HHMMSS)            StartPos 121, Length 6
        public string dshmin{ get; set; } // [string,    2] 동시호가처리시간(MM:분)         StartPos 128, Length 2
        public long rec_count{ get; set; } // [long  ,    7] 레코드카운트                    StartPos 131, Length 7
    }

    public class _t8418OutBlock1
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public decimal open{ get; set; } // [float ,  7.2] 시가                            StartPos 16, Length 7
        public decimal high{ get; set; } // [float ,  7.2] 고가                            StartPos 24, Length 7
        public decimal low{ get; set; } // [float ,  7.2] 저가                            StartPos 32, Length 7
        public decimal close{ get; set; } // [float ,  7.2] 종가                            StartPos 40, Length 7
        public long jdiff_vol{ get; set; } // [long  ,   12] 거래량                          StartPos 48, Length 12
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 61, Length 12
    }
}