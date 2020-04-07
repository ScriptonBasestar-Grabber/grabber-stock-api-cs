namespace XingBot.res
{
    // EUREX 야간옵션 기간별 추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2833InBlock
    {
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public string futcheck{ get; set; } // [string,    1] 선물최근월물                    StartPos 9, Length 1
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 11, Length 8
        public string cts_code{ get; set; } // [string,    8] CTS종목코드                     StartPos 20, Length 8
        public string lastdate{ get; set; } // [string,    8] 전종목만기일                    StartPos 29, Length 8
        public string cnt{ get; set; } // [string,    3] 조회요청건수                    StartPos 38, Length 3
    }

    public struct _t2833OutBlock
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public string cts_code{ get; set; } // [string,    8] CTS종목코드                     StartPos 9, Length 8
        public string lastdate{ get; set; } // [string,    8] 전종목만기일                    StartPos 18, Length 8
        public string nowfutyn{ get; set; } // [string,    1] 최근월선물여부                  StartPos 27, Length 1
    }

    public struct _t2833OutBlock1
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 9, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 16, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 23, Length 6
        public decimal close{ get; set; } // [float ,  6.2] 종가                            StartPos 30, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 37, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 39, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 46, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 53, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 66, Length 10
    }
}