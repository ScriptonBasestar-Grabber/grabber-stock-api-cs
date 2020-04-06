namespace XingBot.real.res.tr
{
    // ETF 구성종목조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1904InBlock
    {
        public string shcode; // [string,    6] ETF단축코드                     StartPos 0, Length 6
        public string date; // [string,    8] PDF적용일자                     StartPos 7, Length 8
        public string sgb; // [string,    1] 정렬기준(1:평가금액2:증권수)    StartPos 16, Length 1
    }

    public struct _t1904OutBlock
    {
        public string chk_tday; // [string,    1] 당일구분                        StartPos 0, Length 1
        public string date; // [string,    8] PDF적용일자                     StartPos 2, Length 8
        public long price; // [long  ,    8] ETF현재가                       StartPos 11, Length 8
        public string sign; // [string,    1] ETF전일대비구분                 StartPos 20, Length 1
        public long change; // [long  ,    8] ETF전일대비                     StartPos 22, Length 8
        public decimal diff; // [float ,  6.2] ETF등락율                       StartPos 31, Length 6
        public long volume; // [long  ,   12] ETF누적거래량                   StartPos 38, Length 12
        public decimal nav; // [float ,  8.2] NAV                             StartPos 51, Length 8
        public string navsign; // [string,    1] NAV전일대비구분                 StartPos 60, Length 1
        public decimal navchange; // [float ,  8.2] NAV전일대비                     StartPos 62, Length 8
        public decimal navdiff; // [float ,  6.2] NAV등락율                       StartPos 71, Length 6
        public decimal jnilnav; // [float ,  8.2] 전일NAV                         StartPos 78, Length 8
        public string jnilnavsign; // [string,    1] 전일NAV전일대비구분             StartPos 87, Length 1
        public decimal jnilnavchange; // [float ,  8.2] 전일NAV전일대비                 StartPos 89, Length 8
        public decimal jnilnavdiff; // [float ,  6.2] 전일NAV등락율                   StartPos 98, Length 6
        public string upname; // [string,   20] 업종명                          StartPos 105, Length 20
        public string upcode; // [string,    3] 업종코드                        StartPos 126, Length 3
        public decimal upprice; // [float ,  7.2] 업종현재가                      StartPos 130, Length 7
        public string upsign; // [string,    1] 업종전일비구분                  StartPos 138, Length 1
        public decimal upchange; // [float ,  6.2] 업종전일대비                    StartPos 140, Length 6
        public decimal updiff; // [float ,  6.2] 업종등락율                      StartPos 147, Length 6
        public string futname; // [string,   20] 선물최근월물명                  StartPos 154, Length 20
        public string futcode; // [string,    8] 선물최근월물코드                StartPos 175, Length 8
        public decimal futprice; // [float ,  6.2] 선물현재가                      StartPos 184, Length 6
        public string futsign; // [string,    1] 선물전일비구분                  StartPos 191, Length 1
        public decimal futchange; // [float ,  6.2] 선물전일대비                    StartPos 193, Length 6
        public decimal futdiff; // [float ,  6.2] 선물등락율                      StartPos 200, Length 6
        public string upname2; // [string,   20] 참고지수명                      StartPos 207, Length 20
        public string upcode2; // [string,    3] 참고지수코드                    StartPos 228, Length 3
        public decimal upprice2; // [float ,  7.2] 참고지수현재가                  StartPos 232, Length 7
        public long etftotcap; // [long  ,   12] 순자산총액(단위:억)             StartPos 240, Length 12
        public long etfnum; // [long  ,    4] 구성종목수                      StartPos 253, Length 4
        public long etfcunum; // [long  ,   12] CU주식수                        StartPos 258, Length 12
        public long cash; // [long  ,   12] 현금                            StartPos 271, Length 12
        public string opcom_nmk; // [string,   20] 운용사명                        StartPos 284, Length 20
        public long tot_pval; // [long  ,   12] 전종목평가금액합                StartPos 305, Length 12
        public long tot_sigatval; // [long  ,   12] 전종목구성시가총액합            StartPos 318, Length 12
    }

    public struct _t1904OutBlock1
    {
        public string shcode; // [string,   12] 단축코드                        StartPos 0, Length 12
        public string hname; // [string,   20] 한글명                          StartPos 13, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 34, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 43, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 45, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 54, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 61, Length 12
        public long value; // [long  ,   12] 거래대금(백만)                  StartPos 74, Length 12
        public long icux; // [long  ,   12] 단위증권수(계약수/원화현금/USD?StartPos 87, Length 12
        public long parprice; // [long  ,   12] 액면금액/설정현금액             StartPos 100, Length 12
        public long pvalue; // [long  ,   12] 평가금액                        StartPos 113, Length 12
        public long sigatvalue; // [long  ,   12] 구성시가총액                    StartPos 126, Length 12
        public string profitdate; // [string,    8] PDF적용일자                     StartPos 139, Length 8
        public decimal weight; // [float ,  6.2] 비중(평가금액)                  StartPos 148, Length 6
        public decimal diff2; // [float ,  6.2] ETF종목과등락차                 StartPos 155, Length 6
    }
}