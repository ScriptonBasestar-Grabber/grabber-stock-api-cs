namespace XingBot.real.res
{
    // 투자의견 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t3401InBlock
    {
        public string shcode; // [string,    9] 종목코드                        StartPos 0, Length 9
        public string gubun1; // [string,    1] 구분                            StartPos 10, Length 1
        public string tradno; // [string,    3] 회원사코드                      StartPos 12, Length 3
        public string cts_date; // [string,    8] IDXDATE                         StartPos 16, Length 8
    }

    public struct _t3401OutBlock
    {
        public string cts_date; // [string,    8] IDXDATE                         StartPos 0, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign; // [string,    1] 대비속성                        StartPos 18, Length 1
        public long change; // [long  ,    8] 대비                            StartPos 20, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 36, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 49, Length 12
    }

    public struct _t3401OutBlock1
    {
        public string shcode; // [string,    9] 종목코드                        StartPos 0, Length 9
        public string tradno; // [string,    3] 회원사코드                      StartPos 10, Length 3
        public string date; // [string,    8] 의견일자                        StartPos 14, Length 8
        public string tradname; // [string,   30] 회원사명                        StartPos 23, Length 30
        public string bopn; // [string,   30] 투자의견변경후                  StartPos 54, Length 30
        public string nopn; // [string,   30] 투자의견변경전                  StartPos 85, Length 30
        public long boga; // [long  ,   12] 목표가변경전                    StartPos 116, Length 12
        public long noga; // [long  ,   12] 목표가변경후                    StartPos 129, Length 12
        public long close; // [long  ,    8] 의견일종가                      StartPos 142, Length 8
    }
}