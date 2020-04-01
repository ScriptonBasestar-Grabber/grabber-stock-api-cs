using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    // ELW마스터조회 API용 ( BLOCK,HEADTYPE=A )
    struct _t9942InBlock
    {
        public string dummy; // [string,    1] Dummy                           StartPos 0, Length 1
    }

    struct _t9942OutBlock
    {
        public string hname; // [string,   40] 종목명                          StartPos 0, Length 40
        public string shcode; // [string,    6] 단축코드                        StartPos 40, Length 6
        public string expcode; // [string,   12] 확장코드                        StartPos 46, Length 12
    }
}