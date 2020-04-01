namespace XingBot.res
{
    // KOSPI체결 ( ATTR, KEY=6, GROUP=1 )
    struct _S3__InBlock
    {
        public char shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    struct _S3__OutBlock
    {
        public string chetime; // [string,    6] 체결시간                        StartPos 0, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 9, Length 8
        public float drate; // [float ,  6.2] 등락율                          StartPos 18, Length 6
        public long price; // [long  ,    8] 현재가                          StartPos 25, Length 8
        public string opentime; // [string,    6] 시가시간                        StartPos 34, Length 6
        public long open; // [long  ,    8] 시가                            StartPos 41, Length 8
        public string hightime; // [string,    6] 고가시간                        StartPos 50, Length 6
        public long high; // [long  ,    8] 고가                            StartPos 57, Length 8
        public string lowtime; // [string,    6] 저가시간                        StartPos 66, Length 6
        public long low; // [long  ,    8] 저가                            StartPos 73, Length 8
        public string cgubun; // [string,    1] 체결구분                        StartPos 82, Length 1
        public long cvolume; // [long  ,    8] 체결량                          StartPos 84, Length 8
        public long volume; // [long  ,   12] 누적거래량                      StartPos 93, Length 12
        public long value; // [long  ,   12] 누적거래대금                    StartPos 106, Length 12
        public long mdvolume; // [long  ,   12] 매도누적체결량                  StartPos 119, Length 12
        public long mdchecnt; // [long  ,    8] 매도누적체결건수                StartPos 132, Length 8
        public long msvolume; // [long  ,   12] 매수누적체결량                  StartPos 141, Length 12
        public long mschecnt; // [long  ,    8] 매수누적체결건수                StartPos 154, Length 8
        public float cpower; // [float ,  9.2] 체결강도                        StartPos 163, Length 9
        public long w_avrg; // [long  ,    8] 가중평균가                      StartPos 173, Length 8
        public long offerho; // [long  ,    8] 매도호가                        StartPos 182, Length 8
        public long bidho; // [long  ,    8] 매수호가                        StartPos 191, Length 8
        public string status; // [string,    2] 장정보                          StartPos 200, Length 2
        public long jnilvolume; // [long  ,   12] 전일동시간대거래량              StartPos 203, Length 12
        public string shcode; // [string,    6] 단축코드                        StartPos 216, Length 6
    }
}