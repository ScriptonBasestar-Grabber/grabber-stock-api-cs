namespace XingBot.res
{
    // 종목별테마 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1532InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    public class _t1532OutBlock
    {
        public string tmname{ get; set; } // [string,   36] 테마명                          StartPos 0, Length 36
        public decimal avgdiff{ get; set; } // [float ,  6.2] 평균등락율                      StartPos 37, Length 6
        public string tmcode{ get; set; } // [string,    4] 테마코드                        StartPos 44, Length 4
    }
}