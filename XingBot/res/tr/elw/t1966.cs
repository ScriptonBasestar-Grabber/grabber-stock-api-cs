namespace XingBot.res
{
    // ELW 거래대금 상위 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1966InBlock
    {
        public string gubun; // [string,    1] 당일전일(0:당일1:전일)          StartPos 0, Length 1
        public string ggubun; // [string,    2] 권리유형구분(00:EX01:콜02:풋'': StartPos 2, Length 2
        public string itemcode; // [string,   12] 기초자산종목                    StartPos 5, Length 12
        public string lastdate; // [string,    8] 조회만기일                      StartPos 18, Length 8
        public string exgubun; // [string,    6] 대상제외                        StartPos 27, Length 6
        public long sprice; // [long  ,    8] 시작가격                        StartPos 34, Length 8
        public long eprice; // [long  ,    8] 종료가격                        StartPos 43, Length 8
        public long volume; // [long  ,   12] 거래량                          StartPos 52, Length 12
        public long sjanday; // [long  ,    8] 잔존시작일수                    StartPos 65, Length 8
        public long ejanday; // [long  ,    8] 잔존종료일수                    StartPos 74, Length 8
        public long idx; // [long  ,    4] IDX                             StartPos 83, Length 4
    }

    internal struct _t1966OutBlock
    {
        public long idx; // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    internal struct _t1966OutBlock1
    {
        public string hname; // [string,   40] 한글명                          StartPos 0, Length 40
        public long price; // [long  ,    8] 현재가                          StartPos 41, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 50, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 52, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 61, Length 6
        public double value; // [double,   12] 누적거래대금                    StartPos 68, Length 12
        public double jnilvalue; // [double,   12] 전일거래대금                    StartPos 81, Length 12
        public double elwexec; // [double, 10.2] 행사가                          StartPos 94, Length 10
        public double convrate; // [double, 12.4] 전환비율                        StartPos 105, Length 12
        public string lastdate; // [string,    8] 만기일                          StartPos 118, Length 8
        public string itemcode; // [string,   12] 기초자산종목코드                StartPos 127, Length 12
        public string itemshcode; // [string,    9] 기초자산단축코드                StartPos 140, Length 9
        public string itemname; // [string,   20] 기초자산종목명                  StartPos 150, Length 20
        public string itemprice; // [string,   10] 기초자산현재가                  StartPos 171, Length 10
        public string itemsign; // [string,    1] 기초자산대비구분                StartPos 182, Length 1
        public string itemchange; // [string,   10] 기초자산전일대비                StartPos 184, Length 10
        public double itemdiff; // [double,  6.2] 기초자산등락율                  StartPos 195, Length 6
        public string elwshcode; // [string,    6] ELW종목코드                     StartPos 202, Length 6
    }
}