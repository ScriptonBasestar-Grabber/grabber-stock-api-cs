namespace XingBot.res
{
    // CME 시간대별 체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2804InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public long cvolume; // [long  ,   12] 특이거래량                      StartPos 9, Length 12
        public string stime; // [string,    4] 시작시간                        StartPos 22, Length 4
        public string etime; // [string,    4] 종료시간                        StartPos 27, Length 4
        public string cts_time; // [string,   10] 시간CTS                         StartPos 32, Length 10
    }

    public struct _t2804OutBlock
    {
        public string cts_time; // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    public struct _t2804OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public string chetime24; // [string,   10] 시간24                          StartPos 11, Length 10
        public decimal price; // [float ,  6.2] 현재가                          StartPos 22, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 29, Length 1
        public decimal change; // [float ,  6.2] 전일대비                        StartPos 31, Length 6
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 38, Length 8
        public decimal chdegree; // [float ,  8.2] 체결강도                        StartPos 47, Length 8
        public decimal offerho; // [float ,  6.2] 매도호가                        StartPos 56, Length 6
        public decimal bidho; // [float ,  6.2] 매수호가                        StartPos 63, Length 6
        public decimal volume; // [double,   12] 거래량                          StartPos 70, Length 12
        public long openyak; // [long  ,    8] 미결수량                        StartPos 83, Length 8
        public long jnilopenupdn; // [long  ,    8] 미결전일증감                    StartPos 92, Length 8
        public decimal ibasis; // [float ,  6.2] 이론BASIS                       StartPos 101, Length 6
        public decimal sbasis; // [float ,  6.2] 시장BASIS                       StartPos 108, Length 6
        public decimal kasis; // [float ,  6.2] 괴리율                          StartPos 115, Length 6
        public decimal value; // [double,   12] 거래대금                        StartPos 122, Length 12
        public long j_openupdn; // [long  ,    8] 미결직전증감                    StartPos 135, Length 8
        public decimal n_msvolume; // [double,   12] 누적매수체결량                  StartPos 144, Length 12
        public decimal n_mdvolume; // [double,   12] 누적매도체결량                  StartPos 157, Length 12
        public decimal s_msvolume; // [double,   12] 누적순매수체결량                StartPos 170, Length 12
        public long n_mschecnt; // [long  ,    8] 누적매수체결건수                StartPos 183, Length 8
        public long n_mdchecnt; // [long  ,    8] 누적매도체결건수                StartPos 192, Length 8
        public long s_mschecnt; // [long  ,    8] 누적순매수체결건수              StartPos 201, Length 8
    }
}