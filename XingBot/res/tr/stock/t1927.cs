namespace XingBot.res
{
    // 공매도일별추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1927InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string date; // [string,    8] 일자                            StartPos 7, Length 8
        public string sdate; // [string,    8] 시작일자                        StartPos 16, Length 8
        public string edate; // [string,    8] 종료일자                        StartPos 25, Length 8
    }

    public struct _t1927OutBlock
    {
        public string date; // [string,    8] 일자CTS                         StartPos 0, Length 8
    }

    public struct _t1927OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long price; // [long  ,    8] 현재가                          StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 36, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 49, Length 12
        public long gm_vo; // [long  ,   12] 공매도수량                      StartPos 62, Length 12
        public long gm_va; // [long  ,   12] 공매도대금                      StartPos 75, Length 12
        public decimal gm_per; // [float ,  6.2] 공매도거래비중                  StartPos 88, Length 6
        public long gm_avg; // [long  ,   12] 평균공매도단가                  StartPos 95, Length 12
        public long gm_vo_sum; // [long  ,   12] 누적공매도수량                  StartPos 108, Length 12
    }
}