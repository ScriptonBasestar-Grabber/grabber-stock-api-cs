namespace XingBot.res
{
    // 재무순위종합 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t3341InBlock
    {
        public string gubun{ get; set; } // [string,    1] 시장구분                        StartPos 0, Length 1
        public string gubun1{ get; set; } // [string,    1] 순위구분(1:매출액증가율2:영업이 StartPos 2, Length 1
        public string gubun2{ get; set; } // [string,    1] 대비구분                        StartPos 4, Length 1
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 6, Length 4
    }

    public class _t3341OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] CNT                             StartPos 0, Length 4
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 5, Length 4
    }

    public class _t3341OutBlock1
    {
        public long rank{ get; set; } // [long  ,    4] 순위                            StartPos 0, Length 4
        public string hname{ get; set; } // [string,   20] 기업명                          StartPos 5, Length 20
        public long salesgrowth{ get; set; } // [long  ,   12] 매출액증가율                    StartPos 26, Length 12
        public long operatingincomegrowt{ get; set; } // [long  ,   12] 영업이익증가율                  StartPos 39, Length 12
        public long ordinaryincomegrowth{ get; set; } // [long  ,   12] 경상이익증가율                  StartPos 52, Length 12
        public long liabilitytoequity{ get; set; } // [long  ,   12] 부채비율                        StartPos 65, Length 12
        public long enterpriseratio{ get; set; } // [long  ,   12] 유보율                          StartPos 78, Length 12
        public long eps{ get; set; } // [long  ,   12] EPS                             StartPos 91, Length 12
        public long bps{ get; set; } // [long  ,   12] BPS                             StartPos 104, Length 12
        public long roe{ get; set; } // [long  ,   12] ROE                             StartPos 117, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 130, Length 6
        public decimal per{ get; set; } // [float , 13.2] PER                             StartPos 137, Length 13
        public decimal pbr{ get; set; } // [float , 13.2] PBR                             StartPos 151, Length 13
        public decimal peg{ get; set; } // [float , 13.2] PEG                             StartPos 165, Length 13
    }
}