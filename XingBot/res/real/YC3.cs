namespace XingBot.res
{
    // 상품선물예상체결 ( ATTR, KEY=8, GROUP=1 )
    public class _YC3_InBlock
    {
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _YC3_OutBlock
    {
        public string ychetime{ get; set; } // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public decimal yeprice{ get; set; } // [float ,  9.2] 예상체결가격                    StartPos 7, Length 9
        public long yevolume{ get; set; } // [long  ,    6] 예상체결수량                    StartPos 17, Length 6
        public string jnilysign{ get; set; } // [string,    1] 예상체결가전일종가대비구분      StartPos 24, Length 1
        public decimal preychange{ get; set; } // [float ,  9.2] 예상체결가전일종가대비          StartPos 26, Length 9
        public decimal jnilydrate{ get; set; } // [float ,  9.2] 예상체결가전일종가등락율        StartPos 36, Length 9
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 46, Length 8
    }
}