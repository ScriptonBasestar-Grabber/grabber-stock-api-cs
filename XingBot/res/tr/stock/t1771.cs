using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 종목별회원사추이 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1771InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string tradno; // [string,    3] 거래원코드                      StartPos 7, Length 3
        public string gubun1; // [string,    1] 구분1                           StartPos 11, Length 1
        public string traddate1; // [string,    8] 거래원날짜1                     StartPos 13, Length 8
        public string traddate2; // [string,    8] 거래원날짜2                     StartPos 22, Length 8
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 31, Length 4
        public string cnt; // [string,    3] 요청건수                        StartPos 36, Length 3
    }

    struct _t1771OutBlock
    {
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 0, Length 4
    }

    struct _t1771OutBlock2
    {
        public string traddate; // [string,    8] 날짜                            StartPos 0, Length 8
        public string tradtime; // [string,    8] 시간                            StartPos 9, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 18, Length 8
        public string sign; // [string,    1] 대비구분                        StartPos 27, Length 1
        public long change; // [long  ,    8] 대비                            StartPos 29, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 38, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 45, Length 12
        public long tradmdcha; // [long  ,   12] 매도                            StartPos 58, Length 12
        public long tradmscha; // [long  ,   12] 매수                            StartPos 71, Length 12
        public long tradmdval; // [long  ,   18] 매도대금                        StartPos 84, Length 18
        public long tradmsval; // [long  ,   18] 매수대금                        StartPos 103, Length 18
        public long tradmsscha; // [long  ,   12] 순매수                          StartPos 122, Length 12
        public long tradmttvolume; // [long  ,   12] 누적순매수                      StartPos 135, Length 12
        public long tradavg; // [long  ,    8] 평균단가                        StartPos 148, Length 8
        public long tradmttavg; // [long  ,    8] 누적평균단가                    StartPos 157, Length 8
    }
}