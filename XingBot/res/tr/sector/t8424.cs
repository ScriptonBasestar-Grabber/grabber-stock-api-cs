﻿namespace XingBot.res
{
    // 업종전체조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8424InBlock
    {
        // 1 KOSPI 2 KOSDAQ 3,4
        public string gubun1 { get; set; } // [string,    1] 구분1                           StartPos 0, Length 1
    }

    public class _t8424OutBlock
    {
        public string hname { get; set; } // [string,   20] 업종명                          StartPos 0, Length 20
        public string upcode { get; set; } // [string,    3] 업종코드                        StartPos 21, Length 3
    }
}