using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // ETFLP호가 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1906InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    struct _t1906OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long lp_offerrem1; // [long  ,   12] LP매도호가수량1                 StartPos 61, Length 12
        public long lp_bidrem1; // [long  ,   12] LP매수호가수량1                 StartPos 74, Length 12
        public long lp_offerrem2; // [long  ,   12] LP매도호가수량2                 StartPos 87, Length 12
        public long lp_bidrem2; // [long  ,   12] LP매수호가수량2                 StartPos 100, Length 12
        public long lp_offerrem3; // [long  ,   12] LP매도호가수량3                 StartPos 113, Length 12
        public long lp_bidrem3; // [long  ,   12] LP매수호가수량3                 StartPos 126, Length 12
        public long lp_offerrem4; // [long  ,   12] LP매도호가수량4                 StartPos 139, Length 12
        public long lp_bidrem4; // [long  ,   12] LP매수호가수량4                 StartPos 152, Length 12
        public long lp_offerrem5; // [long  ,   12] LP매도호가수량5                 StartPos 165, Length 12
        public long lp_bidrem5; // [long  ,   12] LP매수호가수량5                 StartPos 178, Length 12
        public long lp_offerrem6; // [long  ,   12] LP매도호가수량6                 StartPos 191, Length 12
        public long lp_bidrem6; // [long  ,   12] LP매수호가수량6                 StartPos 204, Length 12
        public long lp_offerrem7; // [long  ,   12] LP매도호가수량7                 StartPos 217, Length 12
        public long lp_bidrem7; // [long  ,   12] LP매수호가수량7                 StartPos 230, Length 12
        public long lp_offerrem8; // [long  ,   12] LP매도호가수량8                 StartPos 243, Length 12
        public long lp_bidrem8; // [long  ,   12] LP매수호가수량8                 StartPos 256, Length 12
        public long lp_offerrem9; // [long  ,   12] LP매도호가수량9                 StartPos 269, Length 12
        public long lp_bidrem9; // [long  ,   12] LP매수호가수량9                 StartPos 282, Length 12
        public long lp_offerrem10; // [long  ,   12] LP매도호가수량10                StartPos 295, Length 12
        public long lp_bidrem10; // [long  ,   12] LP매수호가수량10                StartPos 308, Length 12
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 321, Length 8
        public long offerho1; // [long  ,    8] 매도호가1                       StartPos 330, Length 8
        public long bidho1; // [long  ,    8] 매수호가1                       StartPos 339, Length 8
        public long offerrem1; // [long  ,   12] 매도호가수량1                   StartPos 348, Length 12
        public long bidrem1; // [long  ,   12] 매수호가수량1                   StartPos 361, Length 12
        public long preoffercha1; // [long  ,   12] 직전매도대비수량1               StartPos 374, Length 12
        public long prebidcha1; // [long  ,   12] 직전매수대비수량1               StartPos 387, Length 12
        public long offerho2; // [long  ,    8] 매도호가2                       StartPos 400, Length 8
        public long bidho2; // [long  ,    8] 매수호가2                       StartPos 409, Length 8
        public long offerrem2; // [long  ,   12] 매도호가수량2                   StartPos 418, Length 12
        public long bidrem2; // [long  ,   12] 매수호가수량2                   StartPos 431, Length 12
        public long preoffercha2; // [long  ,   12] 직전매도대비수량2               StartPos 444, Length 12
        public long prebidcha2; // [long  ,   12] 직전매수대비수량2               StartPos 457, Length 12
        public long offerho3; // [long  ,    8] 매도호가3                       StartPos 470, Length 8
        public long bidho3; // [long  ,    8] 매수호가3                       StartPos 479, Length 8
        public long offerrem3; // [long  ,   12] 매도호가수량3                   StartPos 488, Length 12
        public long bidrem3; // [long  ,   12] 매수호가수량3                   StartPos 501, Length 12
        public long preoffercha3; // [long  ,   12] 직전매도대비수량3               StartPos 514, Length 12
        public long prebidcha3; // [long  ,   12] 직전매수대비수량3               StartPos 527, Length 12
        public long offerho4; // [long  ,    8] 매도호가4                       StartPos 540, Length 8
        public long bidho4; // [long  ,    8] 매수호가4                       StartPos 549, Length 8
        public long offerrem4; // [long  ,   12] 매도호가수량4                   StartPos 558, Length 12
        public long bidrem4; // [long  ,   12] 매수호가수량4                   StartPos 571, Length 12
        public long preoffercha4; // [long  ,   12] 직전매도대비수량4               StartPos 584, Length 12
        public long prebidcha4; // [long  ,   12] 직전매수대비수량4               StartPos 597, Length 12
        public long offerho5; // [long  ,    8] 매도호가5                       StartPos 610, Length 8
        public long bidho5; // [long  ,    8] 매수호가5                       StartPos 619, Length 8
        public long offerrem5; // [long  ,   12] 매도호가수량5                   StartPos 628, Length 12
        public long bidrem5; // [long  ,   12] 매수호가수량5                   StartPos 641, Length 12
        public long preoffercha5; // [long  ,   12] 직전매도대비수량5               StartPos 654, Length 12
        public long prebidcha5; // [long  ,   12] 직전매수대비수량5               StartPos 667, Length 12
        public long offerho6; // [long  ,    8] 매도호가6                       StartPos 680, Length 8
        public long bidho6; // [long  ,    8] 매수호가6                       StartPos 689, Length 8
        public long offerrem6; // [long  ,   12] 매도호가수량6                   StartPos 698, Length 12
        public long bidrem6; // [long  ,   12] 매수호가수량6                   StartPos 711, Length 12
        public long preoffercha6; // [long  ,   12] 직전매도대비수량6               StartPos 724, Length 12
        public long prebidcha6; // [long  ,   12] 직전매수대비수량6               StartPos 737, Length 12
        public long offerho7; // [long  ,    8] 매도호가7                       StartPos 750, Length 8
        public long bidho7; // [long  ,    8] 매수호가7                       StartPos 759, Length 8
        public long offerrem7; // [long  ,   12] 매도호가수량7                   StartPos 768, Length 12
        public long bidrem7; // [long  ,   12] 매수호가수량7                   StartPos 781, Length 12
        public long preoffercha7; // [long  ,   12] 직전매도대비수량7               StartPos 794, Length 12
        public long prebidcha7; // [long  ,   12] 직전매수대비수량7               StartPos 807, Length 12
        public long offerho8; // [long  ,    8] 매도호가8                       StartPos 820, Length 8
        public long bidho8; // [long  ,    8] 매수호가8                       StartPos 829, Length 8
        public long offerrem8; // [long  ,   12] 매도호가수량8                   StartPos 838, Length 12
        public long bidrem8; // [long  ,   12] 매수호가수량8                   StartPos 851, Length 12
        public long preoffercha8; // [long  ,   12] 직전매도대비수량8               StartPos 864, Length 12
        public long prebidcha8; // [long  ,   12] 직전매수대비수량8               StartPos 877, Length 12
        public long offerho9; // [long  ,    8] 매도호가9                       StartPos 890, Length 8
        public long bidho9; // [long  ,    8] 매수호가9                       StartPos 899, Length 8
        public long offerrem9; // [long  ,   12] 매도호가수량9                   StartPos 908, Length 12
        public long bidrem9; // [long  ,   12] 매수호가수량9                   StartPos 921, Length 12
        public long preoffercha9; // [long  ,   12] 직전매도대비수량9               StartPos 934, Length 12
        public long prebidcha9; // [long  ,   12] 직전매수대비수량9               StartPos 947, Length 12
        public long offerho10; // [long  ,    8] 매도호가10                      StartPos 960, Length 8
        public long bidho10; // [long  ,    8] 매수호가10                      StartPos 969, Length 8
        public long offerrem10; // [long  ,   12] 매도호가수량10                  StartPos 978, Length 12
        public long bidrem10; // [long  ,   12] 매수호가수량10                  StartPos 991, Length 12
        public long preoffercha10; // [long  ,   12] 직전매도대비수량10              StartPos 1004, Length 12
        public long prebidcha10; // [long  ,   12] 직전매수대비수량10              StartPos 1017, Length 12
        public long offer; // [long  ,   12] 매도호가수량합                  StartPos 1030, Length 12
        public long bid; // [long  ,   12] 매수호가수량합                  StartPos 1043, Length 12
        public long preoffercha; // [long  ,   12] 직전매도대비수량합              StartPos 1056, Length 12
        public long prebidcha; // [long  ,   12] 직전매수대비수량합              StartPos 1069, Length 12
        public string hotime; // [string,    8] 수신시간                        StartPos 1082, Length 8
        public long yeprice; // [long  ,    8] 예상체결가격                    StartPos 1091, Length 8
        public long yevolume; // [long  ,   12] 예상체결수량                    StartPos 1100, Length 12
        public string yesign; // [string,    1] 예상체결전일구분                StartPos 1113, Length 1
        public long yechange; // [long  ,    8] 예상체결전일대비                StartPos 1115, Length 8
        public float yediff; // [float ,  6.2] 예상체결등락율                  StartPos 1124, Length 6
        public long tmoffer; // [long  ,   12] 시간외매도잔량                  StartPos 1131, Length 12
        public long tmbid; // [long  ,   12] 시간외매수잔량                  StartPos 1144, Length 12
        public string ho_status; // [string,    1] 동시구분                        StartPos 1157, Length 1
        public string shcode; // [string,    6] 단축코드                        StartPos 1159, Length 6
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 1166, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 1175, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 1184, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 1193, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 1202, Length 8
    }
}