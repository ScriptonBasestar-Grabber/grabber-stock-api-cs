namespace XingBot.res
{
    // ELW 현재가(거래원) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1972InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _t1972OutBlock
    {
        public string hname{ get; set; } // [string,   40] 한글명                          StartPos 0, Length 40
        public string expcode{ get; set; } // [string,   12] 표준코드                        StartPos 41, Length 12
        public string shcode{ get; set; } // [string,    9] 단축코드                        StartPos 54, Length 9
        public string offerno1{ get; set; } // [string,    6] 매도증권사코드1                 StartPos 64, Length 6
        public string bidno1{ get; set; } // [string,    6] 매수증권사코드1                 StartPos 71, Length 6
        public long dvol1{ get; set; } // [long  ,   12] 총매도수량1                     StartPos 78, Length 12
        public long svol1{ get; set; } // [long  ,   12] 총매수수량1                     StartPos 91, Length 12
        public long dcha1{ get; set; } // [long  ,   12] 매도증감1                       StartPos 104, Length 12
        public long scha1{ get; set; } // [long  ,   12] 매수증감1                       StartPos 117, Length 12
        public decimal ddiff1{ get; set; } // [float ,  6.2] 매도비율1                       StartPos 130, Length 6
        public decimal sdiff1{ get; set; } // [float ,  6.2] 매수비율1                       StartPos 137, Length 6
        public string offerno2{ get; set; } // [string,    6] 매도증권사코드2                 StartPos 144, Length 6
        public string bidno2{ get; set; } // [string,    6] 매수증권사코드2                 StartPos 151, Length 6
        public long dvol2{ get; set; } // [long  ,   12] 총매도수량2                     StartPos 158, Length 12
        public long svol2{ get; set; } // [long  ,   12] 총매수수량2                     StartPos 171, Length 12
        public long dcha2{ get; set; } // [long  ,   12] 매도증감2                       StartPos 184, Length 12
        public long scha2{ get; set; } // [long  ,   12] 매수증감2                       StartPos 197, Length 12
        public decimal ddiff2{ get; set; } // [float ,  6.2] 매도비율2                       StartPos 210, Length 6
        public decimal sdiff2{ get; set; } // [float ,  6.2] 매수비율2                       StartPos 217, Length 6
        public string offerno3{ get; set; } // [string,    6] 매도증권사코드3                 StartPos 224, Length 6
        public string bidno3{ get; set; } // [string,    6] 매수증권사코드3                 StartPos 231, Length 6
        public long dvol3{ get; set; } // [long  ,   12] 총매도수량3                     StartPos 238, Length 12
        public long svol3{ get; set; } // [long  ,   12] 총매수수량3                     StartPos 251, Length 12
        public long dcha3{ get; set; } // [long  ,   12] 매도증감3                       StartPos 264, Length 12
        public long scha3{ get; set; } // [long  ,   12] 매수증감3                       StartPos 277, Length 12
        public decimal ddiff3{ get; set; } // [float ,  6.2] 매도비율3                       StartPos 290, Length 6
        public decimal sdiff3{ get; set; } // [float ,  6.2] 매수비율3                       StartPos 297, Length 6
        public string offerno4{ get; set; } // [string,    6] 매도증권사코드4                 StartPos 304, Length 6
        public string bidno4{ get; set; } // [string,    6] 매수증권사코드4                 StartPos 311, Length 6
        public long dvol4{ get; set; } // [long  ,   12] 총매도수량4                     StartPos 318, Length 12
        public long svol4{ get; set; } // [long  ,   12] 총매수수량4                     StartPos 331, Length 12
        public long dcha4{ get; set; } // [long  ,   12] 매도증감4                       StartPos 344, Length 12
        public long scha4{ get; set; } // [long  ,   12] 매수증감4                       StartPos 357, Length 12
        public decimal ddiff4{ get; set; } // [float ,  6.2] 매도비율4                       StartPos 370, Length 6
        public decimal sdiff4{ get; set; } // [float ,  6.2] 매수비율4                       StartPos 377, Length 6
        public string offerno5{ get; set; } // [string,    6] 매도증권사코드5                 StartPos 384, Length 6
        public string bidno5{ get; set; } // [string,    6] 매수증권사코드5                 StartPos 391, Length 6
        public long dvol5{ get; set; } // [long  ,   12] 총매도수량5                     StartPos 398, Length 12
        public long svol5{ get; set; } // [long  ,   12] 총매수수량5                     StartPos 411, Length 12
        public long dcha5{ get; set; } // [long  ,   12] 매도증감5                       StartPos 424, Length 12
        public long scha5{ get; set; } // [long  ,   12] 매수증감5                       StartPos 437, Length 12
        public decimal ddiff5{ get; set; } // [float ,  6.2] 매도비율5                       StartPos 450, Length 6
        public decimal sdiff5{ get; set; } // [float ,  6.2] 매수비율5                       StartPos 457, Length 6
        public long fwdvl{ get; set; } // [long  ,   12] 외국계매도합계수량              StartPos 464, Length 12
        public long fwsvl{ get; set; } // [long  ,   12] 외국계매수합계수량              StartPos 477, Length 12
        public long ftradmdcha{ get; set; } // [long  ,   12] 외국계매도직전대비              StartPos 490, Length 12
        public long ftradmscha{ get; set; } // [long  ,   12] 외국계매수직전대비              StartPos 503, Length 12
        public decimal fwddiff{ get; set; } // [float ,  6.2] 외국계매도합계비율              StartPos 516, Length 6
        public decimal fwsdiff{ get; set; } // [float ,  6.2] 외국계매수합계비율              StartPos 523, Length 6
    }
}