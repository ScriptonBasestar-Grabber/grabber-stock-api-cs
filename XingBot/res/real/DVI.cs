using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////
    // 시간외단일가VI발동해제 ( ATTR, KEY=6, GROUP=1 )
    public struct _DVI_InBlock
    {
        public string shcode; // [string,    6] 단축코드(KEY)                   StartPos 0, Length 6
    }

    public struct _DVI_OutBlock
    {
        public string vi_gubun; // [string,    1] 구분(0:해제 1:정적발동 2:동적발 StartPos 0, Length 1
        public long svi_recprice; // [long  ,    8] 정적VI발동기준가격              StartPos 2, Length 8
        public long dvi_recprice; // [long  ,    8] 동적VI발동기준가격              StartPos 11, Length 8
        public long vi_trgprice; // [long  ,    8] VI발동가격                      StartPos 20, Length 8
        public string shcode; // [string,    6] 단축코드(KEY)                   StartPos 29, Length 6
        public string ref_shcode; // [string,    6] 참조코드(미사용)                StartPos 36, Length 6
        public string time; // [string,    6] 시간                            StartPos 43, Length 6
    }
}