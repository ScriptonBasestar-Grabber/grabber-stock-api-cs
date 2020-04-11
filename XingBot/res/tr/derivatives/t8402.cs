namespace XingBot.res
{
    // 주식선물 현재가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8402InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _t8402OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 41, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 50, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 57, Length 12
        public decimal stimeqrt{ get; set; } // [double,  6.2] 거래량전일동시간비율            StartPos 70, Length 6
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 77, Length 12
        public long mgjv{ get; set; } // [long  ,    8] 미결제량                        StartPos 90, Length 8
        public long mgjvdiff{ get; set; } // [long  ,    8] 미결제증감                      StartPos 99, Length 8
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 108, Length 8
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 117, Length 8
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 126, Length 8
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 135, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 144, Length 8
        public long high52w{ get; set; } // [long  ,    8] 52최고가                        StartPos 153, Length 8
        public long low52w{ get; set; } // [long  ,    8] 52최저가                        StartPos 162, Length 8
        public decimal basis{ get; set; } // [float ,  6.2] 베이시스                        StartPos 171, Length 6
        public long recprice{ get; set; } // [long  ,    8] 기준가                          StartPos 178, Length 8
        public long theoryprice{ get; set; } // [long  ,    8] 이론가                          StartPos 187, Length 8
        public decimal glyl{ get; set; } // [float ,  6.3] 괴리율                          StartPos 196, Length 6
        public string lastmonth{ get; set; } // [string,    8] 만기일                          StartPos 203, Length 8
        public long jandatecnt{ get; set; } // [long  ,    8] 잔여일                          StartPos 212, Length 8
        public decimal pricejisu{ get; set; } // [float ,  6.2] 종합지수                        StartPos 221, Length 6
        public string jisusign{ get; set; } // [string,    1] 종합지수전일대비구분            StartPos 228, Length 1
        public decimal jisuchange{ get; set; } // [float ,  6.2] 종합지수전일대비                StartPos 230, Length 6
        public decimal jisudiff{ get; set; } // [float ,  6.2] 종합지수등락율                  StartPos 237, Length 6
        public decimal kospijisu{ get; set; } // [float ,  6.2] KOSPI200지수                    StartPos 244, Length 6
        public string kospisign{ get; set; } // [string,    1] KOSPI200전일대비구분            StartPos 251, Length 1
        public decimal kospichange{ get; set; } // [float ,  6.2] KOSPI200전일대비                StartPos 253, Length 6
        public decimal kospidiff{ get; set; } // [float ,  6.2] KOSPI200등락율                  StartPos 260, Length 6
        public long listhprice{ get; set; } // [long  ,    8] 상장최고가                      StartPos 267, Length 8
        public long listlprice{ get; set; } // [long  ,    8] 상장최저가                      StartPos 276, Length 8
        public decimal delt{ get; set; } // [float ,  6.4] 델타                            StartPos 285, Length 6
        public decimal gama{ get; set; } // [float ,  6.4] 감마                            StartPos 292, Length 6
        public decimal ceta{ get; set; } // [float ,  6.4] 세타                            StartPos 299, Length 6
        public decimal vega{ get; set; } // [float ,  6.4] 베가                            StartPos 306, Length 6
        public decimal rhox{ get; set; } // [float ,  6.4] 로우                            StartPos 313, Length 6
        public long gmprice{ get; set; } // [long  ,    8] 근월물현재가                    StartPos 320, Length 8
        public string gmsign{ get; set; } // [string,    1] 근월물전일대비구분              StartPos 329, Length 1
        public long gmchange{ get; set; } // [long  ,    8] 근월물전일대비                  StartPos 331, Length 8
        public decimal gmdiff{ get; set; } // [float ,  6.2] 근월물등락율                    StartPos 340, Length 6
        public long theorypriceg{ get; set; } // [long  ,    8] 이론가                          StartPos 347, Length 8
        public decimal histimpv{ get; set; } // [float ,  6.2] 역사적변동성                    StartPos 356, Length 6
        public decimal impv{ get; set; } // [float ,  6.2] 내재변동성                      StartPos 363, Length 6
        public long sbasis{ get; set; } // [long  ,    8] 시장BASIS                       StartPos 370, Length 8
        public long ibasis{ get; set; } // [long  ,    8] 이론BASIS                       StartPos 379, Length 8
        public string gmfutcode{ get; set; } // [string,    8] 근월물종목코드                  StartPos 388, Length 8
        public long actprice{ get; set; } // [long  ,    8] 행사가                          StartPos 397, Length 8
        public string shcode{ get; set; } // [string,    6] 기초자산단축코드                StartPos 406, Length 6
        public string basehname{ get; set; } // [string,   20] 기초자산한글명                  StartPos 413, Length 20
        public long baseprice{ get; set; } // [long  ,    8] 기초자산현재가                  StartPos 434, Length 8
        public string basesign{ get; set; } // [string,    1] 기초자산현재가대비구분          StartPos 443, Length 1
        public long basechange{ get; set; } // [long  ,    8] 기초자산현재가전일대비          StartPos 445, Length 8
        public decimal basediff{ get; set; } // [float ,  6.2] 기초자산등락률                  StartPos 454, Length 6
        public long basevol{ get; set; } // [long  ,   12] 기초자산거래량                  StartPos 461, Length 12
        public long baseprevol{ get; set; } // [long  ,   12] 기초자산전일거래량              StartPos 474, Length 12
        public long basebidprc{ get; set; } // [long  ,    9] 기초자산매수호가                StartPos 487, Length 9
        public long baseaskprc{ get; set; } // [long  ,    9] 기초자산매도호가                StartPos 497, Length 9
        public long basefornetbid{ get; set; } // [long  ,   12] 기초자산외국계회원사순매수      StartPos 507, Length 12
        public string prodgrp{ get; set; } // [string,   20] 상품군                          StartPos 520, Length 20
        public decimal mulcnt{ get; set; } // [float , 12.8] 승수                            StartPos 541, Length 12
        public string danhochk{ get; set; } // [string,    1] 단일가호가여부                  StartPos 554, Length 1
        public long yeprice{ get; set; } // [long  ,    8] 예상체결가                      StartPos 556, Length 8
        public string jnilysign{ get; set; } // [string,    1] 예상체결가전일종가대비구분      StartPos 565, Length 1
        public long jnilychange{ get; set; } // [long  ,    8] 예상체결가전일종가대비          StartPos 567, Length 8
        public decimal jnilydrate{ get; set; } // [float ,  6.2] 예상체결가전일종가등락율        StartPos 576, Length 6
    }
}