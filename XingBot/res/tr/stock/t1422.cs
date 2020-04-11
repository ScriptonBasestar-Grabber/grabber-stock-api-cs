namespace XingBot.res
{
    // 상/하한 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1422InBlock
    {
        public string qrygb{ get; set; } // [string,    1] 조회구분                        StartPos 0, Length 1
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 2, Length 1
        public string jnilgubun{ get; set; } // [string,    1] 전일구분                        StartPos 4, Length 1
        public string sign{ get; set; } // [string,    1] 상하한구분                      StartPos 6, Length 1
        public long jc_num{ get; set; } // [long  ,   12] 대상제외                        StartPos 8, Length 12
        public long sprice{ get; set; } // [long  ,    8] 시작가격                        StartPos 21, Length 8
        public long eprice{ get; set; } // [long  ,    8] 종료가격                        StartPos 30, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 39, Length 12
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 52, Length 4
    }

    public class _t1422OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] CNT                             StartPos 0, Length 4
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 5, Length 4
    }

    public class _t1422OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 61, Length 10
        public long offerrem1{ get; set; } // [long  ,   12] 매도잔량                        StartPos 72, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수잔량                        StartPos 85, Length 12
        public string last{ get; set; } // [string,    6] 최종진입                        StartPos 98, Length 6
        public long lmtdaycnt{ get; set; } // [long  ,    8] 연속                            StartPos 105, Length 8
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 114, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 127, Length 6
    }
}