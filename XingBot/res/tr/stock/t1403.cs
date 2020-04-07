namespace XingBot.res
{
    // 신규상장종목조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1403InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string styymm{ get; set; } // [string,    6] 시작상장월                      StartPos 2, Length 6
        public string enyymm{ get; set; } // [string,    6] 종료상장월                      StartPos 9, Length 6
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 16, Length 4
    }

    public struct _t1403OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public struct _t1403OutBlock1
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long kmprice{ get; set; } // [long  ,    8] 공모가                          StartPos 61, Length 8
        public string date{ get; set; } // [string,    8] 등록일                          StartPos 70, Length 8
        public long recprice{ get; set; } // [long  ,    8] 등록일기준가                    StartPos 79, Length 8
        public decimal kmdiff{ get; set; } // [float ,  6.2] 기준가등락율                    StartPos 88, Length 6
        public long close{ get; set; } // [long  ,    8] 등록일종가                      StartPos 95, Length 8
        public decimal recdiff{ get; set; } // [float ,  6.2] 등록일등락율                    StartPos 104, Length 6
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 111, Length 6
    }
}