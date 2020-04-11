namespace XingBot.res
{
    // 종목별프로그램매매추이 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1637InBlock
    {
        public string gubun1{ get; set; } // [string,    1] 수량금액구분(0:수량1:금액)      StartPos 0, Length 1
        public string gubun2{ get; set; } // [string,    1] 시간일별구분(0:시간1:일자)      StartPos 2, Length 1
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 4, Length 6
        public string date{ get; set; } // [string,    8] 일자                            StartPos 11, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 20, Length 6
        public long cts_idx{ get; set; } // [long  ,    4] IDXCTS(9999:차트)               StartPos 27, Length 4
    }

    public class _t1637OutBlock
    {
        public long cts_idx{ get; set; } // [long  ,    4] IDXCTS                          StartPos 0, Length 4
    }

    public class _t1637OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 16, Length 8
        public string sign{ get; set; } // [string,    1] 대비구분                        StartPos 25, Length 1
        public long change{ get; set; } // [long  ,    8] 대비                            StartPos 27, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 36, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 43, Length 12
        public long svalue{ get; set; } // [long  ,   15] 순매수금액                      StartPos 56, Length 15
        public long offervalue{ get; set; } // [long  ,   15] 매도금액                        StartPos 72, Length 15
        public long stksvalue{ get; set; } // [long  ,   15] 매수금액                        StartPos 88, Length 15
        public long svolume{ get; set; } // [long  ,   12] 순매수수량                      StartPos 104, Length 12
        public long offervolume{ get; set; } // [long  ,   12] 매도수량                        StartPos 117, Length 12
        public long stksvolume{ get; set; } // [long  ,   12] 매수수량                        StartPos 130, Length 12
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 143, Length 6
    }
}