namespace XingBot.res
{
    // 챠트엑셀데이터조회 ( HEADTYPE=B )
    public class _ChartExcelInBlock
    {
        public long indexid{ get; set; } // [indexid  ,   10] 지표ID                          StartPos 0, Length 10
        public string indexname{ get; set; } // [indexname,   40] 지표명                          StartPos 10, Length 40
        public string indexparam{ get; set; } // [indexparam,   40] 지표조건설정                    StartPos 50, Length 40
        public string indexouttype{ get; set; } // [indexouttype,    1] 결과데이터 구분                 StartPos 90, Length 1
        public string market{ get; set; } // [market,    1] 시장구분                        StartPos 91, Length 1
        public string period{ get; set; } // [period,    1] 주기구분                        StartPos 92, Length 1
        public string shcode{ get; set; } // [shcode,    8] 단축코드                        StartPos 93, Length 8
        public string isexcelout{ get; set; } // [isexcelout,    1] 결과 지표데이터 엑셀표시 여부   StartPos 101, Length 1
        public string excelfilename{ get; set; } // [excelfilename,  256] 엑셀데이터 파일명               StartPos 102, Length 256
        public string IsReal{ get; set; } // [IsReal,    1] 실시간 데이터수신 자동등록 여부 StartPos 358, Length 1
    }

    public class _ChartExcelOutBlock
    {
        public long indexid{ get; set; } // [indexid  ,   10] 지표ID                          StartPos 0, Length 10
        public long rec_cnt{ get; set; } // [rec_cnt  ,    5] 레코드갯수                      StartPos 10, Length 5
        public long validdata_cnt{ get; set; } // [validdata_cnt  ,    2] 유효 데이터 컬럼 갯수           StartPos 15, Length 2
    }

    public class _ChartExcelOutBlock1
    {
        public string date{ get; set; } // [date,    8] 일자                            StartPos 0, Length 8
        public string time{ get; set; } // [time,    6] 시간                            StartPos 8, Length 6
        public decimal open{ get; set; } // [open ,   10] 시가                            StartPos 14, Length 10
        public decimal high{ get; set; } // [high ,   10] 고가                            StartPos 24, Length 10
        public decimal low{ get; set; } // [low ,   10] 저가                            StartPos 34, Length 10
        public decimal close{ get; set; } // [close ,   10] 종가                            StartPos 44, Length 10
        public decimal volume{ get; set; } // [volume ,   12] 거래량                          StartPos 54, Length 12
        public decimal value1{ get; set; } // [value1 ,   10] 지표값1                         StartPos 66, Length 10
        public decimal value2{ get; set; } // [value2 ,   10] 지표값2                         StartPos 76, Length 10
        public decimal value3{ get; set; } // [value3 ,   10] 지표값3                         StartPos 86, Length 10
        public decimal value4{ get; set; } // [value4 ,   10] 지표값4                         StartPos 96, Length 10
        public decimal value5{ get; set; } // [value5 ,   10] 지표값5                         StartPos 106, Length 10
        public long pos{ get; set; } // [pos  ,    8] 위치                            StartPos 116, Length 8
    }
}