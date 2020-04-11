﻿namespace XingBot.res
{
    // EUREX연계KP200지수옵션선물체결 ( ATTR, KEY=8, GROUP=1 )
    public class _EC0_InBlock
    {
        public string optcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _EC0_OutBlock
    {
        public string chetime{ get; set; } // [string,    6] 체결시간(24시간)                StartPos 0, Length 6
        public string chetime1{ get; set; } // [string,    6] 체결시간(36시간)                StartPos 7, Length 6
        public string sign{ get; set; } // [string,    1] 정규장종가대비구분              StartPos 14, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 정규장종가대비                  StartPos 16, Length 6
        public decimal drate{ get; set; } // [float ,  6.2] 정규장종가기준등락율            StartPos 23, Length 6
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 30, Length 6
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 37, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 44, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 51, Length 6
        public string cgubun{ get; set; } // [string,    1] 체결구분                        StartPos 58, Length 1
        public long cvolume{ get; set; } // [long  ,    6] 체결량                          StartPos 60, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 67, Length 12
        public long value{ get; set; } // [long  ,   12] 누적거래대금(미제공)            StartPos 80, Length 12
        public long mdvolume{ get; set; } // [long  ,   12] 매도누적체결량                  StartPos 93, Length 12
        public long mdchecnt{ get; set; } // [long  ,    8] 매도누적체결건수(미제공)        StartPos 106, Length 8
        public long msvolume{ get; set; } // [long  ,   12] 매수누적체결량                  StartPos 115, Length 12
        public long mschecnt{ get; set; } // [long  ,    8] 매수누적체결건수(미제공)        StartPos 128, Length 8
        public decimal cpower{ get; set; } // [float ,  9.2] 체결강도                        StartPos 137, Length 9
        public decimal offerho1{ get; set; } // [float ,  6.2] 매도호가1                       StartPos 147, Length 6
        public decimal bidho1{ get; set; } // [float ,  6.2] 매수호가1                       StartPos 154, Length 6
        public long openyak{ get; set; } // [long  ,    8] 미결제약정수량                  StartPos 161, Length 8
        public decimal k200jisu{ get; set; } // [float ,  6.2] KOSPI200지수                    StartPos 170, Length 6
        public decimal eqva{ get; set; } // [float ,  7.2] KOSPI등가                       StartPos 177, Length 7
        public decimal theoryprice{ get; set; } // [float ,  6.2] 이론가                          StartPos 185, Length 6
        public decimal impv{ get; set; } // [float ,  6.2] 내재변동성                      StartPos 192, Length 6
        public long openyakcha{ get; set; } // [long  ,    8] 미결제약정증감                  StartPos 199, Length 8
        public decimal timevalue{ get; set; } // [float ,  6.2] 시간가치                        StartPos 208, Length 6
        public string jgubun{ get; set; } // [string,    2] 장운영정보                      StartPos 215, Length 2
        public long jnilvolume{ get; set; } // [long  ,   12] 전일동시간대거래량              StartPos 218, Length 12
        public string optcode{ get; set; } // [string,    8] 단축코드                        StartPos 231, Length 8
    }
}