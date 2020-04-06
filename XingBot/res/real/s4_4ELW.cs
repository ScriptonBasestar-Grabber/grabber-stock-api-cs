namespace XingBot.res
{
    // ELW기세 ( ATTR, KEY=6, GROUP=1 )
    public struct _s4_ELW_InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _s4_ELW_OutBlock
    {
        public string sign; // [string,    1] 전일대비구분                    StartPos 0, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 2, Length 8
        public decimal drate; // [float ,  6.2] 등락율                          StartPos 11, Length 6
        public long price; // [long  ,    8] 현재가                          StartPos 18, Length 8
        public string opentime; // [string,    6] 시가시간                        StartPos 27, Length 6
        public long open; // [long  ,    8] 시가                            StartPos 34, Length 8
        public string hightime; // [string,    6] 고가시간                        StartPos 43, Length 6
        public long high; // [long  ,    8] 고가                            StartPos 50, Length 8
        public string lowtime; // [string,    6] 저가시간                        StartPos 59, Length 6
        public long low; // [long  ,    8] 저가                            StartPos 66, Length 8
        public string shcode; // [string,    6] 단축코드                        StartPos 75, Length 6
    }
}