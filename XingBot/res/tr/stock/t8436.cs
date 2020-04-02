using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    // 주식종목조회 API용 ( BLOCK,HEADTYPE=A )
    struct _t8436InBlock
    {
        public string gubun; // [string,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 0, Length 1
    }

    struct _t8436OutBlock
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode; // [string,    6] 단축코드                        StartPos 20, Length 6
        public string expcode; // [string,   12] 확장코드                        StartPos 26, Length 12
        public string etfgubun; // [string,    1] ETF구분(1:ETF2:ETN)             StartPos 38, Length 1
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 39, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 47, Length 8
        public long jnilclose; // [long  ,    8] 전일가                          StartPos 55, Length 8
        public string memedan; // [string,    5] 주문수량단위                    StartPos 63, Length 5
        public long recprice; // [long  ,    8] 기준가                          StartPos 68, Length 8
        public string gubun; // [string,    1] 구분(1:코스피2:코스닥)          StartPos 76, Length 1
        public string bu12gubun; // [string,    2] 증권그룹                        StartPos 77, Length 2
        public string spac_gubun; // [string,    1] 기업인수목적회사여부(Y/N)       StartPos 79, Length 1
        public string filler; // [string,   32] filler(미사용)                  StartPos 80, Length 32
    }
}
