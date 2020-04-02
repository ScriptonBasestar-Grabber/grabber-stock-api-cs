using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 시가총액상위 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1444InBlock
    {
        public string upcode; // [string,    3] 업종코드                        StartPos 0, Length 3
        public long idx; // [long  ,    4] IDX                             StartPos 4, Length 4
    }

    struct _t1444OutBlock
    {
        public long idx; // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    struct _t1444OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   20] 종목명                          StartPos 7, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 28, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 37, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 39, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 48, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 55, Length 12
        public float vol_rate; // [float ,  6.2] 거래비중                        StartPos 68, Length 6
        public long total; // [long  ,   12] 시가총액                        StartPos 75, Length 12
        public float rate; // [float ,  6.2] 비중                            StartPos 88, Length 6
        public float for_rate; // [float ,  6.2] 외인비중                        StartPos 95, Length 6
    }
}