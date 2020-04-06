namespace XingBot.real.res
{
    // 해외지수조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t3521InBlock
    {
        public string kind; // [string,    1] 종목종류                        StartPos 0, Length 1
        public string symbol; // [string,   16] SYMBOL                          StartPos 2, Length 16
    }

    public struct _t3521OutBlock
    {
        public string symbol; // [string,   16] 심벌                            StartPos 0, Length 16
        public string hname; // [string,   20] 지수명                          StartPos 17, Length 20
        public decimal close; // [float , 12.2] 지수                            StartPos 38, Length 12
        public string sign; // [string,    1] 대비구분                        StartPos 51, Length 1
        public decimal change; // [float ,  6.2] 대비                            StartPos 53, Length 6
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 60, Length 6
        public string date; // [string,    8] 일자                            StartPos 67, Length 8
    }
}