namespace XingBot.res
{
    // 투자경고/매매정지/정리매매조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1405InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string jongchk{ get; set; } // [string,    1] 종목체크                        StartPos 2, Length 1
        public string cts_shcode{ get; set; } // [string,    6] 종목코드_CTS                    StartPos 4, Length 6
    }

    public class _t1405OutBlock
    {
        public string cts_shcode{ get; set; } // [string,    6] 종목코드_CTS                    StartPos 0, Length 6
    }

    public class _t1405OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public string date{ get; set; } // [string,    8] 지정일                          StartPos 61, Length 8
        public string edate{ get; set; } // [string,    8] 해제일                          StartPos 70, Length 8
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 79, Length 6
    }
}