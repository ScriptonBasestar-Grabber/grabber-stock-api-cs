using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // EUREX 야간옵션 시간대별체결 조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2832InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public long cvolume; // [long  ,   12] 특이거래량                      StartPos 9, Length 12
        public string stime; // [string,    4] 시작시간                        StartPos 22, Length 4
        public string etime; // [string,    4] 종료시간                        StartPos 27, Length 4
        public string cts_time; // [string,   10] 시간CTS                         StartPos 32, Length 10
    }

    struct _t2832OutBlock
    {
        public string cts_time; // [string,   10] 시간CTS                         StartPos 0, Length 10
    }

    struct _t2832OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public float price; // [float ,  6.2] 현재가                          StartPos 11, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 20, Length 6
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 27, Length 8
        public float chdegree; // [float ,  8.2] 체결강도                        StartPos 36, Length 8
        public float offerho; // [float ,  6.2] 매도호가                        StartPos 45, Length 6
        public float bidho; // [float ,  6.2] 매수호가                        StartPos 52, Length 6
        public double volume; // [double,   12] 거래량                          StartPos 59, Length 12
        public double n_msvolume; // [double,   12] 누적매수체결량                  StartPos 72, Length 12
        public double n_mdvolume; // [double,   12] 누적매도체결량                  StartPos 85, Length 12
        public double s_msvolume; // [double,   12] 누적순매수체결량                StartPos 98, Length 12
        public long n_mschecnt; // [long  ,    8] 누적매수체결건수                StartPos 111, Length 8
        public long n_mdchecnt; // [long  ,    8] 누적매도체결건수                StartPos 120, Length 8
        public long s_mschecnt; // [long  ,    8] 누적순매수체결건수              StartPos 129, Length 8
    }
}