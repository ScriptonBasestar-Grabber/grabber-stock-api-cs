namespace XingBot.res
{
    // ELW 기초자산 동일종목 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1974InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    internal struct _t1974OutBlock
    {
        public long cnt; // [long  ,    4] 종목갯수                        StartPos 0, Length 4

        private struct _t1974OutBlock1
        {
            public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
            public string hname; // [string,   40] 종목명                          StartPos 7, Length 40
            public string cpgubun; // [string,    2] 콜/풋구분                       StartPos 48, Length 2
            public long price; // [long  ,    8] 현재가                          StartPos 51, Length 8
            public string sign; // [string,    1] 전일대비구분                    StartPos 60, Length 1
            public long change; // [long  ,    8] 전일대비                        StartPos 62, Length 8
            public float diff; // [float ,  6.2] 등락율                          StartPos 71, Length 6
            public float volume; // [float ,   12] 거래량                          StartPos 78, Length 12
        }
    }

    internal struct _t1974OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   40] 종목명                          StartPos 7, Length 40
        public string cpgubun; // [string,    2] 콜/풋구분                       StartPos 48, Length 2
        public long price; // [long  ,    8] 현재가                          StartPos 51, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 60, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 62, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 71, Length 6
        public float volume; // [float ,   12] 거래량                          StartPos 78, Length 12
    }
}