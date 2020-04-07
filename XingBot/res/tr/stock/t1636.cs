namespace XingBot.res
{
    // 종목별프로그램매매동향 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1636InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string gubun1{ get; set; } // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun2{ get; set; } // [string,    1] 정렬기준                        StartPos 4, Length 1
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 6, Length 6
        public long cts_idx{ get; set; } // [long  ,    4] IDXCTS                          StartPos 13, Length 4
    }

    public struct _t1636OutBlock
    {
        public long cts_idx{ get; set; } // [long  ,    4] IDXCTS                          StartPos 0, Length 4
    }

    public struct _t1636OutBlock1
    {
        public long rank{ get; set; } // [long  ,    8] 순위                            StartPos 0, Length 8
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 9, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 30, Length 8
        public string sign{ get; set; } // [string,    1] 대비구분                        StartPos 39, Length 1
        public long change{ get; set; } // [long  ,    8] 대비                            StartPos 41, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 50, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 57, Length 12
        public long svalue{ get; set; } // [long  ,   12] 순매수금액                      StartPos 70, Length 12
        public long offervalue{ get; set; } // [long  ,   12] 매도금액                        StartPos 83, Length 12
        public long stksvalue{ get; set; } // [long  ,   12] 매수금액                        StartPos 96, Length 12
        public long svolume{ get; set; } // [long  ,   12] 순매수수량                      StartPos 109, Length 12
        public long offervolume{ get; set; } // [long  ,   12] 매도수량                        StartPos 122, Length 12
        public long stksvolume{ get; set; } // [long  ,   12] 매수수량                        StartPos 135, Length 12
        public long sgta{ get; set; } // [long  ,   15] 시가총액                        StartPos 148, Length 15
        public decimal rate{ get; set; } // [float ,  6.2] 비중                            StartPos 164, Length 6
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 171, Length 6
    }
}