namespace XingBot.res.tr
{
    // 예상체결량상위조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1489InBlock
    {
        public string gubun; // [string,    1] 거래소구분                      StartPos 0, Length 1
        public string jgubun; // [string,    1] 장구분                          StartPos 2, Length 1
        public string jongchk; // [string,   12] 종목체크                        StartPos 4, Length 12
        public long idx; // [long  ,    4] IDX                             StartPos 17, Length 4
        public long yesprice; // [long  ,    8] 예상체결시작가격                StartPos 22, Length 8
        public long yeeprice; // [long  ,    8] 예상체결종료가격                StartPos 31, Length 8
        public long yevolume; // [long  ,   12] 예상체결량                      StartPos 40, Length 12
    }

    internal struct _t1489OutBlock
    {
        public long idx; // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    internal struct _t1489OutBlock1
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 예상거래량                      StartPos 48, Length 12
        public long offerho; // [long  ,    8] 매도호가                        StartPos 61, Length 8
        public long bidho; // [long  ,    8] 매수호가                        StartPos 70, Length 8
        public string shcode; // [string,    6] 종목코드                        StartPos 79, Length 6
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 86, Length 12
    }
}