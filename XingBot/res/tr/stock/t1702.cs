namespace XingBot.res
{
    // 외인/기관 종목별동향 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1702InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string todt; // [string,    8] 종료일자                        StartPos 7, Length 8
        public string volvalgb; // [string,    1] 금액수량구분(0:금액1:수량2:단가 StartPos 16, Length 1
        public string msmdgb; // [string,    1] 매수매도구분(0:순매수1:매수2:매 StartPos 18, Length 1
        public string cumulgb; // [string,    1] 누적구분(0:일간1:누적)          StartPos 20, Length 1
        public string cts_date; // [string,    8] CTSDATE                         StartPos 22, Length 8
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 31, Length 4
    }

    public struct _t1702OutBlock
    {
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 0, Length 4
        public string cts_date; // [string,    8] CTSDATE                         StartPos 5, Length 8
    }

    public struct _t1702OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 36, Length 12
        public long amt0000; // [long  ,   12] 사모펀드                        StartPos 49, Length 12
        public long amt0001; // [long  ,   12] 증권                            StartPos 62, Length 12
        public long amt0002; // [long  ,   12] 보험                            StartPos 75, Length 12
        public long amt0003; // [long  ,   12] 투신                            StartPos 88, Length 12
        public long amt0004; // [long  ,   12] 은행                            StartPos 101, Length 12
        public long amt0005; // [long  ,   12] 종금                            StartPos 114, Length 12
        public long amt0006; // [long  ,   12] 기금                            StartPos 127, Length 12
        public long amt0007; // [long  ,   12] 기타법인                        StartPos 140, Length 12
        public long amt0008; // [long  ,   12] 개인                            StartPos 153, Length 12
        public long amt0009; // [long  ,   12] 등록외국인                      StartPos 166, Length 12
        public long amt0010; // [long  ,   12] 미등록외국인                    StartPos 179, Length 12
        public long amt0011; // [long  ,   12] 국가외                          StartPos 192, Length 12
        public long amt0018; // [long  ,   12] 기관                            StartPos 205, Length 12
        public long amt0088; // [long  ,   12] 외인계(등록+미등록)             StartPos 218, Length 12
        public long amt0099; // [long  ,   12] 기타계(기타+국가)               StartPos 231, Length 12
    }
}