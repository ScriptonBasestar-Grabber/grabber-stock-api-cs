namespace XingBot.res
{
    // 시간대별호가잔량추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1471InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    2] 분구분                          StartPos 7, Length 2
        public string time{ get; set; } // [string,    6] 시간                            StartPos 10, Length 6
        public string cnt{ get; set; } // [string,    3] 자료개수                        StartPos 17, Length 3
    }

    public struct _t1471OutBlock
    {
        public string time{ get; set; } // [string,    6] 시간CTS                         StartPos 0, Length 6
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 7, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 16, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 18, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 27, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 34, Length 12
    }

    public struct _t1471OutBlock1
    {
        public string time{ get; set; } // [string,    6] 체결시간                        StartPos 0, Length 6
        public long preoffercha1{ get; set; } // [long  ,   12] 메도증감                        StartPos 7, Length 12
        public long offerrem1{ get; set; } // [long  ,   12] 매도우선잔량                    StartPos 20, Length 12
        public long offerho1{ get; set; } // [long  ,    8] 매도우선호가                    StartPos 33, Length 8
        public long bidho1{ get; set; } // [long  ,    8] 매수우선호가                    StartPos 42, Length 8
        public long bidrem1{ get; set; } // [long  ,   12] 매수우선잔량                    StartPos 51, Length 12
        public long prebidcha1{ get; set; } // [long  ,   12] 매수증감                        StartPos 64, Length 12
        public long totofferrem{ get; set; } // [long  ,   12] 총매도                          StartPos 77, Length 12
        public long totbidrem{ get; set; } // [long  ,   12] 총매수                          StartPos 90, Length 12
        public long totsun{ get; set; } // [long  ,   12] 순매수                          StartPos 103, Length 12
        public decimal msrate{ get; set; } // [float ,  6.2] 매수비율                        StartPos 116, Length 6
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 123, Length 8
    }
}