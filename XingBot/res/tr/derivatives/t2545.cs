namespace XingBot.res
{
    // 상품선물투자자매매동향(챠트용) ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2545InBlock
    {
        public string eitem{ get; set; } // [string,    2] 상품ID                          StartPos 0, Length 2
        public string sgubun{ get; set; } // [string,    1] 시장구분                        StartPos 3, Length 1
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 5, Length 3
        public string nmin{ get; set; } // [string,    2] N분                             StartPos 9, Length 2
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 12, Length 3
        public string bgubun{ get; set; } // [string,    1] 전일분                          StartPos 16, Length 1
    }

    public class _t2545OutBlock
    {
        public string eitem{ get; set; } // [string,    2] 상품ID                          StartPos 0, Length 2
        public string sgubun{ get; set; } // [string,    1] 시장구분                        StartPos 3, Length 1
        public string indcode{ get; set; } // [string,    4] 개인투자자코드                  StartPos 5, Length 4
        public string forcode{ get; set; } // [string,    4] 외국인투자자코드                StartPos 10, Length 4
        public string syscode{ get; set; } // [string,    4] 기관계투자자코드                StartPos 15, Length 4
        public string stocode{ get; set; } // [string,    4] 증권투자자코드                  StartPos 20, Length 4
        public string invcode{ get; set; } // [string,    4] 투신투자자코드                  StartPos 25, Length 4
        public string bancode{ get; set; } // [string,    4] 은행투자자코드                  StartPos 30, Length 4
        public string inscode{ get; set; } // [string,    4] 보험투자자코드                  StartPos 35, Length 4
        public string fincode{ get; set; } // [string,    4] 종금투자자코드                  StartPos 40, Length 4
        public string moncode{ get; set; } // [string,    4] 기금투자자코드                  StartPos 45, Length 4
        public string etccode{ get; set; } // [string,    4] 기타투자자코드                  StartPos 50, Length 4
        public string natcode{ get; set; } // [string,    4] 국가투자자코드                  StartPos 55, Length 4
        public string pefcode{ get; set; } // [string,    4] 사모펀드투자자코드              StartPos 60, Length 4
        public string jisucd{ get; set; } // [string,    8] 기준지수코드                    StartPos 65, Length 8
        public string jisunm{ get; set; } // [string,   20] 기준지수명                      StartPos 74, Length 20
    }

    public class _t2545OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public string datetime{ get; set; } // [string,   14] 일자시간                        StartPos 16, Length 14
        public long indmsvol{ get; set; } // [long  ,    8] 개인순매수거래량                StartPos 31, Length 8
        public decimal indmsamt{ get; set; } // [double,   12] 개인순매수거래대금              StartPos 40, Length 12
        public long formsvol{ get; set; } // [long  ,    8] 외국인순매수거래량              StartPos 53, Length 8
        public decimal formsamt{ get; set; } // [double,   12] 외국인순매수거래대금            StartPos 62, Length 12
        public long sysmsvol{ get; set; } // [long  ,    8] 기관계순매수거래량              StartPos 75, Length 8
        public decimal sysmsamt{ get; set; } // [double,   12] 기관계순매수거래대금            StartPos 84, Length 12
        public long stomsvol{ get; set; } // [long  ,    8] 증권순매수거래량                StartPos 97, Length 8
        public decimal stomsamt{ get; set; } // [double,   12] 증권순매수거래대금              StartPos 106, Length 12
        public long invmsvol{ get; set; } // [long  ,    8] 투신순매수거래량                StartPos 119, Length 8
        public decimal invmsamt{ get; set; } // [double,   12] 투신순매수거래대금              StartPos 128, Length 12
        public long banmsvol{ get; set; } // [long  ,    8] 은행순매수거래량                StartPos 141, Length 8
        public decimal banmsamt{ get; set; } // [double,   12] 은행순매수거래대금              StartPos 150, Length 12
        public long insmsvol{ get; set; } // [long  ,    8] 보험순매수거래량                StartPos 163, Length 8
        public decimal insmsamt{ get; set; } // [double,   12] 보험순매수거래대금              StartPos 172, Length 12
        public long finmsvol{ get; set; } // [long  ,    8] 종금순매수거래량                StartPos 185, Length 8
        public decimal finmsamt{ get; set; } // [double,   12] 종금순매수거래대금              StartPos 194, Length 12
        public long monmsvol{ get; set; } // [long  ,    8] 기금순매수거래량                StartPos 207, Length 8
        public decimal monmsamt{ get; set; } // [double,   12] 기금순매수거래대금              StartPos 216, Length 12
        public long etcmsvol{ get; set; } // [long  ,    8] 기타순매수거래량                StartPos 229, Length 8
        public decimal etcmsamt{ get; set; } // [double,   12] 기타순매수거래대금              StartPos 238, Length 12
        public long natmsvol{ get; set; } // [long  ,    8] 국가순매수거래량                StartPos 251, Length 8
        public decimal natmsamt{ get; set; } // [double,   12] 국가순매수거래대금              StartPos 260, Length 12
        public long pefmsvol{ get; set; } // [long  ,    8] 사모펀드순매수거래량            StartPos 273, Length 8
        public decimal pefmsamt{ get; set; } // [double,   12] 사모펀드순매수거래대금          StartPos 282, Length 12
        public decimal upclose{ get; set; } // [float ,  6.2] 기준지수                        StartPos 295, Length 6
        public long upcvolume{ get; set; } // [long  ,    8] 기준체결거래량                  StartPos 302, Length 8
        public decimal upvolume{ get; set; } // [double,   12] 기준누적거래량                  StartPos 311, Length 12
        public decimal upvalue{ get; set; } // [double,   12] 기준거래대금                    StartPos 324, Length 12
    }
}