namespace XingBot.res
{
    // 상품선물예상체결 ( ATTR, KEY=8, GROUP=1 )
    public struct _YC3_InBlock
    {
        public string shcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _YC3_OutBlock
    {
        public string ychetime; // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public decimal yeprice; // [float ,  9.2] 예상체결가격                    StartPos 7, Length 9
        public long yevolume; // [long  ,    6] 예상체결수량                    StartPos 17, Length 6
        public string jnilysign; // [string,    1] 예상체결가전일종가대비구분      StartPos 24, Length 1
        public decimal preychange; // [float ,  9.2] 예상체결가전일종가대비          StartPos 26, Length 9
        public decimal jnilydrate; // [float ,  9.2] 예상체결가전일종가등락율        StartPos 36, Length 9
        public string shcode; // [string,    8] 단축코드                        StartPos 46, Length 8
    }
}