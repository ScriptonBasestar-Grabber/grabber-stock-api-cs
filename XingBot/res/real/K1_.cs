namespace XingBot.res
{
    // KOSPI거래원 ( ATTR, KEY=6, GROUP=1 )
    struct _K1__InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    struct _K1__OutBlock
    {
        public string offerno1; // [string,    3] 매도증권사코드1                 StartPos 0, Length 3
        public string bidno1; // [string,    3] 매수증권사코드1                 StartPos 4, Length 3
        public string offertrad1; // [string,    6] 매도회원사명1                   StartPos 8, Length 6
        public string bidtrad1; // [string,    6] 매수회원사명1                   StartPos 15, Length 6
        public long tradmdvol1; // [long  ,   10] 매도거래량1                     StartPos 22, Length 10
        public long tradmsvol1; // [long  ,   10] 매수거래량1                     StartPos 33, Length 10
        public float tradmdrate1; // [float ,  6.2] 매도거래량비중1                 StartPos 44, Length 6
        public float tradmsrate1; // [float ,  6.2] 매도거래량비중1                 StartPos 51, Length 6
        public long tradmdcha1; // [long  ,   10] 매도거래량직전대비1             StartPos 58, Length 10
        public long tradmscha1; // [long  ,   10] 매수거래량직전대비1             StartPos 69, Length 10

        public string offerno2; // [string,    3] 매도증권사코드2                 StartPos 80, Length 3
        public string bidno2; // [string,    3] 매수증권사코드2                 StartPos 84, Length 3
        public string offertrad2; // [string,    6] 매도회원사명2                   StartPos 88, Length 6
        public string bidtrad2; // [string,    6] 매수회원사명2                   StartPos 95, Length 6
        public long tradmdvol2; // [long  ,   10] 매도거래량2                     StartPos 102, Length 10
        public long tradmsvol2; // [long  ,   10] 매수거래량2                     StartPos 113, Length 10
        public float tradmdrate2; // [float ,  6.2] 매도거래량비중2                 StartPos 124, Length 6
        public float tradmsrate2; // [float ,  6.2] 매수거래량비중2                 StartPos 131, Length 6
        public long tradmdcha2; // [long  ,   10] 매도거래량직전대비2             StartPos 138, Length 10
        public long tradmscha2; // [long  ,   10] 매수거래량직전대비2             StartPos 149, Length 10

        public string offerno3; // [string,    3] 매도증권사코드3                 StartPos 160, Length 3
        public string bidno3; // [string,    3] 매수증권사코드3                 StartPos 164, Length 3
        public string offertrad3; // [string,    6] 매도회원사명3                   StartPos 168, Length 6
        public string bidtrad3; // [string,    6] 매수회원사명3                   StartPos 175, Length 6
        public long tradmdvol3; // [long  ,   10] 매도거래량3                     StartPos 182, Length 10
        public long tradmsvol3; // [long  ,   10] 매수거래량3                     StartPos 193, Length 10
        public float tradmdrate3; // [float ,  6.2] 매도거래량비중3                 StartPos 204, Length 6
        public float tradmsrate3; // [float ,  6.2] 매수거래량비중3                 StartPos 211, Length 6
        public long tradmdcha3; // [long  ,   10] 매도거래량직전대비3             StartPos 218, Length 10
        public long tradmscha3; // [long  ,   10] 매수거래량직전대비3             StartPos 229, Length 10

        public string offerno4; // [string,    3] 매도증권사코드4                 StartPos 240, Length 3
        public string bidno4; // [string,    3] 매수증권사코드4                 StartPos 244, Length 3
        public string offertrad4; // [string,    6] 매도회원사명4                   StartPos 248, Length 6
        public string bidtrad4; // [string,    6] 매수회원사명4                   StartPos 255, Length 6
        public long tradmdvol4; // [long  ,   10] 매도거래량4                     StartPos 262, Length 10
        public long tradmsvol4; // [long  ,   10] 매수거래량4                     StartPos 273, Length 10
        public float tradmdrate4; // [float ,  6.2] 매도거래량비중4                 StartPos 284, Length 6
        public float tradmsrate4; // [float ,  6.2] 매수거래량비중4                 StartPos 291, Length 6
        public long tradmdcha4; // [long  ,   10] 매도거래량직전대비4             StartPos 298, Length 10
        public long tradmscha4; // [long  ,   10] 매수거래량직전대비4             StartPos 309, Length 10

        public string offerno5; // [string,    3] 매도증권사코드5                 StartPos 320, Length 3
        public string bidno5; // [string,    3] 매수증권사코드5                 StartPos 324, Length 3
        public string offertrad5; // [string,    6] 매도회원사명5                   StartPos 328, Length 6
        public string bidtrad5; // [string,    6] 매수회원사명5                   StartPos 335, Length 6
        public long tradmdvol5; // [long  ,   10] 매도거래량5                     StartPos 342, Length 10
        public long tradmsvol5; // [long  ,   10] 매수거래량5                     StartPos 353, Length 10
        public float tradmdrate5; // [float ,  6.2] 매도거래량비중5                 StartPos 364, Length 6
        public float tradmsrate5; // [float ,  6.2] 매수거래량비중5                 StartPos 371, Length 6
        public long tradmdcha5; // [long  ,   10] 매도거래량직전대비5             StartPos 378, Length 10
        public long tradmscha5; // [long  ,   10] 매수거래량직전대비5             StartPos 389, Length 10

        public string ftradmdvol; // [string,   10] 외국계증권사매도합계            StartPos 400, Length 10
        public string ftradmsvol; // [string,   10] 외국계증권사매수합계            StartPos 411, Length 10
        public float ftradmdrate; // [float ,  6.2] 외국계증권사매도거래량비중      StartPos 422, Length 6
        public float ftradmsrate; // [float ,  6.2] 외국계증권사매수거래량비중      StartPos 429, Length 6
        public string ftradmdcha; // [string,   10] 외국계증권사매도거래량직전대비  StartPos 436, Length 10
        public string ftradmscha; // [string,   10] 외국계증권사매수거래량직전대비  StartPos 447, Length 10

        public string shcode; // [string,    6] 단축코드                        StartPos 458, Length 6

        public long tradmdval1; // [long  ,   15] 매도거래대금1                   StartPos 465, Length 15
        public long tradmsval1; // [long  ,   15] 매수거래대금1                   StartPos 481, Length 15
        public long tradmdavg1; // [long  ,    7] 매도평균단가1                   StartPos 497, Length 7
        public long tradmsavg1; // [long  ,    7] 매수평균단가1                   StartPos 505, Length 7

        public long tradmdval2; // [long  ,   15] 매도거래대금2                   StartPos 513, Length 15
        public long tradmsval2; // [long  ,   15] 매수거래대금2                   StartPos 529, Length 15
        public long tradmdavg2; // [long  ,    7] 매도평균단가2                   StartPos 545, Length 7
        public long tradmsavg2; // [long  ,    7] 매수평균단가2                   StartPos 553, Length 7

        public long tradmdval3; // [long  ,   15] 매도거래대금3                   StartPos 561, Length 15
        public long tradmsval3; // [long  ,   15] 매수거래대금3                   StartPos 577, Length 15
        public long tradmdavg3; // [long  ,    7] 매도평균단가3                   StartPos 593, Length 7
        public long tradmsavg3; // [long  ,    7] 매수평균단가3                   StartPos 601, Length 7

        public long tradmdval4; // [long  ,   15] 매도거래대금4                   StartPos 609, Length 15
        public long tradmsval4; // [long  ,   15] 매수거래대금4                   StartPos 625, Length 15
        public long tradmdavg4; // [long  ,    7] 매도평균단가4                   StartPos 641, Length 7
        public long tradmsavg4; // [long  ,    7] 매수평균단가4                   StartPos 649, Length 7

        public long tradmdval5; // [long  ,   15] 매도거래대금5                   StartPos 657, Length 15
        public long tradmsval5; // [long  ,   15] 매수거래대금5                   StartPos 673, Length 15
        public long tradmdavg5; // [long  ,    7] 매도평균단가5                   StartPos 689, Length 7
        public long tradmsavg5; // [long  ,    7] 매수평균단가5                   StartPos 697, Length 7

        public long ftradmdval; // [long  ,   15] 외국계증권사매도거래대금        StartPos 705, Length 15
        public long ftradmsval; // [long  ,   15] 외국계증권사매수거래대금        StartPos 721, Length 15
        public long ftradmdavg; // [long  ,    7] 외국계증권사매도평균단가        StartPos 737, Length 7
        public long ftradmsavg; // [long  ,    7] 외국계증권사매수평균단가        StartPos 745, Length 7
    }
}