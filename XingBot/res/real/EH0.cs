namespace XingBot.res
{
    // EUREX연계KP200지수옵션선물호가 ( ATTR, KEY=8, GROUP=1 )
    public struct _EH0_InBlock
    {
        public string optcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _EH0_OutBlock
    {
        public string hotime; // [string,    6] 호가시간(24시간)                StartPos 0, Length 6
        public string hotime1; // [string,    6] 호가시간(36시간)                StartPos 7, Length 6
        public decimal offerho1; // [double,  6.2] 매도호가1                       StartPos 14, Length 6
        public decimal bidho1; // [double,  6.2] 매수호가1                       StartPos 21, Length 6
        public long offerrem1; // [long  ,    7] 매도호가수량1                   StartPos 28, Length 7
        public long bidrem1; // [long  ,    7] 매수호가수량1                   StartPos 36, Length 7
        public long offercnt1; // [long  ,    5] 매도호가건수1(미제공)           StartPos 44, Length 5
        public long bidcnt1; // [long  ,    5] 매수호가건수1(미제공)           StartPos 50, Length 5
        public decimal offerho2; // [double,  6.2] 매도호가2                       StartPos 56, Length 6
        public decimal bidho2; // [double,  6.2] 매수호가2                       StartPos 63, Length 6
        public long offerrem2; // [long  ,    7] 매도호가수량2                   StartPos 70, Length 7
        public long bidrem2; // [long  ,    7] 매수호가수량2                   StartPos 78, Length 7
        public long offercnt2; // [long  ,    5] 매도호가건수2(미제공)           StartPos 86, Length 5
        public long bidcnt2; // [long  ,    5] 매수호가건수2(미제공)           StartPos 92, Length 5
        public decimal offerho3; // [double,  6.2] 매도호가3                       StartPos 98, Length 6
        public decimal bidho3; // [double,  6.2] 매수호가3                       StartPos 105, Length 6
        public long offerrem3; // [long  ,    7] 매도호가수량3                   StartPos 112, Length 7
        public long bidrem3; // [long  ,    7] 매수호가수량3                   StartPos 120, Length 7
        public long offercnt3; // [long  ,    5] 매도호가건수3(미제공)           StartPos 128, Length 5
        public long bidcnt3; // [long  ,    5] 매수호가건수3(미제공)           StartPos 134, Length 5
        public decimal offerho4; // [double,  6.2] 매도호가4(미제공)               StartPos 140, Length 6
        public decimal bidho4; // [double,  6.2] 매수호가4(미제공)               StartPos 147, Length 6
        public long offerrem4; // [long  ,    7] 매도호가수량4(미제공)           StartPos 154, Length 7
        public long bidrem4; // [long  ,    7] 매수호가수량4(미제공)           StartPos 162, Length 7
        public long offercnt4; // [long  ,    5] 매도호가건수4(미제공)           StartPos 170, Length 5
        public long bidcnt4; // [long  ,    5] 매수호가건수4(미제공)           StartPos 176, Length 5
        public decimal offerho5; // [double,  6.2] 매도호가5(미제공)               StartPos 182, Length 6
        public decimal bidho5; // [double,  6.2] 매수호가5(미제공)               StartPos 189, Length 6
        public long offerrem5; // [long  ,    7] 매도호가수량5(미제공)           StartPos 196, Length 7
        public long bidrem5; // [long  ,    7] 매수호가수량5(미제공)           StartPos 204, Length 7
        public long offercnt5; // [long  ,    5] 매도호가건수5(미제공)           StartPos 212, Length 5
        public long bidcnt5; // [long  ,    5] 매수호가건수5(미제공)           StartPos 218, Length 5
        public long totofferrem; // [long  ,    7] 매도호가총수량                  StartPos 224, Length 7
        public long totbidrem; // [long  ,    7] 매수호가총수량                  StartPos 232, Length 7
        public long totoffercnt; // [long  ,    5] 매도호가총건수                  StartPos 240, Length 5
        public long totbidcnt; // [long  ,    5] 매수호가총건수                  StartPos 246, Length 5
        public string optcode; // [string,    8] 단축코드                        StartPos 252, Length 8
        public string danhochk; // [string,    1] 단일가호가여부                  StartPos 261, Length 1
    }
}