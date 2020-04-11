namespace XingBot.res
{
    // 신호조회 ( BLOCK,HEADTYPE=A )
    public class _t1809InBlock
    {
        public string gubun{ get; set; } // [gubun,    1] 신호구분                        StartPos 0, Length 1
        public string jmGb{ get; set; } // [jmGb,    1] 종목구분                        StartPos 1, Length 1
        public string jmcode{ get; set; } // [jmcode,    6] 종목코드                        StartPos 2, Length 6
        public string cts{ get; set; } // [cts,   30] NEXTKEY                         StartPos 8, Length 30
    }

    public class _t1809OutBlock
    {
        public string cts{ get; set; } // [cts,   30] NEXTKEY                         StartPos 0, Length 30
    }

    public class _t1809OutBlock1
    {
        public string date{ get; set; } // [date,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [time,    6] 시간                            StartPos 8, Length 6
        public string signal_id{ get; set; } // [signal_id,    4] 신호ID                          StartPos 14, Length 4
        public string signal_desc{ get; set; } // [signal_desc,  300] 신호명                          StartPos 18, Length 300
        public string point{ get; set; } // [point,    3] 신호강도                        StartPos 318, Length 3
        public string keyword{ get; set; } // [keyword,   40] 뉴스신호키워드                  StartPos 321, Length 40
        public string seq{ get; set; } // [seq,   24] 신호별구분                      StartPos 361, Length 24
        public string gubun{ get; set; } // [gubun,    2] 신호구분                        StartPos 385, Length 2
        public string jmcode{ get; set; } // [jmcode,    6] 신호종목                        StartPos 387, Length 6
        public long price{ get; set; } // [price  ,    7] 종목가격                        StartPos 393, Length 7
        public string sign{ get; set; } // [sign,    1] 종목등락부호                    StartPos 400, Length 1
        public decimal chgrate{ get; set; } // [chgrate ,  6.2] 대비등락율                      StartPos 401, Length 6
        public long volume{ get; set; } // [volume  ,    9] 거래량                          StartPos 407, Length 9
        public string datetime{ get; set; } // [datetime,   16] 신호일시                        StartPos 416, Length 16
    }
}