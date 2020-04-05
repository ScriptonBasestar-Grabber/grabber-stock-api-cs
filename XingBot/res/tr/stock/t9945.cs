﻿namespace XingBot.res.tr
{
    // 주식마스터조회 API용 ( BLOCK,HEADTYPE=A )
    // t8436 사용
    internal struct _t9945InBlock
    {
        public string gubun; // [gubun,    1] 구분(KSP:1KSD:2)                StartPos 0, Length 1
    }

    internal struct _t9945OutBlock
    {
        public string hname; // [hname,   40] 종목명                          StartPos 0, Length 40
        public string shcode; // [shcode,    6] 단축코드                        StartPos 40, Length 6
        public string expcode; // [expcode,   12] 확장코드                        StartPos 46, Length 12
        public string etfchk; // [etfchk,    1] ETF구분                         StartPos 58, Length 1
        public string filler; // [filler,    5] filler                          StartPos 59, Length 5
    }
}