namespace XingBot.res
{
    // 선물/옵션챠트(일주월) ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t8416InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string gubun; // [string,    1] 주기구분(2:일3:주4:월)          StartPos 9, Length 1
        public long qrycnt; // [long  ,    4] 요청건수(최대-압축:2000비압축:5 StartPos 11, Length 4
        public string sdate; // [string,    8] 시작일자                        StartPos 16, Length 8
        public string edate; // [string,    8] 종료일자                        StartPos 25, Length 8
        public string cts_date; // [string,    8] 연속일자                        StartPos 34, Length 8
        public string comp_yn; // [string,    1] 압축여부(Y:압축N:비압축)        StartPos 43, Length 1
    }

    internal struct _t8416OutBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public float jisiga; // [float ,  6.2] 전일시가                        StartPos 9, Length 6
        public float jihigh; // [float ,  6.2] 전일고가                        StartPos 16, Length 6
        public float jilow; // [float ,  6.2] 전일저가                        StartPos 23, Length 6
        public float jiclose; // [float ,  6.2] 전일종가                        StartPos 30, Length 6
        public long jivolume; // [long  ,   12] 전일거래량                      StartPos 37, Length 12
        public float disiga; // [float ,  6.2] 당일시가                        StartPos 50, Length 6
        public float dihigh; // [float ,  6.2] 당일고가                        StartPos 57, Length 6
        public float dilow; // [float ,  6.2] 당일저가                        StartPos 64, Length 6
        public float diclose; // [float ,  6.2] 당일종가                        StartPos 71, Length 6
        public float highend; // [float ,  6.2] 상한가                          StartPos 78, Length 6
        public float lowend; // [float ,  6.2] 하한가                          StartPos 85, Length 6
        public string cts_date; // [string,    8] 연속일자                        StartPos 92, Length 8
        public string s_time; // [string,    6] 장시작시간(HHMMSS)              StartPos 101, Length 6
        public string e_time; // [string,    6] 장종료시간(HHMMSS)              StartPos 108, Length 6
        public string dshmin; // [string,    2] 동시호가처리시간(MM:분)         StartPos 115, Length 2
        public long rec_count; // [long  ,    7] 레코드카운트                    StartPos 118, Length 7
    }

    internal struct _t8416OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public float open; // [float ,  6.2] 시가                            StartPos 9, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 16, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 23, Length 6
        public float close; // [float ,  6.2] 종가                            StartPos 30, Length 6
        public long jdiff_vol; // [long  ,   12] 누적거래량                      StartPos 37, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 50, Length 12
        public long openyak; // [long  ,   12] 미결제약정                      StartPos 63, Length 12
    }
}