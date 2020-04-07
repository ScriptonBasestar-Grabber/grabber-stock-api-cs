namespace XingBot.res
{
    // 지수선물마스터조회 API용 ( BLOCK,HEADTYPE=A )
    // t8432
    public struct _t9943InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
    }

    public struct _t9943OutBlock
    {
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode{ get; set; } // [string,   12] 확장코드                        StartPos 28, Length 12
    }
}