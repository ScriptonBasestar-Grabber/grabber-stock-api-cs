namespace XingBot.res
{
    // 상/하한가이탈 ( ATTR, KEY=1, GROUP=1 )
    public struct _SHO_InBlock
    {
        public char updnlmtgubun{ get; set; } // [string,    1] 상/하한구분                     StartPos 0, Length 1
    }

    public struct _SHO_OutBlock
    {
        public string sijanggubun{ get; set; } // [string,    1] 거래소/코스닥구분               StartPos 0, Length 1
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 2, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 23, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 32, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 34, Length 8
        public decimal drate{ get; set; } // [float ,  6.2] 등락율                          StartPos 43, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 50, Length 12
        public decimal volincrate{ get; set; } // [float , 12.2] 거래증가율                      StartPos 63, Length 12
        public long updnlmtprice{ get; set; } // [long  ,    8] 상/하한가                       StartPos 76, Length 8
        public long updnlmtchange{ get; set; } // [long  ,    8] 상/하한가대비                   StartPos 85, Length 8
        public decimal updnlmtdrate{ get; set; } // [float ,  6.2] 상/하한가대비율                 StartPos 94, Length 6
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 101, Length 12
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 114, Length 6
        public string gwangubun{ get; set; } // [string,    1] 관리구분                        StartPos 121, Length 1
        public string undergubun{ get; set; } // [string,    1] 이상급등구분                    StartPos 123, Length 1
        public string tgubun{ get; set; } // [string,    1] 투자유의구분                    StartPos 125, Length 1
        public string wgubun{ get; set; } // [string,    1] 우선주구분                      StartPos 127, Length 1
        public string dishonest{ get; set; } // [string,    1] 불성실구분                      StartPos 129, Length 1
        public string jkrate{ get; set; } // [string,    1] 증거금률                        StartPos 131, Length 1
    }
}