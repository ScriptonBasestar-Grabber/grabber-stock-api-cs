namespace XingBot.res
{
    // 주식선물 틱분별체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8406InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public string cgubun{ get; set; } // [string,    1] 챠트구분                        StartPos 9, Length 1
        public string bgubun{ get; set; } // [string,    3] 분구분                          StartPos 11, Length 3
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 15, Length 3
    }

    public class _t8406OutBlock1
    {
        public string chetime{ get; set; } // [string,   10] 시간                            StartPos 0, Length 10
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 11, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 22, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 31, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 40, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 49, Length 8
        public decimal volume{ get; set; } // [double,   12] 거래량                          StartPos 58, Length 12
        public decimal value{ get; set; } // [double,   12] 거래대금                        StartPos 71, Length 12
        public long openyak{ get; set; } // [long  ,    8] 미결수량                        StartPos 84, Length 8
        public long openupdn{ get; set; } // [long  ,    8] 미결증감                        StartPos 93, Length 8
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 102, Length 8
        public long s_mschecnt{ get; set; } // [long  ,    8] 매수순간체결건수                StartPos 111, Length 8
        public long s_mdchecnt{ get; set; } // [long  ,    8] 매도순간체결건수                StartPos 120, Length 8
        public long ss_mschecnt{ get; set; } // [long  ,    8] 순매수순간체결건수              StartPos 129, Length 8
        public decimal s_mschevol{ get; set; } // [double,   12] 매수순간체결량                  StartPos 138, Length 12
        public decimal s_mdchevol{ get; set; } // [double,   12] 매도순간체결량                  StartPos 151, Length 12
        public decimal ss_mschevol{ get; set; } // [double,   12] 순매수순간체결량                StartPos 164, Length 12
        public decimal chdegvol{ get; set; } // [float ,  8.2] 체결강도(거래량)                StartPos 177, Length 8
        public decimal chdegcnt{ get; set; } // [float ,  8.2] 체결강도(건수)                  StartPos 186, Length 8
    }
}