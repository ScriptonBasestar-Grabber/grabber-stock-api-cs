namespace XingBot.real.res
{
    // CME야간선물 시간대별투자자매매추이 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2813InBlock
    {
        public string gubun1; // [string,    1] 수량구분                        StartPos 0, Length 1
        public string gubun2; // [string,    1] 전일분구분                      StartPos 2, Length 1
        public string cts_time; // [string,    8] CTSTIME                         StartPos 4, Length 8
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 13, Length 4
        public string cnt; // [string,    4] 조회건수                        StartPos 18, Length 4
        public string gubun3; // [string,    1] 직전대비구분(C:직전대비)        StartPos 23, Length 1
    }

    public struct _t2813OutBlock
    {
        public string cts_time; // [string,    8] CTSTIME                         StartPos 0, Length 8
        public string tjjcode_08; // [string,    4] 개인투자자코드                  StartPos 9, Length 4
        public long ms_08; // [long  ,   12] 개인매수                        StartPos 14, Length 12
        public long md_08; // [long  ,   12] 개인매도                        StartPos 27, Length 12
        public long rate_08; // [long  ,   12] 개인증감                        StartPos 40, Length 12
        public long svolume_08; // [long  ,   12] 개인순매수                      StartPos 53, Length 12
        public string tjjcode_17; // [string,    4] 외국인투자자코드                StartPos 66, Length 4
        public long ms_17; // [long  ,   12] 외국인매수                      StartPos 71, Length 12
        public long md_17; // [long  ,   12] 외국인매도                      StartPos 84, Length 12
        public long rate_17; // [long  ,   12] 외국인증감                      StartPos 97, Length 12
        public long svolume_17; // [long  ,   12] 외국인순매수                    StartPos 110, Length 12
        public string tjjcode_18; // [string,    4] 기관계투자자코드                StartPos 123, Length 4
        public long ms_18; // [long  ,   12] 기관계매수                      StartPos 128, Length 12
        public long md_18; // [long  ,   12] 기관계매도                      StartPos 141, Length 12
        public long rate_18; // [long  ,   12] 기관계증감                      StartPos 154, Length 12
        public long svolume_18; // [long  ,   12] 기관계순매수                    StartPos 167, Length 12
        public string tjjcode_01; // [string,    4] 증권투자자코드                  StartPos 180, Length 4
        public long ms_01; // [long  ,   12] 증권매수                        StartPos 185, Length 12
        public long md_01; // [long  ,   12] 증권매도                        StartPos 198, Length 12
        public long rate_01; // [long  ,   12] 증권증감                        StartPos 211, Length 12
        public long svolume_01; // [long  ,   12] 증권순매수                      StartPos 224, Length 12
        public string tjjcode_03; // [string,    4] 투신투자자코드                  StartPos 237, Length 4
        public long ms_03; // [long  ,   12] 투신매수                        StartPos 242, Length 12
        public long md_03; // [long  ,   12] 투신매도                        StartPos 255, Length 12
        public long rate_03; // [long  ,   12] 투신증감                        StartPos 268, Length 12
        public long svolume_03; // [long  ,   12] 투신순매수                      StartPos 281, Length 12
        public string tjjcode_04; // [string,    4] 은행투자자코드                  StartPos 294, Length 4
        public long ms_04; // [long  ,   12] 은행매수                        StartPos 299, Length 12
        public long md_04; // [long  ,   12] 은행매도                        StartPos 312, Length 12
        public long rate_04; // [long  ,   12] 은행증감                        StartPos 325, Length 12
        public long svolume_04; // [long  ,   12] 은행순매수                      StartPos 338, Length 12
        public string tjjcode_02; // [string,    4] 보험투자자코드                  StartPos 351, Length 4
        public long ms_02; // [long  ,   12] 보험매수                        StartPos 356, Length 12
        public long md_02; // [long  ,   12] 보험매도                        StartPos 369, Length 12
        public long rate_02; // [long  ,   12] 보험증감                        StartPos 382, Length 12
        public long svolume_02; // [long  ,   12] 보험순매수                      StartPos 395, Length 12
        public string tjjcode_05; // [string,    4] 종금투자자코드                  StartPos 408, Length 4
        public long ms_05; // [long  ,   12] 종금매수                        StartPos 413, Length 12
        public long md_05; // [long  ,   12] 종금매도                        StartPos 426, Length 12
        public long rate_05; // [long  ,   12] 종금증감                        StartPos 439, Length 12
        public long svolume_05; // [long  ,   12] 종금순매수                      StartPos 452, Length 12
        public string tjjcode_06; // [string,    4] 기금투자자코드                  StartPos 465, Length 4
        public long ms_06; // [long  ,   12] 기금매수                        StartPos 470, Length 12
        public long md_06; // [long  ,   12] 기금매도                        StartPos 483, Length 12
        public long rate_06; // [long  ,   12] 기금증감                        StartPos 496, Length 12
        public long svolume_06; // [long  ,   12] 기금순매수                      StartPos 509, Length 12
        public string tjjcode_07; // [string,    4] 기타투자자코드                  StartPos 522, Length 4
        public long ms_07; // [long  ,   12] 기타매수                        StartPos 527, Length 12
        public long md_07; // [long  ,   12] 기타매도                        StartPos 540, Length 12
        public long rate_07; // [long  ,   12] 기타증감                        StartPos 553, Length 12
        public long svolume_07; // [long  ,   12] 기타순매수                      StartPos 566, Length 12
        public string tjjcode_11; // [string,    4] 국가투자자코드                  StartPos 579, Length 4
        public long ms_11; // [long  ,   12] 국가매수                        StartPos 584, Length 12
        public long md_11; // [long  ,   12] 국가매도                        StartPos 597, Length 12
        public long rate_11; // [long  ,   12] 국가증감                        StartPos 610, Length 12
        public long svolume_11; // [long  ,   12] 국가순매수                      StartPos 623, Length 12
        public string tjjcode_00; // [string,    4] 사모펀드코드                    StartPos 636, Length 4
        public long ms_00; // [long  ,   12] 사모펀드매수                    StartPos 641, Length 12
        public long md_00; // [long  ,   12] 사모펀드매도                    StartPos 654, Length 12
        public long rate_00; // [long  ,   12] 사모펀드증감                    StartPos 667, Length 12
        public long svolume_00; // [long  ,   12] 사모펀드순매수                  StartPos 680, Length 12
    }

    public struct _t2813OutBlock1
    {
        public string time; // [string,    8] 시간                            StartPos 0, Length 8
        public long sv_08; // [long  ,   12] 개인순매수                      StartPos 9, Length 12
        public long sv_17; // [long  ,   12] 외국인순매수                    StartPos 22, Length 12
        public long sv_18; // [long  ,   12] 기관계순매수                    StartPos 35, Length 12
        public long sv_01; // [long  ,   12] 증권순매수                      StartPos 48, Length 12
        public long sv_03; // [long  ,   12] 투신순매수                      StartPos 61, Length 12
        public long sv_04; // [long  ,   12] 은행순매수                      StartPos 74, Length 12
        public long sv_02; // [long  ,   12] 보험순매수                      StartPos 87, Length 12
        public long sv_05; // [long  ,   12] 종금순매수                      StartPos 100, Length 12
        public long sv_06; // [long  ,   12] 기금순매수                      StartPos 113, Length 12
        public long sv_07; // [long  ,   12] 기타순매수                      StartPos 126, Length 12
        public long sv_11; // [long  ,   12] 국가순매수                      StartPos 139, Length 12
        public long sv_00; // [long  ,   12] 사모펀드순매수                  StartPos 152, Length 12
    }
}