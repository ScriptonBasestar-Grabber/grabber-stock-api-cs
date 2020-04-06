namespace XingBot.res
{
    // 업종전체조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t8424InBlock
    {
        public string gubun1; // [string,    1] 구분1                           StartPos 0, Length 1
    }

    public struct _t8424OutBlock
    {
        public string hname; // [string,   20] 업종명                          StartPos 0, Length 20
        public string upcode; // [string,    3] 업종코드                        StartPos 21, Length 3
    }
}