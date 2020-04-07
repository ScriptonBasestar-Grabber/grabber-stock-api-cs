namespace XingBot.res
{
    // 관리/불성실/투자유의조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1404InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string jongchk{ get; set; } // [string,    1] 종목체크                        StartPos 2, Length 1
        public string cts_shcode{ get; set; } // [string,    6] 종목코드_CTS                    StartPos 4, Length 6
    }

    public struct _t1404OutBlock
    {
        public string cts_shcode{ get; set; } // [string,    6] 종목코드_CTS                    StartPos 0, Length 6
    }

    public struct _t1404OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public string date{ get; set; } // [string,    8] 지정일                          StartPos 61, Length 8
        public long tprice{ get; set; } // [long  ,    8] 지정일주가                      StartPos 70, Length 8
        public long tchange{ get; set; } // [long  ,    8] 지정일대비                      StartPos 79, Length 8
        public decimal tdiff{ get; set; } // [float ,  6.2] 대비율                          StartPos 88, Length 6
        public string reason{ get; set; } // [string,    4] 사유                            StartPos 95, Length 4
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 100, Length 6
        public string edate{ get; set; } // [string,    8] 해제일                          StartPos 107, Length 8
    }
}