namespace XingBot.res.tr
{
    // 신호조회 ( BLOCK,HEADTYPE=A )
    internal struct _t1809InBlock
    {
        public string gubun; // [gubun,    1] 신호구분                        StartPos 0, Length 1
        public string jmGb; // [jmGb,    1] 종목구분                        StartPos 1, Length 1
        public string jmcode; // [jmcode,    6] 종목코드                        StartPos 2, Length 6
        public string cts; // [cts,   30] NEXTKEY                         StartPos 8, Length 30
    }

    internal struct _t1809OutBlock
    {
        public string cts; // [cts,   30] NEXTKEY                         StartPos 0, Length 30
    }

    internal struct _t1809OutBlock1
    {
        public string date; // [date,    8] 일자                            StartPos 0, Length 8
        public string time; // [time,    6] 시간                            StartPos 8, Length 6
        public string signal_id; // [signal_id,    4] 신호ID                          StartPos 14, Length 4
        public string signal_desc; // [signal_desc,  300] 신호명                          StartPos 18, Length 300
        public string point; // [point,    3] 신호강도                        StartPos 318, Length 3
        public string keyword; // [keyword,   40] 뉴스신호키워드                  StartPos 321, Length 40
        public string seq; // [seq,   24] 신호별구분                      StartPos 361, Length 24
        public string gubun; // [gubun,    2] 신호구분                        StartPos 385, Length 2
        public string jmcode; // [jmcode,    6] 신호종목                        StartPos 387, Length 6
        public long price; // [price  ,    7] 종목가격                        StartPos 393, Length 7
        public string sign; // [sign,    1] 종목등락부호                    StartPos 400, Length 1
        public float chgrate; // [chgrate ,  6.2] 대비등락율                      StartPos 401, Length 6
        public long volume; // [volume  ,    9] 거래량                          StartPos 407, Length 9
        public string datetime; // [datetime,   16] 신호일시                        StartPos 416, Length 16
    }
}