namespace XingBot.res
{
    // 업종별 투자자별 매매현황(BM) ( attr,block )
    public class _BM__InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                       StartPos 0, Length 3
    }

    public class _BM__OutBlock
    {
        public string tjjcode{ get; set; } // [string,    4] 투자자코드                     StartPos 0, Length 4
        public string tjjtime{ get; set; } // [string,    8] 수신시간                       StartPos 5, Length 8
        public long msvolume{ get; set; } // [long  ,    8] 매수 거래량                    StartPos 14, Length 8
        public long mdvolume{ get; set; } // [long  ,    8] 매도 거래량                    StartPos 23, Length 8
        public long msvol{ get; set; } // [long  ,    8] 거래량 순매수                  StartPos 32, Length 8
        public long p_msvol{ get; set; } // [long  ,    8] 거래량 순매수 직전대비         StartPos 41, Length 8
        public long msvalue{ get; set; } // [long  ,    6] 매수 거래대금                  StartPos 50, Length 6
        public long mdvalue{ get; set; } // [long  ,    6] 매도 거래대금                  StartPos 57, Length 6
        public long msval{ get; set; } // [long  ,    6] 거래대금 순매수                StartPos 64, Length 6
        public long p_msval{ get; set; } // [long  ,    6] 거래대금 순매수 직전대비       StartPos 71, Length 6
        public string upcode{ get; set; } // [string,    3] 업종코드                       StartPos 78, Length 3
    }
}