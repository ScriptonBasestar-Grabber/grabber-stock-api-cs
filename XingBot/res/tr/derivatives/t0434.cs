namespace XingBot.res
{
    // 선물/옵션 체결/미체결 ( TUXCODE=T0434,HEADTYPE=D )
    public struct _t0434InBlock
    {
        public string accno{ get; set; } // [accno,   11] 계좌번호                        StartPos 0, Length 11
        public string passwd{ get; set; } // [passwd,    8] 비밀번호                        StartPos 11, Length 8
        public string expcode{ get; set; } // [expcode,    8] 종목번호                        StartPos 19, Length 8
        public string chegb{ get; set; } // [chegb,    1] 체결구분                        StartPos 27, Length 1
        public string sortgb{ get; set; } // [sortgb,    1] 정렬순서                        StartPos 28, Length 1
        public string cts_ordno{ get; set; } // [cts_ordno,    7] CTS_주문번호                    StartPos 29, Length 7
    }

    public struct _t0434OutBlock
    {
        public string cts_ordno{ get; set; } // [cts_ordno,    7] CTS_주문번호                    StartPos 0, Length 7
    }

    public struct _t0434OutBlock1
    {
        public long ordno{ get; set; } // [ordno  ,    7] 주문번호                        StartPos 0, Length 7
        public long orgordno{ get; set; } // [orgordno  ,    7] 원주문번호                      StartPos 7, Length 7
        public string medosu{ get; set; } // [medosu,   10] 구분                            StartPos 14, Length 10
        public string ordgb{ get; set; } // [ordgb,   20] 유형                            StartPos 24, Length 20
        public long qty{ get; set; } // [qty  ,    9] 주문수량                        StartPos 44, Length 9
        public decimal price{ get; set; } // [price ,  9.2] 주문가격                        StartPos 53, Length 9
        public long cheqty{ get; set; } // [cheqty  ,    9] 체결수량                        StartPos 62, Length 9
        public decimal cheprice{ get; set; } // [cheprice ,  9.2] 체결가격                        StartPos 71, Length 9
        public long ordrem{ get; set; } // [ordrem  ,    9] 미체결잔량                      StartPos 80, Length 9
        public string status{ get; set; } // [status,   10] 상태                            StartPos 89, Length 10
        public string ordtime{ get; set; } // [ordtime,    8] 주문시간                        StartPos 99, Length 8
        public string ordermtd{ get; set; } // [ordermtd,   10] 주문매체                        StartPos 107, Length 10
        public string expcode{ get; set; } // [expcode,    8] 종목번호                        StartPos 117, Length 8
        public string rtcode{ get; set; } // [rtcode,    3] 사유코드                        StartPos 125, Length 3
        public long sysprocseq{ get; set; } // [sysprocseq  ,   10] 처리순번                        StartPos 128, Length 10
        public string hogatype{ get; set; } // [hogatype,    1] 호가타입                        StartPos 138, Length 1
    }
}