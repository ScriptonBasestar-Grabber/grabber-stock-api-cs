namespace XingBot.res
{
    // 재무순위종합 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t3341InBlock
    {
        public string gubun; // [string,    1] 시장구분                        StartPos 0, Length 1
        public string gubun1; // [string,    1] 순위구분(1:매출액증가율2:영업이 StartPos 2, Length 1
        public string gubun2; // [string,    1] 대비구분                        StartPos 4, Length 1
        public long idx; // [long  ,    4] IDX                             StartPos 6, Length 4
    }

    public struct _t3341OutBlock
    {
        public long cnt; // [long  ,    4] CNT                             StartPos 0, Length 4
        public long idx; // [long  ,    4] IDX                             StartPos 5, Length 4
    }

    public struct _t3341OutBlock1
    {
        public long rank; // [long  ,    4] 순위                            StartPos 0, Length 4
        public string hname; // [string,   20] 기업명                          StartPos 5, Length 20
        public long salesgrowth; // [long  ,   12] 매출액증가율                    StartPos 26, Length 12
        public long operatingincomegrowt; // [long  ,   12] 영업이익증가율                  StartPos 39, Length 12
        public long ordinaryincomegrowth; // [long  ,   12] 경상이익증가율                  StartPos 52, Length 12
        public long liabilitytoequity; // [long  ,   12] 부채비율                        StartPos 65, Length 12
        public long enterpriseratio; // [long  ,   12] 유보율                          StartPos 78, Length 12
        public long eps; // [long  ,   12] EPS                             StartPos 91, Length 12
        public long bps; // [long  ,   12] BPS                             StartPos 104, Length 12
        public long roe; // [long  ,   12] ROE                             StartPos 117, Length 12
        public string shcode; // [string,    6] 종목코드                        StartPos 130, Length 6
        public decimal per; // [float , 13.2] PER                             StartPos 137, Length 13
        public decimal pbr; // [float , 13.2] PBR                             StartPos 151, Length 13
        public decimal peg; // [float , 13.2] PEG                             StartPos 165, Length 13
    }
}