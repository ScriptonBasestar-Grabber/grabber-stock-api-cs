namespace XingBot.res.tr
{
    // 예상지수 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1485InBlock
    {
        public string upcode; // [string,    3] 업종코드                        StartPos 0, Length 3
        public string gubun; // [string,    1] 조회구분                        StartPos 4, Length 1
    }

    internal struct _t1485OutBlock
    {
        public float pricejisu; // [float , 10.2] 현재지수                        StartPos 0, Length 10
        public string sign; // [string,    1] 지수전일대비구분                StartPos 11, Length 1
        public float change; // [float , 10.2] 전일대비                        StartPos 13, Length 10
        public long volume; // [long  ,   12] 거래량                          StartPos 24, Length 12
        public long yhighjo; // [long  ,    4] 상승종목수                      StartPos 37, Length 4
        public long yupjo; // [long  ,    4] 상한종목수                      StartPos 42, Length 4
        public long yunchgjo; // [long  ,    4] 보합종목수                      StartPos 47, Length 4
        public long ylowjo; // [long  ,    4] 하락종목수                      StartPos 52, Length 4
        public long ydownjo; // [long  ,    4] 하한종목수                      StartPos 57, Length 4
        public long ytrajo; // [long  ,    4] 거래형성수                      StartPos 62, Length 4
    }

    internal struct _t1485OutBlock1
    {
        public string chetime; // [string,    6] 시간                            StartPos 0, Length 6
        public float jisu; // [float , 10.2] 예상지수                        StartPos 7, Length 10
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public float change; // [float , 10.2] 전일대비                        StartPos 20, Length 10
        public long volume; // [long  ,   12] 예상체결량                      StartPos 31, Length 12
        public long volcha; // [long  ,   12] 예상체결량직전대비              StartPos 44, Length 12
    }
}