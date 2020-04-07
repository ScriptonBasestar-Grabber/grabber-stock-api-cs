namespace XingBot.res
{
    // 종목별상위회원사 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1752InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string traddate1{ get; set; } // [string,    8] 조회날짜1                       StartPos 7, Length 8
        public string traddate2{ get; set; } // [string,    8] 조회날짜2                       StartPos 16, Length 8
        public string fwgubun1{ get; set; } // [string,    1] 외국계구분                      StartPos 25, Length 1
        public long cts_idx{ get; set; } // [long  ,    4] CTSIDX                          StartPos 27, Length 4
    }

    public struct _t1752OutBlock
    {
        public long fwdvl{ get; set; } // [long  ,   12] 외국계매도                      StartPos 0, Length 12
        public long fwsvl{ get; set; } // [long  ,   12] 외국계매수                      StartPos 13, Length 12
        public long cts_idx{ get; set; } // [long  ,    4] CTSIDX                          StartPos 26, Length 4
    }

    public struct _t1752OutBlock1
    {
        public string tradname{ get; set; } // [string,   20] 회원사                          StartPos 0, Length 20
        public long tradmdvol{ get; set; } // [long  ,   12] 매도수량                        StartPos 21, Length 12
        public long tradmsvol{ get; set; } // [long  ,   12] 매수수량                        StartPos 34, Length 12
        public long tradmssvol{ get; set; } // [long  ,   12] 순매수                          StartPos 47, Length 12
        public long wintrd{ get; set; } // [long  ,   12] 창구거래                        StartPos 60, Length 12
        public decimal winrat{ get; set; } // [float ,  6.1] 비중                            StartPos 73, Length 6
        public string tradno{ get; set; } // [string,    3] 회원사코드                      StartPos 80, Length 3
        public string wgubun{ get; set; } // [string,    1] 외국계여부                      StartPos 84, Length 1
        public decimal swinrat{ get; set; } // [float ,  6.1] 순비중                          StartPos 86, Length 6
    }
}