using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.elw
{
    // ELW 현재가(거래원) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1972InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    struct _t1972OutBlock
    {
        public string hname; // [string,   40] 한글명                          StartPos 0, Length 40
        public string expcode; // [string,   12] 표준코드                        StartPos 41, Length 12
        public string shcode; // [string,    9] 단축코드                        StartPos 54, Length 9
        public string offerno1; // [string,    6] 매도증권사코드1                 StartPos 64, Length 6
        public string bidno1; // [string,    6] 매수증권사코드1                 StartPos 71, Length 6
        public long dvol1; // [long  ,   12] 총매도수량1                     StartPos 78, Length 12
        public long svol1; // [long  ,   12] 총매수수량1                     StartPos 91, Length 12
        public long dcha1; // [long  ,   12] 매도증감1                       StartPos 104, Length 12
        public long scha1; // [long  ,   12] 매수증감1                       StartPos 117, Length 12
        public float ddiff1; // [float ,  6.2] 매도비율1                       StartPos 130, Length 6
        public float sdiff1; // [float ,  6.2] 매수비율1                       StartPos 137, Length 6
        public string offerno2; // [string,    6] 매도증권사코드2                 StartPos 144, Length 6
        public string bidno2; // [string,    6] 매수증권사코드2                 StartPos 151, Length 6
        public long dvol2; // [long  ,   12] 총매도수량2                     StartPos 158, Length 12
        public long svol2; // [long  ,   12] 총매수수량2                     StartPos 171, Length 12
        public long dcha2; // [long  ,   12] 매도증감2                       StartPos 184, Length 12
        public long scha2; // [long  ,   12] 매수증감2                       StartPos 197, Length 12
        public float ddiff2; // [float ,  6.2] 매도비율2                       StartPos 210, Length 6
        public float sdiff2; // [float ,  6.2] 매수비율2                       StartPos 217, Length 6
        public string offerno3; // [string,    6] 매도증권사코드3                 StartPos 224, Length 6
        public string bidno3; // [string,    6] 매수증권사코드3                 StartPos 231, Length 6
        public long dvol3; // [long  ,   12] 총매도수량3                     StartPos 238, Length 12
        public long svol3; // [long  ,   12] 총매수수량3                     StartPos 251, Length 12
        public long dcha3; // [long  ,   12] 매도증감3                       StartPos 264, Length 12
        public long scha3; // [long  ,   12] 매수증감3                       StartPos 277, Length 12
        public float ddiff3; // [float ,  6.2] 매도비율3                       StartPos 290, Length 6
        public float sdiff3; // [float ,  6.2] 매수비율3                       StartPos 297, Length 6
        public string offerno4; // [string,    6] 매도증권사코드4                 StartPos 304, Length 6
        public string bidno4; // [string,    6] 매수증권사코드4                 StartPos 311, Length 6
        public long dvol4; // [long  ,   12] 총매도수량4                     StartPos 318, Length 12
        public long svol4; // [long  ,   12] 총매수수량4                     StartPos 331, Length 12
        public long dcha4; // [long  ,   12] 매도증감4                       StartPos 344, Length 12
        public long scha4; // [long  ,   12] 매수증감4                       StartPos 357, Length 12
        public float ddiff4; // [float ,  6.2] 매도비율4                       StartPos 370, Length 6
        public float sdiff4; // [float ,  6.2] 매수비율4                       StartPos 377, Length 6
        public string offerno5; // [string,    6] 매도증권사코드5                 StartPos 384, Length 6
        public string bidno5; // [string,    6] 매수증권사코드5                 StartPos 391, Length 6
        public long dvol5; // [long  ,   12] 총매도수량5                     StartPos 398, Length 12
        public long svol5; // [long  ,   12] 총매수수량5                     StartPos 411, Length 12
        public long dcha5; // [long  ,   12] 매도증감5                       StartPos 424, Length 12
        public long scha5; // [long  ,   12] 매수증감5                       StartPos 437, Length 12
        public float ddiff5; // [float ,  6.2] 매도비율5                       StartPos 450, Length 6
        public float sdiff5; // [float ,  6.2] 매수비율5                       StartPos 457, Length 6
        public long fwdvl; // [long  ,   12] 외국계매도합계수량              StartPos 464, Length 12
        public long fwsvl; // [long  ,   12] 외국계매수합계수량              StartPos 477, Length 12
        public long ftradmdcha; // [long  ,   12] 외국계매도직전대비              StartPos 490, Length 12
        public long ftradmscha; // [long  ,   12] 외국계매수직전대비              StartPos 503, Length 12
        public float fwddiff; // [float ,  6.2] 외국계매도합계비율              StartPos 516, Length 6
        public float fwsdiff; // [float ,  6.2] 외국계매수합계비율              StartPos 523, Length 6
    }
}