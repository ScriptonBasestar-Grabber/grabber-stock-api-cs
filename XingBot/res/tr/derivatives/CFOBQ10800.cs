namespace XingBot.res
{
    // 선물옵션 옵션매도시 주문증거금조회 ( SERVICE=CFOBQ10800,HEADTYPE=B,CREATOR=원종혁,CREDATE=2019/08/01 10:51:29 )
    public class _CFOBQ10800InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string PrdgrpClssCode{ get; set; } // [PrdgrpClssCode,    2] 상품군코드                      StartPos 5, Length 2
        public string ClssGrpCode{ get; set; } // [ClssGrpCode,    3] 기초자산코드                    StartPos 7, Length 3
        public string BaseYear{ get; set; } // [BaseYear,    4] 기준연도                        StartPos 10, Length 4
        public string FstmmTpCode{ get; set; } // [FstmmTpCode,    1] 최근월물구분                    StartPos 14, Length 1
    }

    public class _CFOBQ10800OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string PrdgrpClssCode{ get; set; } // [PrdgrpClssCode,    2] 상품군코드                      StartPos 5, Length 2
        public string ClssGrpCode{ get; set; } // [ClssGrpCode,    3] 기초자산코드                    StartPos 7, Length 3
        public string BaseYear{ get; set; } // [BaseYear,    4] 기준연도                        StartPos 10, Length 4
        public string FstmmTpCode{ get; set; } // [FstmmTpCode,    1] 최근월물구분                    StartPos 14, Length 1
    }

    public class _CFOBQ10800OutBlock2
    {
        public decimal ElwXrcPrc{ get; set; } // [ElwXrcPrc, 13.2] 행사가                          StartPos 0, Length 13
        public string FnoIsuNo{ get; set; } // [FnoIsuNo,   12] 선물옵션종목번호                StartPos 13, Length 12
        public string HanglIsuNm1{ get; set; } // [HanglIsuNm1,   40] 한글종목명1                     StartPos 25, Length 40
        public string TpNm1{ get; set; } // [TpNm1,   40] 구분명1                         StartPos 65, Length 40
        public decimal UpOptRegulThrprc{ get; set; } // [UpOptRegulThrprc, 27.8] 상승옵션조정이론가              StartPos 105, Length 27
        public decimal Thrprc1{ get; set; } // [Thrprc1, 19.8] 이론가1                         StartPos 132, Length 19
        public decimal BasePrc1{ get; set; } // [BasePrc1, 13.2] 기준가1                         StartPos 151, Length 13
        public long OrdMgn1{ get; set; } // [OrdMgn1  ,   16] 주문증거금액1                   StartPos 164, Length 16
        public string FnoIsuNo0{ get; set; } // [FnoIsuNo0,   12] 선물옵션종목번호0               StartPos 180, Length 12
        public string HanglIsuNm2{ get; set; } // [HanglIsuNm2,   40] 한글종목명2                     StartPos 192, Length 40
        public string TpNm2{ get; set; } // [TpNm2,   40] 구분명2                         StartPos 232, Length 40
        public decimal DownOptRegulThrprc{ get; set; } // [DownOptRegulThrprc, 27.8] 하락옵션조정이론가              StartPos 272, Length 27
        public decimal Thrprc2{ get; set; } // [Thrprc2, 19.8] 이론가2                         StartPos 299, Length 19
        public decimal BasePrc2{ get; set; } // [BasePrc2, 13.2] 기준가2                         StartPos 318, Length 13
        public long OrdMgn2{ get; set; } // [OrdMgn2  ,   16] 주문증거금액2                   StartPos 331, Length 16
    }
}