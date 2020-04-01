namespace XingBot.res
{
    // KOSPI프로그램매매전체집계 ( ATTR, KEY=1, GROUP=1 )
    struct _PM__InBlock
    {
        public string gubun; // [string,    1] 구분값                          StartPos 0, Length 1
    }

    struct _PM__OutBlock
    {
        public string time; // [string,    6] 수신시간                        StartPos 0, Length 6
        public long cdhrem; // [long  ,    6] 차익매도호가 잔량               StartPos 7, Length 6
        public long cshrem; // [long  ,    6] 차익매수호가 잔량               StartPos 14, Length 6
        public long bdhrem; // [long  ,    6] 비차익매도호가 잔량             StartPos 21, Length 6
        public long bshrem; // [long  ,    6] 비차익매수호가 잔량             StartPos 28, Length 6
        public long cdhvolume; // [long  ,    6] 차익매도호가 수량               StartPos 35, Length 6
        public long cshvolume; // [long  ,    6] 차익매수호가 수량               StartPos 42, Length 6
        public long bdhvolume; // [long  ,    6] 비차익매도호가 수량             StartPos 49, Length 6
        public long bshvolume; // [long  ,    6] 비차익매수호가 수량             StartPos 56, Length 6
        public long cdwvolume; // [long  ,    6] 차익매도위탁체결수량            StartPos 63, Length 6
        public long cdjvolume; // [long  ,    6] 차익매도자기체결수량            StartPos 70, Length 6
        public long cswvolume; // [long  ,    6] 차익매수위탁체결수량            StartPos 77, Length 6
        public long csjvolume; // [long  ,    6] 차익매수자기체결수량            StartPos 84, Length 6
        public long cwvol; // [long  ,    6] 차익위탁순매수 수량             StartPos 91, Length 6
        public long cjvol; // [long  ,    6] 차익자기순매수 수량             StartPos 98, Length 6
        public long bdwvolume; // [long  ,    6] 비차익매도위탁체결수량          StartPos 105, Length 6
        public long bdjvolume; // [long  ,    6] 비차익매도자기체결수량          StartPos 112, Length 6
        public long bswvolume; // [long  ,    6] 비차익매수위탁체결수량          StartPos 119, Length 6
        public long bsjvolume; // [long  ,    6] 비차익매수자기체결수량          StartPos 126, Length 6
        public long bwvol; // [long  ,    6] 비차익위탁순매수 수량           StartPos 133, Length 6
        public long bjvol; // [long  ,    6] 비차익자기순매수 수량           StartPos 140, Length 6
        public long dwvolume; // [long  ,    6] 전체매도위탁체결수량            StartPos 147, Length 6
        public long swvolume; // [long  ,    6] 전체매수위탁체결수량            StartPos 154, Length 6
        public long wvol; // [long  ,    6] 전체위탁순매수 수량             StartPos 161, Length 6
        public long djvolume; // [long  ,    6] 전체매도자기체결수량            StartPos 168, Length 6
        public long sjvolume; // [long  ,    6] 전체매수자기체결수량            StartPos 175, Length 6
        public long jvol; // [long  ,    6] 전체자기순매수 수량             StartPos 182, Length 6
        public long cdwvalue; // [long  ,    8] 차익매도위탁체결금액            StartPos 189, Length 8
        public long cdjvalue; // [long  ,    8] 차익매도자기체결금액            StartPos 198, Length 8
        public long cswvalue; // [long  ,    8] 차익매수위탁체결금액            StartPos 207, Length 8
        public long csjvalue; // [long  ,    8] 차익매수자기체결금액            StartPos 216, Length 8
        public long cwval; // [long  ,    8] 차익위탁순매수 금액             StartPos 225, Length 8
        public long cjval; // [long  ,    8] 차익자기순매수 금액             StartPos 234, Length 8
        public long bdwvalue; // [long  ,    8] 비차익매도위탁체결금액          StartPos 243, Length 8
        public long bdjvalue; // [long  ,    8] 비차익매도자기체결금액          StartPos 252, Length 8
        public long bswvalue; // [long  ,    8] 비차익매수위탁체결금액          StartPos 261, Length 8
        public long bsjvalue; // [long  ,    8] 비차익매수자기체결금액          StartPos 270, Length 8
        public long bwval; // [long  ,    8] 비차익위탁순매수 금액           StartPos 279, Length 8
        public long bjval; // [long  ,    8] 비차익자기순매수 금액           StartPos 288, Length 8
        public long dwvalue; // [long  ,    8] 전체매도위탁체결금액            StartPos 297, Length 8
        public long swvalue; // [long  ,    8] 전체매수위탁체결금액            StartPos 306, Length 8
        public long wval; // [long  ,    8] 전체위탁순매수 금액             StartPos 315, Length 8
        public long djvalue; // [long  ,    8] 전체매도자기체결금액            StartPos 324, Length 8
        public long sjvalue; // [long  ,    8] 전체매수자기체결금액            StartPos 333, Length 8
        public long jval; // [long  ,    8] 전체자기순매수 금액             StartPos 342, Length 8
        public float k200jisu; // [float ,  6.2] KOSPI200 지수                   StartPos 351, Length 6
        public string k200sign; // [string,    1] KOSPI200 전일대비구분           StartPos 358, Length 1
        public float change; // [float ,  6.2] KOSPI200 전일대비               StartPos 360, Length 6
        public float k200basis; // [float ,  4.2] KOSPI200 베이시스               StartPos 367, Length 4
        public long cdvolume; // [long  ,    6] 차익매도체결수량합계            StartPos 372, Length 6
        public long csvolume; // [long  ,    6] 차익매수체결수량합계            StartPos 379, Length 6
        public long cvol; // [long  ,    6] 차익순매수 수량합계             StartPos 386, Length 6
        public long bdvolume; // [long  ,    6] 비차익매도체결수량합계          StartPos 393, Length 6
        public long bsvolume; // [long  ,    6] 비차익매수체결수량합계          StartPos 400, Length 6
        public long bvol; // [long  ,    6] 비차익순매수 수량합계           StartPos 407, Length 6
        public long tdvolume; // [long  ,    6] 전체매도체결수량합계            StartPos 414, Length 6
        public long tsvolume; // [long  ,    6] 전체매수체결수량합계            StartPos 421, Length 6
        public long tvol; // [long  ,    6] 전체순매수 수량합계             StartPos 428, Length 6
        public long cdvalue; // [long  ,    8] 차익매도체결금액합계            StartPos 435, Length 8
        public long csvalue; // [long  ,    8] 차익매수체결금액합계            StartPos 444, Length 8
        public long cval; // [long  ,    8] 차익순매수 금액합계             StartPos 453, Length 8
        public long bdvalue; // [long  ,    8] 비차익매도체결금액합계          StartPos 462, Length 8
        public long bsvalue; // [long  ,    8] 비차익매수체결금액합계          StartPos 471, Length 8
        public long bval; // [long  ,    8] 비차익순매수 금액합계           StartPos 480, Length 8
        public long tdvalue; // [long  ,    8] 전체매도체결금액합계            StartPos 489, Length 8
        public long tsvalue; // [long  ,    8] 전체매수체결금액합계            StartPos 498, Length 8
        public long tval; // [long  ,    8] 전체순매수 금액합계             StartPos 507, Length 8
        public long p_cdvolcha; // [long  ,    6] 차익매도체결수량직전대비        StartPos 516, Length 6
        public long p_csvolcha; // [long  ,    6] 차익매수체결수량직전대비        StartPos 523, Length 6
        public long p_cvolcha; // [long  ,    6] 차익순매수 수량직전대비         StartPos 530, Length 6
        public long p_bdvolcha; // [long  ,    6] 비차익매도체결수량직전대비      StartPos 537, Length 6
        public long p_bsvolcha; // [long  ,    6] 비차익매수체결수량직전대비      StartPos 544, Length 6
        public long p_bvolcha; // [long  ,    6] 비차익순매수 수량직전대비       StartPos 551, Length 6
        public long p_tdvolcha; // [long  ,    6] 전체매도체결수량직전대비        StartPos 558, Length 6
        public long p_tsvolcha; // [long  ,    6] 전체매수체결수량직전대비        StartPos 565, Length 6
        public long p_tvolcha; // [long  ,    6] 전체순매수 수량직전대비         StartPos 572, Length 6
        public long p_cdvalcha; // [long  ,    8] 차익매도체결금액직전대비        StartPos 579, Length 8
        public long p_csvalcha; // [long  ,    8] 차익매수체결금액직전대비        StartPos 588, Length 8
        public long p_cvalcha; // [long  ,    8] 차익순매수 금액직전대비         StartPos 597, Length 8
        public long p_bdvalcha; // [long  ,    8] 비차익매도체결금액직전대비      StartPos 606, Length 8
        public long p_bsvalcha; // [long  ,    8] 비차익매수체결금액직전대비      StartPos 615, Length 8
        public long p_bvalcha; // [long  ,    8] 비차익순매수 금액직전대비       StartPos 624, Length 8
        public long p_tdvalcha; // [long  ,    8] 전체매도체결금액직전대비        StartPos 633, Length 8
        public long p_tsvalcha; // [long  ,    8] 전체매수체결금액직전대비        StartPos 642, Length 8
        public long p_tvalcha; // [long  ,    8] 전체순매수 금액직전대비         StartPos 651, Length 8
        public string gubun; // [string,    1] 구분값                          StartPos 660, Length 1
    }
}