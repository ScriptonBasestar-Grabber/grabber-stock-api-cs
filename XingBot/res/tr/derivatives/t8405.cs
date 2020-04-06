namespace XingBot.real.res
{
    // 주식선물 기간별주가 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8405InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string futcheck; // [string,    1] 선물최근월물                    StartPos 9, Length 1
        public string date; // [string,    8] 날짜                            StartPos 11, Length 8
        public string cts_code; // [string,    8] CTS종목코드                     StartPos 20, Length 8
        public string lastdate; // [string,    8] 전종목만기일                    StartPos 29, Length 8
        public string cnt; // [string,    3] 조회요청건수                    StartPos 38, Length 3
    }

    public struct _t8405OutBlock
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public string cts_code; // [string,    8] CTS종목코드                     StartPos 9, Length 8
        public string lastdate; // [string,    8] 전종목만기일                    StartPos 18, Length 8
        public string nowfutyn; // [string,    1] 최근월선물여부                  StartPos 27, Length 1
    }

    public struct _t8405OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 9, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 18, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 27, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 36, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 45, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 47, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 56, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 63, Length 12
        public decimal diff_vol; // [float , 10.2] 거래증가율                      StartPos 76, Length 10
        public long openyak; // [long  ,    8] 미결수량                        StartPos 87, Length 8
        public long openyakupdn; // [long  ,    8] 미결증감                        StartPos 96, Length 8
        public decimal value; // [float ,   12] 거래대금                        StartPos 105, Length 12
    }
}