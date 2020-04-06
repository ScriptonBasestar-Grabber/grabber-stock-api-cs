namespace XingBot.res
{
    // 선물/옵션 현재가 시세메모 ( BLOCK,HEADTYPE=A )

    public struct _t2106InBlock
    {
        public string code; // [string,    8] 종목코드                        StartPos 0, Length 8
        public string nrec; // [string,    2] 건수                            StartPos 8, Length 2
    }

    public struct _t2106InBlock1
    {
        public string indx; // [string,    1] 인덱스                          StartPos 0, Length 1
        public string gubn; // [string,    1] 조건구분                        StartPos 1, Length 1
        public string dat1; // [string,    1] 데이타1                         StartPos 2, Length 1
        public string dat2; // [string,    8] 데이타2                         StartPos 3, Length 8
    }

    public struct _t2106OutBlock
    {
        public string nrec; // [string,    2] 출력건수                        StartPos 0, Length 2
    }

    public struct _t2106OutBlock1
    {
        public string indx; // [string,    1] 인덱스                          StartPos 0, Length 1
        public string gubn; // [string,    1] 조건구분                        StartPos 1, Length 1
        public string vals; // [string,    8] 출력값                          StartPos 2, Length 8
    }
}