namespace XingBot.res
{
    public class BMT
    {
        struct _BMT_InBlock
        {
            string upcode; // [string,    3] 업종코드                       StartPos 0, Length 3
        }

        struct _BMT_OutBlock
        {
            string tjjtime; // [string,    8] 수신시간                       StartPos 0, Length 8
            string tjjcode1; // [string,    4] 투자자코드1(개인)              StartPos 9, Length 4
            long msvolume1; // [long  ,    8] 매수 거래량1                   StartPos 14, Length 8
            long mdvolume1; // [long  ,    8] 매도 거래량1                   StartPos 23, Length 8
            long msvol1; // [long  ,    8] 거래량 순매수1                 StartPos 32, Length 8
            long msvalue1; // [long  ,    6] 매수 거래대금1                 StartPos 41, Length 6
            long mdvalue1; // [long  ,    6] 매도 거래대금1                 StartPos 48, Length 6
            long msval1; // [long  ,    6] 거래대금 순매수1               StartPos 55, Length 6
            string tjjcode2; // [string,    4] 투자자코드2(외국인)            StartPos 62, Length 4
            long msvolume2; // [long  ,    8] 매수 거래량2                   StartPos 67, Length 8
            long mdvolume2; // [long  ,    8] 매도 거래량2                   StartPos 76, Length 8
            long msvol2; // [long  ,    8] 거래량 순매수2                 StartPos 85, Length 8
            long msvalue2; // [long  ,    6] 매수 거래대금2                 StartPos 94, Length 6
            long mdvalue2; // [long  ,    6] 매도 거래대금2                 StartPos 101, Length 6
            long msval2; // [long  ,    6] 거래대금 순매수2               StartPos 108, Length 6
            string tjjcode3; // [string,    4] 투자자코드3(기관계)            StartPos 115, Length 4
            long msvolume3; // [long  ,    8] 매수 거래량3                   StartPos 120, Length 8
            long mdvolume3; // [long  ,    8] 매도 거래량3                   StartPos 129, Length 8
            long msvol3; // [long  ,    8] 거래량 순매수3                 StartPos 138, Length 8
            long msvalue3; // [long  ,    6] 매수 거래대금3                 StartPos 147, Length 6
            long mdvalue3; // [long  ,    6] 매도 거래대금3                 StartPos 154, Length 6
            long msval3; // [long  ,    6] 거래대금 순매수3               StartPos 161, Length 6
            string tjjcode4; // [string,    4] 투자자코드4(증권)              StartPos 168, Length 4
            long msvolume4; // [long  ,    8] 매수 거래량4                   StartPos 173, Length 8
            long mdvolume4; // [long  ,    8] 매도 거래량4                   StartPos 182, Length 8
            long msvol4; // [long  ,    8] 거래량 순매수4                 StartPos 191, Length 8
            long msvalue4; // [long  ,    6] 매수 거래대금4                 StartPos 200, Length 6
            long mdvalue4; // [long  ,    6] 매도 거래대금4                 StartPos 207, Length 6
            long msval4; // [long  ,    6] 거래대금 순매수4               StartPos 214, Length 6
            string tjjcode5; // [string,    4] 투자자코드5(투신)              StartPos 221, Length 4
            long msvolume5; // [long  ,    8] 매수 거래량5                   StartPos 226, Length 8
            long mdvolume5; // [long  ,    8] 매도 거래량5                   StartPos 235, Length 8
            long msvol5; // [long  ,    8] 거래량 순매수5                 StartPos 244, Length 8
            long msvalue5; // [long  ,    6] 매수 거래대금5                 StartPos 253, Length 6
            long mdvalue5; // [long  ,    6] 매도 거래대금5                 StartPos 260, Length 6
            long msval5; // [long  ,    6] 거래대금 순매수5               StartPos 267, Length 6
            string tjjcode6; // [string,    4] 투자자코드6(은행)              StartPos 274, Length 4
            long msvolume6; // [long  ,    8] 매수 거래량6                   StartPos 279, Length 8
            long mdvolume6; // [long  ,    8] 매도 거래량6                   StartPos 288, Length 8
            long msvol6; // [long  ,    8] 거래량 순매수6                 StartPos 297, Length 8
            long msvalue6; // [long  ,    6] 매수 거래대금6                 StartPos 306, Length 6
            long mdvalue6; // [long  ,    6] 매도 거래대금6                 StartPos 313, Length 6
            long msval6; // [long  ,    6] 거래대금 순매수6               StartPos 320, Length 6
            string tjjcode7; // [string,    4] 투자자코드7(보험)              StartPos 327, Length 4
            long msvolume7; // [long  ,    8] 매수 거래량7                   StartPos 332, Length 8
            long mdvolume7; // [long  ,    8] 매도 거래량7                   StartPos 341, Length 8
            long msvol7; // [long  ,    8] 거래량 순매수7                 StartPos 350, Length 8
            long msvalue7; // [long  ,    6] 매수 거래대금7                 StartPos 359, Length 6
            long mdvalue7; // [long  ,    6] 매도 거래대금7                 StartPos 366, Length 6
            long msval7; // [long  ,    6] 거래대금 순매수7               StartPos 373, Length 6
            string tjjcode8; // [string,    4] 투자자코드8(종금)              StartPos 380, Length 4
            long msvolume8; // [long  ,    8] 매수 거래량8                   StartPos 385, Length 8
            long mdvolume8; // [long  ,    8] 매도 거래량8                   StartPos 394, Length 8
            long msvol8; // [long  ,    8] 거래량 순매수8                 StartPos 403, Length 8
            long msvalue8; // [long  ,    6] 매수 거래대금8                 StartPos 412, Length 6
            long mdvalue8; // [long  ,    6] 매도 거래대금8                 StartPos 419, Length 6
            long msval8; // [long  ,    6] 거래대금 순매수8               StartPos 426, Length 6
            string tjjcode9; // [string,    4] 투자자코드9(기금)              StartPos 433, Length 4
            long msvolume9; // [long  ,    8] 매수 거래량9                   StartPos 438, Length 8
            long mdvolume9; // [long  ,    8] 매도 거래량9                   StartPos 447, Length 8
            long msvol9; // [long  ,    8] 거래량 순매수9                 StartPos 456, Length 8
            long msvalue9; // [long  ,    6] 매수 거래대금9                 StartPos 465, Length 6
            long mdvalue9; // [long  ,    6] 매도 거래대금9                 StartPos 472, Length 6
            long msval9; // [long  ,    6] 거래대금 순매수9               StartPos 479, Length 6
            string tjjcode10; // [string,    4] 투자자코드10(선물업자)         StartPos 486, Length 4
            long msvolume10; // [long  ,    8] 매수 거래량10                  StartPos 491, Length 8
            long mdvolume10; // [long  ,    8] 매도 거래량10                  StartPos 500, Length 8
            long msvol10; // [long  ,    8] 거래량 순매수10                StartPos 509, Length 8
            long msvalue10; // [long  ,    6] 매수 거래대금10                StartPos 518, Length 6
            long mdvalue10; // [long  ,    6] 매도 거래대금10                StartPos 525, Length 6
            long msval10; // [long  ,    6] 거래대금 순매수10              StartPos 532, Length 6
            string tjjcode11; // [string,    4] 투자자코드11(기타)             StartPos 539, Length 4
            long msvolume11; // [long  ,    8] 매수 거래량11                  StartPos 544, Length 8
            long mdvolume11; // [long  ,    8] 매도 거래량11                  StartPos 553, Length 8
            long msvol11; // [long  ,    8] 거래량 순매수11                StartPos 562, Length 8
            long msvalue11; // [long  ,    6] 매수 거래대금11                StartPos 571, Length 6
            long mdvalue11; // [long  ,    6] 매도 거래대금11                StartPos 578, Length 6
            long msval11; // [long  ,    6] 거래대금 순매수11              StartPos 585, Length 6
            string upcode; // [string,    3] 업종코드                       StartPos 592, Length 3
            string tjjcode0; // [string,    4] 투자자코드0(사모펀드)          StartPos 596, Length 4
            long msvolume0; // [long  ,    8] 매수 거래량0                   StartPos 601, Length 8
            long mdvolume0; // [long  ,    8] 매도 거래량0                   StartPos 610, Length 8
            long msvol0; // [long  ,    8] 거래량 순매수0                 StartPos 619, Length 8
            long msvalue0; // [long  ,    6] 매수 거래대금0                 StartPos 628, Length 6
            long mdvalue0; // [long  ,    6] 매도 거래대금0                 StartPos 635, Length 6
            long msval0; // [long  ,    6] 거래대금 순매수0               StartPos 642, Length 6
        }
    }
}