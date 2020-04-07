namespace XingBot.res
{
    // 주식 분별 주가 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1302InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    1] 작업구분                        StartPos 7, Length 1
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public string cnt{ get; set; } // [string,    3] 건수                            StartPos 16, Length 3
    }

    public struct _t1302OutBlock
    {
        public string cts_time{ get; set; } // [string,    6] 시간CTS                         StartPos 0, Length 6
    }

    public struct _t1302OutBlock1
    {
        public string chetime{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 7, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 16, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 18, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 27, Length 6
        public decimal chdegree{ get; set; } // [float ,  8.2] 체결강도                        StartPos 34, Length 8
        public long mdvolume{ get; set; } // [long  ,   12] 매도체결수량                    StartPos 43, Length 12
        public long msvolume{ get; set; } // [long  ,   12] 매수체결수량                    StartPos 56, Length 12
        public long revolume{ get; set; } // [long  ,   12] 순매수체결량                    StartPos 69, Length 12
        public long mdchecnt{ get; set; } // [long  ,    8] 매도체결건수                    StartPos 82, Length 8
        public long mschecnt{ get; set; } // [long  ,    8] 매수체결건수                    StartPos 91, Length 8
        public long rechecnt{ get; set; } // [long  ,    8] 순체결건수                      StartPos 100, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 109, Length 12
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 122, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 131, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 140, Length 8
        public long cvolume{ get; set; } // [long  ,   12] 체결량                          StartPos 149, Length 12
        public long mdchecnttm{ get; set; } // [long  ,    8] 매도체결건수(시간)              StartPos 162, Length 8
        public long mschecnttm{ get; set; } // [long  ,    8] 매수체결건수(시간)              StartPos 171, Length 8
        public long totofferrem{ get; set; } // [long  ,   12] 매도잔량                        StartPos 180, Length 12
        public long totbidrem{ get; set; } // [long  ,   12] 매수잔량                        StartPos 193, Length 12
        public long mdvolumetm{ get; set; } // [long  ,   12] 시간별매도체결량                StartPos 206, Length 12
        public long msvolumetm{ get; set; } // [long  ,   12] 시간별매수체결량                StartPos 219, Length 12
    }
}