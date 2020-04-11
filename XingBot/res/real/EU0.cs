namespace XingBot.res
{
    // EUX접수 ( KEY=8, GROUP=1 )
    public class _EU0_InBlock
    {
    }

    public class _EU0_OutBlock
    {
        public long lineseq{ get; set; } // [lineseq  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno{ get; set; } // [accno,   11] 계좌번호                        StartPos 10, Length 11
        public string user{ get; set; } // [user,    8] 조작자ID                        StartPos 21, Length 8
        public long len{ get; set; } // [len  ,    6] 헤더길이                        StartPos 29, Length 6
        public string gubun{ get; set; } // [gubun,    1] 헤더구분                        StartPos 35, Length 1
        public string compress{ get; set; } // [compress,    1] 압축구분                        StartPos 36, Length 1
        public string encrypt{ get; set; } // [encrypt,    1] 암호구분                        StartPos 37, Length 1
        public long offset{ get; set; } // [offset  ,    3] 공통시작지점                    StartPos 38, Length 3
        public string trcode{ get; set; } // [trcode,    8] TRCODE                          StartPos 41, Length 8
        public string compid{ get; set; } // [compid,    3] 이용사번호                      StartPos 49, Length 3
        public string userid{ get; set; } // [userid,   16] 사용자ID                        StartPos 52, Length 16
        public string media{ get; set; } // [media,    2] 접속매체                        StartPos 68, Length 2
        public string ifid{ get; set; } // [ifid,    3] I/F일련번호                     StartPos 70, Length 3
        public string seq{ get; set; } // [seq,    9] 전문일련번호                    StartPos 73, Length 9
        public string trid{ get; set; } // [trid,   16] TR추적ID                        StartPos 82, Length 16
        public string pubip{ get; set; } // [pubip,   12] 공인IP                          StartPos 98, Length 12
        public string prvip{ get; set; } // [prvip,   12] 사설IP                          StartPos 110, Length 12
        public string pcbpno{ get; set; } // [pcbpno,    3] 처리지점번호                    StartPos 122, Length 3
        public string bpno{ get; set; } // [bpno,    3] 지점번호                        StartPos 125, Length 3
        public string termno{ get; set; } // [termno,    8] 단말번호                        StartPos 128, Length 8
        public string lang{ get; set; } // [lang,    1] 언어구분                        StartPos 136, Length 1
        public long proctm{ get; set; } // [proctm  ,    9] AP처리시간                      StartPos 137, Length 9
        public string msgcode{ get; set; } // [msgcode,    4] 메세지코드                      StartPos 146, Length 4
        public string outgu{ get; set; } // [outgu,    1] 메세지출력구분                  StartPos 150, Length 1
        public string compreq{ get; set; } // [compreq,    1] 압축요청구분                    StartPos 151, Length 1
        public string funckey{ get; set; } // [funckey,    4] 기능키                          StartPos 152, Length 4
        public long reqcnt{ get; set; } // [reqcnt  ,    4] 요청레코드개수                  StartPos 156, Length 4
        public string filler{ get; set; } // [filler,    6] 예비영역                        StartPos 160, Length 6
        public string cont{ get; set; } // [cont,    1] 연속구분                        StartPos 166, Length 1
        public string contkey{ get; set; } // [contkey,   18] 연속키값                        StartPos 167, Length 18
        public long varlen{ get; set; } // [varlen  ,    2] 가변시스템길이                  StartPos 185, Length 2
        public long varhdlen{ get; set; } // [varhdlen  ,    2] 가변해더길이                    StartPos 187, Length 2
        public long varmsglen{ get; set; } // [varmsglen  ,    2] 가변메시지길이                  StartPos 189, Length 2
        public string trsrc{ get; set; } // [trsrc,    1] 조회발원지                      StartPos 191, Length 1
        public string eventid{ get; set; } // [eventid,    4] I/F이벤트ID                     StartPos 192, Length 4
        public string ifinfo{ get; set; } // [ifinfo,    4] I/F정보                         StartPos 196, Length 4
        public string filler1{ get; set; } // [filler1,   41] 예비영역                        StartPos 200, Length 41
        public string trcode1{ get; set; } // [trcode1,    4] tr코드                          StartPos 241, Length 4
        public string firmno{ get; set; } // [firmno,    3] 회사번호                        StartPos 245, Length 3
        public string acntno{ get; set; } // [acntno,   11] 계좌번호                        StartPos 248, Length 11
        public string acntno1{ get; set; } // [acntno1,    9] 계좌번호                        StartPos 259, Length 9
        public string acntnm{ get; set; } // [acntnm,   40] 계좌명                          StartPos 268, Length 40
        public string brnno{ get; set; } // [brnno,    3] 지점번호                        StartPos 308, Length 3
        public string ordmktcode{ get; set; } // [ordmktcode,    2] 주문시장코드                    StartPos 311, Length 2
        public string ordno1{ get; set; } // [ordno1,    3] 주문번호                        StartPos 313, Length 3
        public long ordno{ get; set; } // [ordno  ,    7] 주문번호                        StartPos 316, Length 7
        public string orgordno1{ get; set; } // [orgordno1,    3] 원주문번호                      StartPos 323, Length 3
        public long orgordno{ get; set; } // [orgordno  ,    7] 원주문번호                      StartPos 326, Length 7
        public string prntordno{ get; set; } // [prntordno,    3] 모주문번호                      StartPos 333, Length 3
        public long prntordno1{ get; set; } // [prntordno1  ,    7] 모주문번호                      StartPos 336, Length 7
        public string isuno{ get; set; } // [isuno,   12] 종목번호                        StartPos 343, Length 12
        public string fnoIsuno{ get; set; } // [fnoIsuno,    8] 선물옵션종목번호                StartPos 355, Length 8
        public string fnoIsunm{ get; set; } // [fnoIsunm,   40] 선물옵션종목명                  StartPos 363, Length 40
        public string pdgrpcode{ get; set; } // [pdgrpcode,    2] 상품군분류코드                  StartPos 403, Length 2
        public string fnoIsuptntp{ get; set; } // [fnoIsuptntp,    1] 선물옵션종목유형구분            StartPos 405, Length 1
        public string bnstp{ get; set; } // [bnstp,    1] 매매구분                        StartPos 406, Length 1
        public string mrctp{ get; set; } // [mrctp,    1] 정정취소구분                    StartPos 407, Length 1
        public long ordqty{ get; set; } // [ordqty  ,   16] 주문수량                        StartPos 408, Length 16
        public string hogatype{ get; set; } // [hogatype,    2] 호가유형코드                    StartPos 424, Length 2
        public string mmgb{ get; set; } // [mmgb,    2] 거래유형코드                    StartPos 426, Length 2
        public decimal ordprc{ get; set; } // [ordprc, 13.2] 주문가격                        StartPos 428, Length 13
        public long unercqty{ get; set; } // [unercqty  ,   16] 미체결수량                      StartPos 441, Length 16
        public string commdacode{ get; set; } // [commdacode,    2] 통신매체                        StartPos 457, Length 2
        public string peeamtcode{ get; set; } // [peeamtcode,    2] 수수료합산코드                  StartPos 459, Length 2
        public string mgempno{ get; set; } // [mgempno,    9] 관리사원                        StartPos 461, Length 9
        public decimal fnotrdunitamt{ get; set; } // [fnotrdunitamt, 19.8] 선물옵션거래단위금액            StartPos 470, Length 19
        public string trxtime{ get; set; } // [trxtime,    9] 처리시각                        StartPos 489, Length 9
        public string strtgcode{ get; set; } // [strtgcode,    6] 전략코드                        StartPos 498, Length 6
        public string grpId{ get; set; } // [grpId,   20] 그룹Id                          StartPos 504, Length 20
        public string ordseqno{ get; set; } // [ordseqno,   10] 주문회차                        StartPos 524, Length 10
        public string ptflno{ get; set; } // [ptflno,   10] 포트폴리오 번호                 StartPos 534, Length 10
        public string bskno{ get; set; } // [bskno,   10] 바스켓번호                      StartPos 544, Length 10
        public string trchno{ get; set; } // [trchno,   10] 트렌치번호                      StartPos 554, Length 10
        public string Itemno{ get; set; } // [Itemno,   10] 아이템번호                      StartPos 564, Length 10
        public string OrderID{ get; set; } // [OrderID,   16] 주문자Id                        StartPos 574, Length 16
        public string opdrtnno{ get; set; } // [opdrtnno,   12] 운영지시번호                    StartPos 590, Length 12
        public string rjtcode{ get; set; } // [rjtcode,    4] 부적격코드                      StartPos 602, Length 4
        public long mrccnfqty{ get; set; } // [mrccnfqty  ,   16] 정정취소확인수량                StartPos 606, Length 16
        public long orgordunercqty{ get; set; } // [orgordunercqty  ,   16] 원주문미체결수량                StartPos 622, Length 16
        public long orgordmrcqty{ get; set; } // [orgordmrcqty  ,   16] 원주문정정취소수량              StartPos 638, Length 16
        public string ctrcttime{ get; set; } // [ctrcttime,    8] 약정시각(체결시각)              StartPos 654, Length 8
        public string ctrctno{ get; set; } // [ctrctno,   10] 약정번호                        StartPos 662, Length 10
        public decimal execprc{ get; set; } // [execprc, 13.2] 체결가격                        StartPos 672, Length 13
        public long execqty{ get; set; } // [execqty  ,   16] 체결수량                        StartPos 685, Length 16
        public long newqty{ get; set; } // [newqty  ,   16] 신규체결수량                    StartPos 701, Length 16
        public long qdtqty{ get; set; } // [qdtqty  ,   16] 청산체결수량                    StartPos 717, Length 16
        public long lastqty{ get; set; } // [lastqty  ,   16] 최종결제수량                    StartPos 733, Length 16
        public long lallexecqty{ get; set; } // [lallexecqty  ,   16] 전체체결수량                    StartPos 749, Length 16
        public long allexecamt{ get; set; } // [allexecamt  ,   16] 전체체결금액                    StartPos 765, Length 16
        public string fnobalevaltp{ get; set; } // [fnobalevaltp,    1] 잔고평가구분                    StartPos 781, Length 1
        public long bnsplamt{ get; set; } // [bnsplamt  ,   16] 매매손익금액                    StartPos 782, Length 16
        public string fnoIsuno1{ get; set; } // [fnoIsuno1,    8] 선물옵션종목번호1               StartPos 798, Length 8
        public string bnstp1{ get; set; } // [bnstp1,    1] 매매구분1                       StartPos 806, Length 1
        public decimal execprc1{ get; set; } // [execprc1, 13.2] 체결가1                         StartPos 807, Length 13
        public long newqty1{ get; set; } // [newqty1  ,   16] 신규체결수량1                   StartPos 820, Length 16
        public long qdtqty1{ get; set; } // [qdtqty1  ,   16] 청산체결수량1                   StartPos 836, Length 16
        public long allexecamt1{ get; set; } // [allexecamt1  ,   16] 전체체결금액1                   StartPos 852, Length 16
        public string fnoIsuno2{ get; set; } // [fnoIsuno2,    8] 선물옵션종목번호2               StartPos 868, Length 8
        public string bnstp2{ get; set; } // [bnstp2,    1] 매매구분2                       StartPos 876, Length 1
        public decimal execprc2{ get; set; } // [execprc2, 13.2] 체결가2                         StartPos 877, Length 13
        public long newqty2{ get; set; } // [newqty2  ,   16] 신규체결수량2                   StartPos 890, Length 16
        public long lqdtqty2{ get; set; } // [lqdtqty2  ,   16] 청산체결수량2                   StartPos 906, Length 16
        public long allexecamt2{ get; set; } // [allexecamt2  ,   16] 전체체결금액2                   StartPos 922, Length 16
        public long dps{ get; set; } // [dps  ,   16] 예수금                          StartPos 938, Length 16
        public long ftsubtdsgnamt{ get; set; } // [ftsubtdsgnamt  ,   16] 선물대용지정금액                StartPos 954, Length 16
        public long mgn{ get; set; } // [mgn  ,   16] 증거금                          StartPos 970, Length 16
        public long mnymgn{ get; set; } // [mnymgn  ,   16] 증거금현금                      StartPos 986, Length 16
        public long ordableamt{ get; set; } // [ordableamt  ,   16] 주문가능금액                    StartPos 1002, Length 16
        public long mnyordableamt{ get; set; } // [mnyordableamt  ,   16] 주문가능현금액                  StartPos 1018, Length 16
        public string fnoIsuno_1{ get; set; } // [fnoIsuno_1,    8] 잔고 종목번호1                  StartPos 1034, Length 8
        public string bnstp_1{ get; set; } // [bnstp_1,    1] 잔고 매매구분1                  StartPos 1042, Length 1
        public long unsttqty_1{ get; set; } // [unsttqty_1  ,   16] 미결제수량1                     StartPos 1043, Length 16
        public long lqdtableqty_1{ get; set; } // [lqdtableqty_1  ,   16] 주문가능수량1                   StartPos 1059, Length 16
        public decimal avrprc_1{ get; set; } // [avrprc_1, 13.2] 평균가1                         StartPos 1075, Length 13
        public string fnoIsuno_2{ get; set; } // [fnoIsuno_2,    8] 잔고 종목번호2                  StartPos 1088, Length 8
        public string bnstp_2{ get; set; } // [bnstp_2,    1] 잔고 매매구분2                  StartPos 1096, Length 1
        public long unsttqty_2{ get; set; } // [unsttqty_2  ,   16] 미결제수량2                     StartPos 1097, Length 16
        public long lqdtableqty_2{ get; set; } // [lqdtableqty_2  ,   16] 주문가능수량2                   StartPos 1113, Length 16
        public decimal avrprc_2{ get; set; } // [avrprc_2, 13.2] 평균가2                         StartPos 1129, Length 13
    }
}