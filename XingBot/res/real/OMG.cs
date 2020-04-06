namespace XingBot.real.res
{
    // KOSPI200옵션민감도 ( ATTR, KEY=8, GROUP=1 )
    public struct _OMG_InBlock
    {
        public string optcode; // [string,    8] 옵션코드                        StartPos 0, Length 8
    }

    public struct _OMG_OutBlock
    {
        public string chetime; // [string,    6] 체결시간                        StartPos 0, Length 6
        public decimal actprice; // [float ,  6.2] 행사가                          StartPos 7, Length 6
        public decimal k200jisu; // [float ,  6.2] KOSPI200지수                    StartPos 14, Length 6
        public decimal fut200jisu; // [float ,  6.2] 선물가격                        StartPos 21, Length 6
        public decimal price; // [float ,  6.2] 현재가                          StartPos 28, Length 6
        public decimal capimpv; // [float ,  6.2] 대표내재변동성                  StartPos 35, Length 6
        public decimal impv; // [float ,  6.2] 내재변동성                      StartPos 42, Length 6
        public decimal delt; // [float ,  7.4] 델타(블랙숄즈)                  StartPos 49, Length 7
        public decimal gama; // [float ,  7.4] 감마(블랙숄즈)                  StartPos 57, Length 7
        public decimal ceta; // [float ,  7.4] 세타(블랙숄즈)                  StartPos 65, Length 7
        public decimal vega; // [float ,  7.4] 베가(블랙숄즈)                  StartPos 73, Length 7
        public decimal rhox; // [float ,  7.4] 로우(블랙숄즈)                  StartPos 81, Length 7
        public decimal theoryprice; // [float ,  6.2] 이론가(블랙숄즈)                StartPos 89, Length 6
        public decimal bimpv; // [float ,  6.2] 전일가내재변동성                StartPos 96, Length 6
        public decimal offerimpv; // [float ,  6.2] 매도가내재변동성                StartPos 103, Length 6
        public decimal bidimpv; // [float ,  6.2] 매수가내재변동성                StartPos 110, Length 6
        public string optcode; // [string,    8] 옵션코드                        StartPos 117, Length 8
    }
}