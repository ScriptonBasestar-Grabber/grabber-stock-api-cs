using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 투자경고/매매정지/정리매매조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1405InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string jongchk; // [string,    1] 종목체크                        StartPos 2, Length 1
        public string cts_shcode; // [string,    6] 종목코드_CTS                    StartPos 4, Length 6
    }

    struct _t1405OutBlock
    {
        public string cts_shcode; // [string,    6] 종목코드_CTS                    StartPos 0, Length 6
    }

    struct _t1405OutBlock1
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 21, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 30, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 32, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 41, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 48, Length 12
        public string date; // [string,    8] 지정일                          StartPos 61, Length 8
        public string edate; // [string,    8] 해제일                          StartPos 70, Length 8
        public string shcode; // [string,    6] 종목코드                        StartPos 79, Length 6
    }
}