namespace XingBot.res
{
    // 주식VI발동해제 ( ATTR, KEY=6, GROUP=1 )
    public class _VI__InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드(KEY)                   StartPos 0, Length 6
    }

    public class _VI__OutBlock
    {
        public string vi_gubun{ get; set; } // [string,    1] 구분(0:해제 1:정적발동 2:동적발 StartPos 0, Length 1
        public long svi_recprice{ get; set; } // [long  ,    8] 정적VI발동기준가격              StartPos 2, Length 8
        public long dvi_recprice{ get; set; } // [long  ,    8] 동적VI발동기준가격              StartPos 11, Length 8
        public long vi_trgprice{ get; set; } // [long  ,    8] VI발동가격                      StartPos 20, Length 8
        public string shcode{ get; set; } // [string,    6] 단축코드(KEY)                   StartPos 29, Length 6
        public string ref_shcode{ get; set; } // [string,    6] 참조코드                        StartPos 36, Length 6
        public string time{ get; set; } // [string,    6] 시간                            StartPos 43, Length 6
    }
}