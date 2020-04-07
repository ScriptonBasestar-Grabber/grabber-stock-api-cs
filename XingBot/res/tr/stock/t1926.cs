namespace XingBot.res
{
    // 종목별 신용/대주 현황 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1926InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    public struct _t1926OutBlock
    {
        public long ynvolume{ get; set; } // [long  ,    8] 융자신규수량                    StartPos 0, Length 8
        public long ysvolume{ get; set; } // [long  ,    8] 융자상환수량                    StartPos 9, Length 8
        public long yjvolume{ get; set; } // [long  ,    8] 융자잔고수량                    StartPos 18, Length 8
        public long yvchange{ get; set; } // [long  ,    8] 융자수량대비                    StartPos 27, Length 8
        public decimal ygrate{ get; set; } // [float ,  9.2] 융자공여율                      StartPos 36, Length 9
        public decimal yjrate{ get; set; } // [float ,  9.2] 융자잔고율                      StartPos 46, Length 9
        public long ynprice{ get; set; } // [long  ,    8] 융자신규금액                    StartPos 56, Length 8
        public long ysprice{ get; set; } // [long  ,    8] 융자상환금액                    StartPos 65, Length 8
        public long yjprice{ get; set; } // [long  ,    8] 융자잔고금액                    StartPos 74, Length 8
        public long yachange{ get; set; } // [long  ,    8] 융자금액대비                    StartPos 83, Length 8
        public long dnvolume{ get; set; } // [long  ,    8] 대주신규수량                    StartPos 92, Length 8
        public long dsvolume{ get; set; } // [long  ,    8] 대주상환수량                    StartPos 101, Length 8
        public long djvolume{ get; set; } // [long  ,    8] 대주잔고수량                    StartPos 110, Length 8
        public long dvchange{ get; set; } // [long  ,    8] 대주수량대비                    StartPos 119, Length 8
        public decimal dgrate{ get; set; } // [float ,  9.2] 대주공여율                      StartPos 128, Length 9
        public decimal djrate{ get; set; } // [float ,  9.2] 대주잔고율                      StartPos 138, Length 9
        public long dnprice{ get; set; } // [long  ,    8] 대주신규금액                    StartPos 148, Length 8
        public long dsprice{ get; set; } // [long  ,    8] 대주상환금액                    StartPos 157, Length 8
        public long djprice{ get; set; } // [long  ,    8] 대주잔고금액                    StartPos 166, Length 8
        public long dachange{ get; set; } // [long  ,    8] 대주금액대비                    StartPos 175, Length 8
        public string mmdate{ get; set; } // [string,    8] 결제일                          StartPos 184, Length 8
        public long close{ get; set; } // [long  ,    8] 결제일종가                      StartPos 193, Length 8
        public long volume{ get; set; } // [long  ,   10] 결제일거래량                    StartPos 202, Length 10
        public long value{ get; set; } // [long  ,   12] 결제일거래대금                  StartPos 213, Length 12
        public decimal pr5days{ get; set; } // [float ,  9.2] 주가5일증가율                   StartPos 226, Length 9
        public decimal pr20days{ get; set; } // [float ,  9.2] 주가20일증가율                  StartPos 236, Length 9
        public decimal yj5days{ get; set; } // [float ,  9.2] 융자5일증가율                   StartPos 246, Length 9
        public decimal yj20days{ get; set; } // [float ,  9.2] 융자20일증가율                  StartPos 256, Length 9
        public decimal dj5days{ get; set; } // [float ,  9.2] 대주5일증가율                   StartPos 266, Length 9
        public decimal dj20days{ get; set; } // [float ,  9.2] 대주20일증가율                  StartPos 276, Length 9
    }
}