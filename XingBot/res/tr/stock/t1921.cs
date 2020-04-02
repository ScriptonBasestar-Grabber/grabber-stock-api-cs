using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 신용거래동향 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1921InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun; // [string,    1] 융자대주구분                    StartPos 7, Length 1
        public string date; // [string,    8] 날짜                            StartPos 9, Length 8
        public long idx; // [long  ,    4] IDX                             StartPos 18, Length 4
    }

    struct _t1921OutBlock
    {
        public long cnt; // [long  ,    4] CNT                             StartPos 0, Length 4
        public string date; // [string,    8] 날짜                            StartPos 5, Length 8
        public long idx; // [long  ,    4] IDX                             StartPos 14, Length 4
    }

    struct _t1921OutBlock1
    {
        public string mmdate; // [string,    8] 날짜                            StartPos 0, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long jchange; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long nvolume; // [long  ,    8] 신규                            StartPos 36, Length 8
        public long svolume; // [long  ,    8] 상환                            StartPos 45, Length 8
        public long jvolume; // [long  ,    8] 잔고                            StartPos 54, Length 8
        public long price; // [long  ,    8] 금액                            StartPos 63, Length 8
        public long change; // [long  ,    8] 대비                            StartPos 72, Length 8
        public float gyrate; // [float ,  6.2] 공여율                          StartPos 81, Length 6
        public float jkrate; // [float ,  6.2] 잔고율                          StartPos 88, Length 6
        public string shcode; // [string,    6] 종목코드                        StartPos 95, Length 6
    }
}