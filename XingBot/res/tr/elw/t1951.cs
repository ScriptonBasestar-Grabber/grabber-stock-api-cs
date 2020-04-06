namespace XingBot.res
{
    // ELW 시간대별 체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1951InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public long cvolume; // [long  ,   12] 특이거래량                      StartPos 7, Length 12
        public string starttime; // [string,    4] 시작시간                        StartPos 20, Length 4
        public string endtime; // [string,    4] 종료시간                        StartPos 25, Length 4
        public string cts_time; // [string,    8] 시간CTS                         StartPos 30, Length 8
    }

    public struct _t1951OutBlock
    {
        public string cts_time; // [string,    8] 시간CTS                         StartPos 0, Length 8
    }

    public struct _t1951OutBlock1
    {
        public string chetime; // [string,    8] 시간                            StartPos 0, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long cvolume; // [long  ,   12] 체결수량                        StartPos 36, Length 12
        public decimal chdegree; // [float ,  8.2] 체결강도                        StartPos 49, Length 8
        public long volume; // [long  ,   12] 거래량                          StartPos 58, Length 12
        public long mdvolume; // [long  ,   12] 매도체결수량                    StartPos 71, Length 12
        public long mdchecnt; // [long  ,    8] 매도체결건수                    StartPos 84, Length 8
        public long msvolume; // [long  ,   12] 매수체결수량                    StartPos 93, Length 12
        public long mschecnt; // [long  ,    8] 매수체결건수                    StartPos 106, Length 8
        public long revolume; // [long  ,   12] 순체결량                        StartPos 115, Length 12
        public long rechecnt; // [long  ,    8] 순체결건수                      StartPos 128, Length 8
    }
}