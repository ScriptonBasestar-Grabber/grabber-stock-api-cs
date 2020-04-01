namespace XingBot.res
{
    // 지수옵션예상체결 ( ATTR, KEY=8, GROUP=1 )
    struct _YOC_InBlock
    {
        public string optcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _YOC_OutBlock
    {
        public string ychetime; // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public float yeprice; // [float ,  6.2] 예상체결가격                    StartPos 7, Length 6
        public string jnilysign; // [string,    1] 예상체결가전일종가대비구분      StartPos 14, Length 1
        public float preychange; // [float ,  6.2] 예상체결가전일종가대비          StartPos 16, Length 6
        public float jnilydrate; // [float ,  6.2] 예상체결가전일종가등락율        StartPos 23, Length 6
    }
}