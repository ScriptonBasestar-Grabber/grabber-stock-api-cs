namespace XingBot.res
{
    // 선물/옵션 현재가(시세) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2101InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _t2101OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public decimal price; // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public decimal change; // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public decimal jnilclose; // [float ,  6.2] 전일종가                        StartPos 37, Length 6
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 44, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 51, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 64, Length 12
        public long mgjv; // [long  ,    8] 미결제량                        StartPos 77, Length 8
        public long mgjvdiff; // [long  ,    8] 미결제증감                      StartPos 86, Length 8
        public decimal open; // [float ,  6.2] 시가                            StartPos 95, Length 6
        public decimal high; // [float ,  6.2] 고가                            StartPos 102, Length 6
        public decimal low; // [float ,  6.2] 저가                            StartPos 109, Length 6
        public decimal uplmtprice; // [float ,  6.2] 상한가                          StartPos 116, Length 6
        public decimal dnlmtprice; // [float ,  6.2] 하한가                          StartPos 123, Length 6
        public decimal high52w; // [float ,  6.2] 52최고가                        StartPos 130, Length 6
        public decimal low52w; // [float ,  6.2] 52최저가                        StartPos 137, Length 6
        public decimal basis; // [float ,  6.2] 베이시스                        StartPos 144, Length 6
        public decimal recprice; // [float ,  6.2] 기준가                          StartPos 151, Length 6
        public decimal theoryprice; // [float ,  6.2] 이론가                          StartPos 158, Length 6
        public decimal glyl; // [float ,  6.3] 괴리율                          StartPos 165, Length 6
        public decimal cbhprice; // [float ,  6.2] CB상한가                        StartPos 172, Length 6
        public decimal cblprice; // [float ,  6.2] CB하한가                        StartPos 179, Length 6
        public string lastmonth; // [string,    8] 만기일                          StartPos 186, Length 8
        public long jandatecnt; // [long  ,    8] 잔여일                          StartPos 195, Length 8
        public decimal pricejisu; // [float ,  6.2] 종합지수                        StartPos 204, Length 6
        public string jisusign; // [string,    1] 종합지수전일대비구분            StartPos 211, Length 1
        public decimal jisuchange; // [float ,  6.2] 종합지수전일대비                StartPos 213, Length 6
        public decimal jisudiff; // [float ,  6.2] 종합지수등락율                  StartPos 220, Length 6
        public decimal kospijisu; // [float ,  6.2] KOSPI200지수                    StartPos 227, Length 6
        public string kospisign; // [string,    1] KOSPI200전일대비구분            StartPos 234, Length 1
        public decimal kospichange; // [float ,  6.2] KOSPI200전일대비                StartPos 236, Length 6
        public decimal kospidiff; // [float ,  6.2] KOSPI200등락율                  StartPos 243, Length 6
        public decimal listhprice; // [float ,  6.2] 상장최고가                      StartPos 250, Length 6
        public decimal listlprice; // [float ,  6.2] 상장최저가                      StartPos 257, Length 6
        public decimal delt; // [float ,  6.4] 델타                            StartPos 264, Length 6
        public decimal gama; // [float ,  6.4] 감마                            StartPos 271, Length 6
        public decimal ceta; // [float ,  6.4] 세타                            StartPos 278, Length 6
        public decimal vega; // [float ,  6.4] 베가                            StartPos 285, Length 6
        public decimal rhox; // [float ,  6.4] 로우                            StartPos 292, Length 6
        public decimal gmprice; // [float ,  6.2] 근월물현재가                    StartPos 299, Length 6
        public string gmsign; // [string,    1] 근월물전일대비구분              StartPos 306, Length 1
        public decimal gmchange; // [float ,  6.2] 근월물전일대비                  StartPos 308, Length 6
        public decimal gmdiff; // [float ,  6.2] 근월물등락율                    StartPos 315, Length 6
        public decimal theorypriceg; // [float ,  6.2] 이론가                          StartPos 322, Length 6
        public decimal histimpv; // [float ,  6.2] 역사적변동성                    StartPos 329, Length 6
        public decimal impv; // [float ,  6.2] 내재변동성                      StartPos 336, Length 6
        public decimal sbasis; // [float ,  6.2] 시장BASIS                       StartPos 343, Length 6
        public decimal ibasis; // [float ,  6.2] 이론BASIS                       StartPos 350, Length 6
        public string gmfutcode; // [string,    8] 근월물종목코드                  StartPos 357, Length 8
        public decimal actprice; // [float ,  6.2] 행사가                          StartPos 366, Length 6
        public string greeks_time; // [string,    6] 거래소민감도수신시간            StartPos 373, Length 6
        public string greeks_confirm; // [string,    8] 거래소민감도확정여부            StartPos 380, Length 8
        public string danhochk; // [string,    1] 단일가호가여부                  StartPos 389, Length 1
        public decimal yeprice; // [float ,  6.2] 예상체결가                      StartPos 391, Length 6
        public string jnilysign; // [string,    1] 예상체결가전일종가대비구분      StartPos 398, Length 1
        public decimal jnilychange; // [float ,  6.2] 예상체결가전일종가대비          StartPos 400, Length 6
        public decimal jnilydrate; // [float ,  6.2] 예상체결가전일종가등락율        StartPos 407, Length 6
        public string alloc_gubun; // [string,    1] 배분구분(1:배분개시2:배분해제0: StartPos 414, Length 1
        public long bjandatecnt; // [long  ,    8] 잔여일(영업일)                  StartPos 416, Length 8
        public string focode; // [string,    8] 종목코드                        StartPos 425, Length 8
        public string dy_gubun; // [string,    1] 실시간가격제한여부(0:대상아님1: StartPos 434, Length 1
        public decimal dy_uplmtprice; // [float ,  6.2] 실시간상한가                    StartPos 436, Length 6
        public decimal dy_dnlmtprice; // [float ,  6.2] 실시간하한가                    StartPos 443, Length 6
        public string updnstep_gubun; // [string,    1] 가격제한폭확대(0:미확대1:확대2: StartPos 450, Length 1
        public string upstep; // [string,    2] 상한적용단계                    StartPos 452, Length 2
        public string dnstep; // [string,    2] 하한적용단계                    StartPos 455, Length 2
        public decimal uplmtprice_3rd; // [float ,  6.2] 3단계상한가                     StartPos 458, Length 6
        public decimal dnlmtprice_3rd; // [float ,  6.2] 3단계하한가                     StartPos 465, Length 6
    }
}