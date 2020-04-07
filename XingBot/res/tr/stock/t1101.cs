namespace XingBot.res
{
    // 주식 현재가 호가 조회 ( ATTR,BLOCK,HEADTYPE=A )

    public struct _t1101InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _t1101OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 61, Length 8
        public long offerho1{ get; set; } // [long  ,    8] 매도호가1                       StartPos 70, Length 8
        public long bidho1{ get; set; } // [long  ,    8] 매수호가1                       StartPos 79, Length 8
        public long offerrem1{ get; set; } // [long  ,   12] 매도호가수량1                   StartPos 88, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수호가수량1                   StartPos 101, Length 12
        public long preoffercha1{ get; set; } // [long  ,   12] 직전매도대비수량1               StartPos 114, Length 12
        public long prebidcha1{ get; set; } // [long  ,   12] 직전매수대비수량1               StartPos 127, Length 12
        public long offerho2{ get; set; } // [long  ,    8] 매도호가2                       StartPos 140, Length 8
        public long bidho2{ get; set; } // [long  ,    8] 매수호가2                       StartPos 149, Length 8
        public long offerrem2{ get; set; } // [long  ,   12] 매도호가수량2                   StartPos 158, Length 12
        public long bidrem2{ get; set; } // [long  ,   12] 매수호가수량2                   StartPos 171, Length 12
        public long preoffercha2{ get; set; } // [long  ,   12] 직전매도대비수량2               StartPos 184, Length 12
        public long prebidcha2{ get; set; } // [long  ,   12] 직전매수대비수량2               StartPos 197, Length 12
        public long offerho3{ get; set; } // [long  ,    8] 매도호가3                       StartPos 210, Length 8
        public long bidho3{ get; set; } // [long  ,    8] 매수호가3                       StartPos 219, Length 8
        public long offerrem3{ get; set; } // [long  ,   12] 매도호가수량3                   StartPos 228, Length 12
        public long bidrem3{ get; set; } // [long  ,   12] 매수호가수량3                   StartPos 241, Length 12
        public long preoffercha3{ get; set; } // [long  ,   12] 직전매도대비수량3               StartPos 254, Length 12
        public long prebidcha3{ get; set; } // [long  ,   12] 직전매수대비수량3               StartPos 267, Length 12
        public long offerho4{ get; set; } // [long  ,    8] 매도호가4                       StartPos 280, Length 8
        public long bidho4{ get; set; } // [long  ,    8] 매수호가4                       StartPos 289, Length 8
        public long offerrem4{ get; set; } // [long  ,   12] 매도호가수량4                   StartPos 298, Length 12
        public long bidrem4{ get; set; } // [long  ,   12] 매수호가수량4                   StartPos 311, Length 12
        public long preoffercha4{ get; set; } // [long  ,   12] 직전매도대비수량4               StartPos 324, Length 12
        public long prebidcha4{ get; set; } // [long  ,   12] 직전매수대비수량4               StartPos 337, Length 12
        public long offerho5{ get; set; } // [long  ,    8] 매도호가5                       StartPos 350, Length 8
        public long bidho5{ get; set; } // [long  ,    8] 매수호가5                       StartPos 359, Length 8
        public long offerrem5{ get; set; } // [long  ,   12] 매도호가수량5                   StartPos 368, Length 12
        public long bidrem5{ get; set; } // [long  ,   12] 매수호가수량5                   StartPos 381, Length 12
        public long preoffercha5{ get; set; } // [long  ,   12] 직전매도대비수량5               StartPos 394, Length 12
        public long prebidcha5{ get; set; } // [long  ,   12] 직전매수대비수량5               StartPos 407, Length 12
        public long offerho6{ get; set; } // [long  ,    8] 매도호가6                       StartPos 420, Length 8
        public long bidho6{ get; set; } // [long  ,    8] 매수호가6                       StartPos 429, Length 8
        public long offerrem6{ get; set; } // [long  ,   12] 매도호가수량6                   StartPos 438, Length 12
        public long bidrem6{ get; set; } // [long  ,   12] 매수호가수량6                   StartPos 451, Length 12
        public long preoffercha6{ get; set; } // [long  ,   12] 직전매도대비수량6               StartPos 464, Length 12
        public long prebidcha6{ get; set; } // [long  ,   12] 직전매수대비수량6               StartPos 477, Length 12
        public long offerho7{ get; set; } // [long  ,    8] 매도호가7                       StartPos 490, Length 8
        public long bidho7{ get; set; } // [long  ,    8] 매수호가7                       StartPos 499, Length 8
        public long offerrem7{ get; set; } // [long  ,   12] 매도호가수량7                   StartPos 508, Length 12
        public long bidrem7{ get; set; } // [long  ,   12] 매수호가수량7                   StartPos 521, Length 12
        public long preoffercha7{ get; set; } // [long  ,   12] 직전매도대비수량7               StartPos 534, Length 12
        public long prebidcha7{ get; set; } // [long  ,   12] 직전매수대비수량7               StartPos 547, Length 12
        public long offerho8{ get; set; } // [long  ,    8] 매도호가8                       StartPos 560, Length 8
        public long bidho8{ get; set; } // [long  ,    8] 매수호가8                       StartPos 569, Length 8
        public long offerrem8{ get; set; } // [long  ,   12] 매도호가수량8                   StartPos 578, Length 12
        public long bidrem8{ get; set; } // [long  ,   12] 매수호가수량8                   StartPos 591, Length 12
        public long preoffercha8{ get; set; } // [long  ,   12] 직전매도대비수량8               StartPos 604, Length 12
        public long prebidcha8{ get; set; } // [long  ,   12] 직전매수대비수량8               StartPos 617, Length 12
        public long offerho9{ get; set; } // [long  ,    8] 매도호가9                       StartPos 630, Length 8
        public long bidho9{ get; set; } // [long  ,    8] 매수호가9                       StartPos 639, Length 8
        public long offerrem9{ get; set; } // [long  ,   12] 매도호가수량9                   StartPos 648, Length 12
        public long bidrem9{ get; set; } // [long  ,   12] 매수호가수량9                   StartPos 661, Length 12
        public long preoffercha9{ get; set; } // [long  ,   12] 직전매도대비수량9               StartPos 674, Length 12
        public long prebidcha9{ get; set; } // [long  ,   12] 직전매수대비수량9               StartPos 687, Length 12
        public long offerho10{ get; set; } // [long  ,    8] 매도호가10                      StartPos 700, Length 8
        public long bidho10{ get; set; } // [long  ,    8] 매수호가10                      StartPos 709, Length 8
        public long offerrem10{ get; set; } // [long  ,   12] 매도호가수량10                  StartPos 718, Length 12
        public long bidrem10{ get; set; } // [long  ,   12] 매수호가수량10                  StartPos 731, Length 12
        public long preoffercha10{ get; set; } // [long  ,   12] 직전매도대비수량10              StartPos 744, Length 12
        public long prebidcha10{ get; set; } // [long  ,   12] 직전매수대비수량10              StartPos 757, Length 12
        public long offer{ get; set; } // [long  ,   12] 매도호가수량합                  StartPos 770, Length 12
        public long bid{ get; set; } // [long  ,   12] 매수호가수량합                  StartPos 783, Length 12
        public long preoffercha{ get; set; } // [long  ,   12] 직전매도대비수량합              StartPos 796, Length 12
        public long prebidcha{ get; set; } // [long  ,   12] 직전매수대비수량합              StartPos 809, Length 12
        public string hotime{ get; set; } // [string,    8] 수신시간                        StartPos 822, Length 8
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가격                    StartPos 831, Length 8
        public long yevolume{ get; set; } // [long  ,   12] 예상체결수량                    StartPos 840, Length 12
        public string yesign{ get; set; } // [string,    1] 예상체결전일구분                StartPos 853, Length 1
        public long yechange{ get; set; } // [long  ,    8] 예상체결전일대비                StartPos 855, Length 8
        public decimal yediff{ get; set; } // [float ,  6.2] 예상체결등락율                  StartPos 864, Length 6
        public long tmoffer{ get; set; } // [long  ,   12] 시간외매도잔량                  StartPos 871, Length 12
        public long tmbid{ get; set; } // [long  ,   12] 시간외매수잔량                  StartPos 884, Length 12
        public string ho_status{ get; set; } // [string,    1] 동시구분                        StartPos 897, Length 1
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 899, Length 6
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 906, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 915, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 924, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 933, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 942, Length 8
    }
}