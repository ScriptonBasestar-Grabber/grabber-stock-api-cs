namespace XingBot.res
{
    // KOSPI200옵션호가 ( ATTR, KEY=8, GROUP=1 )
    public struct _OH0_InBlock
    {
        public string optcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _OH0_OutBlock
    {
        public string hotime{ get; set; } // [string,    6] 호가시간                        StartPos 0, Length 6
        public decimal offerho1{ get; set; } // [double,  6.2] 매도호가1                       StartPos 7, Length 6
        public decimal bidho1{ get; set; } // [double,  6.2] 매수호가1                       StartPos 14, Length 6
        public long offerrem1{ get; set; } // [long  ,    7] 매도호가수량1                   StartPos 21, Length 7
        public long bidrem1{ get; set; } // [long  ,    7] 매수호가수량1                   StartPos 29, Length 7
        public long offercnt1{ get; set; } // [long  ,    5] 매도호가건수1                   StartPos 37, Length 5
        public long bidcnt1{ get; set; } // [long  ,    5] 매수호가건수1                   StartPos 43, Length 5
        public decimal offerho2{ get; set; } // [double,  6.2] 매도호가2                       StartPos 49, Length 6
        public decimal bidho2{ get; set; } // [double,  6.2] 매수호가2                       StartPos 56, Length 6
        public long offerrem2{ get; set; } // [long  ,    7] 매도호가수량2                   StartPos 63, Length 7
        public long bidrem2{ get; set; } // [long  ,    7] 매수호가수량2                   StartPos 71, Length 7
        public long offercnt2{ get; set; } // [long  ,    5] 매도호가건수2                   StartPos 79, Length 5
        public long bidcnt2{ get; set; } // [long  ,    5] 매수호가건수2                   StartPos 85, Length 5
        public decimal offerho3{ get; set; } // [double,  6.2] 매도호가3                       StartPos 91, Length 6
        public decimal bidho3{ get; set; } // [double,  6.2] 매수호가3                       StartPos 98, Length 6
        public long offerrem3{ get; set; } // [long  ,    7] 매도호가수량3                   StartPos 105, Length 7
        public long bidrem3{ get; set; } // [long  ,    7] 매수호가수량3                   StartPos 113, Length 7
        public long offercnt3{ get; set; } // [long  ,    5] 매도호가건수3                   StartPos 121, Length 5
        public long bidcnt3{ get; set; } // [long  ,    5] 매수호가건수3                   StartPos 127, Length 5
        public decimal offerho4{ get; set; } // [double,  6.2] 매도호가4                       StartPos 133, Length 6
        public decimal bidho4{ get; set; } // [double,  6.2] 매수호가4                       StartPos 140, Length 6
        public long offerrem4{ get; set; } // [long  ,    7] 매도호가수량4                   StartPos 147, Length 7
        public long bidrem4{ get; set; } // [long  ,    7] 매수호가수량4                   StartPos 155, Length 7
        public long offercnt4{ get; set; } // [long  ,    5] 매도호가건수4                   StartPos 163, Length 5
        public long bidcnt4{ get; set; } // [long  ,    5] 매수호가건수4                   StartPos 169, Length 5
        public decimal offerho5{ get; set; } // [double,  6.2] 매도호가5                       StartPos 175, Length 6
        public decimal bidho5{ get; set; } // [double,  6.2] 매수호가5                       StartPos 182, Length 6
        public long offerrem5{ get; set; } // [long  ,    7] 매도호가수량5                   StartPos 189, Length 7
        public long bidrem5{ get; set; } // [long  ,    7] 매수호가수량5                   StartPos 197, Length 7
        public long offercnt5{ get; set; } // [long  ,    5] 매도호가건수5                   StartPos 205, Length 5
        public long bidcnt5{ get; set; } // [long  ,    5] 매수호가건수5                   StartPos 211, Length 5
        public long totofferrem{ get; set; } // [long  ,    7] 매도호가총수량                  StartPos 217, Length 7
        public long totbidrem{ get; set; } // [long  ,    7] 매수호가총수량                  StartPos 225, Length 7
        public long totoffercnt{ get; set; } // [long  ,    5] 매도호가총건수                  StartPos 233, Length 5
        public long totbidcnt{ get; set; } // [long  ,    5] 매수호가총건수                  StartPos 239, Length 5
        public string optcode{ get; set; } // [string,    8] 단축코드                        StartPos 245, Length 8
        public string danhochk{ get; set; } // [string,    1] 단일가호가여부                  StartPos 254, Length 1
        public string alloc_gubun{ get; set; } // [string,    1] 배분적용구분                    StartPos 256, Length 1
    }
}