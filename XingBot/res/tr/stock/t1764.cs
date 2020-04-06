namespace XingBot.res
{
    // 회원사리스트 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1764InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun1; // [string,    1] 구분1                           StartPos 7, Length 1
    }

    public struct _t1764OutBlock
    {
        public long rank; // [long  ,    4] 순위                            StartPos 0, Length 4
        public string tradno; // [string,    3] 거래원번호                      StartPos 5, Length 3
        public string tradname; // [string,   20] 거래원이름                      StartPos 9, Length 20
    }
}