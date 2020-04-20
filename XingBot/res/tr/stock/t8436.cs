namespace XingBot.res
{
    // 주식종목조회 API용 ( BLOCK,HEADTYPE=A )
    public struct _t8436InBlock
    {
        public string gubun; // [string,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 0, Length 1
    }

    public class _t8436OutBlock
    {
        public string hname { get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode { get; set; } // [string,    6] 단축코드                        StartPos 20, Length 6
        public string expcode { get; set; } // [string,   12] 확장코드                        StartPos 26, Length 12
        public string etfgubun { get; set; } // [string,    1] ETF구분(1:ETF2:ETN)             StartPos 38, Length 1
        public long uplmtprice { get; set; } // [long  ,    8] 상한가                          StartPos 39, Length 8
        public long dnlmtprice { get; set; } // [long  ,    8] 하한가                          StartPos 47, Length 8
        public long jnilclose { get; set; } // [long  ,    8] 전일가                          StartPos 55, Length 8
        public string memedan { get; set; } // [string,    5] 주문수량단위                    StartPos 63, Length 5
        public long recprice { get; set; } // [long  ,    8] 기준가                          StartPos 68, Length 8
        public string gubun { get; set; } // [string,    1] 구분(1:코스피2:코스닥)          StartPos 76, Length 1
        public string bu12gubun { get; set; } // [string,    2] 증권그룹                        StartPos 77, Length 2
        public string spac_gubun { get; set; } // [string,    1] 기업인수목적회사여부(Y/N)       StartPos 79, Length 1
        public string filler { get; set; } // [string,   32] filler(미사용)                  StartPos 80, Length 32
    }
}