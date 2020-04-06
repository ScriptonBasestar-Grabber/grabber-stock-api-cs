namespace XingBot.real.res
{
    // 장운영정보 ( KEY=1, GROUP=1 )
    public struct _JIF_InBlock
    {
        public string jangubun; // [jangubun,    1] 장구분                          StartPos 0, Length 1
    }

    public struct _JIF_OutBlock
    {
        public string jangubun; // [jangubun,    1] 장구분                          StartPos 0, Length 1
        public string jstatus; // [jstatus,    2] 장상태                          StartPos 1, Length 2
    }
}