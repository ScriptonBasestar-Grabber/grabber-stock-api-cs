namespace XingBot.res
{
    // 주식선물 호가조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t8403InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    internal struct _t8403OutBlock
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 48, Length 12
        public float stimeqrt; // [float ,  6.2] 거래량전일동시간비율            StartPos 61, Length 6
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 68, Length 8
        public long offerho1; // [long  ,    8] 매도호가1                       StartPos 77, Length 8
        public long bidho1; // [long  ,    8] 매수호가1                       StartPos 86, Length 8
        public long offerrem1; // [long  ,    8] 매도호가수량1                   StartPos 95, Length 8
        public long bidrem1; // [long  ,    8] 매수호가수량1                   StartPos 104, Length 8
        public long dcnt1; // [long  ,    8] 매도호가건수1                   StartPos 113, Length 8
        public long scnt1; // [long  ,    8] 매수호가건수1                   StartPos 122, Length 8
        public long offerho2; // [long  ,    8] 매도호가2                       StartPos 131, Length 8
        public long bidho2; // [long  ,    8] 매수호가2                       StartPos 140, Length 8
        public long offerrem2; // [long  ,    8] 매도호가수량2                   StartPos 149, Length 8
        public long bidrem2; // [long  ,    8] 매수호가수량2                   StartPos 158, Length 8
        public long dcnt2; // [long  ,    8] 매도호가건수2                   StartPos 167, Length 8
        public long scnt2; // [long  ,    8] 매수호가건수2                   StartPos 176, Length 8
        public long offerho3; // [long  ,    8] 매도호가3                       StartPos 185, Length 8
        public long bidho3; // [long  ,    8] 매수호가3                       StartPos 194, Length 8
        public long offerrem3; // [long  ,    8] 매도호가수량3                   StartPos 203, Length 8
        public long bidrem3; // [long  ,    8] 매수호가수량3                   StartPos 212, Length 8
        public long dcnt3; // [long  ,    8] 매도호가건수3                   StartPos 221, Length 8
        public long scnt3; // [long  ,    8] 매수호가건수3                   StartPos 230, Length 8
        public long offerho4; // [long  ,    8] 매도호가4                       StartPos 239, Length 8
        public long bidho4; // [long  ,    8] 매수호가4                       StartPos 248, Length 8
        public long offerrem4; // [long  ,    8] 매도호가수량4                   StartPos 257, Length 8
        public long bidrem4; // [long  ,    8] 매수호가수량4                   StartPos 266, Length 8
        public long dcnt4; // [long  ,    8] 매도호가건수4                   StartPos 275, Length 8
        public long scnt4; // [long  ,    8] 매수호가건수4                   StartPos 284, Length 8
        public long offerho5; // [long  ,    8] 매도호가5                       StartPos 293, Length 8
        public long bidho5; // [long  ,    8] 매수호가5                       StartPos 302, Length 8
        public long offerrem5; // [long  ,    8] 매도호가수량5                   StartPos 311, Length 8
        public long bidrem5; // [long  ,    8] 매수호가수량5                   StartPos 320, Length 8
        public long dcnt5; // [long  ,    8] 매도호가건수5                   StartPos 329, Length 8
        public long scnt5; // [long  ,    8] 매수호가건수5                   StartPos 338, Length 8
        public long offerho6; // [long  ,    8] 매도호가6                       StartPos 347, Length 8
        public long bidho6; // [long  ,    8] 매수호가6                       StartPos 356, Length 8
        public long offerrem6; // [long  ,    8] 매도호가수량6                   StartPos 365, Length 8
        public long bidrem6; // [long  ,    8] 매수호가수량6                   StartPos 374, Length 8
        public long dcnt6; // [long  ,    8] 매도호가건수6                   StartPos 383, Length 8
        public long scnt6; // [long  ,    8] 매수호가건수6                   StartPos 392, Length 8
        public long offerho7; // [long  ,    8] 매도호가7                       StartPos 401, Length 8
        public long bidho7; // [long  ,    8] 매수호가7                       StartPos 410, Length 8
        public long offerrem7; // [long  ,    8] 매도호가수량7                   StartPos 419, Length 8
        public long bidrem7; // [long  ,    8] 매수호가수량7                   StartPos 428, Length 8
        public long dcnt7; // [long  ,    8] 매도호가건수7                   StartPos 437, Length 8
        public long scnt7; // [long  ,    8] 매수호가건수7                   StartPos 446, Length 8
        public long offerho8; // [long  ,    8] 매도호가8                       StartPos 455, Length 8
        public long bidho8; // [long  ,    8] 매수호가8                       StartPos 464, Length 8
        public long offerrem8; // [long  ,    8] 매도호가수량8                   StartPos 473, Length 8
        public long bidrem8; // [long  ,    8] 매수호가수량8                   StartPos 482, Length 8
        public long dcnt8; // [long  ,    8] 매도호가건수8                   StartPos 491, Length 8
        public long scnt8; // [long  ,    8] 매수호가건수8                   StartPos 500, Length 8
        public long offerho9; // [long  ,    8] 매도호가9                       StartPos 509, Length 8
        public long bidho9; // [long  ,    8] 매수호가9                       StartPos 518, Length 8
        public long offerrem9; // [long  ,    8] 매도호가수량9                   StartPos 527, Length 8
        public long bidrem9; // [long  ,    8] 매수호가수량9                   StartPos 536, Length 8
        public long dcnt9; // [long  ,    8] 매도호가건수9                   StartPos 545, Length 8
        public long scnt9; // [long  ,    8] 매수호가건수9                   StartPos 554, Length 8
        public long offerho10; // [long  ,    8] 매도호가10                      StartPos 563, Length 8
        public long bidho10; // [long  ,    8] 매수호가10                      StartPos 572, Length 8
        public long offerrem10; // [long  ,    8] 매도호가수량10                  StartPos 581, Length 8
        public long bidrem10; // [long  ,    8] 매수호가수량10                  StartPos 590, Length 8
        public long dcnt10; // [long  ,    8] 매도호가건수10                  StartPos 599, Length 8
        public long scnt10; // [long  ,    8] 매수호가건수10                  StartPos 608, Length 8
        public long dvol; // [long  ,    8] 매도호가총수량                  StartPos 617, Length 8
        public long svol; // [long  ,    8] 매수호가총수량                  StartPos 626, Length 8
        public long toffernum; // [long  ,    8] 총매도호가건수                  StartPos 635, Length 8
        public long tbidnum; // [long  ,    8] 총매수호가건수                  StartPos 644, Length 8
        public string time; // [string,    6] 수신시간                        StartPos 653, Length 6
        public string shcode; // [string,    6] 단축코드                        StartPos 660, Length 6
    }
}