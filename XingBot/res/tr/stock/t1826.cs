namespace XingBot.res
{
    // 종목Q클릭검색리스트 ( BLOCK,HEADTYPE=A )
    public struct _t1826InBlock
    {
        public string search_gb{ get; set; } // [search_gb,    1] 검색구분(0:핵심검색1:지표검색2: StartPos 0, Length 1
    }

    public struct _t1826OutBlock
    {
        public string search_cd{ get; set; } // [search_cd,    4] 검색코드                        StartPos 0, Length 4
        public string search_nm{ get; set; } // [search_nm,   40] 검색명                          StartPos 4, Length 40
    }
}