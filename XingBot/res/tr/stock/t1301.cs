namespace XingBot.res.tr
{
    // 주식 시간대별 체결 조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1301InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public long cvolume; // [long  ,   12] 특이거래량                      StartPos 7, Length 12
        public string starttime; // [string,    4] 시작시간                        StartPos 20, Length 4
        public string endtime; // [string,    4] 종료시간                        StartPos 25, Length 4
        public string cts_time; // [string,   10] 시간CTS                         StartPos 30, Length 10
    }

    internal struct _t1301OutBlock
    {
        public string cts_time; // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    internal struct _t1301OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public long price; // [long  ,    8] 현재가                          StartPos 11, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 22, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 31, Length 6
        public long cvolume; // [long  ,   12] 체결수량                        StartPos 38, Length 12
        public float chdegree; // [float ,  8.2] 체결강도                        StartPos 51, Length 8
        public long volume; // [long  ,   12] 거래량                          StartPos 60, Length 12
        public long mdvolume; // [long  ,   12] 매도체결수량                    StartPos 73, Length 12
        public long mdchecnt; // [long  ,    8] 매도체결건수                    StartPos 86, Length 8
        public long msvolume; // [long  ,   12] 매수체결수량                    StartPos 95, Length 12
        public long mschecnt; // [long  ,    8] 매수체결건수                    StartPos 108, Length 8
        public long revolume; // [long  ,   12] 순체결량                        StartPos 117, Length 12
        public long rechecnt; // [long  ,    8] 순체결건수                      StartPos 130, Length 8
    }
}