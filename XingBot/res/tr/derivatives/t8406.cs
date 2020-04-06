namespace XingBot.res
{
    // 주식선물 틱분별체결조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8406InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string cgubun; // [string,    1] 챠트구분                        StartPos 9, Length 1
        public string bgubun; // [string,    3] 분구분                          StartPos 11, Length 3
        public string cnt; // [string,    3] 조회건수                        StartPos 15, Length 3
    }

    public struct _t8406OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public long price; // [long  ,    8] 현재가                          StartPos 11, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 20, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 22, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 31, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 40, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 49, Length 8
        public decimal volume; // [double,   12] 거래량                          StartPos 58, Length 12
        public decimal value; // [double,   12] 거래대금                        StartPos 71, Length 12
        public long openyak; // [long  ,    8] 미결수량                        StartPos 84, Length 8
        public long openupdn; // [long  ,    8] 미결증감                        StartPos 93, Length 8
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 102, Length 8
        public long s_mschecnt; // [long  ,    8] 매수순간체결건수                StartPos 111, Length 8
        public long s_mdchecnt; // [long  ,    8] 매도순간체결건수                StartPos 120, Length 8
        public long ss_mschecnt; // [long  ,    8] 순매수순간체결건수              StartPos 129, Length 8
        public decimal s_mschevol; // [double,   12] 매수순간체결량                  StartPos 138, Length 12
        public decimal s_mdchevol; // [double,   12] 매도순간체결량                  StartPos 151, Length 12
        public decimal ss_mschevol; // [double,   12] 순매수순간체결량                StartPos 164, Length 12
        public decimal chdegvol; // [float ,  8.2] 체결강도(거래량)                StartPos 177, Length 8
        public decimal chdegcnt; // [float ,  8.2] 체결강도(건수)                  StartPos 186, Length 8
    }
}