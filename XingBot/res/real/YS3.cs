namespace XingBot.res
{
    // KOSPI예상체결 ( ATTR, KEY=6, GROUP=1 )
    public class _YS3_InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _YS3_OutBlock
    {
        public string hotime{ get; set; } // [string,    6] 호가시간                        StartPos 0, Length 6
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가격                    StartPos 7, Length 8
        public long yevolume{ get; set; } // [long  ,   12] 예상체결수량                    StartPos 16, Length 12
        public string jnilysign{ get; set; } // [string,    1] 예상체결가전일종가대비구분      StartPos 29, Length 1
        public long preychange{ get; set; } // [long  ,    8] 예상체결가전일종가대비          StartPos 31, Length 8
        public decimal jnilydrate{ get; set; } // [float ,  6.2] 예상체결가전일종가등락율        StartPos 40, Length 6
        public long yofferho0{ get; set; } // [long  ,    8] 예상매도호가                    StartPos 47, Length 8
        public long ybidho0{ get; set; } // [long  ,    8] 예상매수호가                    StartPos 56, Length 8
        public long yofferrem0{ get; set; } // [long  ,   12] 예상매도호가수량                StartPos 65, Length 12
        public long ybidrem0{ get; set; } // [long  ,   12] 예상매수호가수량                StartPos 78, Length 12
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 91, Length 6
    }
}