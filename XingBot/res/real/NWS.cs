namespace XingBot.res
{
    // 실시간 뉴스 제목 패킷 ( KEY=6, GROUP=1 )
    public struct _NWS_InBlock
    {
        public string nwcode; // [nwcode,    6] 뉴스코드                        StartPos 0, Length 6
    }

    public struct _NWS_OutBlock
    {
        public string date; // [date,    8] 날짜                            StartPos 0, Length 8
        public string time; // [time,    6] 시간                            StartPos 8, Length 6
        public string id; // [id,    2] 뉴스구분자                      StartPos 14, Length 2
        public string realkey; // [realkey,   24] 키값                            StartPos 16, Length 24
        public string title; // [title,  300] 제목                            StartPos 40, Length 300
        public string code; // [code,  240] 단축종목코드                    StartPos 340, Length 240
        public long bodysize; // [bodysize  ,    8] BODY길이                        StartPos 580, Length 8
    }
}