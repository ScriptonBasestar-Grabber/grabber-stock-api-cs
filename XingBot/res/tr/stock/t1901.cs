namespace XingBot.res
{
    // ETF 현재가(시세) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1901InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _t1901OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public decimal volume{ get; set; } // [float ,   12] 누적거래량                      StartPos 48, Length 12
        public long recprice{ get; set; } // [long  ,    8] 기준가                          StartPos 61, Length 8
        public long avg{ get; set; } // [long  ,    8] 가중평균                        StartPos 70, Length 8
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가                          StartPos 79, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가                          StartPos 88, Length 8
        public decimal jnilvolume{ get; set; } // [float ,   12] 전일거래량                      StartPos 97, Length 12
        public long volumediff{ get; set; } // [long  ,   12] 거래량차                        StartPos 110, Length 12
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 123, Length 8
        public string opentime{ get; set; } // [string,    6] 시가시간                        StartPos 132, Length 6
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 139, Length 8
        public string hightime{ get; set; } // [string,    6] 고가시간                        StartPos 148, Length 6
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 155, Length 8
        public string lowtime{ get; set; } // [string,    6] 저가시간                        StartPos 164, Length 6
        public long high52w{ get; set; } // [long  ,    8] 52최고가                        StartPos 171, Length 8
        public string high52wdate{ get; set; } // [string,    8] 52최고가일                      StartPos 180, Length 8
        public long low52w{ get; set; } // [long  ,    8] 52최저가                        StartPos 189, Length 8
        public string low52wdate{ get; set; } // [string,    8] 52최저가일                      StartPos 198, Length 8
        public decimal exhratio{ get; set; } // [float ,  6.2] 소진율                          StartPos 207, Length 6
        public decimal flmtvol{ get; set; } // [float ,   12] 외국인보유수량                  StartPos 214, Length 12
        public decimal per{ get; set; } // [float ,  6.2] PER                             StartPos 227, Length 6
        public long listing{ get; set; } // [long  ,   12] 상장주식수(천)                  StartPos 234, Length 12
        public long jkrate{ get; set; } // [long  ,    8] 증거금율                        StartPos 247, Length 8
        public decimal vol{ get; set; } // [float ,  6.2] 회전율                          StartPos 256, Length 6
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 263, Length 6
        public long value{ get; set; } // [long  ,   12] 누적거래대금                    StartPos 270, Length 12
        public long highyear{ get; set; } // [long  ,    8] 연중최고가                      StartPos 283, Length 8
        public string highyeardate{ get; set; } // [string,    8] 연중최고일자                    StartPos 292, Length 8
        public long lowyear{ get; set; } // [long  ,    8] 연중최저가                      StartPos 301, Length 8
        public string lowyeardate{ get; set; } // [string,    8] 연중최저일자                    StartPos 310, Length 8
        public string upname{ get; set; } // [string,   20] 업종명                          StartPos 319, Length 20
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 340, Length 3
        public decimal upprice{ get; set; } // [float ,  7.2] 업종현재가                      StartPos 344, Length 7
        public string upsign{ get; set; } // [string,    1] 업종전일비구분                  StartPos 352, Length 1
        public decimal upchange{ get; set; } // [float ,  6.2] 업종전일대비                    StartPos 354, Length 6
        public decimal updiff{ get; set; } // [float ,  6.2] 업종등락율                      StartPos 361, Length 6
        public string futname{ get; set; } // [string,   20] 선물최근월물명                  StartPos 368, Length 20
        public string futcode{ get; set; } // [string,    8] 선물최근월물코드                StartPos 389, Length 8
        public decimal futprice{ get; set; } // [float ,  6.2] 선물현재가                      StartPos 398, Length 6
        public string futsign{ get; set; } // [string,    1] 선물전일비구분                  StartPos 405, Length 1
        public decimal futchange{ get; set; } // [float ,  6.2] 선물전일대비                    StartPos 407, Length 6
        public decimal futdiff{ get; set; } // [float ,  6.2] 선물등락율                      StartPos 414, Length 6
        public decimal nav{ get; set; } // [float ,  8.2] NAV                             StartPos 421, Length 8
        public string navsign{ get; set; } // [string,    1] NAV전일대비구분                 StartPos 430, Length 1
        public decimal navchange{ get; set; } // [float ,  8.2] NAV전일대비                     StartPos 432, Length 8
        public decimal navdiff{ get; set; } // [float ,  6.2] NAV등락율                       StartPos 441, Length 6
        public decimal cocrate{ get; set; } // [float ,  6.2] 추적오차율                      StartPos 448, Length 6
        public decimal kasis{ get; set; } // [float ,  6.2] 괴리율                          StartPos 455, Length 6
        public long subprice{ get; set; } // [long  ,   10] 대용가                          StartPos 462, Length 10
        public string offerno1{ get; set; } // [string,    6] 매도증권사코드1                 StartPos 473, Length 6
        public string bidno1{ get; set; } // [string,    6] 매수증권사코드1                 StartPos 480, Length 6
        public long dvol1{ get; set; } // [long  ,    8] 총매도수량1                     StartPos 487, Length 8
        public long svol1{ get; set; } // [long  ,    8] 총매수수량1                     StartPos 496, Length 8
        public long dcha1{ get; set; } // [long  ,    8] 매도증감1                       StartPos 505, Length 8
        public long scha1{ get; set; } // [long  ,    8] 매수증감1                       StartPos 514, Length 8
        public decimal ddiff1{ get; set; } // [float ,  6.2] 매도비율1                       StartPos 523, Length 6
        public decimal sdiff1{ get; set; } // [float ,  6.2] 매수비율1                       StartPos 530, Length 6
        public string offerno2{ get; set; } // [string,    6] 매도증권사코드2                 StartPos 537, Length 6
        public string bidno2{ get; set; } // [string,    6] 매수증권사코드2                 StartPos 544, Length 6
        public long dvol2{ get; set; } // [long  ,    8] 총매도수량2                     StartPos 551, Length 8
        public long svol2{ get; set; } // [long  ,    8] 총매수수량2                     StartPos 560, Length 8
        public long dcha2{ get; set; } // [long  ,    8] 매도증감2                       StartPos 569, Length 8
        public long scha2{ get; set; } // [long  ,    8] 매수증감2                       StartPos 578, Length 8
        public decimal ddiff2{ get; set; } // [float ,  6.2] 매도비율2                       StartPos 587, Length 6
        public decimal sdiff2{ get; set; } // [float ,  6.2] 매수비율2                       StartPos 594, Length 6
        public string offerno3{ get; set; } // [string,    6] 매도증권사코드3                 StartPos 601, Length 6
        public string bidno3{ get; set; } // [string,    6] 매수증권사코드3                 StartPos 608, Length 6
        public long dvol3{ get; set; } // [long  ,    8] 총매도수량3                     StartPos 615, Length 8
        public long svol3{ get; set; } // [long  ,    8] 총매수수량3                     StartPos 624, Length 8
        public long dcha3{ get; set; } // [long  ,    8] 매도증감3                       StartPos 633, Length 8
        public long scha3{ get; set; } // [long  ,    8] 매수증감3                       StartPos 642, Length 8
        public decimal ddiff3{ get; set; } // [float ,  6.2] 매도비율3                       StartPos 651, Length 6
        public decimal sdiff3{ get; set; } // [float ,  6.2] 매수비율3                       StartPos 658, Length 6
        public string offerno4{ get; set; } // [string,    6] 매도증권사코드4                 StartPos 665, Length 6
        public string bidno4{ get; set; } // [string,    6] 매수증권사코드4                 StartPos 672, Length 6
        public long dvol4{ get; set; } // [long  ,    8] 총매도수량4                     StartPos 679, Length 8
        public long svol4{ get; set; } // [long  ,    8] 총매수수량4                     StartPos 688, Length 8
        public long dcha4{ get; set; } // [long  ,    8] 매도증감4                       StartPos 697, Length 8
        public long scha4{ get; set; } // [long  ,    8] 매수증감4                       StartPos 706, Length 8
        public decimal ddiff4{ get; set; } // [float ,  6.2] 매도비율4                       StartPos 715, Length 6
        public decimal sdiff4{ get; set; } // [float ,  6.2] 매수비율4                       StartPos 722, Length 6
        public string offerno5{ get; set; } // [string,    6] 매도증권사코드5                 StartPos 729, Length 6
        public string bidno5{ get; set; } // [string,    6] 매수증권사코드5                 StartPos 736, Length 6
        public long dvol5{ get; set; } // [long  ,    8] 총매도수량5                     StartPos 743, Length 8
        public long svol5{ get; set; } // [long  ,    8] 총매수수량5                     StartPos 752, Length 8
        public long dcha5{ get; set; } // [long  ,    8] 매도증감5                       StartPos 761, Length 8
        public long scha5{ get; set; } // [long  ,    8] 매수증감5                       StartPos 770, Length 8
        public decimal ddiff5{ get; set; } // [float ,  6.2] 매도비율5                       StartPos 779, Length 6
        public decimal sdiff5{ get; set; } // [float ,  6.2] 매수비율5                       StartPos 786, Length 6
        public long fwdvl{ get; set; } // [long  ,   12] 외국계매도합계수량              StartPos 793, Length 12
        public long ftradmdcha{ get; set; } // [long  ,   12] 외국계매도직전대비              StartPos 806, Length 12
        public decimal ftradmddiff{ get; set; } // [float ,  6.2] 외국계매도비율                  StartPos 819, Length 6
        public long fwsvl{ get; set; } // [long  ,   12] 외국계매수합계수량              StartPos 826, Length 12
        public long ftradmscha{ get; set; } // [long  ,   12] 외국계매수직전대비              StartPos 839, Length 12
        public decimal ftradmsdiff{ get; set; } // [float ,  6.2] 외국계매수비율                  StartPos 852, Length 6
        public string upname2{ get; set; } // [string,   20] 참고지수명                      StartPos 859, Length 20
        public string upcode2{ get; set; } // [string,    3] 참고지수코드                    StartPos 880, Length 3
        public decimal upprice2{ get; set; } // [float ,  7.2] 참고지수현재가                  StartPos 884, Length 7
        public decimal jnilnav{ get; set; } // [float ,  8.2] 전일NAV                         StartPos 892, Length 8
        public string jnilnavsign{ get; set; } // [string,    1] 전일NAV전일대비구분             StartPos 901, Length 1
        public decimal jnilnavchange{ get; set; } // [float ,  8.2] 전일NAV전일대비                 StartPos 903, Length 8
        public decimal jnilnavdiff{ get; set; } // [float ,  6.2] 전일NAV등락율                   StartPos 912, Length 6
        public long etftotcap{ get; set; } // [long  ,   12] 순자산총액(억원)                StartPos 919, Length 12
        public decimal spread{ get; set; } // [float ,  6.2] 스프레드                        StartPos 932, Length 6
        public long leverage{ get; set; } // [long  ,    2] 레버리지                        StartPos 939, Length 2
        public string taxgubun{ get; set; } // [string,    1] 과세구분                        StartPos 942, Length 1
        public string opcom_nmk{ get; set; } // [string,   20] 운용사                          StartPos 944, Length 20
        public string lp_nm1{ get; set; } // [string,   20] LP1                             StartPos 965, Length 20
        public string lp_nm2{ get; set; } // [string,   20] LP2                             StartPos 986, Length 20
        public string lp_nm3{ get; set; } // [string,   20] LP3                             StartPos 1007, Length 20
        public string lp_nm4{ get; set; } // [string,   20] LP4                             StartPos 1028, Length 20
        public string lp_nm5{ get; set; } // [string,   20] LP5                             StartPos 1049, Length 20
        public string etf_cp{ get; set; } // [string,   10] 복제방법                        StartPos 1070, Length 10
        public string etf_kind{ get; set; } // [string,   10] 상품유형                        StartPos 1081, Length 10
        public string vi_gubun{ get; set; } // [string,   10] VI발동해제                      StartPos 1092, Length 10
        public string etn_kind_cd{ get; set; } // [string,   20] ETN상품분류                     StartPos 1103, Length 20
        public string lastymd{ get; set; } // [string,    8] ETN만기일                       StartPos 1124, Length 8
        public string payday{ get; set; } // [string,    8] ETN지급일                       StartPos 1133, Length 8
        public string lastdate{ get; set; } // [string,    8] ETN최종거래일                   StartPos 1142, Length 8
        public string issuernmk{ get; set; } // [string,   20] ETN발행시장참가자               StartPos 1151, Length 20
        public string last_sdate{ get; set; } // [string,    8] ETN만기상환가격결정시작일       StartPos 1172, Length 8
        public string last_edate{ get; set; } // [string,    8] ETN만기상환가격결정종료일       StartPos 1181, Length 8
        public string lp_holdvol{ get; set; } // [string,   12] ETNLP보유수량                   StartPos 1190, Length 12
    }
}