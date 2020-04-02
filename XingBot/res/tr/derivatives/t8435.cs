using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 파생종목마스터조회API용 ( BLOCK,HEADTYPE=A )
    struct _t8435InBlock
    {
        public string gubun; // [string,    2] 구분(MF/MO)                     StartPos 0, Length 2
    }

    struct _t8435OutBlock
    {
        public string hname; // [string,   20] 종목명                          StartPos 0, Length 20
        public string shcode; // [string,    8] 단축코드                        StartPos 20, Length 8
        public string expcode; // [string,   12] 확장코드                        StartPos 28, Length 12
        public float uplmtprice; // [float ,  6.2] 상한가                          StartPos 40, Length 6
        public float dnlmtprice; // [float ,  6.2] 하한가                          StartPos 46, Length 6
        public float jnilclose; // [float ,  6.2] 전일종가                        StartPos 52, Length 6
        public float jnilhigh; // [float ,  6.2] 전일고가                        StartPos 58, Length 6
        public float jnillow; // [float ,  6.2] 전일저가                        StartPos 64, Length 6
        public float recprice; // [float ,  6.2] 기준가                          StartPos 70, Length 6
    }
}