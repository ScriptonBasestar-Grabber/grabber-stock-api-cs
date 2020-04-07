namespace XingBot.res
{
    // 프로그램매매 종합조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1631InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 0, Length 1
        public string dgubun{ get; set; } // [string,    1] 일자구분                        StartPos 2, Length 1
        public string sdate{ get; set; } // [string,    8] 시작일자                        StartPos 4, Length 8
        public string edate{ get; set; } // [string,    8] 종료일자                        StartPos 13, Length 8
    }

    public struct _t1631OutBlock
    {
        public long cdhrem{ get; set; } // [long  ,    8] 매도차익미체결잔량              StartPos 0, Length 8
        public long bdhrem{ get; set; } // [long  ,    8] 매도비차익미체결잔량            StartPos 9, Length 8
        public long tcdrem{ get; set; } // [long  ,    8] 매도차익주문수량                StartPos 18, Length 8
        public long tbdrem{ get; set; } // [long  ,    8] 매도비차익주문수량              StartPos 27, Length 8
        public long cshrem{ get; set; } // [long  ,    8] 매수차익미체결잔량              StartPos 36, Length 8
        public long bshrem{ get; set; } // [long  ,    8] 매수비차익미체결잔량            StartPos 45, Length 8
        public long tcsrem{ get; set; } // [long  ,    8] 매수차익주문수량                StartPos 54, Length 8
        public long tbsrem{ get; set; } // [long  ,    8] 매수비차익주문수량              StartPos 63, Length 8
    }

    public struct _t1631OutBlock1
    {
        public long offervolume{ get; set; } // [long  ,    8] 매도수량                        StartPos 0, Length 8
        public long offervalue{ get; set; } // [long  ,   12] 매도금액                        StartPos 9, Length 12
        public long bidvolume{ get; set; } // [long  ,    8] 매수수량                        StartPos 22, Length 8
        public long bidvalue{ get; set; } // [long  ,   12] 매수금액                        StartPos 31, Length 12
        public long volume{ get; set; } // [long  ,    8] 순매수수량                      StartPos 44, Length 8
        public long value{ get; set; } // [long  ,   12] 순매수금액                      StartPos 53, Length 12
    }
}