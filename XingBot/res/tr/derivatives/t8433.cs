﻿namespace XingBot.res
{
    // 지수옵션마스터조회API용 ( BLOCK,HEADTYPE=A )
    public class _t8433InBlock
    {
        public string dummy { get; set; } // [string,    1] Dummy                           StartPos 0, Length 1
    }

    public class _t8433OutBlock
    {
        public string hname { get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode { get; set; } // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode { get; set; } // [string,   12] 확장코드                        StartPos 28, Length 12
        public decimal hprice { get; set; } // [float ,  6.2] 상한가                          StartPos 40, Length 6
        public decimal lprice { get; set; } // [float ,  6.2] 하한가                          StartPos 46, Length 6
        public decimal jnilclose { get; set; } // [float ,  6.2] 전일종가                        StartPos 52, Length 6
        public decimal jnilhigh { get; set; } // [float ,  6.2] 전일고가                        StartPos 58, Length 6
        public decimal jnillow { get; set; } // [float ,  6.2] 전일저가                        StartPos 64, Length 6
        public decimal recprice { get; set; } // [float ,  6.2] 기준가                          StartPos 70, Length 6
    }
}