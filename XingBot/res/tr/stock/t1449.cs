namespace XingBot.res
{
    // 가격대별 매매비중 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1449InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public string dategb; // [string,    1] 일자구분                        StartPos 7, Length 1
    }

    public struct _t1449OutBlock
    {
        public long price; // [long  ,    8] 현재가                          StartPos 0, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 9, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 11, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 20, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 27, Length 12
        public long msvolume; // [long  ,   12] 매수체결량                      StartPos 40, Length 12
        public long mdvolume; // [long  ,   12] 매도체결량                      StartPos 53, Length 12
    }

    public struct _t1449OutBlock1
    {
        public long price; // [long  ,    8] 체결가                          StartPos 0, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 9, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 11, Length 8
        public decimal tickdiff; // [float ,  6.2] 등락율                          StartPos 20, Length 6
        public long cvolume; // [long  ,   12] 체결수량                        StartPos 27, Length 12
        public decimal diff; // [float ,  6.2] 비중                            StartPos 40, Length 6
        public long mdvolume; // [long  ,   12] 매도체결량                      StartPos 47, Length 12
        public long msvolume; // [long  ,   12] 매수체결량                      StartPos 60, Length 12
        public decimal msdiff; // [float ,  6.2] 매수비율                        StartPos 73, Length 6
    }
}