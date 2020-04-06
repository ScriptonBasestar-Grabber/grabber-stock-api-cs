namespace XingBot.res
{
    // KOSPI프로그램매매종목별 ( ATTR, KEY=6, GROUP=1 )
    public struct _PH__InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    public struct _PH__OutBlock
    {
        public string time; // [string,    6] 수신시간                        StartPos 0, Length 6
        public long price; // [long  ,    8] 현재가                          StartPos 7, Length 8
        public long sign; // [long  ,    1] 전일대비구분                    StartPos 16, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 18, Length 8
        public long volume; // [long  ,   10] 누적거래량                      StartPos 27, Length 10
        public decimal drate; // [float ,  6.2] 등락율                          StartPos 38, Length 6
        public long cdhrem; // [long  ,    9] 차익매도호가 잔량               StartPos 45, Length 9
        public long cshrem; // [long  ,    9] 차익매수호가 잔량               StartPos 55, Length 9
        public long bdhrem; // [long  ,    9] 비차익매도호가 잔량             StartPos 65, Length 9
        public long bshrem; // [long  ,    9] 비차익매수호가 잔량             StartPos 75, Length 9
        public long cdhvolume; // [long  ,    9] 차익매도호가 수량               StartPos 85, Length 9
        public long cshvolume; // [long  ,    9] 차익매수호가 수량               StartPos 95, Length 9
        public long bdhvolume; // [long  ,    9] 비차익매도호가 수량             StartPos 105, Length 9
        public long bshvolume; // [long  ,    9] 비차익매수호가 수량             StartPos 115, Length 9
        public long dwcvolume; // [long  ,    9] 전체매도위탁체결수량            StartPos 125, Length 9
        public long swcvolume; // [long  ,    9] 전체매수위탁체결수량            StartPos 135, Length 9
        public long djcvolume; // [long  ,    9] 전체매도자기체결수량            StartPos 145, Length 9
        public long sjcvolume; // [long  ,    9] 전체매수자기체결수량            StartPos 155, Length 9
        public long tdvolume; // [long  ,    9] 전체매도체결수량                StartPos 165, Length 9
        public long tsvolume; // [long  ,    9] 전체매수체결수량                StartPos 175, Length 9
        public long tvol; // [long  ,    9] 전체순매수 수량                 StartPos 185, Length 9
        public long dwcvalue; // [long  ,   12] 전체매도위탁체결금액            StartPos 195, Length 12
        public long swcvalue; // [long  ,   12] 전체매수위탁체결금액            StartPos 208, Length 12
        public long djcvalue; // [long  ,   12] 전체매도자기체결금액            StartPos 221, Length 12
        public long sjcvalue; // [long  ,   12] 전체매수자기체결금액            StartPos 234, Length 12
        public long tdvalue; // [long  ,   12] 전체매도체결금액                StartPos 247, Length 12
        public long tsvalue; // [long  ,   12] 전체매수체결금액                StartPos 260, Length 12
        public long tval; // [long  ,   12] 전체순매수 금액                 StartPos 273, Length 12
        public long pdgvolume; // [long  ,    9] 매도 사전공시수량               StartPos 286, Length 9
        public long psgvolume; // [long  ,    9] 매수 사전공시수량               StartPos 296, Length 9
        public string shcode; // [string,    6] 종목코드                        StartPos 306, Length 6
    }
}