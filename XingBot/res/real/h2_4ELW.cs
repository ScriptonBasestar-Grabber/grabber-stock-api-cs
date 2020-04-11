namespace XingBot.res
{
    // ELW장전시간외호가잔량 ( ATTR, KEY=6, GROUP=1 )
    public class _h2_4ELW_InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _h2_4ELW_OutBlock
    {
        public string hotime{ get; set; } // [string,    6] 호가시간                        StartPos 0, Length 6
        public long tmofferrem{ get; set; } // [long  ,   12] 시간외매도잔량                  StartPos 7, Length 12
        public long tmbidrem{ get; set; } // [long  ,   12] 시간외매수잔량                  StartPos 20, Length 12
        public long pretmoffercha{ get; set; } // [long  ,   12] 시간외매도수량직전대비          StartPos 33, Length 12
        public long pretmbidcha{ get; set; } // [long  ,   12] 시간외매수수량직전대비          StartPos 46, Length 12
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 59, Length 6
    }
}