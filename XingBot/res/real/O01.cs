namespace XingBot.res
{
    // 선물접수 ( KEY=8, GROUP=1 )
    public struct _O01_InBlock
    {
    }

    public struct _O01_OutBlock
    {
        public long lineseq; // [lineseq  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno; // [accno,   11] 계좌번호                        StartPos 10, Length 11
        public string user; // [user,    8] 조작자ID                        StartPos 21, Length 8
        public long len; // [len  ,    6] 헤더길이                        StartPos 29, Length 6
        public string gubun; // [gubun,    1] 헤더구분                        StartPos 35, Length 1
        public string compress; // [compress,    1] 압축구분                        StartPos 36, Length 1
        public string encrypt; // [encrypt,    1] 암호구분                        StartPos 37, Length 1
        public long offset; // [offset  ,    3] 공통시작지점                    StartPos 38, Length 3
        public string trcode; // [trcode,    8] TRCODE                          StartPos 41, Length 8
        public string compid; // [compid,    3] 이용사번호                      StartPos 49, Length 3
        public string userid; // [userid,   16] 사용자ID                        StartPos 52, Length 16
        public string media; // [media,    2] 접속매체                        StartPos 68, Length 2
        public string ifid; // [ifid,    3] I/F일련번호                     StartPos 70, Length 3
        public string seq; // [seq,    9] 전문일련번호                    StartPos 73, Length 9
        public string trid; // [trid,   16] TR추적ID                        StartPos 82, Length 16
        public string pubip; // [pubip,   12] 공인IP                          StartPos 98, Length 12
        public string prvip; // [prvip,   12] 사설IP                          StartPos 110, Length 12
        public string pcbpno; // [pcbpno,    3] 처리지점번호                    StartPos 122, Length 3
        public string bpno; // [bpno,    3] 지점번호                        StartPos 125, Length 3
        public string termno; // [termno,    8] 단말번호                        StartPos 128, Length 8
        public string lang; // [lang,    1] 언어구분                        StartPos 136, Length 1
        public long proctm; // [proctm  ,    9] AP처리시간                      StartPos 137, Length 9
        public string msgcode; // [msgcode,    4] 메세지코드                      StartPos 146, Length 4
        public string outgu; // [outgu,    1] 메세지출력구분                  StartPos 150, Length 1
        public string compreq; // [compreq,    1] 압축요청구분                    StartPos 151, Length 1
        public string funckey; // [funckey,    4] 기능키                          StartPos 152, Length 4
        public long reqcnt; // [reqcnt  ,    4] 요청레코드개수                  StartPos 156, Length 4
        public string filler; // [filler,    6] 예비영역                        StartPos 160, Length 6
        public string cont; // [cont,    1] 연속구분                        StartPos 166, Length 1
        public string contkey; // [contkey,   18] 연속키값                        StartPos 167, Length 18
        public long varlen; // [varlen  ,    2] 가변시스템길이                  StartPos 185, Length 2
        public long varhdlen; // [varhdlen  ,    2] 가변해더길이                    StartPos 187, Length 2
        public long varmsglen; // [varmsglen  ,    2] 가변메시지길이                  StartPos 189, Length 2
        public string trsrc; // [trsrc,    1] 조회발원지                      StartPos 191, Length 1
        public string eventid; // [eventid,    4] I/F이벤트ID                     StartPos 192, Length 4
        public string ifinfo; // [ifinfo,    4] I/F정보                         StartPos 196, Length 4
        public string filler1; // [filler1,   41] 예비영역                        StartPos 200, Length 41
        public string trcode1; // [trcode1,    4] tr코드                          StartPos 241, Length 4
        public string firmno; // [firmno,    3] 회사번호                        StartPos 245, Length 3
        public string acntno; // [acntno,   11] 계좌번호                        StartPos 248, Length 11
        public string acntno1; // [acntno1,    9] 계좌번호                        StartPos 259, Length 9
        public string acntnm; // [acntnm,   40] 계좌명                          StartPos 268, Length 40
        public string brnno; // [brnno,    3] 지점번호                        StartPos 308, Length 3
        public string ordmktcode; // [ordmktcode,    2] 주문시장코드                    StartPos 311, Length 2
        public string ordno1; // [ordno1,    3] 주문번호                        StartPos 313, Length 3
        public long ordno; // [ordno  ,    7] 주문번호                        StartPos 316, Length 7
        public string orgordno1; // [orgordno1,    3] 원주문번호                      StartPos 323, Length 3
        public long orgordno; // [orgordno  ,    7] 원주문번호                      StartPos 326, Length 7
        public string prntordno; // [prntordno,    3] 모주문번호                      StartPos 333, Length 3
        public long prntordno1; // [prntordno1  ,    7] 모주문번호                      StartPos 336, Length 7
        public string isuno; // [isuno,   12] 종목번호                        StartPos 343, Length 12
        public string fnoIsuno; // [fnoIsuno,    8] 선물옵션종목번호                StartPos 355, Length 8
        public string fnoIsunm; // [fnoIsunm,   40] 선물옵션종목명                  StartPos 363, Length 40
        public string pdgrpcode; // [pdgrpcode,    2] 상품군분류코드                  StartPos 403, Length 2
        public string fnoIsuptntp; // [fnoIsuptntp,    1] 선물옵션종목유형구분            StartPos 405, Length 1
        public string bnstp; // [bnstp,    1] 매매구분                        StartPos 406, Length 1
        public string mrctp; // [mrctp,    1] 정정취소구분                    StartPos 407, Length 1
        public long ordqty; // [ordqty  ,   16] 주문수량                        StartPos 408, Length 16
        public string hogatype; // [hogatype,    2] 호가유형코드                    StartPos 424, Length 2
        public string mmgb; // [mmgb,    2] 거래유형코드                    StartPos 426, Length 2
        public decimal ordprc; // [ordprc, 13.2] 주문가격                        StartPos 428, Length 13
        public long unercqty; // [unercqty  ,   16] 미체결수량                      StartPos 441, Length 16
        public string commdacode; // [commdacode,    2] 통신매체                        StartPos 457, Length 2
        public string peeamtcode; // [peeamtcode,    2] 수수료합산코드                  StartPos 459, Length 2
        public string mgempno; // [mgempno,    9] 관리사원                        StartPos 461, Length 9
        public decimal fnotrdunitamt; // [fnotrdunitamt, 19.8] 선물옵션거래단위금액            StartPos 470, Length 19
        public string trxtime; // [trxtime,    9] 처리시각                        StartPos 489, Length 9
        public string strtgcode; // [strtgcode,    6] 전략코드                        StartPos 498, Length 6
        public string grpId; // [grpId,   20] 그룹Id                          StartPos 504, Length 20
        public string ordseqno; // [ordseqno,   10] 주문회차                        StartPos 524, Length 10
        public string ptflno; // [ptflno,   10] 포트폴리오 번호                 StartPos 534, Length 10
        public string bskno; // [bskno,   10] 바스켓번호                      StartPos 544, Length 10
        public string trchno; // [trchno,   10] 트렌치번호                      StartPos 554, Length 10
        public string Itemno; // [Itemno,   10] 아이템번호                      StartPos 564, Length 10
        public string userId; // [userId,   16] 주문자Id                        StartPos 574, Length 16
        public string opdrtnno; // [opdrtnno,   12] 운영지시번호                    StartPos 590, Length 12
        public string rjtcode; // [rjtcode,    3] 부적격코드                      StartPos 602, Length 3
        public long mrccnfqty; // [mrccnfqty  ,   16] 정정취소확인수량                StartPos 605, Length 16
        public long orgordunercqty; // [orgordunercqty  ,   16] 원주문미체결수량                StartPos 621, Length 16
        public long orgordmrcqty; // [orgordmrcqty  ,   16] 원주문정정취소수량              StartPos 637, Length 16
        public string ctrcttime; // [ctrcttime,    8] 약정시각(체결시각)              StartPos 653, Length 8
        public string ctrctno; // [ctrctno,   10] 약정번호                        StartPos 661, Length 10
        public decimal execprc; // [execprc, 13.2] 체결가격                        StartPos 671, Length 13
        public long execqty; // [execqty  ,   16] 체결수량                        StartPos 684, Length 16
        public long newqty; // [newqty  ,   16] 신규체결수량                    StartPos 700, Length 16
        public long qdtqty; // [qdtqty  ,   16] 청산체결수량                    StartPos 716, Length 16
        public long lastqty; // [lastqty  ,   16] 최종결제수량                    StartPos 732, Length 16
        public long lallexecqty; // [lallexecqty  ,   16] 전체체결수량                    StartPos 748, Length 16
        public long allexecamt; // [allexecamt  ,   16] 전체체결금액                    StartPos 764, Length 16
        public string fnobalevaltp; // [fnobalevaltp,    1] 잔고평가구분                    StartPos 780, Length 1
        public long bnsplamt; // [bnsplamt  ,   16] 매매손익금액                    StartPos 781, Length 16
        public string fnoIsuno1; // [fnoIsuno1,    8] 선물옵션종목번호1               StartPos 797, Length 8
        public string bnstp1; // [bnstp1,    1] 매매구분1                       StartPos 805, Length 1
        public decimal execprc1; // [execprc1, 13.2] 체결가1                         StartPos 806, Length 13
        public long newqty1; // [newqty1  ,   16] 신규체결수량1                   StartPos 819, Length 16
        public long qdtqty1; // [qdtqty1  ,   16] 청산체결수량1                   StartPos 835, Length 16
        public long allexecamt1; // [allexecamt1  ,   16] 전체체결금액1                   StartPos 851, Length 16
        public string fnoIsuno2; // [fnoIsuno2,    8] 선물옵션종목번호2               StartPos 867, Length 8
        public string bnstp2; // [bnstp2,    1] 매매구분2                       StartPos 875, Length 1
        public decimal execprc2; // [execprc2, 13.2] 체결가2                         StartPos 876, Length 13
        public long newqty2; // [newqty2  ,   16] 신규체결수량2                   StartPos 889, Length 16
        public long lqdtqty2; // [lqdtqty2  ,   16] 청산체결수량2                   StartPos 905, Length 16
        public long allexecamt2; // [allexecamt2  ,   16] 전체체결금액2                   StartPos 921, Length 16
        public long dps; // [dps  ,   16] 예수금                          StartPos 937, Length 16
        public long ftsubtdsgnamt; // [ftsubtdsgnamt  ,   16] 선물대용지정금액                StartPos 953, Length 16
        public long mgn; // [mgn  ,   16] 증거금                          StartPos 969, Length 16
        public long mnymgn; // [mnymgn  ,   16] 증거금현금                      StartPos 985, Length 16
        public long ordableamt; // [ordableamt  ,   16] 주문가능금액                    StartPos 1001, Length 16
        public long mnyordableamt; // [mnyordableamt  ,   16] 주문가능현금액                  StartPos 1017, Length 16
        public string fnoIsuno_1; // [fnoIsuno_1,    8] 잔고 종목번호1                  StartPos 1033, Length 8
        public string bnstp_1; // [bnstp_1,    1] 잔고 매매구분1                  StartPos 1041, Length 1
        public long unsttqty_1; // [unsttqty_1  ,   16] 미결제수량1                     StartPos 1042, Length 16
        public long lqdtableqty_1; // [lqdtableqty_1  ,   16] 주문가능수량1                   StartPos 1058, Length 16
        public decimal avrprc_1; // [avrprc_1, 13.2] 평균가1                         StartPos 1074, Length 13
        public string fnoIsuno_2; // [fnoIsuno_2,    8] 잔고 종목번호2                  StartPos 1087, Length 8
        public string bnstp_2; // [bnstp_2,    1] 잔고 매매구분2                  StartPos 1095, Length 1
        public long unsttqty_2; // [unsttqty_2  ,   16] 미결제수량2                     StartPos 1096, Length 16
        public long lqdtableqty_2; // [lqdtableqty_2  ,   16] 주문가능수량2                   StartPos 1112, Length 16
        public decimal avrprc_2; // [avrprc_2, 13.2] 평균가2                         StartPos 1128, Length 13
    }
}