using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 외인/기관 종목별동향 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1701InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun; // [string,    1] 구분                            StartPos 7, Length 1
        public string fromdt; // [string,    8] 시작일자                        StartPos 9, Length 8
        public string todt; // [string,    8] 종료일자                        StartPos 18, Length 8
        public long prapp; // [long  ,    3] PR적용                          StartPos 27, Length 3
        public string prgubun; // [string,    1] PR적용구분                      StartPos 31, Length 1
        public string orggubun; // [string,    1] 기관적용                        StartPos 33, Length 1
        public string frggubun; // [string,    1] 외인적용                        StartPos 35, Length 1
    }

    struct _t1701OutBlock
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 36, Length 12
        public long psnvolume; // [long  ,   12] 개인                            StartPos 49, Length 12
        public long orgvolume; // [long  ,   12] 기관                            StartPos 62, Length 12
        public long frgvolume; // [long  ,   12] 외국인                          StartPos 75, Length 12
        public long frgvolumesum; // [long  ,   12] 외국계                          StartPos 88, Length 12
        public long pgmvolume; // [long  ,   12] 프로그램                        StartPos 101, Length 12
        public long listing; // [long  ,   12] 보유주식수                      StartPos 114, Length 12
        public long listupdn; // [long  ,   12] 발행증감                        StartPos 127, Length 12
        public float sjrate; // [float ,  6.2] 소진율                          StartPos 140, Length 6
    }
}