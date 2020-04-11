namespace XingBot.res
{
    // 파생상품증거금율조회 ( SERVICE=MMDAQ91200,HEADTYPE=B,CREATOR=임정선,CREDATE=2014/09/03 15:16:28 )
    public class _MMDAQ91200InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string IsuLgclssCode{ get; set; } // [IsuLgclssCode,    2] 종목대분류코드                  StartPos 5, Length 2
        public string IsuMdclssCode{ get; set; } // [IsuMdclssCode,    2] 종목중분류코드                  StartPos 7, Length 2
    }

    public class _MMDAQ91200OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string IsuLgclssCode{ get; set; } // [IsuLgclssCode,    2] 종목대분류코드                  StartPos 5, Length 2
        public string IsuMdclssCode{ get; set; } // [IsuMdclssCode,    2] 종목중분류코드                  StartPos 7, Length 2
    }

    public class _MMDAQ91200OutBlock2
    {
        public string IsuSmclssCode{ get; set; } // [IsuSmclssCode,    3] 종목소분류코드                  StartPos 0, Length 3
        public string IsuMdclssCode{ get; set; } // [IsuMdclssCode,    2] 종목중분류코드                  StartPos 3, Length 2
        public string IsuLrgMdclssNm{ get; set; } // [IsuLrgMdclssNm,   40] 종목대중분류명                  StartPos 5, Length 40
        public string IsuLrgMidSmclssNm{ get; set; } // [IsuLrgMidSmclssNm,   40] 종목대중소분류명                StartPos 45, Length 40
        public string ShtnHanglIsuNm{ get; set; } // [ShtnHanglIsuNm,   40] 단축한글종목명                  StartPos 85, Length 40
        public decimal CsgnMgnrt{ get; set; } // [CsgnMgnrt, 26.9] 위탁증거금율                    StartPos 125, Length 26
        public decimal MaintMgnrt{ get; set; } // [MaintMgnrt, 26.9] 유지증거금율                    StartPos 151, Length 26
        public decimal MnyMgnrt{ get; set; } // [MnyMgnrt, 26.9] 현금증거금율                    StartPos 177, Length 26
        public long RmndDays{ get; set; } // [RmndDays  ,    6] 잔여일수                        StartPos 203, Length 6
    }
}