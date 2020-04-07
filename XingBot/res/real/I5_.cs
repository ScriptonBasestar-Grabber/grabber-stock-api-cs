namespace XingBot.res
{
    // 코스피ETF종목실시간NAV ( ATTR, KEY=6, GROUP=1 )
    public struct _I5__InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _I5__OutBlock
    {
        public string time{ get; set; } // [string,    8] 시간                            StartPos 0, Length 8
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal volume{ get; set; } // [float ,   12] 누적거래량                      StartPos 29, Length 12
        public decimal navdiff{ get; set; } // [float ,  9.2] NAV대비                         StartPos 42, Length 9
        public decimal nav{ get; set; } // [float ,  9.2] NAV                             StartPos 52, Length 9
        public decimal navchange{ get; set; } // [float ,  9.2] 전일대비                        StartPos 62, Length 9
        public decimal crate{ get; set; } // [float ,  9.2] 추적오차                        StartPos 72, Length 9
        public decimal grate{ get; set; } // [float ,  9.2] 괴리                            StartPos 82, Length 9
        public decimal jisu{ get; set; } // [float ,  8.2] 지수                            StartPos 92, Length 8
        public decimal jichange{ get; set; } // [float ,  8.2] 전일대비                        StartPos 101, Length 8
        public decimal jirate{ get; set; } // [float ,  8.2] 전일대비율                      StartPos 110, Length 8
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 119, Length 6
    }
}