namespace XingBot.res
{
    // 주식선물 현재가조회 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t8402InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    internal struct _t8402OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 41, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 50, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 57, Length 12
        public double stimeqrt; // [double,  6.2] 거래량전일동시간비율            StartPos 70, Length 6
        public long value; // [long  ,   12] 거래대금                        StartPos 77, Length 12
        public long mgjv; // [long  ,    8] 미결제량                        StartPos 90, Length 8
        public long mgjvdiff; // [long  ,    8] 미결제증감                      StartPos 99, Length 8
        public long open; // [long  ,    8] 시가                            StartPos 108, Length 8
        public long high; // [long  ,    8] 고가                            StartPos 117, Length 8
        public long low; // [long  ,    8] 저가                            StartPos 126, Length 8
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 135, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 144, Length 8
        public long high52w; // [long  ,    8] 52최고가                        StartPos 153, Length 8
        public long low52w; // [long  ,    8] 52최저가                        StartPos 162, Length 8
        public float basis; // [float ,  6.2] 베이시스                        StartPos 171, Length 6
        public long recprice; // [long  ,    8] 기준가                          StartPos 178, Length 8
        public long theoryprice; // [long  ,    8] 이론가                          StartPos 187, Length 8
        public float glyl; // [float ,  6.3] 괴리율                          StartPos 196, Length 6
        public string lastmonth; // [string,    8] 만기일                          StartPos 203, Length 8
        public long jandatecnt; // [long  ,    8] 잔여일                          StartPos 212, Length 8
        public float pricejisu; // [float ,  6.2] 종합지수                        StartPos 221, Length 6
        public string jisusign; // [string,    1] 종합지수전일대비구분            StartPos 228, Length 1
        public float jisuchange; // [float ,  6.2] 종합지수전일대비                StartPos 230, Length 6
        public float jisudiff; // [float ,  6.2] 종합지수등락율                  StartPos 237, Length 6
        public float kospijisu; // [float ,  6.2] KOSPI200지수                    StartPos 244, Length 6
        public string kospisign; // [string,    1] KOSPI200전일대비구분            StartPos 251, Length 1
        public float kospichange; // [float ,  6.2] KOSPI200전일대비                StartPos 253, Length 6
        public float kospidiff; // [float ,  6.2] KOSPI200등락율                  StartPos 260, Length 6
        public long listhprice; // [long  ,    8] 상장최고가                      StartPos 267, Length 8
        public long listlprice; // [long  ,    8] 상장최저가                      StartPos 276, Length 8
        public float delt; // [float ,  6.4] 델타                            StartPos 285, Length 6
        public float gama; // [float ,  6.4] 감마                            StartPos 292, Length 6
        public float ceta; // [float ,  6.4] 세타                            StartPos 299, Length 6
        public float vega; // [float ,  6.4] 베가                            StartPos 306, Length 6
        public float rhox; // [float ,  6.4] 로우                            StartPos 313, Length 6
        public long gmprice; // [long  ,    8] 근월물현재가                    StartPos 320, Length 8
        public string gmsign; // [string,    1] 근월물전일대비구분              StartPos 329, Length 1
        public long gmchange; // [long  ,    8] 근월물전일대비                  StartPos 331, Length 8
        public float gmdiff; // [float ,  6.2] 근월물등락율                    StartPos 340, Length 6
        public long theorypriceg; // [long  ,    8] 이론가                          StartPos 347, Length 8
        public float histimpv; // [float ,  6.2] 역사적변동성                    StartPos 356, Length 6
        public float impv; // [float ,  6.2] 내재변동성                      StartPos 363, Length 6
        public long sbasis; // [long  ,    8] 시장BASIS                       StartPos 370, Length 8
        public long ibasis; // [long  ,    8] 이론BASIS                       StartPos 379, Length 8
        public string gmfutcode; // [string,    8] 근월물종목코드                  StartPos 388, Length 8
        public long actprice; // [long  ,    8] 행사가                          StartPos 397, Length 8
        public string shcode; // [string,    6] 기초자산단축코드                StartPos 406, Length 6
        public string basehname; // [string,   20] 기초자산한글명                  StartPos 413, Length 20
        public long baseprice; // [long  ,    8] 기초자산현재가                  StartPos 434, Length 8
        public string basesign; // [string,    1] 기초자산현재가대비구분          StartPos 443, Length 1
        public long basechange; // [long  ,    8] 기초자산현재가전일대비          StartPos 445, Length 8
        public float basediff; // [float ,  6.2] 기초자산등락률                  StartPos 454, Length 6
        public long basevol; // [long  ,   12] 기초자산거래량                  StartPos 461, Length 12
        public long baseprevol; // [long  ,   12] 기초자산전일거래량              StartPos 474, Length 12
        public long basebidprc; // [long  ,    9] 기초자산매수호가                StartPos 487, Length 9
        public long baseaskprc; // [long  ,    9] 기초자산매도호가                StartPos 497, Length 9
        public long basefornetbid; // [long  ,   12] 기초자산외국계회원사순매수      StartPos 507, Length 12
        public string prodgrp; // [string,   20] 상품군                          StartPos 520, Length 20
        public float mulcnt; // [float , 12.8] 승수                            StartPos 541, Length 12
        public string danhochk; // [string,    1] 단일가호가여부                  StartPos 554, Length 1
        public long yeprice; // [long  ,    8] 예상체결가                      StartPos 556, Length 8
        public string jnilysign; // [string,    1] 예상체결가전일종가대비구분      StartPos 565, Length 1
        public long jnilychange; // [long  ,    8] 예상체결가전일종가대비          StartPos 567, Length 8
        public float jnilydrate; // [float ,  6.2] 예상체결가전일종가등락율        StartPos 576, Length 6
    }
}