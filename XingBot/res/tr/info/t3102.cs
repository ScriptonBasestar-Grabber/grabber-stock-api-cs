using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.info
{
    // 뉴스본문 ( BLOCK,HEADTYPE=A )
    struct _t3102InBlock
    {
        public string sNewsno; // [string,   24] 뉴스번호                        StartPos 0, Length 24
    }

    struct _t3102OutBlock
    {
        public string sJongcode; // [string,    6] 뉴스종목                        StartPos 0, Length 6
    }

    struct _t3102OutBlock1
    {
        public string sBody; // [string,  100] 뉴스본문                        StartPos 0, Length 100
    }

    struct _t3102OutBlock2
    {
        public string sTitle; // [string,  300] 뉴스타이틀                      StartPos 0, Length 300
    }
}