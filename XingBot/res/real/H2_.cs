namespace XingBot.real.res
{
    // KOSPI시간외호가잔량 ( ATTR, KEY=6, GROUP=1 )
    public struct _H2__InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _H2__OutBlock
    {
        public string hotime; // [string,    6] 호가시간                        StartPos 0, Length 6
        public long tmofferrem; // [long  ,   12] 시간외매도잔량                  StartPos 7, Length 12
        public long tmbidrem; // [long  ,   12] 시간외매수잔량                  StartPos 20, Length 12
        public long pretmoffercha; // [long  ,   12] 시간외매도수량직전대비          StartPos 33, Length 12
        public long pretmbidcha; // [long  ,   12] 시간외매수수량직전대비          StartPos 46, Length 12
        public string shcode; // [string,    6] 단축코드                        StartPos 59, Length 6
    }
}