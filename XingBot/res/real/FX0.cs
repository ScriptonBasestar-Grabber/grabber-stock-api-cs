namespace XingBot.res
{
    // KOSPI200선물가격제한폭확대 ( ATTR, KEY=8, GROUP=1 )
    struct _FX0_InBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _FX0_OutBlock
    {
        public string upstep; // [string,    2] 적용 상한단계                   StartPos 0, Length 2
        public string dnstep; // [string,    2] 적용 하한단계                   StartPos 3, Length 2
        public float uplmtprice; // [float ,  6.2] 적용 상한가                     StartPos 6, Length 6
        public float dnlmtprice; // [float ,  6.2] 적용 하한가                     StartPos 13, Length 6
        public string futcode; // [string,    8] 단축코드                        StartPos 20, Length 8
    }
}