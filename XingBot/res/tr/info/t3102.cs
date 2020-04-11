namespace XingBot.res
{
    // 뉴스본문 ( BLOCK,HEADTYPE=A )
    public class _t3102InBlock
    {
        public string sNewsno{ get; set; } // [string,   24] 뉴스번호                        StartPos 0, Length 24
    }

    public class _t3102OutBlock
    {
        public string sJongcode{ get; set; } // [string,    6] 뉴스종목                        StartPos 0, Length 6
    }

    public class _t3102OutBlock1
    {
        public string sBody{ get; set; } // [string,  100] 뉴스본문                        StartPos 0, Length 100
    }

    public class _t3102OutBlock2
    {
        public string sTitle{ get; set; } // [string,  300] 뉴스타이틀                      StartPos 0, Length 300
    }
}