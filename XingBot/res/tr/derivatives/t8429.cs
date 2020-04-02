using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // EUREX야간옵션선물틱분별체결조회챠트 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t8429InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
        public string cgubun; // [string,    1] 챠트구분                        StartPos 9, Length 1
        public string bgubun; // [string,    3] 분구분                          StartPos 11, Length 3
        public string cnt; // [string,    3] 조회건수                        StartPos 15, Length 3
    }

    struct _t8429OutBlock1
    {
        public string chetime; // [string,   10] 시간                            StartPos 0, Length 10
        public float price; // [float ,  6.2] 현재가                          StartPos 11, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 20, Length 6
        public float open; // [float ,  6.2] 시가                            StartPos 27, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 34, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 41, Length 6
        public double volume; // [double,   12] 거래량                          StartPos 48, Length 12
        public long cvolume; // [long  ,    8] 체결수량                        StartPos 61, Length 8
        public long s_mschecnt; // [long  ,    8] 매수순간체결건수                StartPos 70, Length 8
        public long s_mdchecnt; // [long  ,    8] 매도순간체결건수                StartPos 79, Length 8
        public long ss_mschecnt; // [long  ,    8] 순매수순간체결건수              StartPos 88, Length 8
        public double s_mschevol; // [double,   12] 매수순간체결량                  StartPos 97, Length 12
        public double s_mdchevol; // [double,   12] 매도순간체결량                  StartPos 110, Length 12
        public double ss_mschevol; // [double,   12] 순매수순간체결량                StartPos 123, Length 12
        public float chdegvol; // [float ,  8.2] 체결강도(거래량)                StartPos 136, Length 8
        public float chdegcnt; // [float ,  8.2] 체결강도(건수)                  StartPos 145, Length 8
    }
}