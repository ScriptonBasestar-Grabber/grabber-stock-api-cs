namespace XingBot.res
{
    // 선물옵션멀티현재가 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8434InBlock
    {
        public long qrycnt{ get; set; } // [long  ,    3] 건수                            StartPos 0, Length 3
        public string focode{ get; set; } // [string,  400] 단축코드                        StartPos 4, Length 400
    }

    public class _t8434OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 37, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 44, Length 12
        public long checnt{ get; set; } // [long  ,    8] 체결건수                        StartPos 57, Length 8
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 66, Length 8
    }
}