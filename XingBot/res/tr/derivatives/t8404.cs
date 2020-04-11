namespace XingBot.res
{
    // 주식선물 시간대별 체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8404InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public long cvolume{ get; set; } // [long  ,   12] 특이거래량                      StartPos 9, Length 12
        public string stime{ get; set; } // [string,    4] 시작시간                        StartPos 22, Length 4
        public string etime{ get; set; } // [string,    4] 종료시간                        StartPos 27, Length 4
        public string cts_time{ get; set; } // [string,   10] 시간CTS                         StartPos 32, Length 10
    }

    public class _t8404OutBlock
    {
        public string cts_time{ get; set; } // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    public class _t8404OutBlock1
    {
        public string chetime{ get; set; } // [string,   10] 시간                            StartPos 0, Length 10
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 11, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public decimal change{ get; set; } // [float ,    8] 전일대비                        StartPos 22, Length 8
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 31, Length 8
        public decimal chdegree{ get; set; } // [float ,  8.2] 체결강도                        StartPos 40, Length 8
        public long offerho{ get; set; } // [long  ,    8] 매도호가                        StartPos 49, Length 8
        public long bidho{ get; set; } // [long  ,    8] 매수호가                        StartPos 58, Length 8
        public decimal volume{ get; set; } // [double,   12] 거래량                          StartPos 67, Length 12
        public long openyak{ get; set; } // [long  ,    8] 미결수량                        StartPos 80, Length 8
        public long jnilopenupdn{ get; set; } // [long  ,    8] 미결전일증감                    StartPos 89, Length 8
        public long ibasis{ get; set; } // [long  ,    8] 이론BASIS                       StartPos 98, Length 8
        public long sbasis{ get; set; } // [long  ,    8] 시장BASIS                       StartPos 107, Length 8
        public decimal kasis{ get; set; } // [float ,  6.2] 괴리율                          StartPos 116, Length 6
        public decimal value{ get; set; } // [double,   12] 거래대금                        StartPos 123, Length 12
        public long j_openupdn{ get; set; } // [long  ,    8] 미결직전증감                    StartPos 136, Length 8
        public decimal n_msvolume{ get; set; } // [double,   12] 누적매수체결량                  StartPos 145, Length 12
        public decimal n_mdvolume{ get; set; } // [double,   12] 누적매도체결량                  StartPos 158, Length 12
        public decimal s_msvolume{ get; set; } // [double,   12] 누적순매수체결량                StartPos 171, Length 12
        public long n_mschecnt{ get; set; } // [long  ,    8] 누적매수체결건수                StartPos 184, Length 8
        public long n_mdchecnt{ get; set; } // [long  ,    8] 누적매도체결건수                StartPos 193, Length 8
        public long s_mschecnt{ get; set; } // [long  ,    8] 누적순매수체결건수              StartPos 202, Length 8
    }
}