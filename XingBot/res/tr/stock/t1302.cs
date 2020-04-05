namespace XingBot.res.tr
{
    // 주식 분별 주가 조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1302InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public string gubun; // [string,    1] 작업구분                        StartPos 7, Length 1
        public string time; // [string,    6] 시간                            StartPos 9, Length 6
        public string cnt; // [string,    3] 건수                            StartPos 16, Length 3
    }

    internal struct _t1302OutBlock
    {
        public string cts_time; // [string,    6] 시간CTS                         StartPos 0, Length 6
    }

    internal struct _t1302OutBlock1
    {
        public string chetime; // [string,    6] 시간                            StartPos 0, Length 6
        public long close; // [long  ,    8] 종가                            StartPos 7, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 16, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 18, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 27, Length 6
        public float chdegree; // [float ,  8.2] 체결강도                        StartPos 34, Length 8
        public long mdvolume; // [long  ,   12] 매도체결수량                    StartPos 43, Length 12
        public long msvolume; // [long  ,   12] 매수체결수량                    StartPos 56, Length 12
        public long revolume; // [long  ,   12] 순매수체결량                    StartPos 69, Length 12
        public long mdchecnt; // [long  ,    8] 매도체결건수                    StartPos 82, Length 8
        public long mschecnt; // [long  ,    8] 매수체결건수                    StartPos 91, Length 8
        public long rechecnt; // [long  ,    8] 순체결건수                      StartPos 100, Length 8
        public long volume; // [long  ,   12] 거래량                          StartPos 109, Length 12
        public long open; // [long  ,    8] 시가                            StartPos 122, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 131, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 140, Length 8
        public long cvolume; // [long  ,   12] 체결량                          StartPos 149, Length 12
        public long mdchecnttm; // [long  ,    8] 매도체결건수(시간)              StartPos 162, Length 8
        public long mschecnttm; // [long  ,    8] 매수체결건수(시간)              StartPos 171, Length 8
        public long totofferrem; // [long  ,   12] 매도잔량                        StartPos 180, Length 12
        public long totbidrem; // [long  ,   12] 매수잔량                        StartPos 193, Length 12
        public long mdvolumetm; // [long  ,   12] 시간별매도체결량                StartPos 206, Length 12
        public long msvolumetm; // [long  ,   12] 시간별매수체결량                StartPos 219, Length 12
    }
}