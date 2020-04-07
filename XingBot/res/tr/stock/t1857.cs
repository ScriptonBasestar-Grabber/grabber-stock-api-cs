namespace XingBot.res
{
    // e종목검색(API용) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1857InBlock
    {
        public string sRealFlag{ get; set; } // [string,    1] 실시간구분(0:조회 1:실시간)     StartPos 0, Length 1
        public string sSearchFlag{ get; set; } // [string,    1] 종목검색구분(F:파일 S:서버)     StartPos 2, Length 1
        public string query_index{ get; set; } // [string,  256] 종목검색입력값                  StartPos 4, Length 256
    }

    public struct _t1857OutBlock
    {
        public long result_count{ get; set; } // [long  ,    5] 검색종목수                      StartPos 0, Length 5
        public string result_time{ get; set; } // [string,    6] 포착시간                        StartPos 6, Length 6
        public string AlertNum{ get; set; } // [string,   11] 실시간키                        StartPos 13, Length 11
    }

    public struct _t1857OutBlock1
    {
        public string shcode{ get; set; } // [string,    7] 종목코드                        StartPos 0, Length 7
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 8, Length 40
        public long price{ get; set; } // [long  ,    9] 현재가                          StartPos 49, Length 9
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 59, Length 1
        public long change{ get; set; } // [long  ,    9] 전일대비                        StartPos 61, Length 9
        public decimal diff{ get; set; } // [float ,    6] 등락율                          StartPos 71, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 78, Length 12
        public string JobFlag{ get; set; } // [string,    1] 종목상태(N:진입 R:재진입 O:이탈 StartPos 91, Length 1
    }
}