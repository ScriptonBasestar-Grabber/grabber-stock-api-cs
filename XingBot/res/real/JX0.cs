namespace XingBot.res
{
    // 주식선물가격제한폭확대 ( ATTR, KEY=8, GROUP=1 )
    public class _JX0_InBlock
    {
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _JX0_OutBlock
    {
        public string upstep{ get; set; } // [string,    2] 적용 상한단계                   StartPos 0, Length 2
        public string dnstep{ get; set; } // [string,    2] 적용 하한단계                   StartPos 3, Length 2
        public long uplmtprice{ get; set; } // [long  ,   10] 적용 상한가                     StartPos 6, Length 10
        public long dnlmtprice{ get; set; } // [long  ,   10] 적용 하한가                     StartPos 17, Length 10
        public string futcode{ get; set; } // [string,    8] 단축코드                        StartPos 28, Length 8
    }
}