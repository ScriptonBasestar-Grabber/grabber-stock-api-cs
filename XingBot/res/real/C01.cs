namespace XingBot.res
{
    // 선물주문체결 ( block )
    public struct _C01_InBlock
    {
    }

    public struct _C01_OutBlock
    {
        public long lineseq{ get; set; } // [long  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno{ get; set; } // [string,   11] 계좌번호                        StartPos 10, Length 11
        public string user{ get; set; } // [string,    8] 조작자ID                        StartPos 21, Length 8
        public long seq{ get; set; } // [long  ,   11] 일련번호                        StartPos 29, Length 11
        public string trcode{ get; set; } // [string,   11] trcode                          StartPos 40, Length 11
        public string megrpno{ get; set; } // [string,    2] 매칭그룹번호                    StartPos 51, Length 2
        public string boardid{ get; set; } // [string,    2] 보드ID                          StartPos 53, Length 2
        public string memberno{ get; set; } // [string,    5] 회원번호                        StartPos 55, Length 5
        public string bpno{ get; set; } // [string,    5] 지점번호                        StartPos 60, Length 5
        public string ordno{ get; set; } // [string,   10] 주문번호                        StartPos 65, Length 10
        public string orgordno{ get; set; } // [string,   10] 원주문번호                      StartPos 75, Length 10
        public string expcode{ get; set; } // [string,   12] 종목코드                        StartPos 85, Length 12
        public string yakseq{ get; set; } // [string,   11] 약정번호                        StartPos 97, Length 11
        public decimal cheprice{ get; set; } // [float , 11.2] 체결가격                        StartPos 108, Length 11
        public long chevol{ get; set; } // [long  ,   10] 체결수량                        StartPos 119, Length 10
        public string sessionid{ get; set; } // [string,    2] 세션ID                          StartPos 129, Length 2
        public string chedate{ get; set; } // [string,    8] 체결일자                        StartPos 131, Length 8
        public string chetime{ get; set; } // [string,    9] 체결시각                        StartPos 139, Length 9
        public decimal spdprc1{ get; set; } // [float , 11.2] 최근월체결가격                  StartPos 148, Length 11
        public decimal spdprc2{ get; set; } // [float , 11.2] 차근월체결가격                  StartPos 159, Length 11
        public string dosugb{ get; set; } // [string,    1] 매도수구분                      StartPos 170, Length 1
        public string accno1{ get; set; } // [string,   12] 계좌번호1                       StartPos 171, Length 12
        public string sihogagb{ get; set; } // [string,   11] 시장조성호가구분                StartPos 183, Length 11
        public string jakino{ get; set; } // [string,    5] 위탁사번호                      StartPos 194, Length 5
        public string daeyong{ get; set; } // [string,   12] 대용주권계좌번호                StartPos 199, Length 12
        public string mem_filler{ get; set; } // [string,    7] mem_filler                      StartPos 211, Length 7
        public string mem_accno{ get; set; } // [string,   11] mem_accno                       StartPos 218, Length 11
        public string mem_filler1{ get; set; } // [string,   42] mem_filler1                     StartPos 229, Length 42
    }
}