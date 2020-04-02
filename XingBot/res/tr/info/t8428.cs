using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.info
{
    // 증시주변자금추이 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t8428InBlock
    {
        public string fdate; // [string,    8] from일자                        StartPos 0, Length 8
        public string tdate; // [string,    8] to일자                          StartPos 9, Length 8
        public string gubun; // [string,    1] 구분                            StartPos 18, Length 1
        public string key_date; // [string,    8] 날짜                            StartPos 20, Length 8
        public string upcode; // [string,    3] 업종코드                        StartPos 29, Length 3
        public string cnt; // [string,    3] 조회건수                        StartPos 33, Length 3
    }

    struct _t8428OutBlock
    {
        public string date; // [string,    8] 날짜CTS                         StartPos 0, Length 8
        public long idx; // [long  ,    4] IDX                             StartPos 9, Length 4
    }

    struct _t8428OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public float jisu; // [float ,  7.2] 지수                            StartPos 9, Length 7
        public string sign; // [string,    1] 대비구분                        StartPos 17, Length 1
        public float change; // [float ,  6.2] 대비                            StartPos 19, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 26, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 33, Length 12
        public long custmoney; // [long  ,   12] 고객예탁금_억원                 StartPos 46, Length 12
        public long yecha; // [long  ,   12] 예탁증감_억원                   StartPos 59, Length 12
        public float vol; // [float ,  6.2] 회전율                          StartPos 72, Length 6
        public long outmoney; // [long  ,   12] 미수금_억원                     StartPos 79, Length 12
        public long trjango; // [long  ,   12] 신용잔고_억원                   StartPos 92, Length 12
        public long futymoney; // [long  ,   12] 선물예수금_억원                 StartPos 105, Length 12
        public long stkmoney; // [long  ,    8] 주식형_억원                     StartPos 118, Length 8
        public long mstkmoney; // [long  ,    8] 혼합형_억원(주식)               StartPos 127, Length 8
        public long mbndmoney; // [long  ,    8] 혼합형_억원(채권)               StartPos 136, Length 8
        public long bndmoney; // [long  ,    8] 채권형_억원                     StartPos 145, Length 8
        public long bndsmoney; // [long  ,    8] 필러(구.단기채권)               StartPos 154, Length 8
        public long mmfmoney; // [long  ,    8] MMF_억원(주식)                  StartPos 163, Length 8
    }
}