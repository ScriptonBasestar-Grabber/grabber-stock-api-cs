namespace XingBot.real.res.tr
{
    // 시간대별 프로그램 매매추이(차트) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1662InBlock
    {
        public string gubun; // [string,    1] 구분                            StartPos 0, Length 1
        public string gubun1; // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string gubun3; // [string,    1] 전일구분                        StartPos 4, Length 1
    }

    public struct _t1662OutBlock
    {
        public string time; // [string,    6] 시간                            StartPos 0, Length 6
        public decimal k200jisu; // [float ,  6.2] KP200                           StartPos 7, Length 6
        public string sign; // [string,    1] 대비구분                        StartPos 14, Length 1
        public decimal change; // [float ,  6.2] 대비                            StartPos 16, Length 6
        public decimal k200basis; // [float ,  6.2] BASIS                           StartPos 23, Length 6
        public long tot3; // [long  ,   12] 전체순매수                      StartPos 30, Length 12
        public long tot1; // [long  ,   12] 전체매수                        StartPos 43, Length 12
        public long tot2; // [long  ,   12] 전체매도                        StartPos 56, Length 12
        public long cha3; // [long  ,   12] 차익순매수                      StartPos 69, Length 12
        public long cha1; // [long  ,   12] 차익매수                        StartPos 82, Length 12
        public long cha2; // [long  ,   12] 차익매도                        StartPos 95, Length 12
        public long bcha3; // [long  ,   12] 비차익순매수                    StartPos 108, Length 12
        public long bcha1; // [long  ,   12] 비차익매수                      StartPos 121, Length 12
        public long bcha2; // [long  ,   12] 비차익매도                      StartPos 134, Length 12
        public long volume; // [long  ,   12] 거래량                          StartPos 147, Length 12
    }
}