namespace XingBot.res
{
    // 주식 시간대별 체결조회 차트 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1308InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string starttime{ get; set; } // [string,    4] 시작시간                        StartPos 7, Length 4
        public string endtime{ get; set; } // [string,    4] 종료시간                        StartPos 12, Length 4
        public string bun_term{ get; set; } // [string,    2] 분간격                          StartPos 17, Length 2
    }

    public class _t1308OutBlock1
    {
        public string chetime{ get; set; } // [string,    8] 시간                            StartPos 0, Length 8
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 36, Length 8
        public decimal chdegvol{ get; set; } // [float ,  8.2] 체결강도(거래량)                StartPos 45, Length 8
        public decimal chdegcnt{ get; set; } // [float ,  8.2] 체결강도(건수)                  StartPos 54, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 63, Length 12
        public long mdvolume{ get; set; } // [long  ,   12] 매도체결수량                    StartPos 76, Length 12
        public long mdchecnt{ get; set; } // [long  ,    8] 매도체결건수                    StartPos 89, Length 8
        public long msvolume{ get; set; } // [long  ,   12] 매수체결수량                    StartPos 98, Length 12
        public long mschecnt{ get; set; } // [long  ,    8] 매수체결건수                    StartPos 111, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 120, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 129, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 138, Length 8
    }
}