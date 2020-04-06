namespace XingBot.res
{
    // 주식선물예상체결 ( ATTR, KEY=8, GROUP=1 )
    public struct _YJC_InBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _YJC_OutBlock
    {
        public string ychetime; // [string,    6] 예상체결시간                    StartPos 0, Length 6
        public long yeprice; // [long  ,   10] 예상체결가격                    StartPos 7, Length 10
        public string jnilysign; // [string,    1] 예상체결가전일종가대비구분      StartPos 18, Length 1
        public long preychange; // [long  ,   10] 예상체결가전일종가대비          StartPos 20, Length 10
        public decimal jnilydrate; // [float ,  6.2] 예상체결가전일종가등락율        StartPos 31, Length 6
        public string futcode; // [string,    8] 단축코드                        StartPos 38, Length 8
    }
}