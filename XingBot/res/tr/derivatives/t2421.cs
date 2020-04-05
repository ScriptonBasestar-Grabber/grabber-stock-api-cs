namespace XingBot.res
{
    // 선물/옵션 미결제약정 추이 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t2421InBlock
    {
        public string focode; // [string,    8] 종목코드                        StartPos 0, Length 8
        public string bdgubun; // [string,    1] 분일구분                        StartPos 9, Length 1
        public string nmin; // [string,    3] N분                             StartPos 11, Length 3
        public string tcgubun; // [string,    1] 당일연결구분                    StartPos 15, Length 1
        public string cnt; // [string,    4] 조회건수                        StartPos 17, Length 4
    }

    internal struct _t2421OutBlock
    {
        public float price; // [float ,  6.2] 현재가                          StartPos 0, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 7, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 9, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 16, Length 6
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 23, Length 8
        public double volume; // [double,   15] 누적거래량                      StartPos 32, Length 15
        public long openyak; // [long  ,    8] 미결제수량                      StartPos 48, Length 8
    }

    internal struct _t2421OutBlock1
    {
        public string dt; // [string,   14] 일자시간                        StartPos 0, Length 14
        public float open; // [float ,  6.2] 시가                            StartPos 15, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 22, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 29, Length 6
        public float close; // [float ,  6.2] 종가                            StartPos 36, Length 6
        public long openopenyak; // [long  ,    8] 미결제시량                      StartPos 43, Length 8
        public long highopenyak; // [long  ,    8] 미결제고량                      StartPos 52, Length 8
        public long lowopenyak; // [long  ,    8] 미결제저량                      StartPos 61, Length 8
        public long closeopenyak; // [long  ,    8] 미결제종량                      StartPos 70, Length 8
        public long openupdn; // [long  ,    8] 미결증감                        StartPos 79, Length 8
    }
}