﻿namespace XingBot.res
{
    // KOSPI우선호가 ( ATTR, KEY=6, GROUP=1 )
    public class _S2__InBlock
    {
        public string shcode;    // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _S2__OutBlock
    {
        public long offerho;    // [long  ,    8] 매도호가                        StartPos 0, Length 8
        public long bidho;    // [long  ,    8] 매수호가                        StartPos 9, Length 8
        public string shcode;    // [string,    6] 단축코드                        StartPos 18, Length 6
    }
}