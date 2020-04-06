namespace XingBot.real.res
{
    // ELW 현재가 호가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1971InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _t1971OutBlock
    {
        public string hname; // [string,   40] 한글명                          StartPos 0, Length 40
        public long price; // [long  ,    8] 현재가                          StartPos 41, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 50, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 52, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 61, Length 6
        public decimal volume; // [float ,   12] 누적거래량                      StartPos 68, Length 12
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 81, Length 8
        public long offerho1; // [long  ,    8] 매도호가1                       StartPos 90, Length 8
        public long bidho1; // [long  ,    8] 매수호가1                       StartPos 99, Length 8
        public long offerrem1; // [long  ,   12] 매도호가수량1                   StartPos 108, Length 12
        public long lp_offerrem1; // [long  ,   12] LP매도호가수량1                 StartPos 121, Length 12
        public long bidrem1; // [long  ,   12] 매수호가수량1                   StartPos 134, Length 12
        public long lp_bidrem1; // [long  ,   12] LP매수호가수량1                 StartPos 147, Length 12
        public long preoffercha1; // [long  ,   12] 직전매도대비수량1               StartPos 160, Length 12
        public long prebidcha1; // [long  ,   12] 직전매수대비수량1               StartPos 173, Length 12
        public long offerho2; // [long  ,    8] 매도호가2                       StartPos 186, Length 8
        public long bidho2; // [long  ,    8] 매수호가2                       StartPos 195, Length 8
        public long offerrem2; // [long  ,   12] 매도호가수량2                   StartPos 204, Length 12
        public long lp_offerrem2; // [long  ,   12] LP매도호가수량2                 StartPos 217, Length 12
        public long bidrem2; // [long  ,   12] 매수호가수량2                   StartPos 230, Length 12
        public long lp_bidrem2; // [long  ,   12] LP매수호가수량2                 StartPos 243, Length 12
        public long preoffercha2; // [long  ,   12] 직전매도대비수량2               StartPos 256, Length 12
        public long prebidcha2; // [long  ,   12] 직전매수대비수량2               StartPos 269, Length 12
        public long offerho3; // [long  ,    8] 매도호가3                       StartPos 282, Length 8
        public long bidho3; // [long  ,    8] 매수호가3                       StartPos 291, Length 8
        public long offerrem3; // [long  ,   12] 매도호가수량3                   StartPos 300, Length 12
        public long lp_offerrem3; // [long  ,   12] LP매도호가수량3                 StartPos 313, Length 12
        public long bidrem3; // [long  ,   12] 매수호가수량3                   StartPos 326, Length 12
        public long lp_bidrem3; // [long  ,   12] LP매수호가수량3                 StartPos 339, Length 12
        public long preoffercha3; // [long  ,   12] 직전매도대비수량3               StartPos 352, Length 12
        public long prebidcha3; // [long  ,   12] 직전매수대비수량3               StartPos 365, Length 12
        public long offerho4; // [long  ,    8] 매도호가4                       StartPos 378, Length 8
        public long bidho4; // [long  ,    8] 매수호가4                       StartPos 387, Length 8
        public long offerrem4; // [long  ,   12] 매도호가수량4                   StartPos 396, Length 12
        public long lp_offerrem4; // [long  ,   12] LP매도호가수량4                 StartPos 409, Length 12
        public long bidrem4; // [long  ,   12] 매수호가수량4                   StartPos 422, Length 12
        public long lp_bidrem4; // [long  ,   12] LP매수호가수량4                 StartPos 435, Length 12
        public long preoffercha4; // [long  ,   12] 직전매도대비수량4               StartPos 448, Length 12
        public long prebidcha4; // [long  ,   12] 직전매수대비수량4               StartPos 461, Length 12
        public long offerho5; // [long  ,    8] 매도호가5                       StartPos 474, Length 8
        public long bidho5; // [long  ,    8] 매수호가5                       StartPos 483, Length 8
        public long offerrem5; // [long  ,   12] 매도호가수량5                   StartPos 492, Length 12
        public long lp_offerrem5; // [long  ,   12] LP매도호가수량5                 StartPos 505, Length 12
        public long bidrem5; // [long  ,   12] 매수호가수량5                   StartPos 518, Length 12
        public long lp_bidrem5; // [long  ,   12] LP매수호가수량5                 StartPos 531, Length 12
        public long preoffercha5; // [long  ,   12] 직전매도대비수량5               StartPos 544, Length 12
        public long prebidcha5; // [long  ,   12] 직전매수대비수량5               StartPos 557, Length 12
        public long offerho6; // [long  ,    8] 매도호가6                       StartPos 570, Length 8
        public long bidho6; // [long  ,    8] 매수호가6                       StartPos 579, Length 8
        public long offerrem6; // [long  ,   12] 매도호가수량6                   StartPos 588, Length 12
        public long lp_offerrem6; // [long  ,   12] LP매도호가수량6                 StartPos 601, Length 12
        public long bidrem6; // [long  ,   12] 매수호가수량6                   StartPos 614, Length 12
        public long lp_bidrem6; // [long  ,   12] LP매수호가수량6                 StartPos 627, Length 12
        public long preoffercha6; // [long  ,   12] 직전매도대비수량6               StartPos 640, Length 12
        public long prebidcha6; // [long  ,   12] 직전매수대비수량6               StartPos 653, Length 12
        public long offerho7; // [long  ,    8] 매도호가7                       StartPos 666, Length 8
        public long bidho7; // [long  ,    8] 매수호가7                       StartPos 675, Length 8
        public long offerrem7; // [long  ,   12] 매도호가수량7                   StartPos 684, Length 12
        public long lp_offerrem7; // [long  ,   12] LP매도호가수량7                 StartPos 697, Length 12
        public long bidrem7; // [long  ,   12] 매수호가수량7                   StartPos 710, Length 12
        public long lp_bidrem7; // [long  ,   12] LP매수호가수량7                 StartPos 723, Length 12
        public long preoffercha7; // [long  ,   12] 직전매도대비수량7               StartPos 736, Length 12
        public long prebidcha7; // [long  ,   12] 직전매수대비수량7               StartPos 749, Length 12
        public long offerho8; // [long  ,    8] 매도호가8                       StartPos 762, Length 8
        public long bidho8; // [long  ,    8] 매수호가8                       StartPos 771, Length 8
        public long offerrem8; // [long  ,   12] 매도호가수량8                   StartPos 780, Length 12
        public long lp_offerrem8; // [long  ,   12] LP매도호가수량8                 StartPos 793, Length 12
        public long bidrem8; // [long  ,   12] 매수호가수량8                   StartPos 806, Length 12
        public long lp_bidrem8; // [long  ,   12] LP매수호가수량8                 StartPos 819, Length 12
        public long preoffercha8; // [long  ,   12] 직전매도대비수량8               StartPos 832, Length 12
        public long prebidcha8; // [long  ,   12] 직전매수대비수량8               StartPos 845, Length 12
        public long offerho9; // [long  ,    8] 매도호가9                       StartPos 858, Length 8
        public long bidho9; // [long  ,    8] 매수호가9                       StartPos 867, Length 8
        public long offerrem9; // [long  ,   12] 매도호가수량9                   StartPos 876, Length 12
        public long lp_offerrem9; // [long  ,   12] LP매도호가수량9                 StartPos 889, Length 12
        public long bidrem9; // [long  ,   12] 매수호가수량9                   StartPos 902, Length 12
        public long lp_bidrem9; // [long  ,   12] LP매수호가수량9                 StartPos 915, Length 12
        public long preoffercha9; // [long  ,   12] 직전매도대비수량9               StartPos 928, Length 12
        public long prebidcha9; // [long  ,   12] 직전매수대비수량9               StartPos 941, Length 12
        public long offerho10; // [long  ,    8] 매도호가10                      StartPos 954, Length 8
        public long bidho10; // [long  ,    8] 매수호가10                      StartPos 963, Length 8
        public long offerrem10; // [long  ,   12] 매도호가수량10                  StartPos 972, Length 12
        public long lp_offerrem10; // [long  ,   12] LP매도호가수량10                StartPos 985, Length 12
        public long bidrem10; // [long  ,   12] 매수호가수량10                  StartPos 998, Length 12
        public long lp_bidrem10; // [long  ,   12] LP매수호가수량10                StartPos 1011, Length 12
        public long preoffercha10; // [long  ,   12] 직전매도대비수량10              StartPos 1024, Length 12
        public long prebidcha10; // [long  ,   12] 직전매수대비수량10              StartPos 1037, Length 12
        public long offer; // [long  ,   12] 매도호가수량합                  StartPos 1050, Length 12
        public long bid; // [long  ,   12] 매수호가수량합                  StartPos 1063, Length 12
        public long preoffercha; // [long  ,   12] 직전매도대비수량합              StartPos 1076, Length 12
        public long prebidcha; // [long  ,   12] 직전매수대비수량합              StartPos 1089, Length 12
        public string hotime; // [string,    8] 수신시간                        StartPos 1102, Length 8
        public long yeprice; // [long  ,    8] 예상체결가격                    StartPos 1111, Length 8
        public decimal yevolume; // [float ,   12] 예상체결수량                    StartPos 1120, Length 12
        public string yesign; // [string,    1] 예상체결전일구분                StartPos 1133, Length 1
        public long yechange; // [long  ,    8] 예상체결전일대비                StartPos 1135, Length 8
        public decimal yediff; // [float ,  6.2] 예상체결등락율                  StartPos 1144, Length 6
        public long tmoffer; // [long  ,   12] 시간외매도잔량                  StartPos 1151, Length 12
        public long tmbid; // [long  ,   12] 시간외매수잔량                  StartPos 1164, Length 12
        public string ho_status; // [string,    1] 동시구분                        StartPos 1177, Length 1
        public long open; // [long  ,    8] 시가                            StartPos 1179, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 1188, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 1197, Length 8
        public string invidx; // [string,    1] ELW권리형태(1:표준2:디지털3:조?StartPos 1206, Length 1
        public decimal koba_stdprc; // [float , 12.2] KO베리어                        StartPos 1208, Length 12
        public decimal koba_acc_rt; // [float , 12.2] KO접근도                        StartPos 1221, Length 12
        public string koba_yn; // [string,    1] KO발생여부(Y/N)                 StartPos 1234, Length 1
    }
}