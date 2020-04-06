namespace XingBot.real.res.tr
{
    // 프로그램 매매종합 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1640InBlock
    {
        public string gubun; // [string,    2] 구분                            StartPos 0, Length 2
    }

    public struct _t1640OutBlock
    {
        public long offervolume; // [long  ,    8] 매도수량                        StartPos 0, Length 8
        public long bidvolume; // [long  ,    8] 매수수량                        StartPos 9, Length 8
        public long volume; // [long  ,    8] 순매수수량                      StartPos 18, Length 8
        public long offerdiff; // [long  ,    8] 매도증감                        StartPos 27, Length 8
        public long biddiff; // [long  ,    8] 매수증감                        StartPos 36, Length 8
        public long sundiff; // [long  ,    8] 순매수증감                      StartPos 45, Length 8
        public decimal basis; // [float ,  6.2] 베이시스                        StartPos 54, Length 6
        public decimal offervalue; // [double,   12] 매도금액                        StartPos 61, Length 12
        public decimal bidvalue; // [double,   12] 매수금액                        StartPos 74, Length 12
        public decimal value; // [double,   12] 순매수금액                      StartPos 87, Length 12
        public decimal offervaldiff; // [double,   12] 매도금액증감                    StartPos 100, Length 12
        public decimal bidvaldiff; // [double,   12] 매수금액증감                    StartPos 113, Length 12
        public decimal sunvaldiff; // [double,   12] 순매수증감                      StartPos 126, Length 12
    }
}