namespace XingBot.res
{
    // KOSDAQ프로그램매매종목별 ( ATTR, KEY=6, GROUP=1 )
    public class _KH__InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _KH__OutBlock
    {
        public string time{ get; set; } // [string,    6] 수신시간                        StartPos 0, Length 6
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 7, Length 8
        public long sign{ get; set; } // [long  ,    1] 전일대비구분                    StartPos 16, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 18, Length 8
        public long volume{ get; set; } // [long  ,   10] 누적거래량                      StartPos 27, Length 10
        public decimal drate{ get; set; } // [float ,  6.2] 등락율                          StartPos 38, Length 6
        public long cdhrem{ get; set; } // [long  ,    9] 차익매도호가 잔량               StartPos 45, Length 9
        public long cshrem{ get; set; } // [long  ,    9] 차익매수호가 잔량               StartPos 55, Length 9
        public long bdhrem{ get; set; } // [long  ,    9] 비차익매도호가 잔량             StartPos 65, Length 9
        public long bshrem{ get; set; } // [long  ,    9] 비차익매수호가 잔량             StartPos 75, Length 9
        public long cdhvolume{ get; set; } // [long  ,    9] 차익매도호가 수량               StartPos 85, Length 9
        public long cshvolume{ get; set; } // [long  ,    9] 차익매수호가 수량               StartPos 95, Length 9
        public long bdhvolume{ get; set; } // [long  ,    9] 비차익매도호가 수량             StartPos 105, Length 9
        public long bshvolume{ get; set; } // [long  ,    9] 비차익매수호가 수량             StartPos 115, Length 9
        public long dwcvolume{ get; set; } // [long  ,    9] 전체매도위탁체결수량            StartPos 125, Length 9
        public long swcvolume{ get; set; } // [long  ,    9] 전체매수위탁체결수량            StartPos 135, Length 9
        public long djcvolume{ get; set; } // [long  ,    9] 전체매도자기체결수량            StartPos 145, Length 9
        public long sjcvolume{ get; set; } // [long  ,    9] 전체매수자기체결수량            StartPos 155, Length 9
        public long tdvolume{ get; set; } // [long  ,    9] 전체매도체결수량                StartPos 165, Length 9
        public long tsvolume{ get; set; } // [long  ,    9] 전체매수체결수량                StartPos 175, Length 9
        public long tvol{ get; set; } // [long  ,    9] 전체순매수 수량                 StartPos 185, Length 9
        public long dwcvalue{ get; set; } // [long  ,   12] 전체매도위탁체결금액            StartPos 195, Length 12
        public long swcvalue{ get; set; } // [long  ,   12] 전체매수위탁체결금액            StartPos 208, Length 12
        public long djcvalue{ get; set; } // [long  ,   12] 전체매도자기체결금액            StartPos 221, Length 12
        public long sjcvalue{ get; set; } // [long  ,   12] 전체매수자기체결금액            StartPos 234, Length 12
        public long tdvalue{ get; set; } // [long  ,   12] 전체매도체결금액                StartPos 247, Length 12
        public long tsvalue{ get; set; } // [long  ,   12] 전체매수체결금액                StartPos 260, Length 12
        public long tval{ get; set; } // [long  ,   12] 전체순매수 금액                 StartPos 273, Length 12
        public long pdgvolume{ get; set; } // [long  ,    9] 매도 사전공시수량               StartPos 286, Length 9
        public long psgvolume{ get; set; } // [long  ,    9] 매수 사전공시수량               StartPos 296, Length 9
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 306, Length 6
    }
}