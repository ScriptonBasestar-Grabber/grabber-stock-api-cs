namespace XingBot.res
{
    // 상/하한가 직전 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1427InBlock
    {
        public string qrygb{ get; set; } // [string,    1] 조회구분                        StartPos 0, Length 1
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 2, Length 1
        public string signgubun{ get; set; } // [string,    1] 상하한가구분                    StartPos 4, Length 1
        public long diff{ get; set; } // [long  ,    3] 등락율                          StartPos 6, Length 3
        public long jc_num{ get; set; } // [long  ,   12] 대상제외                        StartPos 10, Length 12
        public long sprice{ get; set; } // [long  ,    8] 시작가격                        StartPos 23, Length 8
        public long eprice{ get; set; } // [long  ,    8] 종료가격                        StartPos 32, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 41, Length 12
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 54, Length 4
        public string jshex{ get; set; } // [string,    1] 전일상하한제외                  StartPos 59, Length 1
    }

    public class _t1427OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] CNT                             StartPos 0, Length 4
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 5, Length 4
    }

    public class _t1427OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 61, Length 10
        public long lmtprice{ get; set; } // [long  ,    8] 상한가/하한가                   StartPos 72, Length 8
        public decimal rate{ get; set; } // [float , 12.2] 대비율                          StartPos 81, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 94, Length 6
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 101, Length 12
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 114, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 123, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 132, Length 8
        public long lmtdaycnt{ get; set; } // [long  ,    8] 연속                            StartPos 141, Length 8
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 150, Length 12
        public long total{ get; set; } // [long  ,   12] 시가총액                        StartPos 163, Length 12
    }
}