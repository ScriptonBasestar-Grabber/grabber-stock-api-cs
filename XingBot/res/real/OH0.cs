﻿namespace XingBot.res
{
    // KOSPI200옵션호가 ( ATTR, KEY=8, GROUP=1 )
    struct _OH0_InBlock
    {
        public string optcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _OH0_OutBlock
    {
        public string hotime; // [string,    6] 호가시간                        StartPos 0, Length 6
        public double offerho1; // [double,  6.2] 매도호가1                       StartPos 7, Length 6
        public double bidho1; // [double,  6.2] 매수호가1                       StartPos 14, Length 6
        public long offerrem1; // [long  ,    7] 매도호가수량1                   StartPos 21, Length 7
        public long bidrem1; // [long  ,    7] 매수호가수량1                   StartPos 29, Length 7
        public long offercnt1; // [long  ,    5] 매도호가건수1                   StartPos 37, Length 5
        public long bidcnt1; // [long  ,    5] 매수호가건수1                   StartPos 43, Length 5
        public double offerho2; // [double,  6.2] 매도호가2                       StartPos 49, Length 6
        public double bidho2; // [double,  6.2] 매수호가2                       StartPos 56, Length 6
        public long offerrem2; // [long  ,    7] 매도호가수량2                   StartPos 63, Length 7
        public long bidrem2; // [long  ,    7] 매수호가수량2                   StartPos 71, Length 7
        public long offercnt2; // [long  ,    5] 매도호가건수2                   StartPos 79, Length 5
        public long bidcnt2; // [long  ,    5] 매수호가건수2                   StartPos 85, Length 5
        public double offerho3; // [double,  6.2] 매도호가3                       StartPos 91, Length 6
        public double bidho3; // [double,  6.2] 매수호가3                       StartPos 98, Length 6
        public long offerrem3; // [long  ,    7] 매도호가수량3                   StartPos 105, Length 7
        public long bidrem3; // [long  ,    7] 매수호가수량3                   StartPos 113, Length 7
        public long offercnt3; // [long  ,    5] 매도호가건수3                   StartPos 121, Length 5
        public long bidcnt3; // [long  ,    5] 매수호가건수3                   StartPos 127, Length 5
        public double offerho4; // [double,  6.2] 매도호가4                       StartPos 133, Length 6
        public double bidho4; // [double,  6.2] 매수호가4                       StartPos 140, Length 6
        public long offerrem4; // [long  ,    7] 매도호가수량4                   StartPos 147, Length 7
        public long bidrem4; // [long  ,    7] 매수호가수량4                   StartPos 155, Length 7
        public long offercnt4; // [long  ,    5] 매도호가건수4                   StartPos 163, Length 5
        public long bidcnt4; // [long  ,    5] 매수호가건수4                   StartPos 169, Length 5
        public double offerho5; // [double,  6.2] 매도호가5                       StartPos 175, Length 6
        public double bidho5; // [double,  6.2] 매수호가5                       StartPos 182, Length 6
        public long offerrem5; // [long  ,    7] 매도호가수량5                   StartPos 189, Length 7
        public long bidrem5; // [long  ,    7] 매수호가수량5                   StartPos 197, Length 7
        public long offercnt5; // [long  ,    5] 매도호가건수5                   StartPos 205, Length 5
        public long bidcnt5; // [long  ,    5] 매수호가건수5                   StartPos 211, Length 5
        public long totofferrem; // [long  ,    7] 매도호가총수량                  StartPos 217, Length 7
        public long totbidrem; // [long  ,    7] 매수호가총수량                  StartPos 225, Length 7
        public long totoffercnt; // [long  ,    5] 매도호가총건수                  StartPos 233, Length 5
        public long totbidcnt; // [long  ,    5] 매수호가총건수                  StartPos 239, Length 5
        public string optcode; // [string,    8] 단축코드                        StartPos 245, Length 8
        public string danhochk; // [string,    1] 단일가호가여부                  StartPos 254, Length 1
        public string alloc_gubun; // [string,    1] 배분적용구분                    StartPos 256, Length 1
    }
}