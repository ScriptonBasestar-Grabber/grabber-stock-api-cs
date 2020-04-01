namespace XingBot.res
{
    // 상/하한가근접진입 ( ATTR, KEY=1, GROUP=1 )
    struct _SHC_InBlock
    {
        public string updnlmtgubun; // [string,    1] 상/하한구분                     StartPos 0, Length 1
    }

    struct _SHC_OutBlock
    {
        public string sijanggubun; // [string,    1] 거래소/코스닥구분               StartPos 0, Length 1
        public string hname; // [string,   20] 종목명                          StartPos 2, Length 20
        public long price; // [long  ,    8] 현재가                          StartPos 23, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 32, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 34, Length 8
        public float drate; // [float ,  6.2] 등락율                          StartPos 43, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 50, Length 12
        public float volincrate; // [float , 12.2] 거래증가율                      StartPos 63, Length 12
        public long updnlmtprice; // [long  ,    8] 상/하한가                       StartPos 76, Length 8
        public float updnlmtdrate; // [float ,  6.2] 상/하한가대비율                 StartPos 85, Length 6
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 92, Length 12
        public string shcode; // [string,    6] 단축코드                        StartPos 105, Length 6
        public string gwangubun; // [string,    1] 관리구분                        StartPos 112, Length 1
        public string undergubun; // [string,    1] 이상급등구분                    StartPos 114, Length 1
        public string tgubun; // [string,    1] 투자유의구분                    StartPos 116, Length 1
        public string wgubun; // [string,    1] 우선주구분                      StartPos 118, Length 1
        public string dishonest; // [string,    1] 불성실구분                      StartPos 120, Length 1
        public string jkrate; // [string,    1] 증거금률                        StartPos 122, Length 1
        public long updnlmtdaycnt; // [long  ,    3] 상한가/하한가연속일수           StartPos 124, Length 3
    }
}