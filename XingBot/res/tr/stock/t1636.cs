namespace XingBot.res.tr
{
    // 종목별프로그램매매동향 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1636InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string gubun1; // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun2; // [string,    1] 정렬기준                        StartPos 4, Length 1
        public string shcode; // [string,    6] 종목코드                        StartPos 6, Length 6
        public long cts_idx; // [long  ,    4] IDXCTS                          StartPos 13, Length 4
    }

    internal struct _t1636OutBlock
    {
        public long cts_idx; // [long  ,    4] IDXCTS                          StartPos 0, Length 4
    }

    internal struct _t1636OutBlock1
    {
        public long rank; // [long  ,    8] 순위                            StartPos 0, Length 8
        public string hname; // [string,   20] 종목명                          StartPos 9, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 30, Length 8
        public string sign; // [string,    1] 대비구분                        StartPos 39, Length 1
        public long change; // [long  ,    8] 대비                            StartPos 41, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 50, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 57, Length 12
        public long svalue; // [long  ,   12] 순매수금액                      StartPos 70, Length 12
        public long offervalue; // [long  ,   12] 매도금액                        StartPos 83, Length 12
        public long stksvalue; // [long  ,   12] 매수금액                        StartPos 96, Length 12
        public long svolume; // [long  ,   12] 순매수수량                      StartPos 109, Length 12
        public long offervolume; // [long  ,   12] 매도수량                        StartPos 122, Length 12
        public long stksvolume; // [long  ,   12] 매수수량                        StartPos 135, Length 12
        public long sgta; // [long  ,   15] 시가총액                        StartPos 148, Length 15
        public float rate; // [float ,  6.2] 비중                            StartPos 164, Length 6
        public string shcode; // [string,    6] 종목코드                        StartPos 171, Length 6
    }
}