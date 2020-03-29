namespace XingBot.res
{
    public class C01
    {
        struct _C01_InBlock
        {
        }

        struct _C01_OutBlock
        {
            long lineseq; // [long  ,   10] 라인일련번호                    StartPos 0, Length 10
            string accno; // [string,   11] 계좌번호                        StartPos 10, Length 11
            string user; // [string,    8] 조작자ID                        StartPos 21, Length 8
            long seq; // [long  ,   11] 일련번호                        StartPos 29, Length 11
            string trcode; // [string,   11] trcode                          StartPos 40, Length 11
            string megrpno; // [string,    2] 매칭그룹번호                    StartPos 51, Length 2
            string boardid; // [string,    2] 보드ID                          StartPos 53, Length 2
            string memberno; // [string,    5] 회원번호                        StartPos 55, Length 5
            string bpno; // [string,    5] 지점번호                        StartPos 60, Length 5
            string ordno; // [string,   10] 주문번호                        StartPos 65, Length 10
            string orgordno; // [string,   10] 원주문번호                      StartPos 75, Length 10
            string expcode; // [string,   12] 종목코드                        StartPos 85, Length 12
            string yakseq; // [string,   11] 약정번호                        StartPos 97, Length 11
            float cheprice; // [float , 11.2] 체결가격                        StartPos 108, Length 11
            long chevol; // [long  ,   10] 체결수량                        StartPos 119, Length 10
            string sessionid; // [string,    2] 세션ID                          StartPos 129, Length 2
            string chedate; // [string,    8] 체결일자                        StartPos 131, Length 8
            string chetime; // [string,    9] 체결시각                        StartPos 139, Length 9
            float spdprc1; // [float , 11.2] 최근월체결가격                  StartPos 148, Length 11
            float spdprc2; // [float , 11.2] 차근월체결가격                  StartPos 159, Length 11
            string dosugb; // [string,    1] 매도수구분                      StartPos 170, Length 1
            string accno1; // [string,   12] 계좌번호1                       StartPos 171, Length 12
            string sihogagb; // [string,   11] 시장조성호가구분                StartPos 183, Length 11
            string jakino; // [string,    5] 위탁사번호                      StartPos 194, Length 5
            string daeyong; // [string,   12] 대용주권계좌번호                StartPos 199, Length 12
            string mem_filler; // [string,    7] mem_filler                      StartPos 211, Length 7
            string mem_accno; // [string,   11] mem_accno                       StartPos 218, Length 11
            string mem_filler1; // [string,   42] mem_filler1                     StartPos 229, Length 42
        }
    }
}