namespace XingBot.res
{
    // ELW종목조회 ( BLOCK,HEADTYPE=A )
    public class _t8431InBlock
    {
        public string dummy{ get; set; } // [string,    1] Dummy                           StartPos 0, Length 1
    }

    public class _t8431OutBlock
    {
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 0, Length 40
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 40, Length 6
        public string expcode{ get; set; } // [string,   12] 확장코드                        StartPos 46, Length 12
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 58, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 66, Length 8
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 74, Length 8
        public long recprice{ get; set; } // [long  ,    8] 기준가                          StartPos 82, Length 8
    }
}