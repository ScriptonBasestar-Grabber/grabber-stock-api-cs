namespace XingBot.res
{
    // 시가총액상위 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1444InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 0, Length 3
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 4, Length 4
    }

    public struct _t1444OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public struct _t1444OutBlock1
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 7, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 28, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 37, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 39, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 48, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 55, Length 12
        public decimal vol_rate{ get; set; } // [float ,  6.2] 거래비중                        StartPos 68, Length 6
        public long total{ get; set; } // [long  ,   12] 시가총액                        StartPos 75, Length 12
        public decimal rate{ get; set; } // [float ,  6.2] 비중                            StartPos 88, Length 6
        public decimal for_rate{ get; set; } // [float ,  6.2] 외인비중                        StartPos 95, Length 6
    }
}