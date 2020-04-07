namespace XingBot.res
{
    // KOSPI200선물가격제한폭확대 ( ATTR, KEY=8, GROUP=1 )
    public struct _FX0_InBlock
    {
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _FX0_OutBlock
    {
        public string upstep{ get; set; } // [string,    2] 적용 상한단계                   StartPos 0, Length 2
        public string dnstep{ get; set; } // [string,    2] 적용 하한단계                   StartPos 3, Length 2
        public decimal uplmtprice{ get; set; } // [float ,  6.2] 적용 상한가                     StartPos 6, Length 6
        public decimal dnlmtprice{ get; set; } // [float ,  6.2] 적용 하한가                     StartPos 13, Length 6
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 20, Length 8
    }
}