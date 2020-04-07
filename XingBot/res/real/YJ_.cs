namespace XingBot.res
{
    // 예상지수 ( ATTR, KEY=3, GROUP=1 )
    public struct _YJ__InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 0, Length 3
    }

    public struct _YJ__OutBlock
    {
        public string time{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public decimal jisu{ get; set; } // [float ,  8.2] 예상지수                        StartPos 7, Length 8
        public string sign{ get; set; } // [string,    1] 예상전일대비구분                StartPos 16, Length 1
        public decimal change{ get; set; } // [float ,  8.2] 예상전일비                      StartPos 18, Length 8
        public decimal drate{ get; set; } // [float ,  6.2] 예상등락율                      StartPos 27, Length 6
        public long cvolume{ get; set; } // [long  ,    8] 예상체결량                      StartPos 34, Length 8
        public long volume{ get; set; } // [long  ,    8] 누적거래량                      StartPos 43, Length 8
        public long value{ get; set; } // [long  ,    8] 예상거래대금                    StartPos 52, Length 8
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 61, Length 3
    }
}