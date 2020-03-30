using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    // 테마전체조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t8425InBlock
    {
        public string dummy; // [string,    1] Dummy                           StartPos 0, Length 1
    }

    struct _t8425OutBlock
    {
        public string tmname; // [string,   36] 테마명                          StartPos 0, Length 36
        public string tmcode; // [string,    4] 테마코드                        StartPos 37, Length 4
    }
}