namespace XingBot.res
{
    // 종목Q클릭검색 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1825InBlock
    {
        public string search_cd{ get; set; } // [string,    4] 검색코드                        StartPos 0, Length 4
        public string gubun{ get; set; } // [string,    1] 구분(0:전체1:코스피2:코스닥)    StartPos 5, Length 1
    }

    public struct _t1825OutBlock
    {
        public long JongCnt{ get; set; } // [long  ,    4] 검색종목수                      StartPos 0, Length 4
    }

    public struct _t1825OutBlock1
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 7, Length 20
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public long signcnt{ get; set; } // [long  ,    3] 연속봉수                        StartPos 30, Length 3
        public long close{ get; set; } // [long  ,    9] 현재가                          StartPos 34, Length 9
        public long change{ get; set; } // [long  ,    9] 전일대비                        StartPos 44, Length 9
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 54, Length 6
        public long volume{ get; set; } // [long  ,   10] 거래량                          StartPos 61, Length 10
        public decimal volumerate{ get; set; } // [float ,  6.2] 거래량전일대비율                StartPos 72, Length 6
    }
}