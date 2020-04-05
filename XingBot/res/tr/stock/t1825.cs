namespace XingBot.res.tr
{
    // 종목Q클릭검색 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1825InBlock
    {
        public string search_cd; // [string,    4] 검색코드                        StartPos 0, Length 4
        public string gubun; // [string,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 5, Length 1
    }

    internal struct _t1825OutBlock
    {
        public long JongCnt; // [long  ,    4] 검색종목수                      StartPos 0, Length 4
    }

    internal struct _t1825OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   20] 종목명                          StartPos 7, Length 20
        public string sign; // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public long signcnt; // [long  ,    3] 연속봉수                        StartPos 30, Length 3
        public long close; // [long  ,    9] 현재가                          StartPos 34, Length 9
        public long change; // [long  ,    9] 전일대비                        StartPos 44, Length 9
        public float diff; // [float ,  6.2] 등락율                          StartPos 54, Length 6
        public long volume; // [long  ,   10] 거래량                          StartPos 61, Length 10
        public float volumerate; // [float ,  6.2] 거래량전일대비율                StartPos 72, Length 6
    }
}