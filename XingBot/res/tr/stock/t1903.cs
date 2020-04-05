namespace XingBot.res.tr
{
    // ETF 일별추이 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1903InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public string date; // [string,    8] 일자                            StartPos 7, Length 8
    }

    internal struct _t1903OutBlock
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public string hname; // [string,   20] 종목명                          StartPos 9, Length 20
        public string upname; // [string,   20] 업종지수명                      StartPos 30, Length 20
    }

    internal struct _t1903OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public float volume; // [float ,   12] 누적거래량                      StartPos 29, Length 12
        public float navdiff; // [float ,  9.2] NAV대비                         StartPos 42, Length 9
        public float nav; // [float ,  9.2] NAV                             StartPos 52, Length 9
        public float navchange; // [float ,  9.2] 전일대비                        StartPos 62, Length 9
        public float crate; // [float ,  9.2] 추적오차                        StartPos 72, Length 9
        public float grate; // [float ,  9.2] 괴리                            StartPos 82, Length 9
        public float jisu; // [float ,  8.2] 지수                            StartPos 92, Length 8
        public float jichange; // [float ,  8.2] 전일대비                        StartPos 101, Length 8
        public float jirate; // [float ,  8.2] 전일대비율                      StartPos 110, Length 8
    }
}