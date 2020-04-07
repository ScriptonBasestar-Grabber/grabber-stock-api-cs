namespace XingBot.res
{
    // ELW 시간대별 예상체결 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1973InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string cts_time{ get; set; } // [string,    8] 시간CTS                         StartPos 7, Length 8
    }

    public struct _t1973OutBlock
    {
        public string cts_time{ get; set; } // [string,    8] 시간CTS                         StartPos 0, Length 8
    }

    public struct _t1973OutBlock1
    {
        public string chetime{ get; set; } // [string,    8] 시간                            StartPos 0, Length 8
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가격                    StartPos 9, Length 8
        public string yegubun{ get; set; } // [string,    1] 예상체결구분                    StartPos 18, Length 1
        public string jnilysign{ get; set; } // [string,    1] 전일종가대비구분                StartPos 20, Length 1
        public long jnilychange{ get; set; } // [long  ,    8] 전일종가대비                    StartPos 22, Length 8
        public decimal yediff{ get; set; } // [float ,  6.2] 예상체결등락율                  StartPos 31, Length 6
        public long yevolume{ get; set; } // [long  ,   12] 예상체결량                      StartPos 38, Length 12
        public long ymdvolume{ get; set; } // [long  ,   12] 예상매도체결량                  StartPos 51, Length 12
        public long ymsvolume{ get; set; } // [long  ,   12] 예상매수체결량                  StartPos 64, Length 12
    }
}