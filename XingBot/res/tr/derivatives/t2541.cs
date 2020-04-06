namespace XingBot.real.res
{
    // 상품선물투자자매매동향(실시간) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2541InBlock
    {
        public string eitem; // [string,    2] 상품ID                          StartPos 0, Length 2
        public string market; // [string,    1] 시장구분                        StartPos 3, Length 1
        public string upcode; // [string,    3] 업종코드                        StartPos 5, Length 3
        public string gubun1; // [string,    1] 수량구분                        StartPos 9, Length 1
        public string gubun2; // [string,    1] 전일분구분                      StartPos 11, Length 1
        public string cts_time; // [string,    8] CTSTIME                         StartPos 13, Length 8
        public long cts_idx; // [long  ,    4] CTSIDX                          StartPos 22, Length 4
        public string cnt; // [string,    4] 조회건수                        StartPos 27, Length 4
    }

    public struct _t2541OutBlock
    {
        public string eitem; // [string,    2] 상품ID                          StartPos 0, Length 2
        public string sgubun; // [string,    1] 시장구분                        StartPos 3, Length 1
        public string cts_time; // [string,    8] CTSTIME                         StartPos 5, Length 8
        public string tjjcode_08; // [string,    4] 개인투자자코드                  StartPos 14, Length 4
        public long ms_08; // [long  ,   12] 개인매수                        StartPos 19, Length 12
        public long md_08; // [long  ,   12] 개인매도                        StartPos 32, Length 12
        public long rate_08; // [long  ,   12] 개인증감                        StartPos 45, Length 12
        public long svolume_08; // [long  ,   12] 개인순매수                      StartPos 58, Length 12
        public string tjjcode_17; // [string,    4] 외국인투자자코드                StartPos 71, Length 4
        public long ms_17; // [long  ,   12] 외국인매수                      StartPos 76, Length 12
        public long md_17; // [long  ,   12] 외국인매도                      StartPos 89, Length 12
        public long rate_17; // [long  ,   12] 외국인증감                      StartPos 102, Length 12
        public long svolume_17; // [long  ,   12] 외국인순매수                    StartPos 115, Length 12
        public string tjjcode_18; // [string,    4] 기관계투자자코드                StartPos 128, Length 4
        public long ms_18; // [long  ,   12] 기관계매수                      StartPos 133, Length 12
        public long md_18; // [long  ,   12] 기관계매도                      StartPos 146, Length 12
        public long rate_18; // [long  ,   12] 기관계증감                      StartPos 159, Length 12
        public long svolume_18; // [long  ,   12] 기관계순매수                    StartPos 172, Length 12
        public string tjjcode_01; // [string,    4] 증권투자자코드                  StartPos 185, Length 4
        public long ms_01; // [long  ,   12] 증권매수                        StartPos 190, Length 12
        public long md_01; // [long  ,   12] 증권매도                        StartPos 203, Length 12
        public long rate_01; // [long  ,   12] 증권증감                        StartPos 216, Length 12
        public long svolume_01; // [long  ,   12] 증권순매수                      StartPos 229, Length 12
        public string tjjcode_03; // [string,    4] 투신투자자코드                  StartPos 242, Length 4
        public long ms_03; // [long  ,   12] 투신매수                        StartPos 247, Length 12
        public long md_03; // [long  ,   12] 투신매도                        StartPos 260, Length 12
        public long rate_03; // [long  ,   12] 투신증감                        StartPos 273, Length 12
        public long svolume_03; // [long  ,   12] 투신순매수                      StartPos 286, Length 12
        public string tjjcode_04; // [string,    4] 은행투자자코드                  StartPos 299, Length 4
        public long ms_04; // [long  ,   12] 은행매수                        StartPos 304, Length 12
        public long md_04; // [long  ,   12] 은행매도                        StartPos 317, Length 12
        public long rate_04; // [long  ,   12] 은행증감                        StartPos 330, Length 12
        public long svolume_04; // [long  ,   12] 은행순매수                      StartPos 343, Length 12
        public string tjjcode_02; // [string,    4] 보험투자자코드                  StartPos 356, Length 4
        public long ms_02; // [long  ,   12] 보험매수                        StartPos 361, Length 12
        public long md_02; // [long  ,   12] 보험매도                        StartPos 374, Length 12
        public long rate_02; // [long  ,   12] 보험증감                        StartPos 387, Length 12
        public long svolume_02; // [long  ,   12] 보험순매수                      StartPos 400, Length 12
        public string tjjcode_05; // [string,    4] 종금투자자코드                  StartPos 413, Length 4
        public long ms_05; // [long  ,   12] 종금매수                        StartPos 418, Length 12
        public long md_05; // [long  ,   12] 종금매도                        StartPos 431, Length 12
        public long rate_05; // [long  ,   12] 종금증감                        StartPos 444, Length 12
        public long svolume_05; // [long  ,   12] 종금순매수                      StartPos 457, Length 12
        public string tjjcode_06; // [string,    4] 기금투자자코드                  StartPos 470, Length 4
        public long ms_06; // [long  ,   12] 기금매수                        StartPos 475, Length 12
        public long md_06; // [long  ,   12] 기금매도                        StartPos 488, Length 12
        public long rate_06; // [long  ,   12] 기금증감                        StartPos 501, Length 12
        public long svolume_06; // [long  ,   12] 기금순매수                      StartPos 514, Length 12
        public string tjjcode_07; // [string,    4] 기타투자자코드                  StartPos 527, Length 4
        public long ms_07; // [long  ,   12] 기타매수                        StartPos 532, Length 12
        public long md_07; // [long  ,   12] 기타매도                        StartPos 545, Length 12
        public long rate_07; // [long  ,   12] 기타증감                        StartPos 558, Length 12
        public long svolume_07; // [long  ,   12] 기타순매수                      StartPos 571, Length 12
        public string tjjcode_11; // [string,    4] 국가투자자코드                  StartPos 584, Length 4
        public long ms_11; // [long  ,   12] 국가매수                        StartPos 589, Length 12
        public long md_11; // [long  ,   12] 국가매도                        StartPos 602, Length 12
        public long rate_11; // [long  ,   12] 국가증감                        StartPos 615, Length 12
        public long svolume_11; // [long  ,   12] 국가순매수                      StartPos 628, Length 12
        public string tjjcode_00; // [string,    4] 사모펀드코드                    StartPos 641, Length 4
        public long ms_00; // [long  ,   12] 사모펀드매수                    StartPos 646, Length 12
        public long md_00; // [long  ,   12] 사모펀드매도                    StartPos 659, Length 12
        public long rate_00; // [long  ,   12] 사모펀드증감                    StartPos 672, Length 12
        public long svolume_00; // [long  ,   12] 사모펀드순매수                  StartPos 685, Length 12
    }

    public struct _t2541OutBlock1
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