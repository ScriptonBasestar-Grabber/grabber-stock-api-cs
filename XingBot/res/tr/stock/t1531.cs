﻿namespace XingBot.res
{
    // 섹터별 종목 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1531InBlock
    {
        public string tmname{ get; set; } // [string,   36] 테마명                          StartPos 0, Length 36
        public string tmcode{ get; set; } // [string,    4] 테마코드                        StartPos 37, Length 4
    }

    public class _t1531OutBlock
    {
        public string tmname{ get; set; } // [string,   36] 테마명                          StartPos 0, Length 36
        public decimal avgdiff{ get; set; } // [float ,  6.2] 평균등락율                      StartPos 37, Length 6
        public string tmcode{ get; set; } // [string,    4] 테마코드                        StartPos 44, Length 4
    }
}