namespace XingBot.res
{
    // 주식 현재가 시세메모 ( BLOCK,HEADTYPE=A )
    public class _t1104InBlock
    {
        public string code{ get; set; } // [code,    6] 종목코드                        StartPos 0, Length 6
        public string nrec{ get; set; } // [nrec,    2] 건수                            StartPos 6, Length 2
    }

    public class _t1104InBlock1
    {
        public string indx{ get; set; } // [indx,    1] 인덱스                          StartPos 0, Length 1
        public string gubn{ get; set; } // [gubn,    1] 조건구분                        StartPos 1, Length 1
        public string dat1{ get; set; } // [dat1,    1] 데이타1                         StartPos 2, Length 1
        public string dat2{ get; set; } // [dat2,    8] 데이타2                         StartPos 3, Length 8
    }

    public class _t1104OutBlock
    {
        public string nrec{ get; set; } // [nrec,    2] 출력건수                        StartPos 0, Length 2
    }

    public class _t1104OutBlock1
    {
        public string indx{ get; set; } // [indx,    1] 인덱스                          StartPos 0, Length 1
        public string gubn{ get; set; } // [gubn,    1] 조건구분                        StartPos 1, Length 1
        public string vals{ get; set; } // [vals,    8] 출력값                          StartPos 2, Length 8
    }
}