namespace XingBot.res
{
    // 시간대별 투자자 매매추이 상세 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1603InBlock
    {
        public string market{ get; set; } // [string,    1] 시장구분                        StartPos 0, Length 1
        public string gubun1{ get; set; } // [string,    1] 투자자구분                      StartPos 2, Length 1
        public string gubun2{ get; set; } // [string,    1] 전일분구분                      StartPos 4, Length 1
        public string cts_time{ get; set; } // [string,    8] CTSTIME                         StartPos 6, Length 8
        public long cts_idx{ get; set; } // [long  ,    4] CTSIDX                          StartPos 15, Length 4
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 20, Length 3
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 24, Length 3
    }

    public struct _t1603OutBlock
    {
        public long cts_idx{ get; set; } // [long  ,    4] CTSIDX                          StartPos 0, Length 4
        public string cts_time{ get; set; } // [string,    8] CTSTIME                         StartPos 5, Length 8
    }

    public struct _t1603OutBlock1
    {
        public string time{ get; set; } // [string,    8] 시간                            StartPos 0, Length 8
        public string tjjcode{ get; set; } // [string,    4] 투자자구분                      StartPos 9, Length 4
        public long msvolume{ get; set; } // [long  ,    8] 매수수량                        StartPos 14, Length 8
        public long mdvolume{ get; set; } // [long  ,    8] 매도수량                        StartPos 23, Length 8
        public long msvalue{ get; set; } // [long  ,   12] 매수금액                        StartPos 32, Length 12
        public long mdvalue{ get; set; } // [long  ,   12] 매도금액                        StartPos 45, Length 12
        public long svolume{ get; set; } // [long  ,    8] 순매수수량                      StartPos 58, Length 8
        public long svalue{ get; set; } // [long  ,   12] 순매수금액                      StartPos 67, Length 12
    }
}