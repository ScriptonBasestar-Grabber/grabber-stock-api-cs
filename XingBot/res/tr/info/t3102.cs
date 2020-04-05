namespace XingBot.res
{
    // 뉴스본문 ( BLOCK,HEADTYPE=A )
    internal struct _t3102InBlock
    {
        public string sNewsno; // [string,   24] 뉴스번호                        StartPos 0, Length 24
    }

    internal struct _t3102OutBlock
    {
        public string sJongcode; // [string,    6] 뉴스종목                        StartPos 0, Length 6
    }

    internal struct _t3102OutBlock1
    {
        public string sBody; // [string,  100] 뉴스본문                        StartPos 0, Length 100
    }

    internal struct _t3102OutBlock2
    {
        public string sTitle; // [string,  300] 뉴스타이틀                      StartPos 0, Length 300
    }
}