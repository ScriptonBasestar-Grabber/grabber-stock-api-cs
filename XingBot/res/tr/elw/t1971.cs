namespace XingBot.res
{
    // ELW 현재가 호가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1971InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _t1971OutBlock
    {
        public string hname{ get; set; } // [string,   40] 한글명                          StartPos 0, Length 40
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 41, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 50, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 52, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 61, Length 6
        public decimal volume{ get; set; } // [float ,   12] 누적거래량                      StartPos 68, Length 12
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 81, Length 8
        public long offerho1{ get; set; } // [long  ,    8] 매도호가1                       StartPos 90, Length 8
        public long bidho1{ get; set; } // [long  ,    8] 매수호가1                       StartPos 99, Length 8
        public long offerrem1{ get; set; } // [long  ,   12] 매도호가수량1                   StartPos 108, Length 12
        public long lp_offerrem1{ get; set; } // [long  ,   12] LP매도호가수량1                 StartPos 121, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수호가수량1                   StartPos 134, Length 12
        public long lp_bidrem1{ get; set; } // [long  ,   12] LP매수호가수량1                 StartPos 147, Length 12
        public long preoffercha1{ get; set; } // [long  ,   12] 직전매도대비수량1               StartPos 160, Length 12
        public long prebidcha1{ get; set; } // [long  ,   12] 직전매수대비수량1               StartPos 173, Length 12
        public long offerho2{ get; set; } // [long  ,    8] 매도호가2                       StartPos 186, Length 8
        public long bidho2{ get; set; } // [long  ,    8] 매수호가2                       StartPos 195, Length 8
        public long offerrem2{ get; set; } // [long  ,   12] 매도호가수량2                   StartPos 204, Length 12
        public long lp_offerrem2{ get; set; } // [long  ,   12] LP매도호가수량2                 StartPos 217, Length 12
        public long bidrem2{ get; set; } // [long  ,   12] 매수호가수량2                   StartPos 230, Length 12
        public long lp_bidrem2{ get; set; } // [long  ,   12] LP매수호가수량2                 StartPos 243, Length 12
        public long preoffercha2{ get; set; } // [long  ,   12] 직전매도대비수량2               StartPos 256, Length 12
        public long prebidcha2{ get; set; } // [long  ,   12] 직전매수대비수량2               StartPos 269, Length 12
        public long offerho3{ get; set; } // [long  ,    8] 매도호가3                       StartPos 282, Length 8
        public long bidho3{ get; set; } // [long  ,    8] 매수호가3                       StartPos 291, Length 8
        public long offerrem3{ get; set; } // [long  ,   12] 매도호가수량3                   StartPos 300, Length 12
        public long lp_offerrem3{ get; set; } // [long  ,   12] LP매도호가수량3                 StartPos 313, Length 12
        public long bidrem3{ get; set; } // [long  ,   12] 매수호가수량3                   StartPos 326, Length 12
        public long lp_bidrem3{ get; set; } // [long  ,   12] LP매수호가수량3                 StartPos 339, Length 12
        public long preoffercha3{ get; set; } // [long  ,   12] 직전매도대비수량3               StartPos 352, Length 12
        public long prebidcha3{ get; set; } // [long  ,   12] 직전매수대비수량3               StartPos 365, Length 12
        public long offerho4{ get; set; } // [long  ,    8] 매도호가4                       StartPos 378, Length 8
        public long bidho4{ get; set; } // [long  ,    8] 매수호가4                       StartPos 387, Length 8
        public long offerrem4{ get; set; } // [long  ,   12] 매도호가수량4                   StartPos 396, Length 12
        public long lp_offerrem4{ get; set; } // [long  ,   12] LP매도호가수량4                 StartPos 409, Length 12
        public long bidrem4{ get; set; } // [long  ,   12] 매수호가수량4                   StartPos 422, Length 12
        public long lp_bidrem4{ get; set; } // [long  ,   12] LP매수호가수량4                 StartPos 435, Length 12
        public long preoffercha4{ get; set; } // [long  ,   12] 직전매도대비수량4               StartPos 448, Length 12
        public long prebidcha4{ get; set; } // [long  ,   12] 직전매수대비수량4               StartPos 461, Length 12
        public long offerho5{ get; set; } // [long  ,    8] 매도호가5                       StartPos 474, Length 8
        public long bidho5{ get; set; } // [long  ,    8] 매수호가5                       StartPos 483, Length 8
        public long offerrem5{ get; set; } // [long  ,   12] 매도호가수량5                   StartPos 492, Length 12
        public long lp_offerrem5{ get; set; } // [long  ,   12] LP매도호가수량5                 StartPos 505, Length 12
        public long bidrem5{ get; set; } // [long  ,   12] 매수호가수량5                   StartPos 518, Length 12
        public long lp_bidrem5{ get; set; } // [long  ,   12] LP매수호가수량5                 StartPos 531, Length 12
        public long preoffercha5{ get; set; } // [long  ,   12] 직전매도대비수량5               StartPos 544, Length 12
        public long prebidcha5{ get; set; } // [long  ,   12] 직전매수대비수량5               StartPos 557, Length 12
        public long offerho6{ get; set; } // [long  ,    8] 매도호가6                       StartPos 570, Length 8
        public long bidho6{ get; set; } // [long  ,    8] 매수호가6                       StartPos 579, Length 8
        public long offerrem6{ get; set; } // [long  ,   12] 매도호가수량6                   StartPos 588, Length 12
        public long lp_offerrem6{ get; set; } // [long  ,   12] LP매도호가수량6                 StartPos 601, Length 12
        public long bidrem6{ get; set; } // [long  ,   12] 매수호가수량6                   StartPos 614, Length 12
        public long lp_bidrem6{ get; set; } // [long  ,   12] LP매수호가수량6                 StartPos 627, Length 12
        public long preoffercha6{ get; set; } // [long  ,   12] 직전매도대비수량6               StartPos 640, Length 12
        public long prebidcha6{ get; set; } // [long  ,   12] 직전매수대비수량6               StartPos 653, Length 12
        public long offerho7{ get; set; } // [long  ,    8] 매도호가7                       StartPos 666, Length 8
        public long bidho7{ get; set; } // [long  ,    8] 매수호가7                       StartPos 675, Length 8
        public long offerrem7{ get; set; } // [long  ,   12] 매도호가수량7                   StartPos 684, Length 12
        public long lp_offerrem7{ get; set; } // [long  ,   12] LP매도호가수량7                 StartPos 697, Length 12
        public long bidrem7{ get; set; } // [long  ,   12] 매수호가수량7                   StartPos 710, Length 12
        public long lp_bidrem7{ get; set; } // [long  ,   12] LP매수호가수량7                 StartPos 723, Length 12
        public long preoffercha7{ get; set; } // [long  ,   12] 직전매도대비수량7               StartPos 736, Length 12
        public long prebidcha7{ get; set; } // [long  ,   12] 직전매수대비수량7               StartPos 749, Length 12
        public long offerho8{ get; set; } // [long  ,    8] 매도호가8                       StartPos 762, Length 8
        public long bidho8{ get; set; } // [long  ,    8] 매수호가8                       StartPos 771, Length 8
        public long offerrem8{ get; set; } // [long  ,   12] 매도호가수량8                   StartPos 780, Length 12
        public long lp_offerrem8{ get; set; } // [long  ,   12] LP매도호가수량8                 StartPos 793, Length 12
        public long bidrem8{ get; set; } // [long  ,   12] 매수호가수량8                   StartPos 806, Length 12
        public long lp_bidrem8{ get; set; } // [long  ,   12] LP매수호가수량8                 StartPos 819, Length 12
        public long preoffercha8{ get; set; } // [long  ,   12] 직전매도대비수량8               StartPos 832, Length 12
        public long prebidcha8{ get; set; } // [long  ,   12] 직전매수대비수량8               StartPos 845, Length 12
        public long offerho9{ get; set; } // [long  ,    8] 매도호가9                       StartPos 858, Length 8
        public long bidho9{ get; set; } // [long  ,    8] 매수호가9                       StartPos 867, Length 8
        public long offerrem9{ get; set; } // [long  ,   12] 매도호가수량9                   StartPos 876, Length 12
        public long lp_offerrem9{ get; set; } // [long  ,   12] LP매도호가수량9                 StartPos 889, Length 12
        public long bidrem9{ get; set; } // [long  ,   12] 매수호가수량9                   StartPos 902, Length 12
        public long lp_bidrem9{ get; set; } // [long  ,   12] LP매수호가수량9                 StartPos 915, Length 12
        public long preoffercha9{ get; set; } // [long  ,   12] 직전매도대비수량9               StartPos 928, Length 12
        public long prebidcha9{ get; set; } // [long  ,   12] 직전매수대비수량9               StartPos 941, Length 12
        public long offerho10{ get; set; } // [long  ,    8] 매도호가10                      StartPos 954, Length 8
        public long bidho10{ get; set; } // [long  ,    8] 매수호가10                      StartPos 963, Length 8
        public long offerrem10{ get; set; } // [long  ,   12] 매도호가수량10                  StartPos 972, Length 12
        public long lp_offerrem10{ get; set; } // [long  ,   12] LP매도호가수량10                StartPos 985, Length 12
        public long bidrem10{ get; set; } // [long  ,   12] 매수호가수량10                  StartPos 998, Length 12
        public long lp_bidrem10{ get; set; } // [long  ,   12] LP매수호가수량10                StartPos 1011, Length 12
        public long preoffercha10{ get; set; } // [long  ,   12] 직전매도대비수량10              StartPos 1024, Length 12
        public long prebidcha10{ get; set; } // [long  ,   12] 직전매수대비수량10              StartPos 1037, Length 12
        public long offer{ get; set; } // [long  ,   12] 매도호가수량합                  StartPos 1050, Length 12
        public long bid{ get; set; } // [long  ,   12] 매수호가수량합                  StartPos 1063, Length 12
        public long preoffercha{ get; set; } // [long  ,   12] 직전매도대비수량합              StartPos 1076, Length 12
        public long prebidcha{ get; set; } // [long  ,   12] 직전매수대비수량합              StartPos 1089, Length 12
        public string hotime{ get; set; } // [string,    8] 수신시간                        StartPos 1102, Length 8
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가격                    StartPos 1111, Length 8
        public decimal yevolume{ get; set; } // [float ,   12] 예상체결수량                    StartPos 1120, Length 12
        public string yesign{ get; set; } // [string,    1] 예상체결전일구분                StartPos 1133, Length 1
        public long yechange{ get; set; } // [long  ,    8] 예상체결전일대비                StartPos 1135, Length 8
        public decimal yediff{ get; set; } // [float ,  6.2] 예상체결등락율                  StartPos 1144, Length 6
        public long tmoffer{ get; set; } // [long  ,   12] 시간외매도잔량                  StartPos 1151, Length 12
        public long tmbid{ get; set; } // [long  ,   12] 시간외매수잔량                  StartPos 1164, Length 12
        public string ho_status{ get; set; } // [string,    1] 동시구분                        StartPos 1177, Length 1
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 1179, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 1188, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 1197, Length 8
        public string invidx{ get; set; } // [string,    1] ELW권리형태(1:표준2:디지털3:조?StartPos 1206, Length 1
        public decimal koba_stdprc{ get; set; } // [float , 12.2] KO베리어                        StartPos 1208, Length 12
        public decimal koba_acc_rt{ get; set; } // [float , 12.2] KO접근도                        StartPos 1221, Length 12
        public string koba_yn{ get; set; } // [string,    1] KO발생여부(Y/N)                 StartPos 1234, Length 1
    }
}