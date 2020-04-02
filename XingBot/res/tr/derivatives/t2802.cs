using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // CME 호가조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2802InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _t2802OutBlock
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public float price; // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 37, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 44, Length 12
        public float stimeqrt; // [float ,  6.2] 거래량전일동시간비율            StartPos 57, Length 6
        public float jnilclose; // [float ,  6.2] 전일종가                        StartPos 64, Length 6
        public float offerho1; // [float ,  6.2] 매도호가1                       StartPos 71, Length 6
        public float bidho1; // [float ,  6.2] 매수호가1                       StartPos 78, Length 6
        public long offerrem1; // [long  ,    8] 매도호가수량1                   StartPos 85, Length 8
        public long bidrem1; // [long  ,    8] 매수호가수량1                   StartPos 94, Length 8
        public long dcnt1; // [long  ,    8] 매도호가건수1                   StartPos 103, Length 8
        public long scnt1; // [long  ,    8] 매수호가건수1                   StartPos 112, Length 8
        public float offerho2; // [float ,  6.2] 매도호가2                       StartPos 121, Length 6
        public float bidho2; // [float ,  6.2] 매수호가2                       StartPos 128, Length 6
        public long offerrem2; // [long  ,    8] 매도호가수량2                   StartPos 135, Length 8
        public long bidrem2; // [long  ,    8] 매수호가수량2                   StartPos 144, Length 8
        public long dcnt2; // [long  ,    8] 매도호가건수2                   StartPos 153, Length 8
        public long scnt2; // [long  ,    8] 매수호가건수2                   StartPos 162, Length 8
        public float offerho3; // [float ,  6.2] 매도호가3                       StartPos 171, Length 6
        public float bidho3; // [float ,  6.2] 매수호가3                       StartPos 178, Length 6
        public long offerrem3; // [long  ,    8] 매도호가수량3                   StartPos 185, Length 8
        public long bidrem3; // [long  ,    8] 매수호가수량3                   StartPos 194, Length 8
        public long dcnt3; // [long  ,    8] 매도호가건수3                   StartPos 203, Length 8
        public long scnt3; // [long  ,    8] 매수호가건수3                   StartPos 212, Length 8
        public float offerho4; // [float ,  6.2] 매도호가4                       StartPos 221, Length 6
        public float bidho4; // [float ,  6.2] 매수호가4                       StartPos 228, Length 6
        public long offerrem4; // [long  ,    8] 매도호가수량4                   StartPos 235, Length 8
        public long bidrem4; // [long  ,    8] 매수호가수량4                   StartPos 244, Length 8
        public long dcnt4; // [long  ,    8] 매도호가건수4                   StartPos 253, Length 8
        public long scnt4; // [long  ,    8] 매수호가건수4                   StartPos 262, Length 8
        public float offerho5; // [float ,  6.2] 매도호가5                       StartPos 271, Length 6
        public float bidho5; // [float ,  6.2] 매수호가5                       StartPos 278, Length 6
        public long offerrem5; // [long  ,    8] 매도호가수량5                   StartPos 285, Length 8
        public long bidrem5; // [long  ,    8] 매수호가수량5                   StartPos 294, Length 8
        public long dcnt5; // [long  ,    8] 매도호가건수5                   StartPos 303, Length 8
        public long scnt5; // [long  ,    8] 매수호가건수5                   StartPos 312, Length 8
        public long dvol; // [long  ,    8] 매도호가총수량                  StartPos 321, Length 8
        public long svol; // [long  ,    8] 매수호가총수량                  StartPos 330, Length 8
        public long toffernum; // [long  ,    8] 총매도호가건수                  StartPos 339, Length 8
        public long tbidnum; // [long  ,    8] 총매수호가건수                  StartPos 348, Length 8
        public string time; // [string,    6] 수신시간                        StartPos 357, Length 6
        public string shcode; // [string,    8] 단축코드                        StartPos 364, Length 8
    }
}