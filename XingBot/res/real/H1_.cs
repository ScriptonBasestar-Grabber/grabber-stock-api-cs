namespace XingBot.res
{
    // KOSPI호가잔량 ( ATTR, KEY=6, GROUP=1 )
    public struct _H1__InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _H1__OutBlock
    {
        public string hotime; // [string,    6] 호가시간                        StartPos 0, Length 6
        public long offerho1; // [long  ,    7] 매도호가1                       StartPos 7, Length 7
        public long bidho1; // [long  ,    7] 매수호가1                       StartPos 15, Length 7
        public long offerrem1; // [long  ,    9] 매도호가잔량1                   StartPos 23, Length 9
        public long bidrem1; // [long  ,    9] 매수호가잔량1                   StartPos 33, Length 9
        public long offerho2; // [long  ,    7] 매도호가2                       StartPos 43, Length 7
        public long bidho2; // [long  ,    7] 매수호가2                       StartPos 51, Length 7
        public long offerrem2; // [long  ,    9] 매도호가잔량2                   StartPos 59, Length 9
        public long bidrem2; // [long  ,    9] 매수호가잔량2                   StartPos 69, Length 9
        public long offerho3; // [long  ,    7] 매도호가3                       StartPos 79, Length 7
        public long bidho3; // [long  ,    7] 매수호가3                       StartPos 87, Length 7
        public long offerrem3; // [long  ,    9] 매도호가잔량3                   StartPos 95, Length 9
        public long bidrem3; // [long  ,    9] 매수호가잔량3                   StartPos 105, Length 9
        public long offerho4; // [long  ,    7] 매도호가4                       StartPos 115, Length 7
        public long bidho4; // [long  ,    7] 매수호가4                       StartPos 123, Length 7
        public long offerrem4; // [long  ,    9] 매도호가잔량4                   StartPos 131, Length 9
        public long bidrem4; // [long  ,    9] 매수호가잔량4                   StartPos 141, Length 9
        public long offerho5; // [long  ,    7] 매도호가5                       StartPos 151, Length 7
        public long bidho5; // [long  ,    7] 매수호가5                       StartPos 159, Length 7
        public long offerrem5; // [long  ,    9] 매도호가잔량5                   StartPos 167, Length 9
        public long bidrem5; // [long  ,    9] 매수호가잔량5                   StartPos 177, Length 9
        public long offerho6; // [long  ,    7] 매도호가6                       StartPos 187, Length 7
        public long bidho6; // [long  ,    7] 매수호가6                       StartPos 195, Length 7
        public long offerrem6; // [long  ,    9] 매도호가잔량6                   StartPos 203, Length 9
        public long bidrem6; // [long  ,    9] 매수호가잔량6                   StartPos 213, Length 9
        public long offerho7; // [long  ,    7] 매도호가7                       StartPos 223, Length 7
        public long bidho7; // [long  ,    7] 매수호가7                       StartPos 231, Length 7
        public long offerrem7; // [long  ,    9] 매도호가잔량7                   StartPos 239, Length 9
        public long bidrem7; // [long  ,    9] 매수호가잔량7                   StartPos 249, Length 9
        public long offerho8; // [long  ,    7] 매도호가8                       StartPos 259, Length 7
        public long bidho8; // [long  ,    7] 매수호가8                       StartPos 267, Length 7
        public long offerrem8; // [long  ,    9] 매도호가잔량8                   StartPos 275, Length 9
        public long bidrem8; // [long  ,    9] 매수호가잔량8                   StartPos 285, Length 9
        public long offerho9; // [long  ,    7] 매도호가9                       StartPos 295, Length 7
        public long bidho9; // [long  ,    7] 매수호가9                       StartPos 303, Length 7
        public long offerrem9; // [long  ,    9] 매도호가잔량9                   StartPos 311, Length 9
        public long bidrem9; // [long  ,    9] 매수호가잔량9                   StartPos 321, Length 9
        public long offerho10; // [long  ,    7] 매도호가10                      StartPos 331, Length 7
        public long bidho10; // [long  ,    7] 매수호가10                      StartPos 339, Length 7
        public long offerrem10; // [long  ,    9] 매도호가잔량10                  StartPos 347, Length 9
        public long bidrem10; // [long  ,    9] 매수호가잔량10                  StartPos 357, Length 9
        public long totofferrem; // [long  ,    9] 총매도호가잔량                  StartPos 367, Length 9
        public long totbidrem; // [long  ,    9] 총매수호가잔량                  StartPos 377, Length 9
        public string donsigubun; // [string,    1] 동시호가구분                    StartPos 387, Length 1
        public string shcode; // [string,    6] 단축코드                        StartPos 389, Length 6
        public string alloc_gubun; // [string,    1] 배분적용구분                    StartPos 396, Length 1
    }
}