namespace XingBot.res
{
    // 기간별 주가 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1305InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public long dwmcode{ get; set; } // [long  ,    1] 일주월구분                      StartPos 7, Length 1
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 9, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 18, Length 4
        public long cnt{ get; set; } // [long  ,    4] 건수                            StartPos 23, Length 4
    }

    public struct _t1305OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] CNT                             StartPos 0, Length 4
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 5, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 14, Length 4
    }

    public struct _t1305OutBlock1
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 9, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 18, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 27, Length 8
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 36, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 45, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 47, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 56, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 63, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 76, Length 10
        public decimal chdegree{ get; set; } // [float ,  6.2] 체결강도                        StartPos 87, Length 6
        public decimal sojinrate{ get; set; } // [float ,  6.2] 소진율                          StartPos 94, Length 6
        public decimal changerate{ get; set; } // [float ,  6.2] 회전율                          StartPos 101, Length 6
        public long fpvolume{ get; set; } // [long  ,   12] 외인순매수                      StartPos 108, Length 12
        public long covolume{ get; set; } // [long  ,   12] 기관순매수                      StartPos 121, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 134, Length 6
        public long value{ get; set; } // [long  ,   12] 누적거래대금(단위:백만)         StartPos 141, Length 12
        public long ppvolume{ get; set; } // [long  ,   12] 개인순매수                      StartPos 154, Length 12
        public string o_sign{ get; set; } // [string,    1] 시가대비구분                    StartPos 167, Length 1
        public long o_change{ get; set; } // [long  ,    8] 시가대비                        StartPos 169, Length 8
        public decimal o_diff{ get; set; } // [float ,  6.2] 시가기준등락율                  StartPos 178, Length 6
        public string h_sign{ get; set; } // [string,    1] 고가대비구분                    StartPos 185, Length 1
        public long h_change{ get; set; } // [long  ,    8] 고가대비                        StartPos 187, Length 8
        public decimal h_diff{ get; set; } // [float ,  6.2] 고가기준등락율                  StartPos 196, Length 6
        public string l_sign{ get; set; } // [string,    1] 저가대비구분                    StartPos 203, Length 1
        public long l_change{ get; set; } // [long  ,    8] 저가대비                        StartPos 205, Length 8
        public decimal l_diff{ get; set; } // [float ,  6.2] 저가기준등락율                  StartPos 214, Length 6
        public long marketcap{ get; set; } // [long  ,   12] 시가총액(단위:백만)             StartPos 221, Length 12
    }
}