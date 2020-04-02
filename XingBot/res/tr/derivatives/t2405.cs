using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물/옵션 호가잔량 비율 차트 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2405InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string bgubun; // [string,    1] 분구분                          StartPos 9, Length 1
        public string nmin; // [string,    2] N분                             StartPos 11, Length 2
        public string etime; // [string,    4] 종료시간                        StartPos 14, Length 4
        public string hgubun; // [string,    1] 호가구분                        StartPos 19, Length 1
        public string cnt; // [string,    3] 조회건수                        StartPos 21, Length 3
        public string cts_time; // [string,    6] 시간CTS                         StartPos 25, Length 6
    }

    struct _t2405OutBlock
    {
        public double mdvolume; // [double,   12] 매도체결수량                    StartPos 0, Length 12
        public long mdchecnt; // [long  ,    8] 매도체결건수                    StartPos 13, Length 8
        public double msvolume; // [double,   12] 매수체결수량                    StartPos 22, Length 12
        public long mschecnt; // [long  ,    8] 매수체결건수                    StartPos 35, Length 8
        public string cts_time; // [string,    6] 시간CTS                         StartPos 44, Length 6
    }

    struct _t2405OutBlock1
    {
        public string time; // [string,    6] 시간                            StartPos 0, Length 6
        public float price; // [float ,  6.2] 현재가                          StartPos 7, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 14, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 16, Length 6
        public double volume; // [double,   12] 누적거래량                      StartPos 23, Length 12
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 36, Length 8
        public float offerho1; // [float ,  6.2] 매도1호가                       StartPos 45, Length 6
        public float bidho1; // [float ,  6.2] 매수1호가                       StartPos 52, Length 6
        public long offerrem; // [long  ,    8] 매도수량                        StartPos 59, Length 8
        public long bidrem; // [long  ,    8] 매수수량                        StartPos 68, Length 8
        public long offercnt; // [long  ,    8] 매도건수                        StartPos 77, Length 8
        public long bidcnt; // [long  ,    8] 매수건수                        StartPos 86, Length 8
        public long c_offerrem; // [long  ,    8] 매도증감수량                    StartPos 95, Length 8
        public long c_bidrem; // [long  ,    8] 매수증감수량                    StartPos 104, Length 8
        public long c_offercnt; // [long  ,    8] 매도증감건수                    StartPos 113, Length 8
        public long c_bidcnt; // [long  ,    8] 매수증감건수                    StartPos 122, Length 8
        public float r_bidrem; // [float ,  6.2] 매수수량비율                    StartPos 131, Length 6
        public float r_bidcnt; // [float ,  6.2] 매수건수비율                    StartPos 138, Length 6
        public string r_sign; // [string,    1] 매수비율구분                    StartPos 145, Length 1
        public string date; // [string,    8] 일자                            StartPos 147, Length 8
    }
}