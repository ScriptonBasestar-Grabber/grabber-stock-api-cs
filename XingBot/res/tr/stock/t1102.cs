namespace XingBot.res
{
    // 주식 현재가(시세) 조회 ( ATTR,BLOCK,HEADTYPE=A )

    public class _t1102InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _t1102OutBlock
    {
        public string hname{ get; set; } // [string,   20] 한글명                          StartPos 0, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public long recprice{ get; set; } // [long  ,    8] 기준가(평가가격)                StartPos 61, Length 8
        public long avg{ get; set; } // [long  ,    8] 가중평균                        StartPos 70, Length 8
        public long uplmtprice{ get; set; } // [long  ,    8] 상한가(최고호가가격)            StartPos 79, Length 8
        public long dnlmtprice{ get; set; } // [long  ,    8] 하한가(최저호가가격)            StartPos 88, Length 8
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 97, Length 12
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
        public decimal per{ get; set; } // [float ,  6.2] PER                             StartPos 214, Length 6
        public decimal pbrx{ get; set; } // [float ,  6.2] PBRX                            StartPos 221, Length 6
        public long listing{ get; set; } // [long  ,   12] 상장주식수(천)                  StartPos 228, Length 12
        public long jkrate{ get; set; } // [long  ,    8] 증거금율                        StartPos 241, Length 8
        public string memedan{ get; set; } // [string,    5] 수량단위                        StartPos 250, Length 5
        public string offernocd1{ get; set; } // [string,    3] 매도증권사코드1                 StartPos 256, Length 3
        public string bidnocd1{ get; set; } // [string,    3] 매수증권사코드1                 StartPos 260, Length 3
        public string offerno1{ get; set; } // [string,    6] 매도증권사명1                   StartPos 264, Length 6
        public string bidno1{ get; set; } // [string,    6] 매수증권사명1                   StartPos 271, Length 6
        public long dvol1{ get; set; } // [long  ,    8] 총매도수량1                     StartPos 278, Length 8
        public long svol1{ get; set; } // [long  ,    8] 총매수수량1                     StartPos 287, Length 8
        public long dcha1{ get; set; } // [long  ,    8] 매도증감1                       StartPos 296, Length 8
        public long scha1{ get; set; } // [long  ,    8] 매수증감1                       StartPos 305, Length 8
        public decimal ddiff1{ get; set; } // [float ,  6.2] 매도비율1                       StartPos 314, Length 6
        public decimal sdiff1{ get; set; } // [float ,  6.2] 매수비율1                       StartPos 321, Length 6
        public string offernocd2{ get; set; } // [string,    3] 매도증권사코드2                 StartPos 328, Length 3
        public string bidnocd2{ get; set; } // [string,    3] 매수증권사코드2                 StartPos 332, Length 3
        public string offerno2{ get; set; } // [string,    6] 매도증권사명2                   StartPos 336, Length 6
        public string bidno2{ get; set; } // [string,    6] 매수증권사명2                   StartPos 343, Length 6
        public long dvol2{ get; set; } // [long  ,    8] 총매도수량2                     StartPos 350, Length 8
        public long svol2{ get; set; } // [long  ,    8] 총매수수량2                     StartPos 359, Length 8
        public long dcha2{ get; set; } // [long  ,    8] 매도증감2                       StartPos 368, Length 8
        public long scha2{ get; set; } // [long  ,    8] 매수증감2                       StartPos 377, Length 8
        public decimal ddiff2{ get; set; } // [float ,  6.2] 매도비율2                       StartPos 386, Length 6
        public decimal sdiff2{ get; set; } // [float ,  6.2] 매수비율2                       StartPos 393, Length 6
        public string offernocd3{ get; set; } // [string,    3] 매도증권사코드3                 StartPos 400, Length 3
        public string bidnocd3{ get; set; } // [string,    3] 매수증권사코드3                 StartPos 404, Length 3
        public string offerno3{ get; set; } // [string,    6] 매도증권사명3                   StartPos 408, Length 6
        public string bidno3{ get; set; } // [string,    6] 매수증권사명3                   StartPos 415, Length 6
        public long dvol3{ get; set; } // [long  ,    8] 총매도수량3                     StartPos 422, Length 8
        public long svol3{ get; set; } // [long  ,    8] 총매수수량3                     StartPos 431, Length 8
        public long dcha3{ get; set; } // [long  ,    8] 매도증감3                       StartPos 440, Length 8
        public long scha3{ get; set; } // [long  ,    8] 매수증감3                       StartPos 449, Length 8
        public decimal ddiff3{ get; set; } // [float ,  6.2] 매도비율3                       StartPos 458, Length 6
        public decimal sdiff3{ get; set; } // [float ,  6.2] 매수비율3                       StartPos 465, Length 6
        public string offernocd4{ get; set; } // [string,    3] 매도증권사코드4                 StartPos 472, Length 3
        public string bidnocd4{ get; set; } // [string,    3] 매수증권사코드4                 StartPos 476, Length 3
        public string offerno4{ get; set; } // [string,    6] 매도증권사명4                   StartPos 480, Length 6
        public string bidno4{ get; set; } // [string,    6] 매수증권사명4                   StartPos 487, Length 6
        public long dvol4{ get; set; } // [long  ,    8] 총매도수량4                     StartPos 494, Length 8
        public long svol4{ get; set; } // [long  ,    8] 총매수수량4                     StartPos 503, Length 8
        public long dcha4{ get; set; } // [long  ,    8] 매도증감4                       StartPos 512, Length 8
        public long scha4{ get; set; } // [long  ,    8] 매수증감4                       StartPos 521, Length 8
        public decimal ddiff4{ get; set; } // [float ,  6.2] 매도비율4                       StartPos 530, Length 6
        public decimal sdiff4{ get; set; } // [float ,  6.2] 매수비율4                       StartPos 537, Length 6
        public string offernocd5{ get; set; } // [string,    3] 매도증권사코드5                 StartPos 544, Length 3
        public string bidnocd5{ get; set; } // [string,    3] 매수증권사코드5                 StartPos 548, Length 3
        public string offerno5{ get; set; } // [string,    6] 매도증권사명5                   StartPos 552, Length 6
        public string bidno5{ get; set; } // [string,    6] 매수증권사명5                   StartPos 559, Length 6
        public long dvol5{ get; set; } // [long  ,    8] 총매도수량5                     StartPos 566, Length 8
        public long svol5{ get; set; } // [long  ,    8] 총매수수량5                     StartPos 575, Length 8
        public long dcha5{ get; set; } // [long  ,    8] 매도증감5                       StartPos 584, Length 8
        public long scha5{ get; set; } // [long  ,    8] 매수증감5                       StartPos 593, Length 8
        public decimal ddiff5{ get; set; } // [float ,  6.2] 매도비율5                       StartPos 602, Length 6
        public decimal sdiff5{ get; set; } // [float ,  6.2] 매수비율5                       StartPos 609, Length 6
        public long fwdvl{ get; set; } // [long  ,   12] 외국계매도합계수량              StartPos 616, Length 12
        public long ftradmdcha{ get; set; } // [long  ,   12] 외국계매도직전대비              StartPos 629, Length 12
        public decimal ftradmddiff{ get; set; } // [float ,  6.2] 외국계매도비율                  StartPos 642, Length 6
        public long fwsvl{ get; set; } // [long  ,   12] 외국계매수합계수량              StartPos 649, Length 12
        public long ftradmscha{ get; set; } // [long  ,   12] 외국계매수직전대비              StartPos 662, Length 12
        public decimal ftradmsdiff{ get; set; } // [float ,  6.2] 외국계매수비율                  StartPos 675, Length 6
        public decimal vol{ get; set; } // [float ,  6.2] 회전율                          StartPos 682, Length 6
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 689, Length 6
        public long value{ get; set; } // [long  ,   12] 누적거래대금                    StartPos 696, Length 12
        public long jvolume{ get; set; } // [long  ,   12] 전일동시간거래량                StartPos 709, Length 12
        public long highyear{ get; set; } // [long  ,    8] 연중최고가                      StartPos 722, Length 8
        public string highyeardate{ get; set; } // [string,    8] 연중최고일자                    StartPos 731, Length 8
        public long lowyear{ get; set; } // [long  ,    8] 연중최저가                      StartPos 740, Length 8
        public string lowyeardate{ get; set; } // [string,    8] 연중최저일자                    StartPos 749, Length 8
        public long target{ get; set; } // [long  ,    8] 목표가                          StartPos 758, Length 8
        public long capital{ get; set; } // [long  ,   12] 자본금                          StartPos 767, Length 12
        public long abscnt{ get; set; } // [long  ,   12] 유동주식수                      StartPos 780, Length 12
        public long parprice{ get; set; } // [long  ,    8] 액면가                          StartPos 793, Length 8
        public string gsmm{ get; set; } // [string,    2] 결산월                          StartPos 802, Length 2
        public long subprice{ get; set; } // [long  ,    8] 대용가                          StartPos 805, Length 8
        public long total{ get; set; } // [long  ,   12] 시가총액                        StartPos 814, Length 12
        public string listdate{ get; set; } // [string,    8] 상장일                          StartPos 827, Length 8
        public string name{ get; set; } // [string,   10] 전분기명                        StartPos 836, Length 10
        public long bfsales{ get; set; } // [long  ,   12] 전분기매출액                    StartPos 847, Length 12
        public long bfoperatingincome{ get; set; } // [long  ,   12] 전분기영업이익                  StartPos 860, Length 12
        public long bfordinaryincome{ get; set; } // [long  ,   12] 전분기경상이익                  StartPos 873, Length 12
        public long bfnetincome{ get; set; } // [long  ,   12] 전분기순이익                    StartPos 886, Length 12
        public decimal bfeps{ get; set; } // [float , 13.2] 전분기EPS                       StartPos 899, Length 13
        public string name2{ get; set; } // [string,   10] 전전분기명                      StartPos 913, Length 10
        public long bfsales2{ get; set; } // [long  ,   12] 전전분기매출액                  StartPos 924, Length 12
        public long bfoperatingincome2{ get; set; } // [long  ,   12] 전전분기영업이익                StartPos 937, Length 12
        public long bfordinaryincome2{ get; set; } // [long  ,   12] 전전분기경상이익                StartPos 950, Length 12
        public long bfnetincome2{ get; set; } // [long  ,   12] 전전분기순이익                  StartPos 963, Length 12
        public decimal bfeps2{ get; set; } // [float , 13.2] 전전분기EPS                     StartPos 976, Length 13
        public decimal salert{ get; set; } // [float ,  7.2] 전년대비매출액                  StartPos 990, Length 7
        public decimal opert{ get; set; } // [float ,  7.2] 전년대비영업이익                StartPos 998, Length 7
        public decimal ordrt{ get; set; } // [float ,  7.2] 전년대비경상이익                StartPos 1006, Length 7
        public decimal netrt{ get; set; } // [float ,  7.2] 전년대비순이익                  StartPos 1014, Length 7
        public decimal epsrt{ get; set; } // [float ,  7.2] 전년대비EPS                     StartPos 1022, Length 7
        public string info1{ get; set; } // [string,   10] 락구분                          StartPos 1030, Length 10
        public string info2{ get; set; } // [string,   10] 관리/급등구분                   StartPos 1041, Length 10
        public string info3{ get; set; } // [string,   10] 정지/연장구분                   StartPos 1052, Length 10
        public string info4{ get; set; } // [string,   12] 투자/불성실구분                 StartPos 1063, Length 12
        public string janginfo{ get; set; } // [string,   10] 장구분                          StartPos 1076, Length 10
        public decimal t_per{ get; set; } // [float ,  6.2] T.PER                           StartPos 1087, Length 6
        public string tonghwa{ get; set; } // [string,    3] 통화ISO코드                     StartPos 1094, Length 3
        public long dval1{ get; set; } // [long  ,   18] 총매도대금1                     StartPos 1098, Length 18
        public long sval1{ get; set; } // [long  ,   18] 총매수대금1                     StartPos 1117, Length 18
        public long dval2{ get; set; } // [long  ,   18] 총매도대금2                     StartPos 1136, Length 18
        public long sval2{ get; set; } // [long  ,   18] 총매수대금2                     StartPos 1155, Length 18
        public long dval3{ get; set; } // [long  ,   18] 총매도대금3                     StartPos 1174, Length 18
        public long sval3{ get; set; } // [long  ,   18] 총매수대금3                     StartPos 1193, Length 18
        public long dval4{ get; set; } // [long  ,   18] 총매도대금4                     StartPos 1212, Length 18
        public long sval4{ get; set; } // [long  ,   18] 총매수대금4                     StartPos 1231, Length 18
        public long dval5{ get; set; } // [long  ,   18] 총매도대금5                     StartPos 1250, Length 18
        public long sval5{ get; set; } // [long  ,   18] 총매수대금5                     StartPos 1269, Length 18
        public long davg1{ get; set; } // [long  ,    8] 총매도평단가1                   StartPos 1288, Length 8
        public long savg1{ get; set; } // [long  ,    8] 총매수평단가1                   StartPos 1297, Length 8
        public long davg2{ get; set; } // [long  ,    8] 총매도평단가2                   StartPos 1306, Length 8
        public long savg2{ get; set; } // [long  ,    8] 총매수평단가2                   StartPos 1315, Length 8
        public long davg3{ get; set; } // [long  ,    8] 총매도평단가3                   StartPos 1324, Length 8
        public long savg3{ get; set; } // [long  ,    8] 총매수평단가3                   StartPos 1333, Length 8
        public long davg4{ get; set; } // [long  ,    8] 총매도평단가4                   StartPos 1342, Length 8
        public long savg4{ get; set; } // [long  ,    8] 총매수평단가4                   StartPos 1351, Length 8
        public long davg5{ get; set; } // [long  ,    8] 총매도평단가5                   StartPos 1360, Length 8
        public long savg5{ get; set; } // [long  ,    8] 총매수평단가5                   StartPos 1369, Length 8
        public long ftradmdval{ get; set; } // [long  ,   18] 외국계매도대금                  StartPos 1378, Length 18
        public long ftradmsval{ get; set; } // [long  ,   18] 외국계매수대금                  StartPos 1397, Length 18
        public long ftradmdavg{ get; set; } // [long  ,    8] 외국계매도평단가                StartPos 1416, Length 8
        public long ftradmsavg{ get; set; } // [long  ,    8] 외국계매수평단가                StartPos 1425, Length 8
        public string info5{ get; set; } // [string,    8] 투자주의환기                    StartPos 1434, Length 8
        public string spac_gubun{ get; set; } // [string,    1] 기업인수목적회사여부            StartPos 1443, Length 1
        public long issueprice{ get; set; } // [long  ,    8] 발행가격                        StartPos 1445, Length 8
        public string alloc_gubun{ get; set; } // [string,    1] 배분적용구분코드(1:배분발생2:배 StartPos 1454, Length 1
        public string alloc_text{ get; set; } // [string,    8] 배분적용구분                    StartPos 1456, Length 8
        public string shterm_text{ get; set; } // [string,   10] 단기과열/VI발동                 StartPos 1465, Length 10
        public long svi_uplmtprice{ get; set; } // [long  ,    8] 정적VI상한가                    StartPos 1476, Length 8
        public long svi_dnlmtprice{ get; set; } // [long  ,    8] 정적VI하한가                    StartPos 1485, Length 8
        public string low_lqdt_gu{ get; set; } // [string,    1] 저유동성종목여부                StartPos 1494, Length 1
        public string abnormal_rise_gu{ get; set; } // [string,    1] 이상급등종목여부                StartPos 1496, Length 1
        public string lend_text{ get; set; } // [string,    8] 대차불가표시                    StartPos 1498, Length 8
    }
}