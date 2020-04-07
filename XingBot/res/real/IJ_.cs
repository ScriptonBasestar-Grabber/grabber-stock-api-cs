namespace XingBot.res
{
    // 지수 ( ATTR, KEY=3, GROUP=1 )
    public struct _IJ__InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _IJ__OutBlock
    {
        public string time{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public decimal jisu{ get; set; } // [float ,  8.2] 지수                            StartPos 7, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 16, Length 1
        public decimal change{ get; set; } // [float ,  8.2] 전일비                          StartPos 18, Length 8
        public decimal drate{ get; set; } // [float ,  6.2] 등락율                          StartPos 27, Length 6
        public long cvolume{ get; set; } // [long  ,    8] 체결량                          StartPos 34, Length 8
        public long volume{ get; set; } // [long  ,    8] 거래량                          StartPos 43, Length 8
        public long value{ get; set; } // [long  ,    8] 거래대금                        StartPos 52, Length 8
        public long upjo{ get; set; } // [long  ,    4] 상한종목수                      StartPos 61, Length 4
        public long highjo{ get; set; } // [long  ,    4] 상승종목수                      StartPos 66, Length 4
        public long unchgjo{ get; set; } // [long  ,    4] 보합종목수                      StartPos 71, Length 4
        public long lowjo{ get; set; } // [long  ,    4] 하락종목수                      StartPos 76, Length 4
        public long downjo{ get; set; } // [long  ,    4] 하한종목수                      StartPos 81, Length 4
        public decimal upjrate{ get; set; } // [float ,  6.2] 상승종목비율                    StartPos 86, Length 6
        public decimal openjisu{ get; set; } // [float ,  8.2] 시가지수                        StartPos 93, Length 8
        public string opentime{ get; set; } // [string,    6] 시가시간                        StartPos 102, Length 6
        public decimal highjisu{ get; set; } // [float ,  8.2] 고가지수                        StartPos 109, Length 8
        public string hightime{ get; set; } // [string,    6] 고가시간                        StartPos 118, Length 6
        public decimal lowjisu{ get; set; } // [float ,  8.2] 저가지수                        StartPos 125, Length 8
        public string lowtime{ get; set; } // [string,    6] 저가시간                        StartPos 134, Length 6
        public long frgsvolume{ get; set; } // [long  ,    8] 외인순매수수량                  StartPos 141, Length 8
        public long orgsvolume{ get; set; } // [long  ,    8] 기관순매수수량                  StartPos 150, Length 8
        public long frgsvalue{ get; set; } // [long  ,   10] 외인순매수금액                  StartPos 159, Length 10
        public long orgsvalue{ get; set; } // [long  ,   10] 기관순매수금액                  StartPos 170, Length 10
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 181, Length 3
    }
}