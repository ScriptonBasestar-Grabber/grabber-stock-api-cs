namespace XingBot.res
{
    // 선물/옵션 호가잔량 비율 차트 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2405InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public string bgubun{ get; set; } // [string,    1] 분구분                          StartPos 9, Length 1
        public string nmin{ get; set; } // [string,    2] N분                             StartPos 11, Length 2
        public string etime{ get; set; } // [string,    4] 종료시간                        StartPos 14, Length 4
        public string hgubun{ get; set; } // [string,    1] 호가구분                        StartPos 19, Length 1
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 21, Length 3
        public string cts_time{ get; set; } // [string,    6] 시간CTS                         StartPos 25, Length 6
    }

    public class _t2405OutBlock
    {
        public decimal mdvolume{ get; set; } // [double,   12] 매도체결수량                    StartPos 0, Length 12
        public long mdchecnt{ get; set; } // [long  ,    8] 매도체결건수                    StartPos 13, Length 8
        public decimal msvolume{ get; set; } // [double,   12] 매수체결수량                    StartPos 22, Length 12
        public long mschecnt{ get; set; } // [long  ,    8] 매수체결건수                    StartPos 35, Length 8
        public string cts_time{ get; set; } // [string,    6] 시간CTS                         StartPos 44, Length 6
    }

    public class _t2405OutBlock1
    {
        public string time{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 7, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 14, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 16, Length 6
        public decimal volume{ get; set; } // [double,   12] 누적거래량                      StartPos 23, Length 12
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 36, Length 8
        public decimal offerho1{ get; set; } // [float ,  6.2] 매도1호가                       StartPos 45, Length 6
        public decimal bidho1{ get; set; } // [float ,  6.2] 매수1호가                       StartPos 52, Length 6
        public long offerrem{ get; set; } // [long  ,    8] 매도수량                        StartPos 59, Length 8
        public long bidrem{ get; set; } // [long  ,    8] 매수수량                        StartPos 68, Length 8
        public long offercnt{ get; set; } // [long  ,    8] 매도건수                        StartPos 77, Length 8
        public long bidcnt{ get; set; } // [long  ,    8] 매수건수                        StartPos 86, Length 8
        public long c_offerrem{ get; set; } // [long  ,    8] 매도증감수량                    StartPos 95, Length 8
        public long c_bidrem{ get; set; } // [long  ,    8] 매수증감수량                    StartPos 104, Length 8
        public long c_offercnt{ get; set; } // [long  ,    8] 매도증감건수                    StartPos 113, Length 8
        public long c_bidcnt{ get; set; } // [long  ,    8] 매수증감건수                    StartPos 122, Length 8
        public decimal r_bidrem{ get; set; } // [float ,  6.2] 매수수량비율                    StartPos 131, Length 6
        public decimal r_bidcnt{ get; set; } // [float ,  6.2] 매수건수비율                    StartPos 138, Length 6
        public string r_sign{ get; set; } // [string,    1] 매수비율구분                    StartPos 145, Length 1
        public string date{ get; set; } // [string,    8] 일자                            StartPos 147, Length 8
    }
}