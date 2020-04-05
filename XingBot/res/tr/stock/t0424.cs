namespace XingBot.res.tr
{
    // 주식 잔고2 ( ATTR,TUXCODE=T0424,HEADTYPE=D )
    internal struct _t0424InBlock
    {
        public string accno; // [string,   11] 계좌번호                        StartPos 0, Length 11
        public string passwd; // [string,    8] 비밀번호                        StartPos 12, Length 8
        public string prcgb; // [string,    1] 단가구분                        StartPos 21, Length 1
        public string chegb; // [string,    1] 체결구분                        StartPos 23, Length 1
        public string dangb; // [string,    1] 단일가구분                      StartPos 25, Length 1
        public string charge; // [string,    1] 제비용포함여부                  StartPos 27, Length 1
        public string cts_expcode; // [string,   22] CTS_종목번호                    StartPos 29, Length 22
    }

    internal struct _t0424OutBlock
    {
        public long sunamt; // [long  ,   18] 추정순자산                      StartPos 0, Length 18
        public long dtsunik; // [long  ,   18] 실현손익                        StartPos 19, Length 18
        public long mamt; // [long  ,   18] 매입금액                        StartPos 38, Length 18
        public long sunamt1; // [long  ,   18] 추정D2예수금                    StartPos 57, Length 18
        public string cts_expcode; // [string,   22] CTS_종목번호                    StartPos 76, Length 22
        public long tappamt; // [long  ,   18] 평가금액                        StartPos 99, Length 18
        public long tdtsunik; // [long  ,   18] 평가손익                        StartPos 118, Length 18
    }

    internal struct _t0424OutBlock1
    {
        public string expcode; // [string,   12] 종목번호                        StartPos 0, Length 12
        public string jangb; // [string,   10] 잔고구분                        StartPos 13, Length 10
        public long janqty; // [long  ,   18] 잔고수량                        StartPos 24, Length 18
        public long mdposqt; // [long  ,   18] 매도가능수량                    StartPos 43, Length 18
        public long pamt; // [long  ,   18] 평균단가                        StartPos 62, Length 18
        public long mamt; // [long  ,   18] 매입금액                        StartPos 81, Length 18
        public long sinamt; // [long  ,   18] 대출금액                        StartPos 100, Length 18
        public string lastdt; // [string,    8] 만기일자                        StartPos 119, Length 8
        public long msat; // [long  ,   18] 당일매수금액                    StartPos 128, Length 18
        public long mpms; // [long  ,   18] 당일매수단가                    StartPos 147, Length 18
        public long mdat; // [long  ,   18] 당일매도금액                    StartPos 166, Length 18
        public long mpmd; // [long  ,   18] 당일매도단가                    StartPos 185, Length 18
        public long jsat; // [long  ,   18] 전일매수금액                    StartPos 204, Length 18
        public long jpms; // [long  ,   18] 전일매수단가                    StartPos 223, Length 18
        public long jdat; // [long  ,   18] 전일매도금액                    StartPos 242, Length 18
        public long jpmd; // [long  ,   18] 전일매도단가                    StartPos 261, Length 18
        public long sysprocseq; // [long  ,   10] 처리순번                        StartPos 280, Length 10
        public string loandt; // [string,    8] 대출일자                        StartPos 291, Length 8
        public string hname; // [string,   20] 종목명                          StartPos 300, Length 20
        public string marketgb; // [string,    1] 시장구분                        StartPos 321, Length 1
        public string jonggb; // [string,    1] 종목구분                        StartPos 323, Length 1
        public float janrt; // [float , 10.2] 보유비중                        StartPos 325, Length 10
        public long price; // [long  ,    8] 현재가                          StartPos 336, Length 8
        public long appamt; // [long  ,   18] 평가금액                        StartPos 345, Length 18
        public long dtsunik; // [long  ,   18] 평가손익                        StartPos 364, Length 18
        public float sunikrt; // [float , 10.2] 수익율                          StartPos 383, Length 10
        public long fee; // [long  ,   10] 수수료                          StartPos 394, Length 10
        public long tax; // [long  ,   10] 제세금                          StartPos 405, Length 10
        public long sininter; // [long  ,   10] 신용이자                        StartPos 416, Length 10
    }
}