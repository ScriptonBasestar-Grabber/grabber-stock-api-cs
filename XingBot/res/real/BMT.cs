namespace XingBot.real.res
{
    // 시간대별 투자자매매추이(BMT) ( attr,block )
    public struct _BMT_InBlock
    {
        public string upcode; // [string,    3] 업종코드                       StartPos 0, Length 3
    }

    public struct _BMT_OutBlock
    {
        public string tjjtime; // [string,    8] 수신시간                       StartPos 0, Length 8
        public string tjjcode1; // [string,    4] 투자자코드1(개인)              StartPos 9, Length 4
        public long msvolume1; // [long  ,    8] 매수 거래량1                   StartPos 14, Length 8
        public long mdvolume1; // [long  ,    8] 매도 거래량1                   StartPos 23, Length 8
        public long msvol1; // [long  ,    8] 거래량 순매수1                 StartPos 32, Length 8
        public long msvalue1; // [long  ,    6] 매수 거래대금1                 StartPos 41, Length 6
        public long mdvalue1; // [long  ,    6] 매도 거래대금1                 StartPos 48, Length 6
        public long msval1; // [long  ,    6] 거래대금 순매수1               StartPos 55, Length 6
        public string tjjcode2; // [string,    4] 투자자코드2(외국인)            StartPos 62, Length 4
        public long msvolume2; // [long  ,    8] 매수 거래량2                   StartPos 67, Length 8
        public long mdvolume2; // [long  ,    8] 매도 거래량2                   StartPos 76, Length 8
        public long msvol2; // [long  ,    8] 거래량 순매수2                 StartPos 85, Length 8
        public long msvalue2; // [long  ,    6] 매수 거래대금2                 StartPos 94, Length 6
        public long mdvalue2; // [long  ,    6] 매도 거래대금2                 StartPos 101, Length 6
        public long msval2; // [long  ,    6] 거래대금 순매수2               StartPos 108, Length 6
        public string tjjcode3; // [string,    4] 투자자코드3(기관계)            StartPos 115, Length 4
        public long msvolume3; // [long  ,    8] 매수 거래량3                   StartPos 120, Length 8
        public long mdvolume3; // [long  ,    8] 매도 거래량3                   StartPos 129, Length 8
        public long msvol3; // [long  ,    8] 거래량 순매수3                 StartPos 138, Length 8
        public long msvalue3; // [long  ,    6] 매수 거래대금3                 StartPos 147, Length 6
        public long mdvalue3; // [long  ,    6] 매도 거래대금3                 StartPos 154, Length 6
        public long msval3; // [long  ,    6] 거래대금 순매수3               StartPos 161, Length 6
        public string tjjcode4; // [string,    4] 투자자코드4(증권)              StartPos 168, Length 4
        public long msvolume4; // [long  ,    8] 매수 거래량4                   StartPos 173, Length 8
        public long mdvolume4; // [long  ,    8] 매도 거래량4                   StartPos 182, Length 8
        public long msvol4; // [long  ,    8] 거래량 순매수4                 StartPos 191, Length 8
        public long msvalue4; // [long  ,    6] 매수 거래대금4                 StartPos 200, Length 6
        public long mdvalue4; // [long  ,    6] 매도 거래대금4                 StartPos 207, Length 6
        public long msval4; // [long  ,    6] 거래대금 순매수4               StartPos 214, Length 6
        public string tjjcode5; // [string,    4] 투자자코드5(투신)              StartPos 221, Length 4
        public long msvolume5; // [long  ,    8] 매수 거래량5                   StartPos 226, Length 8
        public long mdvolume5; // [long  ,    8] 매도 거래량5                   StartPos 235, Length 8
        public long msvol5; // [long  ,    8] 거래량 순매수5                 StartPos 244, Length 8
        public long msvalue5; // [long  ,    6] 매수 거래대금5                 StartPos 253, Length 6
        public long mdvalue5; // [long  ,    6] 매도 거래대금5                 StartPos 260, Length 6
        public long msval5; // [long  ,    6] 거래대금 순매수5               StartPos 267, Length 6
        public string tjjcode6; // [string,    4] 투자자코드6(은행)              StartPos 274, Length 4
        public long msvolume6; // [long  ,    8] 매수 거래량6                   StartPos 279, Length 8
        public long mdvolume6; // [long  ,    8] 매도 거래량6                   StartPos 288, Length 8
        public long msvol6; // [long  ,    8] 거래량 순매수6                 StartPos 297, Length 8
        public long msvalue6; // [long  ,    6] 매수 거래대금6                 StartPos 306, Length 6
        public long mdvalue6; // [long  ,    6] 매도 거래대금6                 StartPos 313, Length 6
        public long msval6; // [long  ,    6] 거래대금 순매수6               StartPos 320, Length 6
        public string tjjcode7; // [string,    4] 투자자코드7(보험)              StartPos 327, Length 4
        public long msvolume7; // [long  ,    8] 매수 거래량7                   StartPos 332, Length 8
        public long mdvolume7; // [long  ,    8] 매도 거래량7                   StartPos 341, Length 8
        public long msvol7; // [long  ,    8] 거래량 순매수7                 StartPos 350, Length 8
        public long msvalue7; // [long  ,    6] 매수 거래대금7                 StartPos 359, Length 6
        public long mdvalue7; // [long  ,    6] 매도 거래대금7                 StartPos 366, Length 6
        public long msval7; // [long  ,    6] 거래대금 순매수7               StartPos 373, Length 6
        public string tjjcode8; // [string,    4] 투자자코드8(종금)              StartPos 380, Length 4
        public long msvolume8; // [long  ,    8] 매수 거래량8                   StartPos 385, Length 8
        public long mdvolume8; // [long  ,    8] 매도 거래량8                   StartPos 394, Length 8
        public long msvol8; // [long  ,    8] 거래량 순매수8                 StartPos 403, Length 8
        public long msvalue8; // [long  ,    6] 매수 거래대금8                 StartPos 412, Length 6
        public long mdvalue8; // [long  ,    6] 매도 거래대금8                 StartPos 419, Length 6
        public long msval8; // [long  ,    6] 거래대금 순매수8               StartPos 426, Length 6
        public string tjjcode9; // [string,    4] 투자자코드9(기금)              StartPos 433, Length 4
        public long msvolume9; // [long  ,    8] 매수 거래량9                   StartPos 438, Length 8
        public long mdvolume9; // [long  ,    8] 매도 거래량9                   StartPos 447, Length 8
        public long msvol9; // [long  ,    8] 거래량 순매수9                 StartPos 456, Length 8
        public long msvalue9; // [long  ,    6] 매수 거래대금9                 StartPos 465, Length 6
        public long mdvalue9; // [long  ,    6] 매도 거래대금9                 StartPos 472, Length 6
        public long msval9; // [long  ,    6] 거래대금 순매수9               StartPos 479, Length 6
        public string tjjcode10; // [string,    4] 투자자코드10(선물업자)         StartPos 486, Length 4
        public long msvolume10; // [long  ,    8] 매수 거래량10                  StartPos 491, Length 8
        public long mdvolume10; // [long  ,    8] 매도 거래량10                  StartPos 500, Length 8
        public long msvol10; // [long  ,    8] 거래량 순매수10                StartPos 509, Length 8
        public long msvalue10; // [long  ,    6] 매수 거래대금10                StartPos 518, Length 6
        public long mdvalue10; // [long  ,    6] 매도 거래대금10                StartPos 525, Length 6
        public long msval10; // [long  ,    6] 거래대금 순매수10              StartPos 532, Length 6
        public string tjjcode11; // [string,    4] 투자자코드11(기타)             StartPos 539, Length 4
        public long msvolume11; // [long  ,    8] 매수 거래량11                  StartPos 544, Length 8
        public long mdvolume11; // [long  ,    8] 매도 거래량11                  StartPos 553, Length 8
        public long msvol11; // [long  ,    8] 거래량 순매수11                StartPos 562, Length 8
        public long msvalue11; // [long  ,    6] 매수 거래대금11                StartPos 571, Length 6
        public long mdvalue11; // [long  ,    6] 매도 거래대금11                StartPos 578, Length 6
        public long msval11; // [long  ,    6] 거래대금 순매수11              StartPos 585, Length 6
        public string upcode; // [string,    3] 업종코드                       StartPos 592, Length 3
        public string tjjcode0; // [string,    4] 투자자코드0(사모펀드)          StartPos 596, Length 4
        public long msvolume0; // [long  ,    8] 매수 거래량0                   StartPos 601, Length 8
        public long mdvolume0; // [long  ,    8] 매도 거래량0                   StartPos 610, Length 8
        public long msvol0; // [long  ,    8] 거래량 순매수0                 StartPos 619, Length 8
        public long msvalue0; // [long  ,    6] 매수 거래대금0                 StartPos 628, Length 6
        public long mdvalue0; // [long  ,    6] 매도 거래대금0                 StartPos 635, Length 6
        public long msval0; // [long  ,    6] 거래대금 순매수0               StartPos 642, Length 6
    }
}