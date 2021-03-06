﻿namespace XingBot.res
{
    // 주식선물예상체결 ( ATTR, KEY=8, GROUP=1 )
    public class _YJC_InBlock
    {
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _YJC_OutBlock
    {
        public string ychetime{ get; set; } // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public long yeprice{ get; set; } // [long  ,   10] 예상체결가격                    StartPos 7, Length 10
        public string jnilysign{ get; set; } // [string,    1] 예상체결가전일종가대비구분      StartPos 18, Length 1
        public long preychange{ get; set; } // [long  ,   10] 예상체결가전일종가대비          StartPos 20, Length 10
        public decimal jnilydrate{ get; set; } // [float ,  6.2] 예상체결가전일종가등락율        StartPos 31, Length 6
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 38, Length 8
    }
}