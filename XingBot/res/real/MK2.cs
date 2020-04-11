namespace XingBot.res
{
    // US지수 ( ATTR, KEY=16, GROUP=1 )
    public class _MK2_InBlock
    {
        public string symbol{ get; set; } // [string,   16] 심볼코드                        StartPos 0, Length 16
    }

    public class _MK2_OutBlock
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public string kodate{ get; set; } // [string,    8] 한국일자                        StartPos 16, Length 8
        public string kotime{ get; set; } // [string,    6] 한국시간                        StartPos 25, Length 6
        public decimal open{ get; set; } // [float ,  9.2] 시가                            StartPos 32, Length 9
        public decimal high{ get; set; } // [float ,  9.2] 고가                            StartPos 42, Length 9
        public decimal low{ get; set; } // [float ,  9.2] 저가                            StartPos 52, Length 9
        public decimal price{ get; set; } // [float ,  9.2] 현재가                          StartPos 62, Length 9
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 72, Length 1
        public decimal change{ get; set; } // [float ,  9.2] 전일대비                        StartPos 74, Length 9
        public decimal uprate{ get; set; } // [float ,  9.2] 등락율                          StartPos 84, Length 9
        public decimal bidho{ get; set; } // [float ,  9.2] 매수호가                        StartPos 94, Length 9
        public long bidrem{ get; set; } // [long  ,    9] 매수잔량                        StartPos 104, Length 9
        public decimal offerho{ get; set; } // [float ,  9.2] 매도호가                        StartPos 114, Length 9
        public long offerrem{ get; set; } // [long  ,    9] 매도잔량                        StartPos 124, Length 9
        public decimal volume{ get; set; } // [float ,   12] 누적거래량                      StartPos 134, Length 12
        public string xsymbol{ get; set; } // [string,   16] 심벌                            StartPos 147, Length 16
        public decimal cvolume{ get; set; } // [float ,    8] 체결거래량                      StartPos 164, Length 8
    }
}