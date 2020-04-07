namespace XingBot.res
{
    // ELW체결 ( ATTR, KEY=6, GROUP=1 )
    public struct _s3_4ELW_InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _s3_4ELW_OutBlock
    {
        public string chetime{ get; set; } // [string,    6] 체결시간                        StartPos 0, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 9, Length 8
        public decimal drate{ get; set; } // [float ,  6.2] 등락율                          StartPos 18, Length 6
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 25, Length 8
        public string opentime{ get; set; } // [string,    6] 시가시간                        StartPos 34, Length 6
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 41, Length 8
        public string hightime{ get; set; } // [string,    6] 고가시간                        StartPos 50, Length 6
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 57, Length 8
        public string lowtime{ get; set; } // [string,    6] 저가시간                        StartPos 66, Length 6
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 73, Length 8
        public string cgubun{ get; set; } // [string,    1] 체결구분                        StartPos 82, Length 1
        public long cvolume{ get; set; } // [long  ,    8] 체결량                          StartPos 84, Length 8
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 93, Length 12
        public long value{ get; set; } // [long  ,   12] 누적거래대금                    StartPos 106, Length 12
        public long mdvolume{ get; set; } // [long  ,   12] 매도누적체결량                  StartPos 119, Length 12
        public long mdchecnt{ get; set; } // [long  ,    8] 매도누적체결건수                StartPos 132, Length 8
        public long msvolume{ get; set; } // [long  ,   12] 매수누적체결량                  StartPos 141, Length 12
        public long mschecnt{ get; set; } // [long  ,    8] 매수누적체결건수                StartPos 154, Length 8
        public decimal cpower{ get; set; } // [float ,  9.2] 체결강도                        StartPos 163, Length 9
        public long w_avrg{ get; set; } // [long  ,    8] 가중평균가                      StartPos 173, Length 8
        public long offerho{ get; set; } // [long  ,    8] 매도호가                        StartPos 182, Length 8
        public long bidho{ get; set; } // [long  ,    8] 매수호가                        StartPos 191, Length 8
        public string status{ get; set; } // [string,    2] 장정보                          StartPos 200, Length 2
        public long jnilvolume{ get; set; } // [long  ,   12] 전일동시간대거래량              StartPos 203, Length 12
        public decimal premium{ get; set; } // [float ,  8.2] 프리미엄                        StartPos 216, Length 8
        public string moneyness{ get; set; } // [string,    1] ATM구분                         StartPos 225, Length 1
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 227, Length 6
        public long lpvolume{ get; set; } // [long  ,   15] LP보유수량                      StartPos 234, Length 15
    }
}