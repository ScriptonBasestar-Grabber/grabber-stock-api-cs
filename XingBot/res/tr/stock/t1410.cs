namespace XingBot.res.tr
{
    // 초저유동성조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1410InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string cts_shcode; // [string,    6] 종목코드_CTS                    StartPos 2, Length 6
    }

    internal struct _t1410OutBlock
    {
        public string cts_shcode; // [string,    6] 종목코드_CTS                    StartPos 0, Length 6
    }

    internal struct _t1410OutBlock1
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public string shcode; // [string,    6] 종목코드                        StartPos 61, Length 6
    }
}