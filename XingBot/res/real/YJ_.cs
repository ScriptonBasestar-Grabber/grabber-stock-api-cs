﻿namespace XingBot.res
{
    // 예상지수 ( ATTR, KEY=3, GROUP=1 )
    struct _YJ__InBlock
    {
        public string upcode; // [string,    3] 업종코드                        StartPos 0, Length 3
    }

    struct _YJ__OutBlock
    {
        public string time; // [string,    6] 시간                            StartPos 0, Length 6
        public float jisu; // [float ,  8.2] 예상지수                        StartPos 7, Length 8
        public string sign; // [string,    1] 예상전일대비구분                StartPos 16, Length 1
        public float change; // [float ,  8.2] 예상전일비                      StartPos 18, Length 8
        public float drate; // [float ,  6.2] 예상등락율                      StartPos 27, Length 6
        public long cvolume; // [long  ,    8] 예상체결량                      StartPos 34, Length 8
        public long volume; // [long  ,    8] 누적거래량                      StartPos 43, Length 8
        public long value; // [long  ,    8] 예상거래대금                    StartPos 52, Length 8
        public string upcode; // [string,    3] 업종코드                        StartPos 61, Length 3
    }
}