namespace XingBot.res
{
    // 선물/옵션 시간대별 체결조회(단일출력용) ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2210InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
        public long cvolume{ get; set; } // [long  ,   12] 특이거래량                      StartPos 9, Length 12
        public string stime{ get; set; } // [string,    4] 시작시간                        StartPos 22, Length 4
        public string etime{ get; set; } // [string,    4] 종료시간                        StartPos 27, Length 4
    }

    public class _t2210OutBlock
    {
        public long mdvolume{ get; set; } // [long  ,    8] 매도체결수량                    StartPos 0, Length 8
        public long mdchecnt{ get; set; } // [long  ,    8] 매도체결건수                    StartPos 9, Length 8
        public long msvolume{ get; set; } // [long  ,    8] 매수체결수량                    StartPos 18, Length 8
        public long mschecnt{ get; set; } // [long  ,    8] 매수체결건수                    StartPos 27, Length 8
    }
}