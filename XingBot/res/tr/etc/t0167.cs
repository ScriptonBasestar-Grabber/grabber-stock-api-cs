namespace XingBot.res
{
    // 시간조회 ( BLOCK,HEADTYPE=A )
    public struct _t0167InBlock
    {
        public string id{ get; set; } // [string,    8] id                              StartPos 0, Length 8
    }

    public struct _t0167OutBlock
    {
        public string dt{ get; set; } // [string,    8] 일자(YYYYMMDD)                  StartPos 0, Length 8
        public string time{ get; set; } // [string,   12] 시간(HHMMSSssssss)              StartPos 8, Length 12
    }
}