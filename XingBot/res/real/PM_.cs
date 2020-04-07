namespace XingBot.res
{
    // KOSPI프로그램매매전체집계 ( ATTR, KEY=1, GROUP=1 )
    public struct _PM__InBlock
    {
        public string gubun{ get; set; } // [string,    1] 구분값                          StartPos 0, Length 1
    }

    public struct _PM__OutBlock
    {
        public string time{ get; set; } // [string,    6] 수신시간                        StartPos 0, Length 6
        public long cdhrem{ get; set; } // [long  ,    6] 차익매도호가 잔량               StartPos 7, Length 6
        public long cshrem{ get; set; } // [long  ,    6] 차익매수호가 잔량               StartPos 14, Length 6
        public long bdhrem{ get; set; } // [long  ,    6] 비차익매도호가 잔량             StartPos 21, Length 6
        public long bshrem{ get; set; } // [long  ,    6] 비차익매수호가 잔량             StartPos 28, Length 6
        public long cdhvolume{ get; set; } // [long  ,    6] 차익매도호가 수량               StartPos 35, Length 6
        public long cshvolume{ get; set; } // [long  ,    6] 차익매수호가 수량               StartPos 42, Length 6
        public long bdhvolume{ get; set; } // [long  ,    6] 비차익매도호가 수량             StartPos 49, Length 6
        public long bshvolume{ get; set; } // [long  ,    6] 비차익매수호가 수량             StartPos 56, Length 6
        public long cdwvolume{ get; set; } // [long  ,    6] 차익매도위탁체결수량            StartPos 63, Length 6
        public long cdjvolume{ get; set; } // [long  ,    6] 차익매도자기체결수량            StartPos 70, Length 6
        public long cswvolume{ get; set; } // [long  ,    6] 차익매수위탁체결수량            StartPos 77, Length 6
        public long csjvolume{ get; set; } // [long  ,    6] 차익매수자기체결수량            StartPos 84, Length 6
        public long cwvol{ get; set; } // [long  ,    6] 차익위탁순매수 수량             StartPos 91, Length 6
        public long cjvol{ get; set; } // [long  ,    6] 차익자기순매수 수량             StartPos 98, Length 6
        public long bdwvolume{ get; set; } // [long  ,    6] 비차익매도위탁체결수량          StartPos 105, Length 6
        public long bdjvolume{ get; set; } // [long  ,    6] 비차익매도자기체결수량          StartPos 112, Length 6
        public long bswvolume{ get; set; } // [long  ,    6] 비차익매수위탁체결수량          StartPos 119, Length 6
        public long bsjvolume{ get; set; } // [long  ,    6] 비차익매수자기체결수량          StartPos 126, Length 6
        public long bwvol{ get; set; } // [long  ,    6] 비차익위탁순매수 수량           StartPos 133, Length 6
        public long bjvol{ get; set; } // [long  ,    6] 비차익자기순매수 수량           StartPos 140, Length 6
        public long dwvolume{ get; set; } // [long  ,    6] 전체매도위탁체결수량            StartPos 147, Length 6
        public long swvolume{ get; set; } // [long  ,    6] 전체매수위탁체결수량            StartPos 154, Length 6
        public long wvol{ get; set; } // [long  ,    6] 전체위탁순매수 수량             StartPos 161, Length 6
        public long djvolume{ get; set; } // [long  ,    6] 전체매도자기체결수량            StartPos 168, Length 6
        public long sjvolume{ get; set; } // [long  ,    6] 전체매수자기체결수량            StartPos 175, Length 6
        public long jvol{ get; set; } // [long  ,    6] 전체자기순매수 수량             StartPos 182, Length 6
        public long cdwvalue{ get; set; } // [long  ,    8] 차익매도위탁체결금액            StartPos 189, Length 8
        public long cdjvalue{ get; set; } // [long  ,    8] 차익매도자기체결금액            StartPos 198, Length 8
        public long cswvalue{ get; set; } // [long  ,    8] 차익매수위탁체결금액            StartPos 207, Length 8
        public long csjvalue{ get; set; } // [long  ,    8] 차익매수자기체결금액            StartPos 216, Length 8
        public long cwval{ get; set; } // [long  ,    8] 차익위탁순매수 금액             StartPos 225, Length 8
        public long cjval{ get; set; } // [long  ,    8] 차익자기순매수 금액             StartPos 234, Length 8
        public long bdwvalue{ get; set; } // [long  ,    8] 비차익매도위탁체결금액          StartPos 243, Length 8
        public long bdjvalue{ get; set; } // [long  ,    8] 비차익매도자기체결금액          StartPos 252, Length 8
        public long bswvalue{ get; set; } // [long  ,    8] 비차익매수위탁체결금액          StartPos 261, Length 8
        public long bsjvalue{ get; set; } // [long  ,    8] 비차익매수자기체결금액          StartPos 270, Length 8
        public long bwval{ get; set; } // [long  ,    8] 비차익위탁순매수 금액           StartPos 279, Length 8
        public long bjval{ get; set; } // [long  ,    8] 비차익자기순매수 금액           StartPos 288, Length 8
        public long dwvalue{ get; set; } // [long  ,    8] 전체매도위탁체결금액            StartPos 297, Length 8
        public long swvalue{ get; set; } // [long  ,    8] 전체매수위탁체결금액            StartPos 306, Length 8
        public long wval{ get; set; } // [long  ,    8] 전체위탁순매수 금액             StartPos 315, Length 8
        public long djvalue{ get; set; } // [long  ,    8] 전체매도자기체결금액            StartPos 324, Length 8
        public long sjvalue{ get; set; } // [long  ,    8] 전체매수자기체결금액            StartPos 333, Length 8
        public long jval{ get; set; } // [long  ,    8] 전체자기순매수 금액             StartPos 342, Length 8
        public decimal k200jisu{ get; set; } // [float ,  6.2] KOSPI200 지수                   StartPos 351, Length 6
        public string k200sign{ get; set; } // [string,    1] KOSPI200 전일대비구분           StartPos 358, Length 1
        public decimal change{ get; set; } // [float ,  6.2] KOSPI200 전일대비               StartPos 360, Length 6
        public decimal k200basis{ get; set; } // [float ,  4.2] KOSPI200 베이시스               StartPos 367, Length 4
        public long cdvolume{ get; set; } // [long  ,    6] 차익매도체결수량합계            StartPos 372, Length 6
        public long csvolume{ get; set; } // [long  ,    6] 차익매수체결수량합계            StartPos 379, Length 6
        public long cvol{ get; set; } // [long  ,    6] 차익순매수 수량합계             StartPos 386, Length 6
        public long bdvolume{ get; set; } // [long  ,    6] 비차익매도체결수량합계          StartPos 393, Length 6
        public long bsvolume{ get; set; } // [long  ,    6] 비차익매수체결수량합계          StartPos 400, Length 6
        public long bvol{ get; set; } // [long  ,    6] 비차익순매수 수량합계           StartPos 407, Length 6
        public long tdvolume{ get; set; } // [long  ,    6] 전체매도체결수량합계            StartPos 414, Length 6
        public long tsvolume{ get; set; } // [long  ,    6] 전체매수체결수량합계            StartPos 421, Length 6
        public long tvol{ get; set; } // [long  ,    6] 전체순매수 수량합계             StartPos 428, Length 6
        public long cdvalue{ get; set; } // [long  ,    8] 차익매도체결금액합계            StartPos 435, Length 8
        public long csvalue{ get; set; } // [long  ,    8] 차익매수체결금액합계            StartPos 444, Length 8
        public long cval{ get; set; } // [long  ,    8] 차익순매수 금액합계             StartPos 453, Length 8
        public long bdvalue{ get; set; } // [long  ,    8] 비차익매도체결금액합계          StartPos 462, Length 8
        public long bsvalue{ get; set; } // [long  ,    8] 비차익매수체결금액합계          StartPos 471, Length 8
        public long bval{ get; set; } // [long  ,    8] 비차익순매수 금액합계           StartPos 480, Length 8
        public long tdvalue{ get; set; } // [long  ,    8] 전체매도체결금액합계            StartPos 489, Length 8
        public long tsvalue{ get; set; } // [long  ,    8] 전체매수체결금액합계            StartPos 498, Length 8
        public long tval{ get; set; } // [long  ,    8] 전체순매수 금액합계             StartPos 507, Length 8
        public long p_cdvolcha{ get; set; } // [long  ,    6] 차익매도체결수량직전대비        StartPos 516, Length 6
        public long p_csvolcha{ get; set; } // [long  ,    6] 차익매수체결수량직전대비        StartPos 523, Length 6
        public long p_cvolcha{ get; set; } // [long  ,    6] 차익순매수 수량직전대비         StartPos 530, Length 6
        public long p_bdvolcha{ get; set; } // [long  ,    6] 비차익매도체결수량직전대비      StartPos 537, Length 6
        public long p_bsvolcha{ get; set; } // [long  ,    6] 비차익매수체결수량직전대비      StartPos 544, Length 6
        public long p_bvolcha{ get; set; } // [long  ,    6] 비차익순매수 수량직전대비       StartPos 551, Length 6
        public long p_tdvolcha{ get; set; } // [long  ,    6] 전체매도체결수량직전대비        StartPos 558, Length 6
        public long p_tsvolcha{ get; set; } // [long  ,    6] 전체매수체결수량직전대비        StartPos 565, Length 6
        public long p_tvolcha{ get; set; } // [long  ,    6] 전체순매수 수량직전대비         StartPos 572, Length 6
        public long p_cdvalcha{ get; set; } // [long  ,    8] 차익매도체결금액직전대비        StartPos 579, Length 8
        public long p_csvalcha{ get; set; } // [long  ,    8] 차익매수체결금액직전대비        StartPos 588, Length 8
        public long p_cvalcha{ get; set; } // [long  ,    8] 차익순매수 금액직전대비         StartPos 597, Length 8
        public long p_bdvalcha{ get; set; } // [long  ,    8] 비차익매도체결금액직전대비      StartPos 606, Length 8
        public long p_bsvalcha{ get; set; } // [long  ,    8] 비차익매수체결금액직전대비      StartPos 615, Length 8
        public long p_bvalcha{ get; set; } // [long  ,    8] 비차익순매수 금액직전대비       StartPos 624, Length 8
        public long p_tdvalcha{ get; set; } // [long  ,    8] 전체매도체결금액직전대비        StartPos 633, Length 8
        public long p_tsvalcha{ get; set; } // [long  ,    8] 전체매수체결금액직전대비        StartPos 642, Length 8
        public long p_tvalcha{ get; set; } // [long  ,    8] 전체순매수 금액직전대비         StartPos 651, Length 8
        public string gubun{ get; set; } // [string,    1] 구분값                          StartPos 660, Length 1
    }
}