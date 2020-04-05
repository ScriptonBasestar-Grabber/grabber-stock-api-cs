namespace XingBot.res.tr
{
    // 체결강도추이 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1475InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string vptype; // [string,    1] 상승하락                        StartPos 7, Length 1
        public long datacnt; // [long  ,    4] 데이터개수                      StartPos 9, Length 4
        public long date; // [long  ,    8] 기준일자                        StartPos 14, Length 8
        public long time; // [long  ,    6] 기준시간                        StartPos 23, Length 6
        public long rankcnt; // [long  ,    3] 랭크카운터                      StartPos 30, Length 3
        public string gubun; // [string,    1] 조회구분                        StartPos 34, Length 1
    }

    internal struct _t1475OutBlock
    {
        public long date; // [long  ,    8] 기준일자                        StartPos 0, Length 8
        public long time; // [long  ,    6] 기준시간                        StartPos 9, Length 6
        public long rankcnt; // [long  ,    3] 랭크카운터                      StartPos 16, Length 3
    }

    internal struct _t1475OutBlock1
    {
        public string datetime; // [string,   10] 일자                            StartPos 0, Length 10
        public long price; // [long  ,    8] 현재가                          StartPos 11, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 22, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 31, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 38, Length 12
        public float todayvp; // [float ,  8.2] 당일VP                          StartPos 51, Length 8
        public float ma5vp; // [float ,  8.2] 5일MAVP                         StartPos 60, Length 8
        public float ma20vp; // [float ,  8.2] 20일MAVP                        StartPos 69, Length 8
        public float ma60vp; // [float ,  8.2] 60일MAVP                        StartPos 78, Length 8
    }
}