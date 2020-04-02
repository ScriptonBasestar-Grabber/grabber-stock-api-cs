using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 상품선물 마스터 조회 ( BLOCK,HEADTYPE=A )
    struct _t8426InBlock
    {
        public string dummy; // [string,    1] Dummy                           StartPos 0, Length 1
    }

    struct _t8426OutBlock
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode; // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode; // [string,   12] 확장코드                        StartPos 28, Length 12
    }
}