namespace XingBot.res
{
    // 주식멀티현재가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8407InBlock
    {
        public long nrec; // [long  ,    3] 건수                            StartPos 0, Length 3
        public string shcode; // [string,  300] 종목코드                        StartPos 4, Length 300
    }

    public struct _t8407OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   40] 종목명                          StartPos 7, Length 40
        public long price; // [long  ,    8] 현재가                          StartPos 48, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 57, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 59, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 68, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 75, Length 12
        public long offerho; // [long  ,    8] 매도호가                        StartPos 88, Length 8
        public long bidho; // [long  ,    8] 매수호가                        StartPos 97, Length 8
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 106, Length 8
        public decimal chdegree; // [float ,  9.2] 체결강도                        StartPos 115, Length 9
        public long open; // [long  ,    8] 시가                            StartPos 125, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 134, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 143, Length 8
        public long value; // [long  ,   12] 거래대금(백만)                  StartPos 152, Length 12
        public long offerrem; // [long  ,   12] 우선매도잔량                    StartPos 165, Length 12
        public long bidrem; // [long  ,   12] 우선매수잔량                    StartPos 178, Length 12
        public long totofferrem; // [long  ,   12] 총매도잔량                      StartPos 191, Length 12
        public long totbidrem; // [long  ,   12] 총매수잔량                      StartPos 204, Length 12
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 217, Length 8
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 226, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 235, Length 8
    }
}