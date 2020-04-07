namespace XingBot.res
{
    // CME야간선물틱분별조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8408InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public string cgubun{ get; set; } // [string,    1] 챠트구분                        StartPos 9, Length 1
        public string bgubun{ get; set; } // [string,    3] 분구분                          StartPos 11, Length 3
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 15, Length 3
    }

    public struct _t8408OutBlock1
    {
        public string chetime{ get; set; } // [string,   10] 시간                            StartPos 0, Length 10
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 11, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 20, Length 6
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 27, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 34, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 41, Length 6
        public decimal volume{ get; set; } // [double,   12] 거래량                          StartPos 48, Length 12
        public decimal value{ get; set; } // [double,   12] 거래대금                        StartPos 61, Length 12
        public long openyak{ get; set; } // [long  ,    8] 미결수량                        StartPos 74, Length 8
        public long openupdn{ get; set; } // [long  ,    8] 미결증감                        StartPos 83, Length 8
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 92, Length 8
        public long s_mschecnt{ get; set; } // [long  ,    8] 매수순간체결건수                StartPos 101, Length 8
        public long s_mdchecnt{ get; set; } // [long  ,    8] 매도순간체결건수                StartPos 110, Length 8
        public long ss_mschecnt{ get; set; } // [long  ,    8] 순매수순간체결건수              StartPos 119, Length 8
        public decimal s_mschevol{ get; set; } // [double,   12] 매수순간체결량                  StartPos 128, Length 12
        public decimal s_mdchevol{ get; set; } // [double,   12] 매도순간체결량                  StartPos 141, Length 12
        public decimal ss_mschevol{ get; set; } // [double,   12] 순매수순간체결량                StartPos 154, Length 12
        public decimal chdegvol{ get; set; } // [float ,  8.2] 체결강도(거래량)                StartPos 167, Length 8
        public decimal chdegcnt{ get; set; } // [float ,  8.2] 체결강도(건수)                  StartPos 176, Length 8
    }
}