namespace XingBot.res
{
    // 투자자매매종합1 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1615InBlock
    {
        public string gubun1; // [string,    1] 주식구분                        StartPos 0, Length 1
        public string gubun2; // [string,    1] 옵션구분                        StartPos 2, Length 1
    }

    public struct _t1615OutBlock
    {
        public long dwvolume; // [long  ,   12] 위탁매도수량                    StartPos 0, Length 12
        public long dwvalue; // [long  ,   12] 위탁매도금액                    StartPos 13, Length 12
        public long djvolume; // [long  ,   12] 자기매도수량                    StartPos 26, Length 12
        public long djvalue; // [long  ,   12] 자기매도금액                    StartPos 39, Length 12
        public long sum_volume; // [long  ,   12] 합계수량                        StartPos 52, Length 12
        public long sum_value; // [long  ,   12] 합계금액                        StartPos 65, Length 12
    }

    public struct _t1615OutBlock1
    {
        public string hname; // [string,   20] 시장명                          StartPos 0, Length 20
        public long sv_08; // [long  ,   12] 개인                            StartPos 21, Length 12
        public long sv_17; // [long  ,   12] 외국인                          StartPos 34, Length 12
        public long sv_18; // [long  ,   12] 기관계                          StartPos 47, Length 12
        public long sv_07; // [long  ,   12] 증권                            StartPos 60, Length 12
    }
}