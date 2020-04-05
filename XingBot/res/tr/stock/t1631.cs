namespace XingBot.res.tr
{
    // 프로그램매매 종합조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1631InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string dgubun; // [string,    1] 일자구분                        StartPos 2, Length 1
        public string sdate; // [string,    8] 시작일자                        StartPos 4, Length 8
        public string edate; // [string,    8] 종료일자                        StartPos 13, Length 8
    }

    internal struct _t1631OutBlock
    {
        public long cdhrem; // [long  ,    8] 매도차익미체결잔량              StartPos 0, Length 8
        public long bdhrem; // [long  ,    8] 매도비차익미체결잔량            StartPos 9, Length 8
        public long tcdrem; // [long  ,    8] 매도차익주문수량                StartPos 18, Length 8
        public long tbdrem; // [long  ,    8] 매도비차익주문수량              StartPos 27, Length 8
        public long cshrem; // [long  ,    8] 매수차익미체결잔량              StartPos 36, Length 8
        public long bshrem; // [long  ,    8] 매수비차익미체결잔량            StartPos 45, Length 8
        public long tcsrem; // [long  ,    8] 매수차익주문수량                StartPos 54, Length 8
        public long tbsrem; // [long  ,    8] 매수비차익주문수량              StartPos 63, Length 8
    }

    internal struct _t1631OutBlock1
    {
        public long offervolume; // [long  ,    8] 매도수량                        StartPos 0, Length 8
        public long offervalue; // [long  ,   12] 매도금액                        StartPos 9, Length 12
        public long bidvolume; // [long  ,    8] 매수수량                        StartPos 22, Length 8
        public long bidvalue; // [long  ,   12] 매수금액                        StartPos 31, Length 12
        public long volume; // [long  ,    8] 순매수수량                      StartPos 44, Length 8
        public long value; // [long  ,   12] 순매수금액                      StartPos 53, Length 12
    }
}