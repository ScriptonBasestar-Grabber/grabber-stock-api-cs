using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 증거금율별 종목조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1411InBlock
    {
        public string gubun; // [string,    1] 시장구분                        StartPos 0, Length 1
        public string jongchk; // [string,    1] 위탁신용구분                    StartPos 2, Length 1
        public string jkrate; // [string,    1] 증거금율구분                    StartPos 4, Length 1
        public string shcode; // [string,    6] 종목코드                        StartPos 6, Length 6
        public long idx; // [long  ,    4] IDX                             StartPos 13, Length 4
    }

    struct _t1411OutBlock
    {
        public long jkrate; // [long  ,    3] 위탁증거금율                    StartPos 0, Length 3
        public long sjkrate; // [long  ,    3] 신용증거금율                    StartPos 4, Length 3
        public long idx; // [long  ,    4] IDX                             StartPos 8, Length 4
    }

    struct _t1411OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   20] 종목명                          StartPos 7, Length 20
        public long jkrate; // [long  ,    3] 위탁증거금율                    StartPos 28, Length 3
        public long sjkrate; // [long  ,    3] 신용증거금율                    StartPos 32, Length 3
        public long subprice; // [long  ,    8] 대용가                          StartPos 36, Length 8
        public long recprice; // [long  ,    8] 전일종가                        StartPos 45, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 54, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 63, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 65, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 74, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 81, Length 12
    }
}