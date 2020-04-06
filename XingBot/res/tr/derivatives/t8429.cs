namespace XingBot.real.res
{
    // EUREX야간옵션선물틱분별체결조회챠트 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8429InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string cgubun; // [string,    1] 챠트구분                        StartPos 9, Length 1
        public string bgubun; // [string,    3] 분구분                          StartPos 11, Length 3
        public string cnt; // [string,    3] 조회건수                        StartPos 15, Length 3
    }

    public struct _t8429OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public decimal price; // [float ,  6.2] 현재가                          StartPos 11, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public decimal change; // [float ,  6.2] 전일대비                        StartPos 20, Length 6
        public decimal open; // [float ,  6.2] 시가                            StartPos 27, Length 6
        public decimal high; // [float ,  6.2] 고가                            StartPos 34, Length 6
        public decimal low; // [float ,  6.2] 저가                            StartPos 41, Length 6
        public decimal volume; // [double,   12] 거래량                          StartPos 48, Length 12
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 61, Length 8
        public long s_mschecnt; // [long  ,    8] 매수순간체결건수                StartPos 70, Length 8
        public long s_mdchecnt; // [long  ,    8] 매도순간체결건수                StartPos 79, Length 8
        public long ss_mschecnt; // [long  ,    8] 순매수순간체결건수              StartPos 88, Length 8
        public decimal s_mschevol; // [double,   12] 매수순간체결량                  StartPos 97, Length 12
        public decimal s_mdchevol; // [double,   12] 매도순간체결량                  StartPos 110, Length 12
        public decimal ss_mschevol; // [double,   12] 순매수순간체결량                StartPos 123, Length 12
        public decimal chdegvol; // [float ,  8.2] 체결강도(거래량)                StartPos 136, Length 8
        public decimal chdegcnt; // [float ,  8.2] 체결강도(건수)                  StartPos 145, Length 8
    }
}