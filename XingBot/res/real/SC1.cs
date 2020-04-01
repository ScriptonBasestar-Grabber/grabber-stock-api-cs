namespace XingBot.res
{
    // 주식주문체결 ( KEY=8, GROUP=1 )
    struct _SC1_InBlock
    {
    }

    struct _SC1_OutBlock
    {
        public long lineseq; // [long  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno; // [string,   11] 계좌번호                        StartPos 10, Length 11
        public string user; // [string,    8] 조작자ID                        StartPos 21, Length 8
        public long len; // [long  ,    6] 헤더길이                        StartPos 29, Length 6
        public string gubun; // [string,    1] 헤더구분                        StartPos 35, Length 1
        public string compress; // [string,    1] 압축구분                        StartPos 36, Length 1
        public string encrypt; // [string,    1] 암호구분                        StartPos 37, Length 1
        public long offset; // [long  ,    3] 공통시작지점                    StartPos 38, Length 3
        public string trcode; // [string,    8] TRCODE                          StartPos 41, Length 8
        public string compid; // [string,    3] 이용사번호                      StartPos 49, Length 3
        public string userid; // [string,   16] 사용자ID                        StartPos 52, Length 16
        public string media; // [string,    2] 접속매체                        StartPos 68, Length 2
        public string ifid; // [string,    3] I/F일련번호                     StartPos 70, Length 3
        public string seq; // [string,    9] 전문일련번호                    StartPos 73, Length 9
        public string trid; // [string,   16] TR추적ID                        StartPos 82, Length 16
        public string pubip; // [string,   12] 공인IP                          StartPos 98, Length 12
        public string prvip; // [string,   12] 사설IP                          StartPos 110, Length 12
        public string pcbpno; // [string,    3] 처리지점번호                    StartPos 122, Length 3
        public string bpno; // [string,    3] 지점번호                        StartPos 125, Length 3
        public string termno; // [string,    8] 단말번호                        StartPos 128, Length 8
        public string lang; // [string,    1] 언어구분                        StartPos 136, Length 1
        public long proctm; // [long  ,    9] AP처리시간                      StartPos 137, Length 9
        public string msgcode; // [string,    4] 메세지코드                      StartPos 146, Length 4
        public string outgu; // [string,    1] 메세지출력구분                  StartPos 150, Length 1
        public string compreq; // [string,    1] 압축요청구분                    StartPos 151, Length 1
        public string funckey; // [string,    4] 기능키                          StartPos 152, Length 4
        public long reqcnt; // [long  ,    4] 요청레코드개수                  StartPos 156, Length 4
        public string filler; // [string,    6] 예비영역                        StartPos 160, Length 6
        public string cont; // [string,    1] 연속구분                        StartPos 166, Length 1
        public string contkey; // [string,   18] 연속키값                        StartPos 167, Length 18
        public long varlen; // [long  ,    2] 가변시스템길이                  StartPos 185, Length 2
        public long varhdlen; // [long  ,    2] 가변해더길이                    StartPos 187, Length 2
        public long varmsglen; // [long  ,    2] 가변메시지길이                  StartPos 189, Length 2
        public string trsrc; // [string,    1] 조회발원지                      StartPos 191, Length 1
        public string eventid; // [string,    4] I/F이벤트ID                     StartPos 192, Length 4
        public string ifinfo; // [string,    4] I/F정보                         StartPos 196, Length 4
        public string filler1; // [string,   41] 예비영역                        StartPos 200, Length 41
        public string ordxctptncode; // [string,    2] 주문체결유형코드                StartPos 241, Length 2
        public string ordmktcode; // [string,    2] 주문시장코드                    StartPos 243, Length 2
        public string ordptncode; // [string,    2] 주문유형코드                    StartPos 245, Length 2
        public string mgmtbrnno; // [string,    3] 관리지점번호                    StartPos 247, Length 3
        public string accno1; // [string,   11] 계좌번호                        StartPos 250, Length 11
        public string accno2; // [string,    9] 계좌번호                        StartPos 261, Length 9
        public string acntnm; // [string,   40] 계좌명                          StartPos 270, Length 40
        public string Isuno; // [string,   12] 종목번호                        StartPos 310, Length 12
        public string Isunm; // [string,   40] 종목명                          StartPos 322, Length 40
        public long ordno; // [long  ,   10] 주문번호                        StartPos 362, Length 10
        public long orgordno; // [long  ,   10] 원주문번호                      StartPos 372, Length 10
        public long execno; // [long  ,   10] 체결번호                        StartPos 382, Length 10
        public long ordqty; // [long  ,   16] 주문수량                        StartPos 392, Length 16
        public long ordprc; // [long  ,   13] 주문가격                        StartPos 408, Length 13
        public long execqty; // [long  ,   16] 체결수량                        StartPos 421, Length 16
        public long execprc; // [long  ,   13] 체결가격                        StartPos 437, Length 13
        public long mdfycnfqty; // [long  ,   16] 정정확인수량                    StartPos 450, Length 16
        public long mdfycnfprc; // [long  ,   16] 정정확인가격                    StartPos 466, Length 16
        public long canccnfqty; // [long  ,   16] 취소확인수량                    StartPos 482, Length 16
        public long rjtqty; // [long  ,   16] 거부수량                        StartPos 498, Length 16
        public long ordtrxptncode; // [long  ,    4] 주문처리유형코드                StartPos 514, Length 4
        public long mtiordseqno; // [long  ,   10] 복수주문일련번호                StartPos 518, Length 10
        public string ordcndi; // [string,    1] 주문조건                        StartPos 528, Length 1
        public string ordprcptncode; // [string,    2] 호가유형코드                    StartPos 529, Length 2
        public long nsavtrdqty; // [long  ,   16] 비저축체결수량                  StartPos 531, Length 16
        public string shtnIsuno; // [string,    9] 단축종목번호                    StartPos 547, Length 9
        public string opdrtnno; // [string,   12] 운용지시번호                    StartPos 556, Length 12
        public string cvrgordtp; // [string,    1] 반대매매주문구분                StartPos 568, Length 1
        public long unercqty; // [long  ,   16] 미체결수량(주문)                StartPos 569, Length 16
        public long orgordunercqty; // [long  ,   16] 원주문미체결수량                StartPos 585, Length 16
        public long orgordmdfyqty; // [long  ,   16] 원주문정정수량                  StartPos 601, Length 16
        public long orgordcancqty; // [long  ,   16] 원주문취소수량                  StartPos 617, Length 16
        public long ordavrexecprc; // [long  ,   13] 주문평균체결가격                StartPos 633, Length 13
        public long ordamt; // [long  ,   16] 주문금액                        StartPos 646, Length 16
        public string stdIsuno; // [string,   12] 표준종목번호                    StartPos 662, Length 12
        public string bfstdIsuno; // [string,   12] 전표준종목번호                  StartPos 674, Length 12
        public string bnstp; // [string,    1] 매매구분                        StartPos 686, Length 1
        public string ordtrdptncode; // [string,    2] 주문거래유형코드                StartPos 687, Length 2
        public string mgntrncode; // [string,    3] 신용거래코드                    StartPos 689, Length 3
        public string adduptp; // [string,    2] 수수료합산코드                  StartPos 692, Length 2
        public string commdacode; // [string,    2] 통신매체코드                    StartPos 694, Length 2
        public string Loandt; // [string,    8] 대출일                          StartPos 696, Length 8
        public long mbrnmbrno; // [long  ,    3] 회원/비회원사번호               StartPos 704, Length 3
        public string ordacntno; // [string,   20] 주문계좌번호                    StartPos 707, Length 20
        public string agrgbrnno; // [string,    3] 집계지점번호                    StartPos 727, Length 3
        public string mgempno; // [string,    9] 관리사원번호                    StartPos 730, Length 9
        public string futsLnkbrnno; // [string,    3] 선물연계지점번호                StartPos 739, Length 3
        public string futsLnkacntno; // [string,   20] 선물연계계좌번호                StartPos 742, Length 20
        public string futsmkttp; // [string,    1] 선물시장구분                    StartPos 762, Length 1
        public string regmktcode; // [string,    2] 등록시장코드                    StartPos 763, Length 2
        public long mnymgnrat; // [long  ,    7] 현금증거금률                    StartPos 765, Length 7
        public long substmgnrat; // [long  ,    9] 대용증거금률                    StartPos 772, Length 9
        public long mnyexecamt; // [long  ,   16] 현금체결금액                    StartPos 781, Length 16
        public long ubstexecamt; // [long  ,   16] 대용체결금액                    StartPos 797, Length 16
        public long cmsnamtexecamt; // [long  ,   16] 수수료체결금액                  StartPos 813, Length 16
        public long crdtpldgexecamt; // [long  ,   16] 신용담보체결금액                StartPos 829, Length 16
        public long crdtexecamt; // [long  ,   16] 신용체결금액                    StartPos 845, Length 16
        public long prdayruseexecval; // [long  ,   16] 전일재사용체결금액              StartPos 861, Length 16
        public long crdayruseexecval; // [long  ,   16] 금일재사용체결금액              StartPos 877, Length 16
        public long spotexecqty; // [long  ,   16] 실물체결수량                    StartPos 893, Length 16
        public long stslexecqty; // [long  ,   16] 공매도체결수량                  StartPos 909, Length 16
        public string strtgcode; // [string,    6] 전략코드                        StartPos 925, Length 6
        public string grpId; // [string,   20] 그룹Id                          StartPos 931, Length 20
        public long ordseqno; // [long  ,   10] 주문회차                        StartPos 951, Length 10
        public long ptflno; // [long  ,   10] 포트폴리오번호                  StartPos 961, Length 10
        public long bskno; // [long  ,   10] 바스켓번호                      StartPos 971, Length 10
        public long trchno; // [long  ,   10] 트렌치번호                      StartPos 981, Length 10
        public long itemno; // [long  ,   10] 아이템번호                      StartPos 991, Length 10
        public string orduserId; // [string,   16] 주문자Id                        StartPos 1001, Length 16
        public long brwmgmtYn; // [long  ,    1] 차입관리여부                    StartPos 1017, Length 1
        public string frgrunqno; // [string,    6] 외국인고유번호                  StartPos 1018, Length 6
        public string trtzxLevytp; // [string,    1] 거래세징수구분                  StartPos 1024, Length 1
        public string lptp; // [string,    1] 유동성공급자구분                StartPos 1025, Length 1
        public string exectime; // [string,    9] 체결시각                        StartPos 1026, Length 9
        public string rcptexectime; // [string,    9] 거래소수신체결시각              StartPos 1035, Length 9
        public long rmndLoanamt; // [long  ,   16] 잔여대출금액                    StartPos 1044, Length 16
        public long secbalqty; // [long  ,   16] 잔고수량                        StartPos 1060, Length 16
        public long spotordableqty; // [long  ,   16] 실물가능수량                    StartPos 1076, Length 16
        public long ordableruseqty; // [long  ,   16] 재사용가능수량(매도)            StartPos 1092, Length 16
        public long flctqty; // [long  ,   16] 변동수량                        StartPos 1108, Length 16
        public long secbalqtyd2; // [long  ,   16] 잔고수량(d2)                    StartPos 1124, Length 16
        public long sellableqty; // [long  ,   16] 매도주문가능수량                StartPos 1140, Length 16
        public long unercsellordqty; // [long  ,   16] 미체결매도주문수량              StartPos 1156, Length 16
        public long avrpchsprc; // [long  ,   13] 평균매입가                      StartPos 1172, Length 13
        public long pchsant; // [long  ,   16] 매입금액                        StartPos 1185, Length 16
        public long deposit; // [long  ,   16] 예수금                          StartPos 1201, Length 16
        public long substamt; // [long  ,   16] 대용금                          StartPos 1217, Length 16
        public long csgnmnymgn; // [long  ,   16] 위탁증거금현금                  StartPos 1233, Length 16
        public long csgnsubstmgn; // [long  ,   16] 위탁증거금대용                  StartPos 1249, Length 16
        public long crdtpldgruseamt; // [long  ,   16] 신용담보재사용금                StartPos 1265, Length 16
        public long ordablemny; // [long  ,   16] 주문가능현금                    StartPos 1281, Length 16
        public long ordablesubstamt; // [long  ,   16] 주문가능대용                    StartPos 1297, Length 16
        public long ruseableamt; // [long  ,   16] 재사용가능금액                  StartPos 1313, Length 16
    }
}