namespace XingBot.res
{
    // ELW우선호가 ( ATTR, KEY=6, GROUP=1 )
    public class _s2_4ELW_InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _s2_4ELW_OutBlock
    {
        public long offerho{ get; set; } // [long  ,    8] 매도호가                        StartPos 0, Length 8
        public long bidho{ get; set; } // [long  ,    8] 매수호가                        StartPos 9, Length 8
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 18, Length 6
    }
}