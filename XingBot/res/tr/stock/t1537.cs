namespace XingBot.res
{
    // 테마종목별 시세조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1537InBlock
    {
        public string tmcode; // [string,    4] 테마코드                        StartPos 0, Length 4
    }

    public struct _t1537OutBlock
    {
        public long upcnt; // [long  ,    4] 상승종목수                      StartPos 0, Length 4
        public long tmcnt; // [long  ,    4] 테마종목수                      StartPos 5, Length 4
        public long uprate; // [long  ,    4] 상승종목비율                    StartPos 10, Length 4
        public string tmname; // [string,   36] 테마명                          StartPos 15, Length 36
    }

    public struct _t1537OutBlock1
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public decimal jniltime; // [float ,  9.2] 전일동시간                      StartPos 61, Length 9
        public string shcode; // [string,    6] 종목코드                        StartPos 71, Length 6
        public long yeprice; // [long  ,    8] 예상체결가                      StartPos 78, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 87, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 96, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 105, Length 8
        public long value; // [long  ,   12] 누적거래대금(단위:백만)         StartPos 114, Length 12
        public long marketcap; // [long  ,   12] 시가총액(단위:백만)             StartPos 127, Length 12
    }
}