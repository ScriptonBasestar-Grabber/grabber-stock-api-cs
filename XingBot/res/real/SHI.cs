namespace XingBot.res
{
    // 상/하한가진입 ( ATTR, KEY=1, GROUP=1 )
    public class _SHI_InBlock
    {
        public string updnlmtgubun{ get; set; } // [string,    1] 상/하한구분                     StartPos 0, Length 1
    }

    public class _SHI_OutBlock
    {
        public string sijanggubun{ get; set; } // [string,    1] 거래소/코스닥구분               StartPos 0, Length 1
        public string hname{ get; set; } // [string,   20] 종목명                          StartPos 2, Length 20
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 23, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 32, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 34, Length 8
        public decimal drate{ get; set; } // [float ,  6.2] 등락율                          StartPos 43, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 50, Length 12
        public decimal volincrate{ get; set; } // [float , 12.2] 거래증가율                      StartPos 63, Length 12
        public long totofferrem{ get; set; } // [long  ,   12] 매도호가총수량                  StartPos 76, Length 12
        public long totbidrem{ get; set; } // [long  ,   12] 매수호가총수량                  StartPos 89, Length 12
        public string updnlmtstime{ get; set; } // [string,    6] 상한가/하한가최종진입시간       StartPos 102, Length 6
        public long updnlmtdaycnt{ get; set; } // [long  ,    3] 상한가/하한가연속일수           StartPos 109, Length 3
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 113, Length 12
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 126, Length 6
        public string gwangubun{ get; set; } // [string,    1] 관리구분                        StartPos 133, Length 1
        public string undergubun{ get; set; } // [string,    1] 이상급등구분                    StartPos 135, Length 1
        public string tgubun{ get; set; } // [string,    1] 투자유의구분                    StartPos 137, Length 1
        public string wgubun{ get; set; } // [string,    1] 우선주구분                      StartPos 139, Length 1
        public string dishonest{ get; set; } // [string,    1] 불성실구분                      StartPos 141, Length 1
        public string jkrate{ get; set; } // [string,    1] 증거금률                        StartPos 143, Length 1
    }
}