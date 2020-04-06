namespace XingBot.real.res
{
    // 주식선물체결 ( ATTR, KEY=8, GROUP=1 )
    public struct _JC0_InBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _JC0_OutBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string chetime; // [string,    6] 체결시간                        StartPos 9, Length 6
        public string sign; // [string,    1] 대비기호                        StartPos 16, Length 1
        public long change; // [long  ,   10] 전일대비                        StartPos 18, Length 10
        public decimal drate; // [double,  6.2] 등락율                          StartPos 29, Length 6
        public long price; // [long  ,   10] 현재가                          StartPos 36, Length 10
        public long open; // [long  ,   10] 시가                            StartPos 47, Length 10
        public long high; // [long  ,   10] 고가                            StartPos 58, Length 10
        public long low; // [long  ,   10] 저가                            StartPos 69, Length 10
        public string cgubun; // [string,    1] 체결구분                        StartPos 80, Length 1
        public long cvolume; // [long  ,    6] 체결량                          StartPos 82, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 89, Length 12
        public long value; // [long  ,   15] 누적거래대금                    StartPos 102, Length 15
        public long mdvolume; // [long  ,   12] 매도누적체결량                  StartPos 118, Length 12
        public long mdchecnt; // [long  ,    8] 매도누적체결건수                StartPos 131, Length 8
        public long msvolume; // [long  ,   12] 매수누적체결량                  StartPos 140, Length 12
        public long mschecnt; // [long  ,    8] 매수누적체결건수                StartPos 153, Length 8
        public decimal cpower; // [double,  9.2] 체결강도                        StartPos 162, Length 9
        public long offerho1; // [long  ,   10] 매도호가1                       StartPos 172, Length 10
        public long bidho1; // [long  ,   10] 매수호가1                       StartPos 183, Length 10
        public long openyak; // [long  ,    8] 미결제약정수량                  StartPos 194, Length 8
        public decimal k200jisu; // [double,  6.2] KOSPI200지수                    StartPos 203, Length 6
        public long theoryprice; // [long  ,    8] 이론가                          StartPos 210, Length 8
        public decimal kasis; // [double,  6.3] 괴리율                          StartPos 219, Length 6
        public long sbasis; // [long  ,    6] 시장BASIS                       StartPos 226, Length 6
        public long ibasis; // [long  ,    6] 이론BASIS                       StartPos 233, Length 6
        public long openyakcha; // [long  ,    8] 미결제약정증감                  StartPos 240, Length 8
        public string jgubun; // [string,    2] 장운영정보                      StartPos 249, Length 2
        public long jnilvolume; // [long  ,   12] 전일동시간대거래량              StartPos 252, Length 12
        public long basprice; // [long  ,    8] 기초자산현재가                  StartPos 265, Length 8
    }
}