namespace XingBot.res
{
    // 거래대금상위 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1463InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string jnilgubun{ get; set; } // [string,    1] 전일구분                        StartPos 2, Length 1
        public long jc_num{ get; set; } // [long  ,   12] 대상제외                        StartPos 4, Length 12
        public long sprice{ get; set; } // [long  ,    8] 시작가격                        StartPos 17, Length 8
        public long eprice{ get; set; } // [long  ,    8] 종료가격                        StartPos 26, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 35, Length 12
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 48, Length 4
        public long jc_num2{ get; set; } // [long  ,   12] 대상제외2                       StartPos 53, Length 12
    }

    public class _t1463OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public class _t1463OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 61, Length 12
        public long jnilvalue{ get; set; } // [long  ,   12] 전일거래대금                    StartPos 74, Length 12
        public decimal bef_diff{ get; set; } // [float , 10.2] 전일비                          StartPos 87, Length 10
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 98, Length 6
        public string filler{ get; set; } // [string,    1] filler                          StartPos 105, Length 1
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 107, Length 12
    }
}