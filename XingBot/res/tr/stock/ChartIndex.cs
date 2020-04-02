﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 챠트지표데이터조회 ( HEADTYPE=B )
    struct _ChartIndexInBlock
    {
        public long indexid; // [indexid  ,   10] 지표ID                          StartPos 0, Length 10
        public string indexname; // [indexname,   40] 지표명                          StartPos 10, Length 40
        public string indexparam; // [indexparam,   40] 지표조건설정                    StartPos 50, Length 40
        public string market; // [market,    1] 시장구분                        StartPos 90, Length 1
        public string period; // [period,    1] 주기구분                        StartPos 91, Length 1
        public string shcode; // [shcode,    8] 단축코드                        StartPos 92, Length 8
        public long qrycnt; // [qrycnt  ,    4] 요청건수(최대 500개)            StartPos 100, Length 4
        public long ncnt; // [ncnt  ,    4] 단위(n틱/n분)                   StartPos 104, Length 4
        public string sdate; // [sdate,    8] 시작일자                        StartPos 108, Length 8
        public string edate; // [edate,    8] 종료일자                        StartPos 116, Length 8
        public string Isamend; // [Isamend,    1] 수정주가 반영 여부              StartPos 124, Length 1
        public string Isgab; // [Isgab,    1] 갭보정 여부                     StartPos 125, Length 1
        public string IsReal; // [IsReal,    1] 실시간 데이터수신 자동등록 여부 StartPos 126, Length 1
    }

    struct _ChartIndexOutBlock
    {
        public long indexid; // [indexid  ,   10] 지표ID                          StartPos 0, Length 10
        public long rec_cnt; // [rec_cnt  ,    5] 레코드갯수                      StartPos 10, Length 5
        public long validdata_cnt; // [validdata_cnt  ,    2] 유효 데이터 컬럼 갯수           StartPos 15, Length 2
    }

    struct _ChartIndexOutBlock1
    {
        public string date; // [date,    8] 일자                            StartPos 0, Length 8
        public string time; // [time,    6] 시간                            StartPos 8, Length 6
        public float open; // [open ,   10] 시가                            StartPos 14, Length 10
        public float high; // [high ,   10] 고가                            StartPos 24, Length 10
        public float low; // [low ,   10] 저가                            StartPos 34, Length 10
        public float close; // [close ,   10] 종가                            StartPos 44, Length 10
        public float volume; // [volume ,   12] 거래량                          StartPos 54, Length 12
        public float value1; // [value1 ,   10] 지표값1                         StartPos 66, Length 10
        public float value2; // [value2 ,   10] 지표값2                         StartPos 76, Length 10
        public float value3; // [value3 ,   10] 지표값3                         StartPos 86, Length 10
        public float value4; // [value4 ,   10] 지표값4                         StartPos 96, Length 10
        public float value5; // [value5 ,   10] 지표값5                         StartPos 106, Length 10
        public long pos; // [pos  ,    8] 위치                            StartPos 116, Length 8
    }
}