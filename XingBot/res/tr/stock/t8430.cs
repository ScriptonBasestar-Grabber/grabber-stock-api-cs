namespace XingBot.res
{
    // 주식종목조회 ( BLOCK,HEADTYPE=A )
    // t8436 사용
    public struct _t8430InBlock
    {
        public string gubun{ get; set; } // [gubun,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 0, Length 1
    }

    public struct _t8430OutBlock
    {
        public string hname{ get; set; } // [hname,   20] 종목명                          StartPos 0, Length 20
        public string shcode{ get; set; } // [shcode,    6] 단축코드                        StartPos 20, Length 6
        public string expcode{ get; set; } // [expcode,   12] 확장코드                        StartPos 26, Length 12
        public string etfgubun{ get; set; } // [etfgubun,    1] ETF구분(1:ETF)                  StartPos 38, Length 1
        public long uplmtprice{ get; set; } // [uplmtprice  ,    8] 상한가                          StartPos 39, Length 8
        public long dnlmtprice{ get; set; } // [dnlmtprice  ,    8] 하한가                          StartPos 47, Length 8
        public long jnilclose{ get; set; } // [jnilclose  ,    8] 전일가                          StartPos 55, Length 8
        public string memedan{ get; set; } // [memedan,    5] 주문수량단위                    StartPos 63, Length 5
        public long recprice{ get; set; } // [recprice  ,    8] 기준가                          StartPos 68, Length 8
        public string gubun{ get; set; } // [gubun,    1] 구분(1:코스피2:코스닥)          StartPos 76, Length 1
    }
}