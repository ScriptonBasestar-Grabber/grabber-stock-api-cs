namespace XingBot.res
{
    // 만기월조회 ( BLOCK,HEADTYPE=A )
    public class _t9905InBlock
    {
        public string dummy { get; set; } // [string,    1] DUMMY                           StartPos 0, Length 1
    }

    public class _t9905OutBlock1
    {
        public string shcode { get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
        public string expcode { get; set; } // [string,   12] 표준코드                        StartPos 6, Length 12
        public string hname { get; set; } // [string,   20] 종목명                          StartPos 18, Length 20
    }
}