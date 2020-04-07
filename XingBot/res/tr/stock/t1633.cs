namespace XingBot.res
{
    // 기간별 프로그램 매매추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1633InBlock
    {
        public string gubun{ get; set; } // [string,    1] 시장구분                        StartPos 0, Length 1
        public string gubun1{ get; set; } // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun2{ get; set; } // [string,    1] 수치누적구분                    StartPos 4, Length 1
        public string gubun3{ get; set; } // [string,    1] 일주월구분                      StartPos 6, Length 1
        public string fdate{ get; set; } // [string,    8] from일자                        StartPos 8, Length 8
        public string tdate{ get; set; } // [string,    8] to일자                          StartPos 17, Length 8
        public string gubun4{ get; set; } // [string,    1] 직전대비증감구분                StartPos 26, Length 1
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 28, Length 8
    }

    public struct _t1633OutBlock
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 9, Length 4
    }

    public struct _t1633OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public decimal jisu{ get; set; } // [float ,  6.2] KP200                           StartPos 9, Length 6
        public string sign{ get; set; } // [string,    1] 대비구분                        StartPos 16, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 대비                            StartPos 18, Length 6
        public long tot3{ get; set; } // [long  ,   12] 전체순매수                      StartPos 25, Length 12
        public long tot1{ get; set; } // [long  ,   12] 전체매수                        StartPos 38, Length 12
        public long tot2{ get; set; } // [long  ,   12] 전체매도                        StartPos 51, Length 12
        public long cha3{ get; set; } // [long  ,   12] 차익순매수                      StartPos 64, Length 12
        public long cha1{ get; set; } // [long  ,   12] 차익매수                        StartPos 77, Length 12
        public long cha2{ get; set; } // [long  ,   12] 차익매도                        StartPos 90, Length 12
        public long bcha3{ get; set; } // [long  ,   12] 비차익순매수                    StartPos 103, Length 12
        public long bcha1{ get; set; } // [long  ,   12] 비차익매수                      StartPos 116, Length 12
        public long bcha2{ get; set; } // [long  ,   12] 비차익매도                      StartPos 129, Length 12
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 142, Length 12
    }
}