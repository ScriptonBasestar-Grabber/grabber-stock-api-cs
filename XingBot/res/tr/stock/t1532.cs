using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 종목별테마 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1532InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    struct _t1532OutBlock
    {
        public string tmname; // [string,   36] 테마명                          StartPos 0, Length 36
        public float avgdiff; // [float ,  6.2] 평균등락율                      StartPos 37, Length 6
        public string tmcode; // [string,    4] 테마코드                        StartPos 44, Length 4
    }
}