namespace XingBot.real.res.tr
{
    // ETF 현재가(시세) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1901InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _t1901OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public decimal volume; // [float ,   12] 누적거래량                      StartPos 48, Length 12
        public long recprice; // [long  ,    8] 기준가                          StartPos 61, Length 8
        public long avg; // [long  ,    8] 가중평균                        StartPos 70, Length 8
        public long uplmtprice; // [long  ,    8] 상한가                          StartPos 79, Length 8
        public long dnlmtprice; // [long  ,    8] 하한가                          StartPos 88, Length 8
        public decimal jnilvolume; // [float ,   12] 전일거래량                      StartPos 97, Length 12
        public long volumediff; // [long  ,   12] 거래량차                        StartPos 110, Length 12
        public long open; // [long  ,    8] 시가                            StartPos 123, Length 8
        public string opentime; // [string,    6] 시가시간                        StartPos 132, Length 6
        public long high; // [long  ,    8] 고가                            StartPos 139, Length 8
        public string hightime; // [string,    6] 고가시간                        StartPos 148, Length 6
        public long low; // [long  ,    8] 저가                            StartPos 155, Length 8
        public string lowtime; // [string,    6] 저가시간                        StartPos 164, Length 6
        public long high52w; // [long  ,    8] 52최고가                        StartPos 171, Length 8
        public string high52wdate; // [string,    8] 52최고가일                      StartPos 180, Length 8
        public long low52w; // [long  ,    8] 52최저가                        StartPos 189, Length 8
        public string low52wdate; // [string,    8] 52최저가일                      StartPos 198, Length 8
        public decimal exhratio; // [float ,  6.2] 소진율                          StartPos 207, Length 6
        public decimal flmtvol; // [float ,   12] 외국인보유수량                  StartPos 214, Length 12
        public decimal per; // [float ,  6.2] PER                             StartPos 227, Length 6
        public long listing; // [long  ,   12] 상장주식수(천)                  StartPos 234, Length 12
        public long jkrate; // [long  ,    8] 증거금율                        StartPos 247, Length 8
        public decimal vol; // [float ,  6.2] 회전율                          StartPos 256, Length 6
        public string shcode; // [string,    6] 단축코드                        StartPos 263, Length 6
        public long value; // [long  ,   12] 누적거래대금                    StartPos 270, Length 12
        public long highyear; // [long  ,    8] 연중최고가                      StartPos 283, Length 8
        public string highyeardate; // [string,    8] 연중최고일자                    StartPos 292, Length 8
        public long lowyear; // [long  ,    8] 연중최저가                      StartPos 301, Length 8
        public string lowyeardate; // [string,    8] 연중최저일자                    StartPos 310, Length 8
        public string upname; // [string,   20] 업종명                          StartPos 319, Length 20
        public string upcode; // [string,    3] 업종코드                        StartPos 340, Length 3
        public decimal upprice; // [float ,  7.2] 업종현재가                      StartPos 344, Length 7
        public string upsign; // [string,    1] 업종전일비구분                  StartPos 352, Length 1
        public decimal upchange; // [float ,  6.2] 업종전일대비                    StartPos 354, Length 6
        public decimal updiff; // [float ,  6.2] 업종등락율                      StartPos 361, Length 6
        public string futname; // [string,   20] 선물최근월물명                  StartPos 368, Length 20
        public string futcode; // [string,    8] 선물최근월물코드                StartPos 389, Length 8
        public decimal futprice; // [float ,  6.2] 선물현재가                      StartPos 398, Length 6
        public string futsign; // [string,    1] 선물전일비구분                  StartPos 405, Length 1
        public decimal futchange; // [float ,  6.2] 선물전일대비                    StartPos 407, Length 6
        public decimal futdiff; // [float ,  6.2] 선물등락율                      StartPos 414, Length 6
        public decimal nav; // [float ,  8.2] NAV                             StartPos 421, Length 8
        public string navsign; // [string,    1] NAV전일대비구분                 StartPos 430, Length 1
        public decimal navchange; // [float ,  8.2] NAV전일대비                     StartPos 432, Length 8
        public decimal navdiff; // [float ,  6.2] NAV등락율                       StartPos 441, Length 6
        public decimal cocrate; // [float ,  6.2] 추적오차율                      StartPos 448, Length 6
        public decimal kasis; // [float ,  6.2] 괴리율                          StartPos 455, Length 6
        public long subprice; // [long  ,   10] 대용가                          StartPos 462, Length 10
        public string offerno1; // [string,    6] 매도증권사코드1                 StartPos 473, Length 6
        public string bidno1; // [string,    6] 매수증권사코드1                 StartPos 480, Length 6
        public long dvol1; // [long  ,    8] 총매도수량1                     StartPos 487, Length 8
        public long svol1; // [long  ,    8] 총매수수량1                     StartPos 496, Length 8
        public long dcha1; // [long  ,    8] 매도증감1                       StartPos 505, Length 8
        public long scha1; // [long  ,    8] 매수증감1                       StartPos 514, Length 8
        public decimal ddiff1; // [float ,  6.2] 매도비율1                       StartPos 523, Length 6
        public decimal sdiff1; // [float ,  6.2] 매수비율1                       StartPos 530, Length 6
        public string offerno2; // [string,    6] 매도증권사코드2                 StartPos 537, Length 6
        public string bidno2; // [string,    6] 매수증권사코드2                 StartPos 544, Length 6
        public long dvol2; // [long  ,    8] 총매도수량2                     StartPos 551, Length 8
        public long svol2; // [long  ,    8] 총매수수량2                     StartPos 560, Length 8
        public long dcha2; // [long  ,    8] 매도증감2                       StartPos 569, Length 8
        public long scha2; // [long  ,    8] 매수증감2                       StartPos 578, Length 8
        public decimal ddiff2; // [float ,  6.2] 매도비율2                       StartPos 587, Length 6
        public decimal sdiff2; // [float ,  6.2] 매수비율2                       StartPos 594, Length 6
        public string offerno3; // [string,    6] 매도증권사코드3                 StartPos 601, Length 6
        public string bidno3; // [string,    6] 매수증권사코드3                 StartPos 608, Length 6
        public long dvol3; // [long  ,    8] 총매도수량3                     StartPos 615, Length 8
        public long svol3; // [long  ,    8] 총매수수량3                     StartPos 624, Length 8
        public long dcha3; // [long  ,    8] 매도증감3                       StartPos 633, Length 8
        public long scha3; // [long  ,    8] 매수증감3                       StartPos 642, Length 8
        public decimal ddiff3; // [float ,  6.2] 매도비율3                       StartPos 651, Length 6
        public decimal sdiff3; // [float ,  6.2] 매수비율3                       StartPos 658, Length 6
        public string offerno4; // [string,    6] 매도증권사코드4                 StartPos 665, Length 6
        public string bidno4; // [string,    6] 매수증권사코드4                 StartPos 672, Length 6
        public long dvol4; // [long  ,    8] 총매도수량4                     StartPos 679, Length 8
        public long svol4; // [long  ,    8] 총매수수량4                     StartPos 688, Length 8
        public long dcha4; // [long  ,    8] 매도증감4                       StartPos 697, Length 8
        public long scha4; // [long  ,    8] 매수증감4                       StartPos 706, Length 8
        public decimal ddiff4; // [float ,  6.2] 매도비율4                       StartPos 715, Length 6
        public decimal sdiff4; // [float ,  6.2] 매수비율4                       StartPos 722, Length 6
        public string offerno5; // [string,    6] 매도증권사코드5                 StartPos 729, Length 6
        public string bidno5; // [string,    6] 매수증권사코드5                 StartPos 736, Length 6
        public long dvol5; // [long  ,    8] 총매도수량5                     StartPos 743, Length 8
        public long svol5; // [long  ,    8] 총매수수량5                     StartPos 752, Length 8
        public long dcha5; // [long  ,    8] 매도증감5                       StartPos 761, Length 8
        public long scha5; // [long  ,    8] 매수증감5                       StartPos 770, Length 8
        public decimal ddiff5; // [float ,  6.2] 매도비율5                       StartPos 779, Length 6
        public decimal sdiff5; // [float ,  6.2] 매수비율5                       StartPos 786, Length 6
        public long fwdvl; // [long  ,   12] 외국계매도합계수량              StartPos 793, Length 12
        public long ftradmdcha; // [long  ,   12] 외국계매도직전대비              StartPos 806, Length 12
        public decimal ftradmddiff; // [float ,  6.2] 외국계매도비율                  StartPos 819, Length 6
        public long fwsvl; // [long  ,   12] 외국계매수합계수량              StartPos 826, Length 12
        public long ftradmscha; // [long  ,   12] 외국계매수직전대비              StartPos 839, Length 12
        public decimal ftradmsdiff; // [float ,  6.2] 외국계매수비율                  StartPos 852, Length 6
        public string upname2; // [string,   20] 참고지수명                      StartPos 859, Length 20
        public string upcode2; // [string,    3] 참고지수코드                    StartPos 880, Length 3
        public decimal upprice2; // [float ,  7.2] 참고지수현재가                  StartPos 884, Length 7
        public decimal jnilnav; // [float ,  8.2] 전일NAV                         StartPos 892, Length 8
        public string jnilnavsign; // [string,    1] 전일NAV전일대비구분             StartPos 901, Length 1
        public decimal jnilnavchange; // [float ,  8.2] 전일NAV전일대비                 StartPos 903, Length 8
        public decimal jnilnavdiff; // [float ,  6.2] 전일NAV등락율                   StartPos 912, Length 6
        public long etftotcap; // [long  ,   12] 순자산총액(억원)                StartPos 919, Length 12
        public decimal spread; // [float ,  6.2] 스프레드                        StartPos 932, Length 6
        public long leverage; // [long  ,    2] 레버리지                        StartPos 939, Length 2
        public string taxgubun; // [string,    1] 과세구분                        StartPos 942, Length 1
        public string opcom_nmk; // [string,   20] 운용사                          StartPos 944, Length 20
        public string lp_nm1; // [string,   20] LP1                             StartPos 965, Length 20
        public string lp_nm2; // [string,   20] LP2                             StartPos 986, Length 20
        public string lp_nm3; // [string,   20] LP3                             StartPos 1007, Length 20
        public string lp_nm4; // [string,   20] LP4                             StartPos 1028, Length 20
        public string lp_nm5; // [string,   20] LP5                             StartPos 1049, Length 20
        public string etf_cp; // [string,   10] 복제방법                        StartPos 1070, Length 10
        public string etf_kind; // [string,   10] 상품유형                        StartPos 1081, Length 10
        public string vi_gubun; // [string,   10] VI발동해제                      StartPos 1092, Length 10
        public string etn_kind_cd; // [string,   20] ETN상품분류                     StartPos 1103, Length 20
        public string lastymd; // [string,    8] ETN만기일                       StartPos 1124, Length 8
        public string payday; // [string,    8] ETN지급일                       StartPos 1133, Length 8
        public string lastdate; // [string,    8] ETN최종거래일                   StartPos 1142, Length 8
        public string issuernmk; // [string,   20] ETN발행시장참가자               StartPos 1151, Length 20
        public string last_sdate; // [string,    8] ETN만기상환가격결정시작일       StartPos 1172, Length 8
        public string last_edate; // [string,    8] ETN만기상환가격결정종료일       StartPos 1181, Length 8
        public string lp_holdvol; // [string,   12] ETNLP보유수량                   StartPos 1190, Length 12
    }
}