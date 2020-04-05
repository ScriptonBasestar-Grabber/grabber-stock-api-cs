namespace XingBot.res.tr
{
    // 기간별 프로그램 매매추이 ( ATTR,BLOCK,HEADTYPE=A )
    internal struct _t1633InBlock
    {
        public string gubun; // [string,    1] 시장구분                        StartPos 0, Length 1
        public string gubun1; // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun2; // [string,    1] 수치누적구분                    StartPos 4, Length 1
        public string gubun3; // [string,    1] 일주월구분                      StartPos 6, Length 1
        public string fdate; // [string,    8] from일자                        StartPos 8, Length 8
        public string tdate; // [string,    8] to일자                          StartPos 17, Length 8
        public string gubun4; // [string,    1] 직전대비증감구분                StartPos 26, Length 1
        public string date; // [string,    8] 날짜                            StartPos 28, Length 8
    }

    internal struct _t1633OutBlock
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public long idx; // [long  ,    4] IDX                             StartPos 9, Length 4
    }

    internal struct _t1633OutBlock1
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public float jisu; // [float ,  6.2] KP200                           StartPos 9, Length 6
        public string sign; // [string,    1] 대비구분                        StartPos 16, Length 1
        public float change; // [float ,  6.2] 대비                            StartPos 18, Length 6
        public long tot3; // [long  ,   12] 전체순매수                      StartPos 25, Length 12
        public long tot1; // [long  ,   12] 전체매수                        StartPos 38, Length 12
        public long tot2; // [long  ,   12] 전체매도                        StartPos 51, Length 12
        public long cha3; // [long  ,   12] 차익순매수                      StartPos 64, Length 12
        public long cha1; // [long  ,   12] 차익매수                        StartPos 77, Length 12
        public long cha2; // [long  ,   12] 차익매도                        StartPos 90, Length 12
        public long bcha3; // [long  ,   12] 비차익순매수                    StartPos 103, Length 12
        public long bcha1; // [long  ,   12] 비차익매수                      StartPos 116, Length 12
        public long bcha2; // [long  ,   12] 비차익매도                      StartPos 129, Length 12
        public long volume; // [long  ,   12] 거래량                          StartPos 142, Length 12
    }
}