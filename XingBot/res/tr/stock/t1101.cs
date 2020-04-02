using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 주식 현재가 호가 조회 ( ATTR,BLOCK,HEADTYPE=A )

    struct _t1101InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    struct _t1101OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 61, Length 8
        public long offerho1; // [long  ,    8] 매도호가1                       StartPos 70, Length 8
        public long bidho1; // [long  ,    8] 매수호가1                       StartPos 79, Length 8
        public long offerrem1; // [long  ,   12] 매도호가수량1                   StartPos 88, Length 12
        public long bidrem1; // [long  ,   12] 매수호가수량1                   StartPos 101, Length 12
        public long preoffercha1; // [long  ,   12] 직전매도대비수량1               StartPos 114, Length 12
        public long prebidcha1; // [long  ,   12] 직전매수대비수량1               StartPos 127, Length 12
        public long offerho2; // [long  ,    8] 매도호가2                       StartPos 140, Length 8
        public long bidho2; // [long  ,    8] 매수호가2                       StartPos 149, Length 8
        public long offerrem2; // [long  ,   12] 매도호가수량2                   StartPos 158, Length 12
        public long bidrem2; // [long  ,   12] 매수호가수량2                   StartPos 171, Length 12
        public long preoffercha2; // [long  ,   12] 직전매도대비수량2               StartPos 184, Length 12
        public long prebidcha2; // [long  ,   12] 직전매수대비수량2               StartPos 197, Length 12
        public long offerho3; // [long  ,    8] 매도호가3                       StartPos 210, Length 8
        public long bidho3; // [long  ,    8] 매수호가3                       StartPos 219, Length 8
        public long offerrem3; // [long  ,   12] 매도호가수량3                   StartPos 228, Length 12
        public long bidrem3; // [long  ,   12] 매수호가수량3                   StartPos 241, Length 12
        public long preoffercha3; // [long  ,   12] 직전매도대비수량3               StartPos 254, Length 12
        public long prebidcha3; // [long  ,   12] 직전매수대비수량3               StartPos 267, Length 12
        public long offerho4; // [long  ,    8] 매도호가4                       StartPos 280, Length 8
        public long bidho4; // [long  ,    8] 매수호가4                       StartPos 289, Length 8
        public long offerrem4; // [long  ,   12] 매도호가수량4                   StartPos 298, Length 12
        public long bidrem4; // [long  ,   12] 매수호가수량4                   StartPos 311, Length 12
        public long preoffercha4; // [long  ,   12] 직전매도대비수량4               StartPos 324, Length 12
        public long prebidcha4; // [long  ,   12] 직전매수대비수량4               StartPos 337, Length 12
        public long offerho5; // [long  ,    8] 매도호가5                       StartPos 350, Length 8
        public long bidho5; // [long  ,    8] 매수호가5                       StartPos 359, Length 8
        public long offerrem5; // [long  ,   12] 매도호가수량5                   StartPos 368, Length 12
        public long bidrem5; // [long  ,   12] 매수호가수량5                   StartPos 381, Length 12
        public long preoffercha5; // [long  ,   12] 직전매도대비수량5               StartPos 394, Length 12
        public long prebidcha5; // [long  ,   12] 직전매수대비수량5               StartPos 407, Length 12
        public long offerho6; // [long  ,    8] 매도호가6                       StartPos 420, Length 8
        public long bidho6; // [long  ,    8] 매수호가6                       StartPos 429, Length 8
        public long offerrem6; // [long  ,   12] 매도호가수량6                   StartPos 438, Length 12
        public long bidrem6; // [long  ,   12] 매수호가수량6                   StartPos 451, Length 12
        public long preoffercha6; // [long  ,   12] 직전매도대비수량6               StartPos 464, Length 12
        public long prebidcha6; // [long  ,   12] 직전매수대비수량6               StartPos 477, Length 12
        public long offerho7; // [long  ,    8] 매도호가7                       StartPos 490, Length 8
        public long bidho7; // [long  ,    8] 매수호가7                       StartPos 499, Length 8
        public long offerrem7; // [long  ,   12] 매도호가수량7                   StartPos 508, Length 12
        public long bidrem7; // [long  ,   12] 매수호가수량7                   StartPos 521, Length 12
        public long preoffercha7; // [long  ,   12] 직전매도대비수량7               StartPos 534, Length 12
        public long prebidcha7; // [long  ,   12] 직전매수대비수량7               StartPos 547, Length 12
        public long offerho8; // [long  ,    8] 매도호가8                       StartPos 560, Length 8
        public long bidho8; // [long  ,    8] 매수호가8                       StartPos 569, Length 8
        public long offerrem8; // [long  ,   12] 매도호가수량8                   StartPos 578, Length 12
        public long bidrem8; // [long  ,   12] 매수호가수량8                   StartPos 591, Length 12
        public long preoffercha8; // [long  ,   12] 직전매도대비수량8               StartPos 604, Length 12
        public long prebidcha8; // [long  ,   12] 직전매수대비수량8               StartPos 617, Length 12
        public long offerho9; // [long  ,    8] 매도호가9                       StartPos 630, Length 8
        public long bidho9; // [long  ,    8] 매수호가9                       StartPos 639, Length 8
        public long offerrem9; // [long  ,   12] 매도호가수량9                   StartPos 648, Length 12
        public long bidrem9; // [long  ,   12] 매수호가수량9                   StartPos 661, Length 12
        public long preoffercha9; // [long  ,   12] 직전매도대비수량9               StartPos 674, Length 12
        public long prebidcha9; // [long  ,   12] 직전매수대비수량9               StartPos 687, Length 12
        public long offerho10; // [long  ,    8] 매도호가10                      StartPos 700, Length 8
        public long bidho10; // [long  ,    8] 매수호가10                      StartPos 709, Length 8
        public long offerrem10; // [long  ,   12] 매도호가수량10                  StartPos 718, Length 12
        public long bidrem10; // [long  ,   12] 매수호가수량10                  StartPos 731, Length 12
        public long preoffercha10; // [long  ,   12] 직전매도대비수량10              StartPos 744, Length 12
        public long prebidcha10; // [long  ,   12] 직전매수대비수량10              StartPos 757, Length 12
        public long offer; // [long  ,   12] 매도호가수량합                  StartPos 770, Length 12
        public long bid; // [long  ,   12] 매수호가수량합                  StartPos 783, Length 12
        public long preoffercha; // [long  ,   12] 직전매도대비수량합              StartPos 796, Length 12
        public long prebidcha; // [long  ,   12] 직전매수대비수량합              StartPos 809, Length 12
        public string hotime; // [string,    8] 수신시간                        StartPos 822, Length 8
        public long yeprice; // [long  ,    8] 예상체결가격                    StartPos 831, Length 8
        public long yevolume; // [long  ,   12] 예상체결수량                    StartPos 840, Length 12
        public string yesign; // [string,    1] 예상체결전일구분                StartPos 853, Length 1
        public long yechange; // [long  ,    8] 예상체결전일대비                StartPos 855, Length 8
        public float yediff; // [float ,  6.2] 예상체결등락율                  StartPos 864, Length 6
        public long tmoffer; // [long  ,   12] 시간외매도잔량                  StartPos 871, Length 12
        public long tmbid; // [long  ,   12] 시간외매수잔량                  StartPos 884, Length 12
        public string ho_status; // [string,    1] 동시구분                        StartPos 897, Length 1
        public string shcode; // [string,    6] 단축코드                        StartPos 899, Length 6
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 906, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 915, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 924, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 933, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 942, Length 8
    }
}