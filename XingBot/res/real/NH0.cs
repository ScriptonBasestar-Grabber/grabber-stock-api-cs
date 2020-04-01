namespace XingBot.res
{
    // CME연계KP200지수선물호가 ( ATTR, KEY=8, GROUP=1 )
    struct _NH0_InBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _NH0_OutBlock
    {
        public string hotime; // [string,    6] 호가시간(24시간)                StartPos 0, Length 6
        public string hotime1; // [string,    6] 호가시간(36시간)                StartPos 7, Length 6
        public double offerho1; // [double,  6.2] 매도호가1                       StartPos 14, Length 6
        public double bidho1; // [double,  6.2] 매수호가1                       StartPos 21, Length 6
        public long offerrem1; // [long  ,    6] 매도호가수량1                   StartPos 28, Length 6
        public long bidrem1; // [long  ,    6] 매수호가수량1                   StartPos 35, Length 6
        public long offercnt1; // [long  ,    5] 매도호가건수1                   StartPos 42, Length 5
        public long bidcnt1; // [long  ,    5] 매수호가건수1                   StartPos 48, Length 5
        public double offerho2; // [double,  6.2] 매도호가2                       StartPos 54, Length 6
        public double bidho2; // [double,  6.2] 매수호가2                       StartPos 61, Length 6
        public long offerrem2; // [long  ,    6] 매도호가수량2                   StartPos 68, Length 6
        public long bidrem2; // [long  ,    6] 매수호가수량2                   StartPos 75, Length 6
        public long offercnt2; // [long  ,    5] 매도호가건수2                   StartPos 82, Length 5
        public long bidcnt2; // [long  ,    5] 매수호가건수2                   StartPos 88, Length 5
        public double offerho3; // [double,  6.2] 매도호가3                       StartPos 94, Length 6
        public double bidho3; // [double,  6.2] 매수호가3                       StartPos 101, Length 6
        public long offerrem3; // [long  ,    6] 매도호가수량3                   StartPos 108, Length 6
        public long bidrem3; // [long  ,    6] 매수호가수량3                   StartPos 115, Length 6
        public long offercnt3; // [long  ,    5] 매도호가건수3                   StartPos 122, Length 5
        public long bidcnt3; // [long  ,    5] 매수호가건수3                   StartPos 128, Length 5
        public double offerho4; // [double,  6.2] 매도호가4                       StartPos 134, Length 6
        public double bidho4; // [double,  6.2] 매수호가4                       StartPos 141, Length 6
        public long offerrem4; // [long  ,    6] 매도호가수량4                   StartPos 148, Length 6
        public long bidrem4; // [long  ,    6] 매수호가수량4                   StartPos 155, Length 6
        public long offercnt4; // [long  ,    5] 매도호가건수4                   StartPos 162, Length 5
        public long bidcnt4; // [long  ,    5] 매수호가건수4                   StartPos 168, Length 5
        public double offerho5; // [double,  6.2] 매도호가5                       StartPos 174, Length 6
        public double bidho5; // [double,  6.2] 매수호가5                       StartPos 181, Length 6
        public long offerrem5; // [long  ,    6] 매도호가수량5                   StartPos 188, Length 6
        public long bidrem5; // [long  ,    6] 매수호가수량5                   StartPos 195, Length 6
        public long offercnt5; // [long  ,    5] 매도호가건수5                   StartPos 202, Length 5
        public long bidcnt5; // [long  ,    5] 매수호가건수5                   StartPos 208, Length 5
        public long totofferrem; // [long  ,    6] 매도호가총수량                  StartPos 214, Length 6
        public long totbidrem; // [long  ,    6] 매수호가총수량                  StartPos 221, Length 6
        public long totoffercnt; // [long  ,    5] 매도호가총건수                  StartPos 228, Length 5
        public long totbidcnt; // [long  ,    5] 매수호가총건수                  StartPos 234, Length 5
        public string futcode; // [string,    8] 단축코드                        StartPos 240, Length 8
    }
}