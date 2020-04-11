namespace XingBot.res
{
    // 신고/신저가 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1442InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string type1{ get; set; } // [string,    1] 신고신저                        StartPos 2, Length 1
        public string type2{ get; set; } // [string,    1] 기간                            StartPos 4, Length 1
        public string type3{ get; set; } // [string,    1] 유지여부                        StartPos 6, Length 1
        public long jc_num{ get; set; } // [long  ,   12] 대상제외                        StartPos 8, Length 12
        public long sprice{ get; set; } // [long  ,    8] 시작가격                        StartPos 21, Length 8
        public long eprice{ get; set; } // [long  ,    8] 종료가격                        StartPos 30, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 39, Length 12
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 52, Length 4
    }

    public class _t1442OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public class _t1442OutBlock1
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 7, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 28, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 37, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 39, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 48, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 55, Length 12
        public long pastprice{ get; set; } // [long  ,    8] 이전가                          StartPos 68, Length 8
        public string pastsign{ get; set; } // [string,    1] 이전가대비구분                  StartPos 77, Length 1
        public long pastchange{ get; set; } // [long  ,    8] 이전가대비                      StartPos 79, Length 8
        public decimal pastdiff{ get; set; } // [float ,  6.2] 이전가대비율                    StartPos 88, Length 6
    }
}