namespace XingBot.res
{
    // KOSPI200선물체결 ( ATTR, KEY=8, GROUP=1 )
    struct _FC0_InBlock
    {
        public string futcode; ; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _FC0_OutBlock
    {
        public string chetime; // [string,    6] 체결시간                        StartPos 0, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 9, Length 6
        public float drate; // [float ,  6.2] 등락율                          StartPos 16, Length 6
        public float price; // [float ,  6.2] 현재가                          StartPos 23, Length 6
        public float open; // [float ,  6.2] 시가                            StartPos 30, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 37, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 44, Length 6
        public string cgubun; // [string,    1] 체결구분                        StartPos 51, Length 1
        public long cvolume; // [long  ,    6] 체결량                          StartPos 53, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 60, Length 12
        public long value; // [long  ,   12] 누적거래대금                    StartPos 73, Length 12
        public long mdvolume; // [long  ,   12] 매도누적체결량                  StartPos 86, Length 12
        public long mdchecnt; // [long  ,    8] 매도누적체결건수                StartPos 99, Length 8
        public long msvolume; // [long  ,   12] 매수누적체결량                  StartPos 108, Length 12
        public long mschecnt; // [long  ,    8] 매수누적체결건수                StartPos 121, Length 8
        public float cpower; // [float ,  9.2] 체결강도                        StartPos 130, Length 9
        public float offerho1; // [float ,  6.2] 매도호가1                       StartPos 140, Length 6
        public float bidho1; // [float ,  6.2] 매수호가1                       StartPos 147, Length 6
        public long openyak; // [long  ,    8] 미결제약정수량                  StartPos 154, Length 8
        public float k200jisu; // [float ,  6.2] KOSPI200지수                    StartPos 163, Length 6
        public float theoryprice; // [float ,  6.2] 이론가                          StartPos 170, Length 6
        public float kasis; // [float ,  6.2] 괴리율                          StartPos 177, Length 6
        public float sbasis; // [float ,  6.2] 시장BASIS                       StartPos 184, Length 6
        public float ibasis; // [float ,  6.2] 이론BASIS                       StartPos 191, Length 6
        public long openyakcha; // [long  ,    8] 미결제약정증감                  StartPos 198, Length 8
        public string jgubun; // [string,    2] 장운영정보                      StartPos 207, Length 2
        public long jnilvolume; // [long  ,   12] 전일동시간대거래량              StartPos 210, Length 12
        public string futcode; // [string,    8] 단축코드                        StartPos 223, Length 8
    }
}