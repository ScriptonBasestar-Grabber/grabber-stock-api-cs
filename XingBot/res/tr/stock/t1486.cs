using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 시간대별 예상체결가 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1486InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
        public string cts_time; // [string,   10] 시간CTS                         StartPos 7, Length 10
        public string cnt; // [string,    4] 조회건수                        StartPos 18, Length 4
    }

    struct _t1486OutBlock
    {
        public string cts_time; // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    struct _t1486OutBlock1
    {
        public string chetime; // [string,    8] 시간                            StartPos 0, Length 8
        public long price; // [long  ,    8] 예상체결가                      StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long cvolume; // [long  ,   12] 예상체결량                      StartPos 36, Length 12
        public long offerho1; // [long  ,    8] 매도호가                        StartPos 49, Length 8
        public long bidho1; // [long  ,    8] 매수호가                        StartPos 58, Length 8
        public long offerrem1; // [long  ,   12] 매도잔량                        StartPos 67, Length 12
        public long bidrem1; // [long  ,   12] 매수잔량                        StartPos 80, Length 12
    }
}