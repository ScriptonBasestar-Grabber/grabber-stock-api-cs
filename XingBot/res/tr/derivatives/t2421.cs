namespace XingBot.res
{
    // 선물/옵션 미결제약정 추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2421InBlock
    {
        public string focode{ get; set; } // [string,    8] 종목코드                        StartPos 0, Length 8
        public string bdgubun{ get; set; } // [string,    1] 분일구분                        StartPos 9, Length 1
        public string nmin{ get; set; } // [string,    3] N분                             StartPos 11, Length 3
        public string tcgubun{ get; set; } // [string,    1] 당일연결구분                    StartPos 15, Length 1
        public string cnt{ get; set; } // [string,    4] 조회건수                        StartPos 17, Length 4
    }

    public struct _t2421OutBlock
    {
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 0, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 9, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 16, Length 6
        public long cvolume{ get; set; } // [long  ,    8] 체결수량                        StartPos 23, Length 8
        public decimal volume{ get; set; } // [double,   15] 누적거래량                      StartPos 32, Length 15
        public long openyak{ get; set; } // [long  ,    8] 미결제수량                      StartPos 48, Length 8
    }

    public struct _t2421OutBlock1
    {
        public string dt{ get; set; } // [string,   14] 일자시간                        StartPos 0, Length 14
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 15, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 22, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 29, Length 6
        public decimal close{ get; set; } // [float ,  6.2] 종가                            StartPos 36, Length 6
        public long openopenyak{ get; set; } // [long  ,    8] 미결제시량                      StartPos 43, Length 8
        public long highopenyak{ get; set; } // [long  ,    8] 미결제고량                      StartPos 52, Length 8
        public long lowopenyak{ get; set; } // [long  ,    8] 미결제저량                      StartPos 61, Length 8
        public long closeopenyak{ get; set; } // [long  ,    8] 미결제종량                      StartPos 70, Length 8
        public long openupdn{ get; set; } // [long  ,    8] 미결증감                        StartPos 79, Length 8
    }
}