namespace XingBot.res
{
    // 지수선물예상체결 ( ATTR, KEY=8, GROUP=1 )
    public class _YFC_InBlock
    {
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _YFC_OutBlock
    {
        public string ychetime{ get; set; } // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public decimal yeprice{ get; set; } // [float ,  6.2] 예상체결가격                    StartPos 7, Length 6
        public string jnilysign{ get; set; } // [string,    1] 예상체결가전일종가대비구분      StartPos 14, Length 1
        public decimal preychange{ get; set; } // [float ,  6.2] 예상체결가전일종가대비          StartPos 16, Length 6
        public decimal jnilydrate{ get; set; } // [float ,  6.2] 예상체결가전일종가등락율        StartPos 23, Length 6
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 30, Length 8
    }
}