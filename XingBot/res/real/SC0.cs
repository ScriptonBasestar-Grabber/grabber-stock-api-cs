﻿namespace XingBot.res
{
    // 주식주문접수 ( KEY=8, GROUP=1 )
    public class _SC0_InBlock
    {
    }

    public class _SC0_OutBlock
    {
        public long lineseq{ get; set; } // [long  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno{ get; set; } // [string,   11] 계좌번호                        StartPos 10, Length 11
        public string user{ get; set; } // [string,    8] 조작자ID                        StartPos 21, Length 8
        public long len{ get; set; } // [long  ,    6] 헤더길이                        StartPos 29, Length 6
        public string gubun{ get; set; } // [string,    1] 헤더구분                        StartPos 35, Length 1
        public string compress{ get; set; } // [string,    1] 압축구분                        StartPos 36, Length 1
        public string encrypt{ get; set; } // [string,    1] 암호구분                        StartPos 37, Length 1
        public long offset{ get; set; } // [long  ,    3] 공통시작지점                    StartPos 38, Length 3
        public string trcode{ get; set; } // [string,    8] TRCODE                          StartPos 41, Length 8
        public string compid{ get; set; } // [string,    3] 이용사번호                      StartPos 49, Length 3
        public string userid{ get; set; } // [string,   16] 사용자ID                        StartPos 52, Length 16
        public string media{ get; set; } // [string,    2] 접속매체                        StartPos 68, Length 2
        public string ifid{ get; set; } // [string,    3] I/F일련번호                     StartPos 70, Length 3
        public string seq{ get; set; } // [string,    9] 전문일련번호                    StartPos 73, Length 9
        public string trid{ get; set; } // [string,   16] TR추적ID                        StartPos 82, Length 16
        public string pubip{ get; set; } // [string,   12] 공인IP                          StartPos 98, Length 12
        public string prvip{ get; set; } // [string,   12] 사설IP                          StartPos 110, Length 12
        public string pcbpno{ get; set; } // [string,    3] 처리지점번호                    StartPos 122, Length 3
        public string bpno{ get; set; } // [string,    3] 지점번호                        StartPos 125, Length 3
        public string termno{ get; set; } // [string,    8] 단말번호                        StartPos 128, Length 8
        public string lang{ get; set; } // [string,    1] 언어구분                        StartPos 136, Length 1
        public long proctm{ get; set; } // [long  ,    9] AP처리시간                      StartPos 137, Length 9
        public string msgcode{ get; set; } // [string,    4] 메세지코드                      StartPos 146, Length 4
        public string outgu{ get; set; } // [string,    1] 메세지출력구분                  StartPos 150, Length 1
        public string compreq{ get; set; } // [string,    1] 압축요청구분                    StartPos 151, Length 1
        public string funckey{ get; set; } // [string,    4] 기능키                          StartPos 152, Length 4
        public long reqcnt{ get; set; } // [long  ,    4] 요청레코드개수                  StartPos 156, Length 4
        public string filler{ get; set; } // [string,    6] 예비영역                        StartPos 160, Length 6
        public string cont{ get; set; } // [string,    1] 연속구분                        StartPos 166, Length 1
        public string contkey{ get; set; } // [string,   18] 연속키값                        StartPos 167, Length 18
        public long varlen{ get; set; } // [long  ,    2] 가변시스템길이                  StartPos 185, Length 2
        public long varhdlen{ get; set; } // [long  ,    2] 가변해더길이                    StartPos 187, Length 2
        public long varmsglen{ get; set; } // [long  ,    2] 가변메시지길이                  StartPos 189, Length 2
        public string trsrc{ get; set; } // [string,    1] 조회발원지                      StartPos 191, Length 1
        public string eventid{ get; set; } // [string,    4] I/F이벤트ID                     StartPos 192, Length 4
        public string ifinfo{ get; set; } // [string,    4] I/F정보                         StartPos 196, Length 4
        public string filler1{ get; set; } // [string,   41] 예비영역                        StartPos 200, Length 41
        public string ordchegb{ get; set; } // [string,    2] 주문체결구분                    StartPos 241, Length 2
        public string marketgb{ get; set; } // [string,    2] 시장구분                        StartPos 243, Length 2
        public string ordgb{ get; set; } // [string,    2] 주문구분                        StartPos 245, Length 2
        public long orgordno{ get; set; } // [long  ,   10] 원주문번호                      StartPos 247, Length 10
        public string accno1{ get; set; } // [string,   11] 계좌번호                        StartPos 257, Length 11
        public string accno2{ get; set; } // [string,    9] 계좌번호                        StartPos 268, Length 9
        public string passwd{ get; set; } // [string,    8] 비밀번호                        StartPos 277, Length 8
        public string expcode{ get; set; } // [string,   12] 종목번호                        StartPos 285, Length 12
        public string shtcode{ get; set; } // [string,    9] 단축종목번호                    StartPos 297, Length 9
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 306, Length 40
        public long ordqty{ get; set; } // [long  ,   16] 주문수량                        StartPos 346, Length 16
        public long ordprice{ get; set; } // [long  ,   13] 주문가격                        StartPos 362, Length 13
        public string hogagb{ get; set; } // [string,    1] 주문조건                        StartPos 375, Length 1
        public string etfhogagb{ get; set; } // [string,    2] 호가유형코드                    StartPos 376, Length 2
        public long pgmtype{ get; set; } // [long  ,    2] 프로그램호가구분                StartPos 378, Length 2
        public long gmhogagb{ get; set; } // [long  ,    1] 공매도호가구분                  StartPos 380, Length 1
        public long gmhogayn{ get; set; } // [long  ,    1] 공매도가능여부                  StartPos 381, Length 1
        public string singb{ get; set; } // [string,    3] 신용구분                        StartPos 382, Length 3
        public string loandt{ get; set; } // [string,    8] 대출일                          StartPos 385, Length 8
        public string cvrgordtp{ get; set; } // [string,    1] 반대매매주문구분                StartPos 393, Length 1
        public string strtgcode{ get; set; } // [string,    6] 전략코드                        StartPos 394, Length 6
        public string groupid{ get; set; } // [string,   20] 그룹ID                          StartPos 400, Length 20
        public long ordseqno{ get; set; } // [long  ,   10] 주문회차                        StartPos 420, Length 10
        public long prtno{ get; set; } // [long  ,   10] 포트폴리오번호                  StartPos 430, Length 10
        public long basketno{ get; set; } // [long  ,   10] 바스켓번호                      StartPos 440, Length 10
        public long trchno{ get; set; } // [long  ,   10] 트렌치번호                      StartPos 450, Length 10
        public long itemno{ get; set; } // [long  ,   10] 아아템번호                      StartPos 460, Length 10
        public long brwmgmyn{ get; set; } // [long  ,    1] 차입구분                        StartPos 470, Length 1
        public long mbrno{ get; set; } // [long  ,    3] 회원사번호                      StartPos 471, Length 3
        public string procgb{ get; set; } // [string,    1] 처리구분                        StartPos 474, Length 1
        public string admbrchno{ get; set; } // [string,    3] 관리지점번호                    StartPos 475, Length 3
        public string futaccno{ get; set; } // [string,   20] 선물계좌번호                    StartPos 478, Length 20
        public string futmarketgb{ get; set; } // [string,    1] 선물상품구분                    StartPos 498, Length 1
        public string tongsingb{ get; set; } // [string,    2] 통신매체구분                    StartPos 499, Length 2
        public string lpgb{ get; set; } // [string,    1] 유동성공급자구분                StartPos 501, Length 1
        public string dummy{ get; set; } // [string,   20] DUMMY                           StartPos 502, Length 20
        public long ordno{ get; set; } // [long  ,   10] 주문번호                        StartPos 522, Length 10
        public string ordtm{ get; set; } // [string,    9] 주문시각                        StartPos 532, Length 9
        public long prntordno{ get; set; } // [long  ,   10] 모주문번호                      StartPos 541, Length 10
        public string mgempno{ get; set; } // [string,    9] 관리사원번호                    StartPos 551, Length 9
        public long orgordundrqty{ get; set; } // [long  ,   16] 원주문미체결수량                StartPos 560, Length 16
        public long orgordmdfyqty{ get; set; } // [long  ,   16] 원주문정정수량                  StartPos 576, Length 16
        public long ordordcancelqty{ get; set; } // [long  ,   16] 원주문취소수량                  StartPos 592, Length 16
        public long nmcpysndno{ get; set; } // [long  ,   10] 비회원사송신번호                StartPos 608, Length 10
        public long ordamt{ get; set; } // [long  ,   16] 주문금액                        StartPos 618, Length 16
        public string bnstp{ get; set; } // [string,    1] 매매구분                        StartPos 634, Length 1
        public long spareordno{ get; set; } // [long  ,   10] 예비주문번호                    StartPos 635, Length 10
        public long cvrgseqno{ get; set; } // [long  ,   10] 반대매매일련번호                StartPos 645, Length 10
        public long rsvordno{ get; set; } // [long  ,   10] 예약주문번호                    StartPos 655, Length 10
        public long mtordseqno{ get; set; } // [long  ,   10] 복수주문일련번호                StartPos 665, Length 10
        public long spareordqty{ get; set; } // [long  ,   16] 예비주문수량                    StartPos 675, Length 16
        public string orduserid{ get; set; } // [string,   16] 주문사원번호                    StartPos 691, Length 16
        public long spotordqty{ get; set; } // [long  ,   16] 실물주문수량                    StartPos 707, Length 16
        public long ordruseqty{ get; set; } // [long  ,   16] 재사용주문수량                  StartPos 723, Length 16
        public long mnyordamt{ get; set; } // [long  ,   16] 현금주문금액                    StartPos 739, Length 16
        public long ordsubstamt{ get; set; } // [long  ,   16] 주문대용금액                    StartPos 755, Length 16
        public long ruseordamt{ get; set; } // [long  ,   16] 재사용주문금액                  StartPos 771, Length 16
        public long ordcmsnamt{ get; set; } // [long  ,   16] 수수료주문금액                  StartPos 787, Length 16
        public long crdtuseamt{ get; set; } // [long  ,   16] 사용신용담보재사용금            StartPos 803, Length 16
        public long secbalqty{ get; set; } // [long  ,   16] 잔고수량                        StartPos 819, Length 16
        public long spotordableqty{ get; set; } // [long  ,   16] 실물가능수량                    StartPos 835, Length 16
        public long ordableruseqty{ get; set; } // [long  ,   16] 재사용가능수량(매도)            StartPos 851, Length 16
        public long flctqty{ get; set; } // [long  ,   16] 변동수량                        StartPos 867, Length 16
        public long secbalqtyd2{ get; set; } // [long  ,   16] 잔고수량(D2)                    StartPos 883, Length 16
        public long sellableqty{ get; set; } // [long  ,   16] 매도주문가능수량                StartPos 899, Length 16
        public long unercsellordqty{ get; set; } // [long  ,   16] 미체결매도주문수량              StartPos 915, Length 16
        public long avrpchsprc{ get; set; } // [long  ,   13] 평균매입가                      StartPos 931, Length 13
        public long pchsamt{ get; set; } // [long  ,   16] 매입금액                        StartPos 944, Length 16
        public long deposit{ get; set; } // [long  ,   16] 예수금                          StartPos 960, Length 16
        public long substamt{ get; set; } // [long  ,   16] 대용금                          StartPos 976, Length 16
        public long csgnmnymgn{ get; set; } // [long  ,   16] 위탁증거금현금                  StartPos 992, Length 16
        public long csgnsubstmgn{ get; set; } // [long  ,   16] 위탁증거금대용                  StartPos 1008, Length 16
        public long crdtpldgruseamt{ get; set; } // [long  ,   16] 신용담보재사용금                StartPos 1024, Length 16
        public long ordablemny{ get; set; } // [long  ,   16] 주문가능현금                    StartPos 1040, Length 16
        public long ordablesubstamt{ get; set; } // [long  ,   16] 주문가능대용                    StartPos 1056, Length 16
        public long ruseableamt{ get; set; } // [long  ,   16] 재사용가능금액                  StartPos 1072, Length 16
    }
}