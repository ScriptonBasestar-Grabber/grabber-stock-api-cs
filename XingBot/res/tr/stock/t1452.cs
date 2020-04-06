namespace XingBot.res
{
    // 거래량상위 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1452InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string jnilgubun; // [string,    1] 전일구분                        StartPos 2, Length 1
        public long sdiff; // [long  ,    3] 시작등락율                      StartPos 4, Length 3
        public long ediff; // [long  ,    3] 종료등락율                      StartPos 8, Length 3
        public long jc_num; // [long  ,   12] 대상제외                        StartPos 12, Length 12
        public long sprice; // [long  ,    8] 시작가격                        StartPos 25, Length 8
        public long eprice; // [long  ,    8] 종료가격                        StartPos 34, Length 8
        public long volume; // [long  ,   12] 거래량                          StartPos 43, Length 12
        public long idx; // [long  ,    4] IDX                             StartPos 56, Length 4
    }

    public struct _t1452OutBlock
    {
        public long idx; // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public struct _t1452OutBlock1
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public decimal vol; // [float ,  6.2] 회전율                          StartPos 61, Length 6
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 68, Length 12
        public decimal bef_diff; // [float , 10.2] 전일비                          StartPos 81, Length 10
        public string shcode; // [string,    6] 종목코드                        StartPos 92, Length 6
    }
}