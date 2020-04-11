namespace XingBot.res
{
    // 프로그램 매매종합 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1640InBlock
    {
        public string gubun{ get; set; } // [string,    2] 구분                            StartPos 0, Length 2
    }

    public class _t1640OutBlock
    {
        public long offervolume{ get; set; } // [long  ,    8] 매도수량                        StartPos 0, Length 8
        public long bidvolume{ get; set; } // [long  ,    8] 매수수량                        StartPos 9, Length 8
        public long volume{ get; set; } // [long  ,    8] 순매수수량                      StartPos 18, Length 8
        public long offerdiff{ get; set; } // [long  ,    8] 매도증감                        StartPos 27, Length 8
        public long biddiff{ get; set; } // [long  ,    8] 매수증감                        StartPos 36, Length 8
        public long sundiff{ get; set; } // [long  ,    8] 순매수증감                      StartPos 45, Length 8
        public decimal basis{ get; set; } // [float ,  6.2] 베이시스                        StartPos 54, Length 6
        public decimal offervalue{ get; set; } // [double,   12] 매도금액                        StartPos 61, Length 12
        public decimal bidvalue{ get; set; } // [double,   12] 매수금액                        StartPos 74, Length 12
        public decimal value{ get; set; } // [double,   12] 순매수금액                      StartPos 87, Length 12
        public decimal offervaldiff{ get; set; } // [double,   12] 매도금액증감                    StartPos 100, Length 12
        public decimal bidvaldiff{ get; set; } // [double,   12] 매수금액증감                    StartPos 113, Length 12
        public decimal sunvaldiff{ get; set; } // [double,   12] 순매수증감                      StartPos 126, Length 12
    }
}