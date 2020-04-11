namespace XingBot.res
{
    // 상품선물 마스터 조회 ( BLOCK,HEADTYPE=A )
    public class _t8426InBlock
    {
        public string dummy{ get; set; } // [string,    1] Dummy                           StartPos 0, Length 1
    }

    public class _t8426OutBlock
    {
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode{ get; set; } // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode{ get; set; } // [string,   12] 확장코드                        StartPos 28, Length 12
    }
}