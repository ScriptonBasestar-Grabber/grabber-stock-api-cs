namespace XingBot.real.res
{
    // 기초자산리스트 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1981InBlock
    {
        public string mkt_gb { get; set; } // [string,    1] 시장구분(0:전체1:코스피2:코스닥 StartPos 0, Length 1
    }

    struct _t1981OutBlock
    {
        public string ksp_cnt { get; set; } // [string,    4] 코스피종목건수                  StartPos 0, Length 4
        public string ksd_cnt { get; set; } // [string,    4] 코스닥종목건수                  StartPos 5, Length 4
    }

    public struct _t1981OutBlock1
    {
        public string shcode { get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string expcode { get; set; } // [string,   12] 표준코드                        StartPos 7, Length 12
        public string hname { get; set; } // [string,   20] 종목명                          StartPos 20, Length 20
        public string price { get; set; } // [string,   12] 현재가                          StartPos 41, Length 12
        public string sign { get; set; } // [string,    1] 부호                            StartPos 54, Length 1
        public string change { get; set; } // [string,   12] 대비                            StartPos 56, Length 12
        public decimal rate { get; set; } // [float ,  5.2] 등락율                          StartPos 69, Length 5
        public string volume { get; set; } // [string,   12] 누적거래량(주)                  StartPos 75, Length 12
        public string value { get; set; } // [string,   12] 누적거래대금(백만)              StartPos 88, Length 12
        public string mkt_gb { get; set; } // [string,    1] 시장구분                        StartPos 101, Length 1
    }
}