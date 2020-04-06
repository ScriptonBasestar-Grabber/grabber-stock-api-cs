namespace XingBot.res
{
    // 투자자 매매종합(차트) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1664InBlock
    {
        public string mgubun; // [string,    1] 시장구분                        StartPos 0, Length 1
        public string vagubun; // [string,    1] 금액수량구분                    StartPos 2, Length 1
        public string bdgubun; // [string,    1] 시간일별구분                    StartPos 4, Length 1
        public string cnt; // [string,    3] 조회건수                        StartPos 6, Length 3
    }

    public struct _t1664OutBlock1
    {
        public string dt; // [string,    8] 일자시간                        StartPos 0, Length 8
        public decimal tjj01; // [double,   12] 증권순매수                      StartPos 9, Length 12
        public decimal tjj02; // [double,   12] 보험순매수                      StartPos 22, Length 12
        public decimal tjj03; // [double,   12] 투신순매수                      StartPos 35, Length 12
        public decimal tjj04; // [double,   12] 은행순매수                      StartPos 48, Length 12
        public decimal tjj05; // [double,   12] 종금순매수                      StartPos 61, Length 12
        public decimal tjj06; // [double,   12] 기금순매수                      StartPos 74, Length 12
        public decimal tjj07; // [double,   12] 기타순매수                      StartPos 87, Length 12
        public decimal tjj08; // [double,   12] 개인순매수                      StartPos 100, Length 12
        public decimal tjj17; // [double,   12] 외국인순매수                    StartPos 113, Length 12
        public decimal tjj18; // [double,   12] 기관순매수                      StartPos 126, Length 12
        public decimal cha; // [double,   12] 차익순매수                      StartPos 139, Length 12
        public decimal bicha; // [double,   12] 비차익순매수                    StartPos 152, Length 12
        public decimal totcha; // [double,   12] 종합순매수                      StartPos 165, Length 12
        public decimal basis; // [float ,  6.2] 베이시스                        StartPos 178, Length 6
    }
}