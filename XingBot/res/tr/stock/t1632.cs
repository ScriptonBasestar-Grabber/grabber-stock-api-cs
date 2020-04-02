using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 시간대별 프로그램 매매추이 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1632InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string gubun1; // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun2; // [string,    1] 직전대비증감                    StartPos 4, Length 1
        public string gubun3; // [string,    1] 전일구분                        StartPos 6, Length 1
        public string date; // [string,    8] 일자                            StartPos 8, Length 8
        public string time; // [string,    6] 시간                            StartPos 17, Length 6
    }

    struct _t1632OutBlock
    {
        public string date; // [string,    8] 날짜CTS                         StartPos 0, Length 8
        public string time; // [string,    6] 시간CTS                         StartPos 9, Length 6
        public long idx; // [long  ,    4] IDX                             StartPos 16, Length 4
    }

    struct _t1632OutBlock1
    {
        public string time; // [string,    6] 시간                            StartPos 0, Length 6
        public float k200jisu; // [float ,  6.2] KP200                           StartPos 7, Length 6
        public string sign; // [string,    1] 대비구분                        StartPos 14, Length 1
        public float change; // [float ,  6.2] 대비                            StartPos 16, Length 6
        public float k200basis; // [float ,  6.2] BASIS                           StartPos 23, Length 6
        public long tot3; // [long  ,   12] 전체순매수                      StartPos 30, Length 12
        public long tot1; // [long  ,   12] 전체매수                        StartPos 43, Length 12
        public long tot2; // [long  ,   12] 전체매도                        StartPos 56, Length 12
        public long cha3; // [long  ,   12] 차익순매수                      StartPos 69, Length 12
        public long cha1; // [long  ,   12] 차익매수                        StartPos 82, Length 12
        public long cha2; // [long  ,   12] 차익매도                        StartPos 95, Length 12
        public long bcha3; // [long  ,   12] 비차익순매수                    StartPos 108, Length 12
        public long bcha1; // [long  ,   12] 비차익매수                      StartPos 121, Length 12
        public long bcha2; // [long  ,   12] 비차익매도                      StartPos 134, Length 12
    }
}