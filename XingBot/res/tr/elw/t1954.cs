namespace XingBot.res
{
    // ELW 일별주가 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1954InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public string date; // [string,    8] 날짜                            StartPos 7, Length 8
        public long cnt; // [long  ,    3] 건수                            StartPos 16, Length 3
    }

    public struct _t1954OutBlock
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public string bsjgubun; // [string,    1] 기초자산구분                    StartPos 9, Length 1
        public string bscode; // [string,    6] 기초자산코드(현물)              StartPos 11, Length 6
        public string bjcode; // [string,    3] 기초자산코드(지수)              StartPos 18, Length 3
    }

    public struct _t1954OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 9, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 18, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 27, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 36, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 45, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 47, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 56, Length 6
        public decimal volume; // [float ,   12] 거래량                          StartPos 63, Length 12
        public long bsprice; // [long  ,    8] 기초자산(현물)                  StartPos 76, Length 8
        public decimal bjprice; // [float ,  8.2] 기초자산(지수)                  StartPos 85, Length 8
        public string bsign; // [string,    1] 전일대비구분                    StartPos 94, Length 1
        public long bschange; // [long  ,    8] 전일대비(현물)                  StartPos 96, Length 8
        public decimal bjchange; // [float ,  8.2] 전일대비(지수)                  StartPos 105, Length 8
        public decimal bdiff; // [float ,  6.2] 등락율                          StartPos 114, Length 6
        public decimal bvolume; // [float ,   12] 기초자산거래량                  StartPos 121, Length 12
        public decimal parity; // [float ,  6.2] 패리티                          StartPos 134, Length 6
        public decimal egearing; // [float ,  6.2] e.기어링                        StartPos 141, Length 6
        public decimal premium; // [float ,  6.2] 프리미엄                        StartPos 148, Length 6
        public decimal berate; // [float ,  6.2] 손익분기                        StartPos 155, Length 6
        public decimal capt; // [float ,  6.2] 자본지지                        StartPos 162, Length 6
        public decimal gearing; // [float ,  6.2] 기어링                          StartPos 169, Length 6
        public string mness; // [string,    1] Moneyness                       StartPos 176, Length 1
    }
}