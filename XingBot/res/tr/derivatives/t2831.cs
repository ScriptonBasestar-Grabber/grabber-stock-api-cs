﻿namespace XingBot.res
{
    // EUREX 야간옵션 호가 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2831InBlock
    {
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _t2831OutBlock
    {
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 37, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 44, Length 12
        public decimal jnilclose{ get; set; } // [float ,  6.2] 전일종가                        StartPos 57, Length 6
        public decimal offerho1{ get; set; } // [float ,  6.2] 매도호가1                       StartPos 64, Length 6
        public decimal bidho1{ get; set; } // [float ,  6.2] 매수호가1                       StartPos 71, Length 6
        public long offerrem1{ get; set; } // [long  ,    8] 매도호가수량1                   StartPos 78, Length 8
        public long bidrem1{ get; set; } // [long  ,    8] 매수호가수량1                   StartPos 87, Length 8
        public long dcnt1{ get; set; } // [long  ,    8] 매도호가건수1                   StartPos 96, Length 8
        public long scnt1{ get; set; } // [long  ,    8] 매수호가건수1                   StartPos 105, Length 8
        public decimal offerho2{ get; set; } // [float ,  6.2] 매도호가2                       StartPos 114, Length 6
        public decimal bidho2{ get; set; } // [float ,  6.2] 매수호가2                       StartPos 121, Length 6
        public long offerrem2{ get; set; } // [long  ,    8] 매도호가수량2                   StartPos 128, Length 8
        public long bidrem2{ get; set; } // [long  ,    8] 매수호가수량2                   StartPos 137, Length 8
        public long dcnt2{ get; set; } // [long  ,    8] 매도호가건수2                   StartPos 146, Length 8
        public long scnt2{ get; set; } // [long  ,    8] 매수호가건수2                   StartPos 155, Length 8
        public decimal offerho3{ get; set; } // [float ,  6.2] 매도호가3                       StartPos 164, Length 6
        public decimal bidho3{ get; set; } // [float ,  6.2] 매수호가3                       StartPos 171, Length 6
        public long offerrem3{ get; set; } // [long  ,    8] 매도호가수량3                   StartPos 178, Length 8
        public long bidrem3{ get; set; } // [long  ,    8] 매수호가수량3                   StartPos 187, Length 8
        public long dcnt3{ get; set; } // [long  ,    8] 매도호가건수3                   StartPos 196, Length 8
        public long scnt3{ get; set; } // [long  ,    8] 매수호가건수3                   StartPos 205, Length 8
        public decimal offerho4{ get; set; } // [float ,  6.2] 매도호가4                       StartPos 214, Length 6
        public decimal bidho4{ get; set; } // [float ,  6.2] 매수호가4                       StartPos 221, Length 6
        public long offerrem4{ get; set; } // [long  ,    8] 매도호가수량4                   StartPos 228, Length 8
        public long bidrem4{ get; set; } // [long  ,    8] 매수호가수량4                   StartPos 237, Length 8
        public long dcnt4{ get; set; } // [long  ,    8] 매도호가건수4                   StartPos 246, Length 8
        public long scnt4{ get; set; } // [long  ,    8] 매수호가건수4                   StartPos 255, Length 8
        public decimal offerho5{ get; set; } // [float ,  6.2] 매도호가5                       StartPos 264, Length 6
        public decimal bidho5{ get; set; } // [float ,  6.2] 매수호가5                       StartPos 271, Length 6
        public long offerrem5{ get; set; } // [long  ,    8] 매도호가수량5                   StartPos 278, Length 8
        public long bidrem5{ get; set; } // [long  ,    8] 매수호가수량5                   StartPos 287, Length 8
        public long dcnt5{ get; set; } // [long  ,    8] 매도호가건수5                   StartPos 296, Length 8
        public long scnt5{ get; set; } // [long  ,    8] 매수호가건수5                   StartPos 305, Length 8
        public long dvol{ get; set; } // [long  ,    8] 매도호가총수량                  StartPos 314, Length 8
        public long svol{ get; set; } // [long  ,    8] 매수호가총수량                  StartPos 323, Length 8
        public long toffernum{ get; set; } // [long  ,    8] 총매도호가건수                  StartPos 332, Length 8
        public long tbidnum{ get; set; } // [long  ,    8] 총매수호가건수                  StartPos 341, Length 8
        public string time{ get; set; } // [string,    6] 수신시간                        StartPos 350, Length 6
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 357, Length 8
    }
}