namespace XingBot.res
{
// 선물/옵션 시간대별 체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2201InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public long cvolume{ get; set; } // [long  ,   12] 특이거래량                      StartPos 9, Length 12
        public string stime{ get; set; } // [string,    4] 시작시간                        StartPos 22, Length 4
        public string etime{ get; set; } // [string,    4] 종료시간                        StartPos 27, Length 4
        public string cts_time{ get; set; } // [string,   10] 시간CTS                         StartPos 32, Length 10
    }

    public struct _t2201OutBlock
    {
        public string cts_time{ get; set; } // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    public struct _t2201OutBlock1
    {
        public string chetime{ get; set; } // [string,   10] 시간                            StartPos 0, Length 10
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 11, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 20, Length 6
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 27, Length 8
        public decimal chdegree{ get; set; } // [float ,  8.2] 체결강도                        StartPos 36, Length 8
        public decimal offerho{ get; set; } // [float ,  6.2] 매도호가                        StartPos 45, Length 6
        public decimal bidho{ get; set; } // [float ,  6.2] 매수호가                        StartPos 52, Length 6
        public decimal volume{ get; set; } // [double,   12] 거래량                          StartPos 59, Length 12
        public long openyak{ get; set; } // [long  ,    8] 미결수량                        StartPos 72, Length 8
        public long jnilopenupdn{ get; set; } // [long  ,    8] 미결전일증감                    StartPos 81, Length 8
        public decimal ibasis{ get; set; } // [float ,  6.2] 이론BASIS                       StartPos 90, Length 6
        public decimal sbasis{ get; set; } // [float ,  6.2] 시장BASIS                       StartPos 97, Length 6
        public decimal kasis{ get; set; } // [float ,  6.2] 괴리율                          StartPos 104, Length 6
        public decimal value{ get; set; } // [double,   12] 거래대금                        StartPos 111, Length 12
        public long j_openupdn{ get; set; } // [long  ,    8] 미결직전증감                    StartPos 124, Length 8
        public decimal n_msvolume{ get; set; } // [double,   12] 누적매수체결량                  StartPos 133, Length 12
        public decimal n_mdvolume{ get; set; } // [double,   12] 누적매도체결량                  StartPos 146, Length 12
        public decimal s_msvolume{ get; set; } // [double,   12] 누적순매수체결량                StartPos 159, Length 12
        public long n_mschecnt{ get; set; } // [long  ,    8] 누적매수체결건수                StartPos 172, Length 8
        public long n_mdchecnt{ get; set; } // [long  ,    8] 누적매도체결건수                StartPos 181, Length 8
        public long s_mschecnt{ get; set; } // [long  ,    8] 누적순매수체결건수              StartPos 190, Length 8
    }
}