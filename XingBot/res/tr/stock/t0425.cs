namespace XingBot.real.res.tr
{
    // 주식 체결/미체결 ( ATTR,TUXCODE=T0425,HEADTYPE=D )
    public struct _t0425InBlock
    {
        public string accno; // [string,   11] 계좌번호                        StartPos 0, Length 11
        public string passwd; // [string,    8] 비밀번호                        StartPos 12, Length 8
        public string expcode; // [string,   12] 종목번호                        StartPos 21, Length 12
        public string chegb; // [string,    1] 체결구분                        StartPos 34, Length 1
        public string medosu; // [string,    1] 매매구분                        StartPos 36, Length 1
        public string sortgb; // [string,    1] 정렬순서                        StartPos 38, Length 1
        public string cts_ordno; // [string,   10] 주문번호                        StartPos 40, Length 10
    }

    public struct _t0425OutBlock
    {
        public long tqty; // [long  ,   18] 총주문수량                      StartPos 0, Length 18
        public long tcheqty; // [long  ,   18] 총체결수량                      StartPos 19, Length 18
        public long tordrem; // [long  ,   18] 총미체결수량                    StartPos 38, Length 18
        public long cmss; // [long  ,   18] 추정수수료                      StartPos 57, Length 18
        public long tamt; // [long  ,   18] 총주문금액                      StartPos 76, Length 18
        public long tmdamt; // [long  ,   18] 총매도체결금액                  StartPos 95, Length 18
        public long tmsamt; // [long  ,   18] 총매수체결금액                  StartPos 114, Length 18
        public long tax; // [long  ,   18] 추정제세금                      StartPos 133, Length 18
        public string cts_ordno; // [string,   10] 주문번호                        StartPos 152, Length 10
    }

    public struct _t0425OutBlock1
    {
        public long ordno; // [long  ,   10] 주문번호                        StartPos 0, Length 10
        public string expcode; // [string,   12] 종목번호                        StartPos 11, Length 12
        public string medosu; // [string,   10] 구분                            StartPos 24, Length 10
        public long qty; // [long  ,    9] 주문수량                        StartPos 35, Length 9
        public long price; // [long  ,    9] 주문가격                        StartPos 45, Length 9
        public long cheqty; // [long  ,    9] 체결수량                        StartPos 55, Length 9
        public long cheprice; // [long  ,    9] 체결가격                        StartPos 65, Length 9
        public long ordrem; // [long  ,    9] 미체결잔량                      StartPos 75, Length 9
        public long cfmqty; // [long  ,    9] 확인수량                        StartPos 85, Length 9
        public string status; // [string,   10] 상태                            StartPos 95, Length 10
        public long orgordno; // [long  ,   10] 원주문번호                      StartPos 106, Length 10
        public string ordgb; // [string,   20] 유형                            StartPos 117, Length 20
        public string ordtime; // [string,    8] 주문시간                        StartPos 138, Length 8
        public string ordermtd; // [string,   10] 주문매체                        StartPos 147, Length 10
        public long sysprocseq; // [long  ,   10] 처리순번                        StartPos 158, Length 10
        public string hogagb; // [string,    2] 호가유형                        StartPos 169, Length 2
        public long price1; // [long  ,    8] 현재가                          StartPos 172, Length 8
        public string orggb; // [string,    2] 주문구분                        StartPos 181, Length 2
        public string singb; // [string,    2] 신용구분                        StartPos 184, Length 2
        public string loandt; // [string,    8] 대출일자                        StartPos 187, Length 8
    }
}