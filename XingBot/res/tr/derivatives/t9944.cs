﻿namespace XingBot.res
{
    // 지수옵션마스터조회 API용 ( BLOCK,HEADTYPE=A )
    // t8433
    public class _t9944InBlock
    {
        public string dummy{ get; set; } // [string,    1] Dummy                           StartPos 0, Length 1
    }

    public class _t9944OutBlock
    {
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode{ get; set; } // [string,   12] 확장코드                        StartPos 28, Length 12
    }
}