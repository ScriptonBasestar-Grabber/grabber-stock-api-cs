using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 주식종목조회 ( BLOCK,HEADTYPE=A )
    // t8436 사용
    struct _t8430InBlock
    {
        public string gubun; // [gubun,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 0, Length 1
    }

    struct _t8430OutBlock
    {
        public string hname; // [hname,   20] 종목명                          StartPos 0, Length 20
        public string shcode; // [shcode,    6] 단축코드                        StartPos 20, Length 6
        public string expcode; // [expcode,   12] 확장코드                        StartPos 26, Length 12
        public string etfgubun; // [etfgubun,    1] ETF구분(1:ETF)                  StartPos 38, Length 1
        public long uplmtprice; // [uplmtprice  ,    8] 상한가                          StartPos 39, Length 8
        public long dnlmtprice; // [dnlmtprice  ,    8] 하한가                          StartPos 47, Length 8
        public long jnilclose; // [jnilclose  ,    8] 전일가                          StartPos 55, Length 8
        public string memedan; // [memedan,    5] 주문수량단위                    StartPos 63, Length 5
        public long recprice; // [recprice  ,    8] 기준가                          StartPos 68, Length 8
        public string gubun; // [gubun,    1] 구분(1:코스피2:코스닥)          StartPos 76, Length 1
    }
}