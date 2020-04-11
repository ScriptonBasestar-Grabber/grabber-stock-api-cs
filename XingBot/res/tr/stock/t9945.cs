namespace XingBot.res
{
    // 주식마스터조회 API용 ( BLOCK,HEADTYPE=A )
    // t8436 사용
    public class _t9945InBlock
    {
        public string gubun{ get; set; } // [gubun,    1] 구분(KSP:1KSD:2)                StartPos 0, Length 1
    }

    public class _t9945OutBlock
    {
        public string hname{ get; set; } // [hname,   40] 종목명                          StartPos 0, Length 40
        public string shcode{ get; set; } // [shcode,    6] 단축코드                        StartPos 40, Length 6
        public string expcode{ get; set; } // [expcode,   12] 확장코드                        StartPos 46, Length 12
        public string etfchk{ get; set; } // [etfchk,    1] ETF구분                         StartPos 58, Length 1
        public string filler{ get; set; } // [filler,    5] filler                          StartPos 59, Length 5
    }
}