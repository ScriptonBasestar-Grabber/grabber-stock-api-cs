namespace XingBot.res
{
    // ETFLP호가 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1906InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _t1906OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long lp_offerrem1{ get; set; } // [long  ,   12] LP매도호가수량1                 StartPos 61, Length 12
        public long lp_bidrem1{ get; set; } // [long  ,   12] LP매수호가수량1                 StartPos 74, Length 12
        public long lp_offerrem2{ get; set; } // [long  ,   12] LP매도호가수량2                 StartPos 87, Length 12
        public long lp_bidrem2{ get; set; } // [long  ,   12] LP매수호가수량2                 StartPos 100, Length 12
        public long lp_offerrem3{ get; set; } // [long  ,   12] LP매도호가수량3                 StartPos 113, Length 12
        public long lp_bidrem3{ get; set; } // [long  ,   12] LP매수호가수량3                 StartPos 126, Length 12
        public long lp_offerrem4{ get; set; } // [long  ,   12] LP매도호가수량4                 StartPos 139, Length 12
        public long lp_bidrem4{ get; set; } // [long  ,   12] LP매수호가수량4                 StartPos 152, Length 12
        public long lp_offerrem5{ get; set; } // [long  ,   12] LP매도호가수량5                 StartPos 165, Length 12
        public long lp_bidrem5{ get; set; } // [long  ,   12] LP매수호가수량5                 StartPos 178, Length 12
        public long lp_offerrem6{ get; set; } // [long  ,   12] LP매도호가수량6                 StartPos 191, Length 12
        public long lp_bidrem6{ get; set; } // [long  ,   12] LP매수호가수량6                 StartPos 204, Length 12
        public long lp_offerrem7{ get; set; } // [long  ,   12] LP매도호가수량7                 StartPos 217, Length 12
        public long lp_bidrem7{ get; set; } // [long  ,   12] LP매수호가수량7                 StartPos 230, Length 12
        public long lp_offerrem8{ get; set; } // [long  ,   12] LP매도호가수량8                 StartPos 243, Length 12
        public long lp_bidrem8{ get; set; } // [long  ,   12] LP매수호가수량8                 StartPos 256, Length 12
        public long lp_offerrem9{ get; set; } // [long  ,   12] LP매도호가수량9                 StartPos 269, Length 12
        public long lp_bidrem9{ get; set; } // [long  ,   12] LP매수호가수량9                 StartPos 282, Length 12
        public long lp_offerrem10{ get; set; } // [long  ,   12] LP매도호가수량10                StartPos 295, Length 12
        public long lp_bidrem10{ get; set; } // [long  ,   12] LP매수호가수량10                StartPos 308, Length 12
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 321, Length 8
        public long offerho1{ get; set; } // [long  ,    8] 매도호가1                       StartPos 330, Length 8
        public long bidho1{ get; set; } // [long  ,    8] 매수호가1                       StartPos 339, Length 8
        public long offerrem1{ get; set; } // [long  ,   12] 매도호가수량1                   StartPos 348, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수호가수량1                   StartPos 361, Length 12
        public long preoffercha1{ get; set; } // [long  ,   12] 직전매도대비수량1               StartPos 374, Length 12
        public long prebidcha1{ get; set; } // [long  ,   12] 직전매수대비수량1               StartPos 387, Length 12
        public long offerho2{ get; set; } // [long  ,    8] 매도호가2                       StartPos 400, Length 8
        public long bidho2{ get; set; } // [long  ,    8] 매수호가2                       StartPos 409, Length 8
        public long offerrem2{ get; set; } // [long  ,   12] 매도호가수량2                   StartPos 418, Length 12
        public long bidrem2{ get; set; } // [long  ,   12] 매수호가수량2                   StartPos 431, Length 12
        public long preoffercha2{ get; set; } // [long  ,   12] 직전매도대비수량2               StartPos 444, Length 12
        public long prebidcha2{ get; set; } // [long  ,   12] 직전매수대비수량2               StartPos 457, Length 12
        public long offerho3{ get; set; } // [long  ,    8] 매도호가3                       StartPos 470, Length 8
        public long bidho3{ get; set; } // [long  ,    8] 매수호가3                       StartPos 479, Length 8
        public long offerrem3{ get; set; } // [long  ,   12] 매도호가수량3                   StartPos 488, Length 12
        public long bidrem3{ get; set; } // [long  ,   12] 매수호가수량3                   StartPos 501, Length 12
        public long preoffercha3{ get; set; } // [long  ,   12] 직전매도대비수량3               StartPos 514, Length 12
        public long prebidcha3{ get; set; } // [long  ,   12] 직전매수대비수량3               StartPos 527, Length 12
        public long offerho4{ get; set; } // [long  ,    8] 매도호가4                       StartPos 540, Length 8
        public long bidho4{ get; set; } // [long  ,    8] 매수호가4                       StartPos 549, Length 8
        public long offerrem4{ get; set; } // [long  ,   12] 매도호가수량4                   StartPos 558, Length 12
        public long bidrem4{ get; set; } // [long  ,   12] 매수호가수량4                   StartPos 571, Length 12
        public long preoffercha4{ get; set; } // [long  ,   12] 직전매도대비수량4               StartPos 584, Length 12
        public long prebidcha4{ get; set; } // [long  ,   12] 직전매수대비수량4               StartPos 597, Length 12
        public long offerho5{ get; set; } // [long  ,    8] 매도호가5                       StartPos 610, Length 8
        public long bidho5{ get; set; } // [long  ,    8] 매수호가5                       StartPos 619, Length 8
        public long offerrem5{ get; set; } // [long  ,   12] 매도호가수량5                   StartPos 628, Length 12
        public long bidrem5{ get; set; } // [long  ,   12] 매수호가수량5                   StartPos 641, Length 12
        public long preoffercha5{ get; set; } // [long  ,   12] 직전매도대비수량5               StartPos 654, Length 12
        public long prebidcha5{ get; set; } // [long  ,   12] 직전매수대비수량5               StartPos 667, Length 12
        public long offerho6{ get; set; } // [long  ,    8] 매도호가6                       StartPos 680, Length 8
        public long bidho6{ get; set; } // [long  ,    8] 매수호가6                       StartPos 689, Length 8
        public long offerrem6{ get; set; } // [long  ,   12] 매도호가수량6                   StartPos 698, Length 12
        public long bidrem6{ get; set; } // [long  ,   12] 매수호가수량6                   StartPos 711, Length 12
        public long preoffercha6{ get; set; } // [long  ,   12] 직전매도대비수량6               StartPos 724, Length 12
        public long prebidcha6{ get; set; } // [long  ,   12] 직전매수대비수량6               StartPos 737, Length 12
        public long offerho7{ get; set; } // [long  ,    8] 매도호가7                       StartPos 750, Length 8
        public long bidho7{ get; set; } // [long  ,    8] 매수호가7                       StartPos 759, Length 8
        public long offerrem7{ get; set; } // [long  ,   12] 매도호가수량7                   StartPos 768, Length 12
        public long bidrem7{ get; set; } // [long  ,   12] 매수호가수량7                   StartPos 781, Length 12
        public long preoffercha7{ get; set; } // [long  ,   12] 직전매도대비수량7               StartPos 794, Length 12
        public long prebidcha7{ get; set; } // [long  ,   12] 직전매수대비수량7               StartPos 807, Length 12
        public long offerho8{ get; set; } // [long  ,    8] 매도호가8                       StartPos 820, Length 8
        public long bidho8{ get; set; } // [long  ,    8] 매수호가8                       StartPos 829, Length 8
        public long offerrem8{ get; set; } // [long  ,   12] 매도호가수량8                   StartPos 838, Length 12
        public long bidrem8{ get; set; } // [long  ,   12] 매수호가수량8                   StartPos 851, Length 12
        public long preoffercha8{ get; set; } // [long  ,   12] 직전매도대비수량8               StartPos 864, Length 12
        public long prebidcha8{ get; set; } // [long  ,   12] 직전매수대비수량8               StartPos 877, Length 12
        public long offerho9{ get; set; } // [long  ,    8] 매도호가9                       StartPos 890, Length 8
        public long bidho9{ get; set; } // [long  ,    8] 매수호가9                       StartPos 899, Length 8
        public long offerrem9{ get; set; } // [long  ,   12] 매도호가수량9                   StartPos 908, Length 12
        public long bidrem9{ get; set; } // [long  ,   12] 매수호가수량9                   StartPos 921, Length 12
        public long preoffercha9{ get; set; } // [long  ,   12] 직전매도대비수량9               StartPos 934, Length 12
        public long prebidcha9{ get; set; } // [long  ,   12] 직전매수대비수량9               StartPos 947, Length 12
        public long offerho10{ get; set; } // [long  ,    8] 매도호가10                      StartPos 960, Length 8
        public long bidho10{ get; set; } // [long  ,    8] 매수호가10                      StartPos 969, Length 8
        public long offerrem10{ get; set; } // [long  ,   12] 매도호가수량10                  StartPos 978, Length 12
        public long bidrem10{ get; set; } // [long  ,   12] 매수호가수량10                  StartPos 991, Length 12
        public long preoffercha10{ get; set; } // [long  ,   12] 직전매도대비수량10              StartPos 1004, Length 12
        public long prebidcha10{ get; set; } // [long  ,   12] 직전매수대비수량10              StartPos 1017, Length 12
        public long offer{ get; set; } // [long  ,   12] 매도호가수량합                  StartPos 1030, Length 12
        public long bid{ get; set; } // [long  ,   12] 매수호가수량합                  StartPos 1043, Length 12
        public long preoffercha{ get; set; } // [long  ,   12] 직전매도대비수량합              StartPos 1056, Length 12
        public long prebidcha{ get; set; } // [long  ,   12] 직전매수대비수량합              StartPos 1069, Length 12
        public string hotime{ get; set; } // [string,    8] 수신시간                        StartPos 1082, Length 8
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가격                    StartPos 1091, Length 8
        public long yevolume{ get; set; } // [long  ,   12] 예상체결수량                    StartPos 1100, Length 12
        public string yesign{ get; set; } // [string,    1] 예상체결전일구분                StartPos 1113, Length 1
        public long yechange{ get; set; } // [long  ,    8] 예상체결전일대비                StartPos 1115, Length 8
        public decimal yediff{ get; set; } // [float ,  6.2] 예상체결등락율                  StartPos 1124, Length 6
        public long tmoffer{ get; set; } // [long  ,   12] 시간외매도잔량                  StartPos 1131, Length 12
        public long tmbid{ get; set; } // [long  ,   12] 시간외매수잔량                  StartPos 1144, Length 12
        public string ho_status{ get; set; } // [string,    1] 동시구분                        StartPos 1157, Length 1
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 1159, Length 6
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 1166, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 1175, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 1184, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 1193, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 1202, Length 8
    }
}