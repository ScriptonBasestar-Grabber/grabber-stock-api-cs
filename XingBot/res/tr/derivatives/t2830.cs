using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // EUREX 야간옵션 시세 조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2830InBlock
    {
        public string focode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    struct _t2830OutBlock
    {
        public string hname; // [string,   20] 한글명                          StartPos 0, Length 20
        public float price; // [float ,  6.2] 현재가                          StartPos 21, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 28, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 30, Length 6
        public float jnilclose; // [float ,  6.2] 전일종가                        StartPos 37, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 44, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 51, Length 12
        public long value; // [long  ,   12] 거래대금                        StartPos 64, Length 12
        public float open; // [float ,  6.2] 시가                            StartPos 77, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 84, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 91, Length 6
        public float recprice; // [float ,  6.2] 기준가                          StartPos 98, Length 6
        public float theoryprice; // [float ,  6.2] 이론가                          StartPos 105, Length 6
        public float actprice; // [float ,  6.2] 행사가                          StartPos 112, Length 6
        public float impv; // [float ,  6.2] 내재가치                        StartPos 119, Length 6
        public float timevl; // [float ,  6.2] 시간가치                        StartPos 126, Length 6
        public float kospijisu; // [float ,  6.2] KOSPI200지수                    StartPos 133, Length 6
        public string kospisign; // [string,    1] KOSPI200전일대비구분            StartPos 140, Length 1
        public float kospichange; // [float ,  6.2] KOSPI200전일대비                StartPos 142, Length 6
        public float kospidiff; // [float ,  6.2] KOSPI200등락율                  StartPos 149, Length 6
        public float cmeprice; // [float ,  6.2] CME야간선물현재가               StartPos 156, Length 6
        public string cmesign; // [string,    1] CME야간선물전일대비구분         StartPos 163, Length 1
        public float cmechange; // [float ,  6.2] CME야간선물전일대비             StartPos 165, Length 6
        public float cmediff; // [float ,  6.2] CME야간선물등락율               StartPos 172, Length 6
        public string cmefocode; // [string,    8] CME야간선물종목코드             StartPos 179, Length 8
        public float uplmtprice; // [float ,  6.2] 정규장적용상한가                StartPos 188, Length 6
        public float dnlmtprice; // [float ,  6.2] 정규장적용하한가                StartPos 195, Length 6
        public string focode; // [string,    8] 단축코드                        StartPos 202, Length 8
        public float yeprice; // [float ,  6.2] 예상체결가                      StartPos 211, Length 6
        public string ysign; // [string,    1] 전일대비구분                    StartPos 218, Length 1
        public float ychange; // [float ,  6.2] 전일대비                        StartPos 220, Length 6
        public float ydiff; // [float ,  6.2] 등락율                          StartPos 227, Length 6
        public string danhochk; // [string,    1] 단일가호가여부                  StartPos 234, Length 1
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 236, Length 12
        public long jnilvalue; // [long  ,   12] 전일거래대금                    StartPos 249, Length 12
        public float uplmtprice_3rd; // [float ,  6.2] 정규장3단계상한가               StartPos 262, Length 6
        public float dnlmtprice_3rd; // [float ,  6.2] 정규장3단계하한가               StartPos 269, Length 6
    }
}