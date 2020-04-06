namespace XingBot.res
{
    // 투자자매매종합2 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1617InBlock
    {
        public string gubun1; // [string,    1] 시장구분(1:코스피2:코스닥3:선물 StartPos 0, Length 1
        public string gubun2; // [string,    1] 수량금액구분(1:수량2:금액)      StartPos 2, Length 1
        public string gubun3; // [string,    1] 일자구분(1:시간대별2:일별)      StartPos 4, Length 1
        public string cts_date; // [string,    8] CTSDATE(연속키값-일자)          StartPos 6, Length 8
        public string cts_time; // [string,    8] CTSTIME(연속키값-시간)          StartPos 15, Length 8
    }

    public struct _t1617OutBlock
    {
        public string cts_date; // [string,    8] CTSDATE                         StartPos 0, Length 8
        public string cts_time; // [string,    8] CTSTIME                         StartPos 9, Length 8
        public long ms_08; // [long  ,   12] 개인매수                        StartPos 18, Length 12
        public long md_08; // [long  ,   12] 개인매도                        StartPos 31, Length 12
        public long sv_08; // [long  ,   12] 개인순매수                      StartPos 44, Length 12
        public long ms_17; // [long  ,   12] 외국인매수                      StartPos 57, Length 12
        public long md_17; // [long  ,   12] 외국인매도                      StartPos 70, Length 12
        public long sv_17; // [long  ,   12] 외국인순매수                    StartPos 83, Length 12
        public long ms_18; // [long  ,   12] 기관계매수                      StartPos 96, Length 12
        public long md_18; // [long  ,   12] 기관계매도                      StartPos 109, Length 12
        public long sv_18; // [long  ,   12] 기관계순매수                    StartPos 122, Length 12
        public long ms_01; // [long  ,   12] 증권매수                        StartPos 135, Length 12
        public long md_01; // [long  ,   12] 증권매도                        StartPos 148, Length 12
        public long sv_01; // [long  ,   12] 증권순매수                      StartPos 161, Length 12
    }

    public struct _t1617OutBlock1
    {
        public string date; // [string,    8] 날짜                            StartPos 0, Length 8
        public string time; // [string,    8] 시간                            StartPos 9, Length 8
        public long sv_08; // [long  ,   12] 개인                            StartPos 18, Length 12
        public long sv_17; // [long  ,   12] 외국인                          StartPos 31, Length 12
        public long sv_18; // [long  ,   12] 기관계                          StartPos 44, Length 12
        public long sv_01; // [long  ,   12] 증권                            StartPos 57, Length 12
    }
}