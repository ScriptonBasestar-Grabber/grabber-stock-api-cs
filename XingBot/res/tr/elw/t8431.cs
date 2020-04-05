namespace XingBot.res
{
    // ELW종목조회 ( BLOCK,HEADTYPE=A )
    internal struct _t8431InBlock
    {
        public string dummy; // [string,    1] Dummy                           StartPos 0, Length 1
    }

    internal struct _t8431OutBlock
    {
        public string hname; // [string,   40] 종목명                          StartPos 0, Length 40
        public string shcode; // [string,    6] 단축코드                        StartPos 40, Length 6
        public string expcode; // [string,   12] 확장코드                        StartPos 46, Length 12
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 58, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 66, Length 8
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 74, Length 8
        public long recprice; // [long  ,    8] 기준가                          StartPos 82, Length 8
    }
}