namespace XingBot.res
{
    // 증시주변자금추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8428InBlock
    {
        public string fdate{ get; set; } // [string,    8] from일자                        StartPos 0, Length 8
        public string tdate{ get; set; } // [string,    8] to일자                          StartPos 9, Length 8
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 18, Length 1
        public string key_date{ get; set; } // [string,    8] 날짜                            StartPos 20, Length 8
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 29, Length 3
        public string cnt{ get; set; } // [string,    3] 조회건수                        StartPos 33, Length 3
    }

    public struct _t8428OutBlock
    {
        public string date{ get; set; } // [string,    8] 날짜CTS                         StartPos 0, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 9, Length 4
    }

    public struct _t8428OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public decimal jisu{ get; set; } // [float ,  7.2] 지수                            StartPos 9, Length 7
        public string sign{ get; set; } // [string,    1] 대비구분                        StartPos 17, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 대비                            StartPos 19, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 26, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 33, Length 12
        public long custmoney{ get; set; } // [long  ,   12] 고객예탁금_억원                 StartPos 46, Length 12
        public long yecha{ get; set; } // [long  ,   12] 예탁증감_억원                   StartPos 59, Length 12
        public decimal vol{ get; set; } // [float ,  6.2] 회전율                          StartPos 72, Length 6
        public long outmoney{ get; set; } // [long  ,   12] 미수금_억원                     StartPos 79, Length 12
        public long trjango{ get; set; } // [long  ,   12] 신용잔고_억원                   StartPos 92, Length 12
        public long futymoney{ get; set; } // [long  ,   12] 선물예수금_억원                 StartPos 105, Length 12
        public long stkmoney{ get; set; } // [long  ,    8] 주식형_억원                     StartPos 118, Length 8
        public long mstkmoney{ get; set; } // [long  ,    8] 혼합형_억원(주식)               StartPos 127, Length 8
        public long mbndmoney{ get; set; } // [long  ,    8] 혼합형_억원(채권)               StartPos 136, Length 8
        public long bndmoney{ get; set; } // [long  ,    8] 채권형_억원                     StartPos 145, Length 8
        public long bndsmoney{ get; set; } // [long  ,    8] 필러(구.단기채권)               StartPos 154, Length 8
        public long mmfmoney{ get; set; } // [long  ,    8] MMF_억원(주식)                  StartPos 163, Length 8
    }
}