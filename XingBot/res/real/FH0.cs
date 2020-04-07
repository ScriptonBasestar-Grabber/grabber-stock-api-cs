using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    // KOSPI200선물호가 ( ATTR, KEY=8, GROUP=1 )
    public struct _FH0_InBlock
    {
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _FH0_OutBlock
    {
        public string hotime{ get; set; } // [string,    6] 호가시간                        StartPos 0, Length 6
        public decimal offerho1{ get; set; } // [double,  6.2] 매도호가1                       StartPos 7, Length 6
        public decimal bidho1{ get; set; } // [double,  6.2] 매수호가1                       StartPos 14, Length 6
        public long offerrem1{ get; set; } // [long  ,    6] 매도호가수량1                   StartPos 21, Length 6
        public long bidrem1{ get; set; } // [long  ,    6] 매수호가수량1                   StartPos 28, Length 6
        public long offercnt1{ get; set; } // [long  ,    5] 매도호가건수1                   StartPos 35, Length 5
        public long bidcnt1{ get; set; } // [long  ,    5] 매수호가건수1                   StartPos 41, Length 5
        public decimal offerho2{ get; set; } // [double,  6.2] 매도호가2                       StartPos 47, Length 6
        public decimal bidho2{ get; set; } // [double,  6.2] 매수호가2                       StartPos 54, Length 6
        public long offerrem2{ get; set; } // [long  ,    6] 매도호가수량2                   StartPos 61, Length 6
        public long bidrem2{ get; set; } // [long  ,    6] 매수호가수량2                   StartPos 68, Length 6
        public long offercnt2{ get; set; } // [long  ,    5] 매도호가건수2                   StartPos 75, Length 5
        public long bidcnt2{ get; set; } // [long  ,    5] 매수호가건수2                   StartPos 81, Length 5
        public decimal offerho3{ get; set; } // [double,  6.2] 매도호가3                       StartPos 87, Length 6
        public decimal bidho3{ get; set; } // [double,  6.2] 매수호가3                       StartPos 94, Length 6
        public long offerrem3{ get; set; } // [long  ,    6] 매도호가수량3                   StartPos 101, Length 6
        public long bidrem3{ get; set; } // [long  ,    6] 매수호가수량3                   StartPos 108, Length 6
        public long offercnt3{ get; set; } // [long  ,    5] 매도호가건수3                   StartPos 115, Length 5
        public long bidcnt3{ get; set; } // [long  ,    5] 매수호가건수3                   StartPos 121, Length 5
        public decimal offerho4{ get; set; } // [double,  6.2] 매도호가4                       StartPos 127, Length 6
        public decimal bidho4{ get; set; } // [double,  6.2] 매수호가4                       StartPos 134, Length 6
        public long offerrem4{ get; set; } // [long  ,    6] 매도호가수량4                   StartPos 141, Length 6
        public long bidrem4{ get; set; } // [long  ,    6] 매수호가수량4                   StartPos 148, Length 6
        public long offercnt4{ get; set; } // [long  ,    5] 매도호가건수4                   StartPos 155, Length 5
        public long bidcnt4{ get; set; } // [long  ,    5] 매수호가건수4                   StartPos 161, Length 5
        public decimal offerho5{ get; set; } // [double,  6.2] 매도호가5                       StartPos 167, Length 6
        public decimal bidho5{ get; set; } // [double,  6.2] 매수호가5                       StartPos 174, Length 6
        public long offerrem5{ get; set; } // [long  ,    6] 매도호가수량5                   StartPos 181, Length 6
        public long bidrem5{ get; set; } // [long  ,    6] 매수호가수량5                   StartPos 188, Length 6
        public long offercnt5{ get; set; } // [long  ,    5] 매도호가건수5                   StartPos 195, Length 5
        public long bidcnt5{ get; set; } // [long  ,    5] 매수호가건수5                   StartPos 201, Length 5
        public long totofferrem{ get; set; } // [long  ,    6] 매도호가총수량                  StartPos 207, Length 6
        public long totbidrem{ get; set; } // [long  ,    6] 매수호가총수량                  StartPos 214, Length 6
        public long totoffercnt{ get; set; } // [long  ,    5] 매도호가총건수                  StartPos 221, Length 5
        public long totbidcnt{ get; set; } // [long  ,    5] 매수호가총건수                  StartPos 227, Length 5
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 233, Length 8
        public string danhochk{ get; set; } // [string,    1] 단일가호가여부                  StartPos 242, Length 1
        public string alloc_gubun{ get; set; } // [string,    1] 배분적용구분                    StartPos 244, Length 1
    }
}