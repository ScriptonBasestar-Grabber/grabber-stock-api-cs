namespace XingBot.res
{
    // 주식 현재가 시세메모 ( BLOCK,HEADTYPE=A )
    public struct _t1104InBlock
    {
        public string code; // [code,    6] 종목코드                        StartPos 0, Length 6
        public string nrec; // [nrec,    2] 건수                            StartPos 6, Length 2
    }

    public struct _t1104InBlock1
    {
        public string indx; // [indx,    1] 인덱스                          StartPos 0, Length 1
        public string gubn; // [gubn,    1] 조건구분                        StartPos 1, Length 1
        public string dat1; // [dat1,    1] 데이타1                         StartPos 2, Length 1
        public string dat2; // [dat2,    8] 데이타2                         StartPos 3, Length 8
    }

    public struct _t1104OutBlock
    {
        public string nrec; // [nrec,    2] 출력건수                        StartPos 0, Length 2
    }

    public struct _t1104OutBlock1
    {
        public string indx; // [indx,    1] 인덱스                          StartPos 0, Length 1
        public string gubn; // [gubn,    1] 조건구분                        StartPos 1, Length 1
        public string vals; // [vals,    8] 출력값                          StartPos 2, Length 8
    }
}