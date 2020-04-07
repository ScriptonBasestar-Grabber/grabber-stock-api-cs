namespace XingBot.res
{
    // 주식챠트(N분) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8412InBlock
    {
        public string shcode{get;set;} //[string,    6] 단축코드                        StartPos 0, Length 6
        public long ncnt{get;set;} //[long  ,    4] 단위(n분)                       StartPos 7, Length 4
        public long qrycnt{get;set;} //[long  ,    4] 요청건수(최대-압축:2000비압축:5 StartPos 12, Length 4
        public string nday{get;set;} //[string,    1] 조회영업일수(0:미사용1>=사용)   StartPos 17, Length 1
        public string sdate{get;set;} //[string,    8] 시작일자                        StartPos 19, Length 8
        public string stime{get;set;} //[string,    6] 시작시간(현재미사용)            StartPos 28, Length 6
        public string edate{get;set;} //[string,    8] 종료일자                        StartPos 35, Length 8
        public string etime{get;set;} //[string,    6] 종료시간(현재미사용)            StartPos 44, Length 6
        public string cts_date{get;set;} //[string,    8] 연속일자                        StartPos 51, Length 8
        public string cts_time{get;set;} //[string,   10] 연속시간                        StartPos 60, Length 10
        public string comp_yn{get;set;} //[string,    1] 압축여부(Y:압축N:비압축)        StartPos 71, Length 1
    }

    public struct _t8412OutBlock
    {
        public string shcode{get;set;} //[string,    6] 단축코드                        StartPos 0, Length 6
        public long jisiga{get;set;} //[long  ,    8] 전일시가                        StartPos 7, Length 8
        public long jihigh{get;set;} //[long  ,    8] 전일고가                        StartPos 16, Length 8
        public long jilow{get;set;} //[long  ,    8] 전일저가                        StartPos 25, Length 8
        public long jiclose{get;set;} //[long  ,    8] 전일종가                        StartPos 34, Length 8
        public long jivolume{get;set;} //[long  ,   12] 전일거래량                      StartPos 43, Length 12
        public long disiga{get;set;} //[long  ,    8] 당일시가                        StartPos 56, Length 8
        public long dihigh{get;set;} //[long  ,    8] 당일고가                        StartPos 65, Length 8
        public long dilow{get;set;} //[long  ,    8] 당일저가                        StartPos 74, Length 8
        public long diclose{get;set;} //[long  ,    8] 당일종가                        StartPos 83, Length 8
        public long highend{get;set;} //[long  ,    8] 상한가                          StartPos 92, Length 8
        public long lowend{get;set;} //[long  ,    8] 하한가                          StartPos 101, Length 8
        public string cts_date{get;set;} //[string,    8] 연속일자                        StartPos 110, Length 8
        public string cts_time{get;set;} //[string,   10] 연속시간                        StartPos 119, Length 10
        public string s_time{get;set;} //[string,    6] 장시작시간(HHMMSS)              StartPos 130, Length 6
        public string e_time{get;set;} //[string,    6] 장종료시간(HHMMSS)              StartPos 137, Length 6
        public string dshmin{get;set;} //[string,    2] 동시호가처리시간(MM:분)         StartPos 144, Length 2
        public long rec_count{get;set;} //[long  ,    7] 레코드카운트                    StartPos 147, Length 7
    }

    public struct _t8412OutBlock1
    {
        public string date{get;set;} //[string,    8] 날짜                            StartPos 0, Length 8
        public string time{get;set;} //[string,   10] 시간                            StartPos 9, Length 10
        public long open{get;set;} //[long  ,    8] 시가                            StartPos 20, Length 8
        public long high{get;set;} //[long  ,    8] 고가                            StartPos 29, Length 8
        public long low{get;set;} //[long  ,    8] 저가                            StartPos 38, Length 8
        public long close{get;set;} //[long  ,    8] 종가                            StartPos 47, Length 8
        public long jdiff_vol{get;set;} //[long  ,   12] 거래량                          StartPos 56, Length 12
        public long value{get;set;} //[long  ,   12] 거래대금                        StartPos 69, Length 12
        public long jongchk{get;set;} //[long  ,   13] 수정구분                        StartPos 82, Length 13
        public double rate{get;set;} //[double,  6.2] 수정비율                        StartPos 96, Length 6
        public string sign{get;set;} //[string,    1] 종가등락구분(1:상한2:상승3:보합 StartPos 103, Length 1
    }
}
