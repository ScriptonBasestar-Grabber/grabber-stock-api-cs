namespace XingBot.res
{
    // CME 현재가조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2801InBlock
    {
        public string focode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public class _t2801OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public decimal jnilclose{ get; set; } // [float ,  6.2] 전일종가                        StartPos 37, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 44, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 51, Length 12
        public long value{ get; set; } // [long  ,   12] 거래대금                        StartPos 64, Length 12
        public long mgjv{ get; set; } // [long  ,    8] 미결제량                        StartPos 77, Length 8
        public long mgjvdiff{ get; set; } // [long  ,    8] 미결제증감                      StartPos 86, Length 8
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 95, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 102, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 109, Length 6
        public decimal uplmtprice{ get; set; } // [float ,  6.2] 상한가                          StartPos 116, Length 6
        public decimal dnlmtprice{ get; set; } // [float ,  6.2] 하한가                          StartPos 123, Length 6
        public decimal high52w{ get; set; } // [float ,  6.2] 52최고가                        StartPos 130, Length 6
        public decimal low52w{ get; set; } // [float ,  6.2] 52최저가                        StartPos 137, Length 6
        public decimal basis{ get; set; } // [float ,  6.2] 베이시스                        StartPos 144, Length 6
        public decimal recprice{ get; set; } // [float ,  6.2] 기준가                          StartPos 151, Length 6
        public decimal theoryprice{ get; set; } // [float ,  6.2] 이론가                          StartPos 158, Length 6
        public decimal glyl{ get; set; } // [float ,  6.3] 괴리율                          StartPos 165, Length 6
        public decimal cbhprice{ get; set; } // [float ,  6.2] CB상한가                        StartPos 172, Length 6
        public decimal cblprice{ get; set; } // [float ,  6.2] CB하한가                        StartPos 179, Length 6
        public string lastmonth{ get; set; } // [string,    8] 만기일                          StartPos 186, Length 8
        public long jandatecnt{ get; set; } // [long  ,    8] 잔여일                          StartPos 195, Length 8
        public decimal pricejisu{ get; set; } // [float ,  6.2] 종합지수                        StartPos 204, Length 6
        public string jisusign{ get; set; } // [string,    1] 종합지수전일대비구분            StartPos 211, Length 1
        public decimal jisuchange{ get; set; } // [float ,  6.2] 종합지수전일대비                StartPos 213, Length 6
        public decimal jisudiff{ get; set; } // [float ,  6.2] 종합지수등락율                  StartPos 220, Length 6
        public decimal kospijisu{ get; set; } // [float ,  6.2] KOSPI200지수                    StartPos 227, Length 6
        public string kospisign{ get; set; } // [string,    1] KOSPI200전일대비구분            StartPos 234, Length 1
        public decimal kospichange{ get; set; } // [float ,  6.2] KOSPI200전일대비                StartPos 236, Length 6
        public decimal kospidiff{ get; set; } // [float ,  6.2] KOSPI200등락율                  StartPos 243, Length 6
        public decimal listhprice{ get; set; } // [float ,  6.2] 상장최고가                      StartPos 250, Length 6
        public decimal listlprice{ get; set; } // [float ,  6.2] 상장최저가                      StartPos 257, Length 6
        public decimal sbasis{ get; set; } // [float ,  6.2] 시장BASIS                       StartPos 264, Length 6
        public decimal ibasis{ get; set; } // [float ,  6.2] 이론BASIS                       StartPos 271, Length 6
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 278, Length 12
        public long jnilvalue{ get; set; } // [long  ,   12] 전일거래대금                    StartPos 291, Length 12
    }
}