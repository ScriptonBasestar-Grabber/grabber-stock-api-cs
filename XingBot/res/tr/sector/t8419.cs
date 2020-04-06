namespace XingBot.res
{
    // 업종챠트(일주월) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8419InBlock
    {
        public string shcode; // [string,    3] 단축코드                        StartPos 0, Length 3
        public string gubun; // [string,    1] 주기구분(2:일3:주4:월)          StartPos 4, Length 1
        public long qrycnt; // [long  ,    4] 요청건수(최대-압축:2000비압축:5 StartPos 6, Length 4
        public string sdate; // [string,    8] 시작일자                        StartPos 11, Length 8
        public string edate; // [string,    8] 종료일자                        StartPos 20, Length 8
        public string cts_date; // [string,    8] 연속일자                        StartPos 29, Length 8
        public string comp_yn; // [string,    1] 압축여부(Y:압축N:비압축)        StartPos 38, Length 1
    }

    public struct _t8419OutBlock
    {
        public string shcode; // [string,    3] 단축코드                        StartPos 0, Length 3
        public decimal jisiga; // [float ,  7.2] 전일시가                        StartPos 4, Length 7
        public decimal jihigh; // [float ,  7.2] 전일고가                        StartPos 12, Length 7
        public decimal jilow; // [float ,  7.2] 전일저가                        StartPos 20, Length 7
        public decimal jiclose; // [float ,  7.2] 전일종가                        StartPos 28, Length 7
        public long jivolume; // [long  ,   12] 전일거래량                      StartPos 36, Length 12
        public decimal disiga; // [float ,  7.2] 당일시가                        StartPos 49, Length 7
        public decimal dihigh; // [float ,  7.2] 당일고가                        StartPos 57, Length 7
        public decimal dilow; // [float ,  7.2] 당일저가                        StartPos 65, Length 7
        public decimal diclose; // [float ,  7.2] 당일종가                        StartPos 73, Length 7
        public long disvalue; // [long  ,   12] 당일거래대금                    StartPos 81, Length 12
        public string cts_date; // [string,    8] 연속일자                        StartPos 94, Length 8
        public string s_time; // [string,    6] 업종시작시간                    StartPos 103, Length 6
        public string e_time; // [string,    6] 업종종료시간                    StartPos 110, Length 6
        public string dshmin; // [string,    2] 동시호가처리시간(MM:분)         StartPos 117, Length 2
        public long rec_count; // [long  ,    7] 레코드카운트                    StartPos 120, Length 7
    }

    public struct _t8419OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public decimal open; // [float ,  7.2] 시가                            StartPos 9, Length 7
        public decimal high; // [float ,  7.2] 고가                            StartPos 17, Length 7
        public decimal low; // [float ,  7.2] 저가                            StartPos 25, Length 7
        public decimal close; // [float ,  7.2] 종가                            StartPos 33, Length 7
        public long jdiff_vol; // [long  ,   12] 거래량                          StartPos 41, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 54, Length 12
    }
}