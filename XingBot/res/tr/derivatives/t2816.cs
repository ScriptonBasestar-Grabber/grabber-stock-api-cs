namespace XingBot.real.res
{
    // CME야간선물투자자별종합 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t2816InBlock
    {
        public string dummy; // [string,    1] Dummy                           StartPos 0, Length 1
    }

    public struct _t2816OutBlock1
    {
        public string tjjcode_08; // [string,    4] 개인투자자코드                  StartPos 0, Length 4
        public long ms_08; // [long  ,   12] 개인매수                        StartPos 5, Length 12
        public long md_08; // [long  ,   12] 개인매도                        StartPos 18, Length 12
        public long rate_08; // [long  ,   12] 개인증감                        StartPos 31, Length 12
        public long svolume_08; // [long  ,   12] 개인순매수                      StartPos 44, Length 12
        public string tjjcode_17; // [string,    4] 외국인투자자코드                StartPos 57, Length 4
        public long ms_17; // [long  ,   12] 외국인매수                      StartPos 62, Length 12
        public long md_17; // [long  ,   12] 외국인매도                      StartPos 75, Length 12
        public long rate_17; // [long  ,   12] 외국인증감                      StartPos 88, Length 12
        public long svolume_17; // [long  ,   12] 외국인순매수                    StartPos 101, Length 12
        public string tjjcode_18; // [string,    4] 기관계투자자코드                StartPos 114, Length 4
        public long ms_18; // [long  ,   12] 기관계매수                      StartPos 119, Length 12
        public long md_18; // [long  ,   12] 기관계매도                      StartPos 132, Length 12
        public long rate_18; // [long  ,   12] 기관계증감                      StartPos 145, Length 12
        public long svolume_18; // [long  ,   12] 기관계순매수                    StartPos 158, Length 12
        public string tjjcode_01; // [string,    4] 증권투자자코드                  StartPos 171, Length 4
        public long ms_01; // [long  ,   12] 증권매수                        StartPos 176, Length 12
        public long md_01; // [long  ,   12] 증권매도                        StartPos 189, Length 12
        public long rate_01; // [long  ,   12] 증권증감                        StartPos 202, Length 12
        public long svolume_01; // [long  ,   12] 증권순매수                      StartPos 215, Length 12
        public string tjjcode_03; // [string,    4] 투신투자자코드                  StartPos 228, Length 4
        public long ms_03; // [long  ,   12] 투신매수                        StartPos 233, Length 12
        public long md_03; // [long  ,   12] 투신매도                        StartPos 246, Length 12
        public long rate_03; // [long  ,   12] 투신증감                        StartPos 259, Length 12
        public long svolume_03; // [long  ,   12] 투신순매수                      StartPos 272, Length 12
        public string tjjcode_04; // [string,    4] 은행투자자코드                  StartPos 285, Length 4
        public long ms_04; // [long  ,   12] 은행매수                        StartPos 290, Length 12
        public long md_04; // [long  ,   12] 은행매도                        StartPos 303, Length 12
        public long rate_04; // [long  ,   12] 은행증감                        StartPos 316, Length 12
        public long svolume_04; // [long  ,   12] 은행순매수                      StartPos 329, Length 12
        public string tjjcode_02; // [string,    4] 보험투자자코드                  StartPos 342, Length 4
        public long ms_02; // [long  ,   12] 보험매수                        StartPos 347, Length 12
        public long md_02; // [long  ,   12] 보험매도                        StartPos 360, Length 12
        public long rate_02; // [long  ,   12] 보험증감                        StartPos 373, Length 12
        public long svolume_02; // [long  ,   12] 보험순매수                      StartPos 386, Length 12
        public string tjjcode_05; // [string,    4] 종금투자자코드                  StartPos 399, Length 4
        public long ms_05; // [long  ,   12] 종금매수                        StartPos 404, Length 12
        public long md_05; // [long  ,   12] 종금매도                        StartPos 417, Length 12
        public long rate_05; // [long  ,   12] 종금증감                        StartPos 430, Length 12
        public long svolume_05; // [long  ,   12] 종금순매수                      StartPos 443, Length 12
        public string tjjcode_06; // [string,    4] 기금투자자코드                  StartPos 456, Length 4
        public long ms_06; // [long  ,   12] 기금매수                        StartPos 461, Length 12
        public long md_06; // [long  ,   12] 기금매도                        StartPos 474, Length 12
        public long rate_06; // [long  ,   12] 기금증감                        StartPos 487, Length 12
        public long svolume_06; // [long  ,   12] 기금순매수                      StartPos 500, Length 12
        public string tjjcode_11; // [string,    4] 국가투자코드                    StartPos 513, Length 4
        public long ms_11; // [long  ,   12] 국가매수                        StartPos 518, Length 12
        public long md_11; // [long  ,   12] 국가매도                        StartPos 531, Length 12
        public long rate_11; // [long  ,   12] 국가증감                        StartPos 544, Length 12
        public long svolume_11; // [long  ,   12] 국가순매수                      StartPos 557, Length 12
        public string tjjcode_07; // [string,    4] 기타투자자코드                  StartPos 570, Length 4
        public long ms_07; // [long  ,   12] 기타매수                        StartPos 575, Length 12
        public long md_07; // [long  ,   12] 기타매도                        StartPos 588, Length 12
        public long rate_07; // [long  ,   12] 기타증감                        StartPos 601, Length 12
        public long svolume_07; // [long  ,   12] 기타순매수                      StartPos 614, Length 12
        public string tjjcode_00; // [string,    4] 사모펀드투자자코드              StartPos 627, Length 4
        public long ms_00; // [long  ,   12] 사모펀드매수                    StartPos 632, Length 12
        public long md_00; // [long  ,   12] 사모펀드매도                    StartPos 645, Length 12
        public long rate_00; // [long  ,   12] 사모펀드증감                    StartPos 658, Length 12
        public long svolume_00; // [long  ,   12] 사모펀드순매수                  StartPos 671, Length 12
    }

    public struct _t2816OutBlock2
    {
        public string tjjcode_08; // [string,    4] 개인투자자코드                  StartPos 0, Length 4
        public long ms_08; // [long  ,   12] 개인매수                        StartPos 5, Length 12
        public long md_08; // [long  ,   12] 개인매도                        StartPos 18, Length 12
        public long rate_08; // [long  ,   12] 개인증감                        StartPos 31, Length 12
        public long svolume_08; // [long  ,   12] 개인순매수                      StartPos 44, Length 12
        public string tjjcode_17; // [string,    4] 외국인투자자코드                StartPos 57, Length 4
        public long ms_17; // [long  ,   12] 외국인매수                      StartPos 62, Length 12
        public long md_17; // [long  ,   12] 외국인매도                      StartPos 75, Length 12
        public long rate_17; // [long  ,   12] 외국인증감                      StartPos 88, Length 12
        public long svolume_17; // [long  ,   12] 외국인순매수                    StartPos 101, Length 12
        public string tjjcode_18; // [string,    4] 기관계투자자코드                StartPos 114, Length 4
        public long ms_18; // [long  ,   12] 기관계매수                      StartPos 119, Length 12
        public long md_18; // [long  ,   12] 기관계매도                      StartPos 132, Length 12
        public long rate_18; // [long  ,   12] 기관계증감                      StartPos 145, Length 12
        public long svolume_18; // [long  ,   12] 기관계순매수                    StartPos 158, Length 12
        public string tjjcode_01; // [string,    4] 증권투자자코드                  StartPos 171, Length 4
        public long ms_01; // [long  ,   12] 증권매수                        StartPos 176, Length 12
        public long md_01; // [long  ,   12] 증권매도                        StartPos 189, Length 12
        public long rate_01; // [long  ,   12] 증권증감                        StartPos 202, Length 12
        public long svolume_01; // [long  ,   12] 증권순매수                      StartPos 215, Length 12
        public string tjjcode_03; // [string,    4] 투신투자자코드                  StartPos 228, Length 4
        public long ms_03; // [long  ,   12] 투신매수                        StartPos 233, Length 12
        public long md_03; // [long  ,   12] 투신매도                        StartPos 246, Length 12
        public long rate_03; // [long  ,   12] 투신증감                        StartPos 259, Length 12
        public long svolume_03; // [long  ,   12] 투신순매수                      StartPos 272, Length 12
        public string tjjcode_04; // [string,    4] 은행투자자코드                  StartPos 285, Length 4
        public long ms_04; // [long  ,   12] 은행매수                        StartPos 290, Length 12
        public long md_04; // [long  ,   12] 은행매도                        StartPos 303, Length 12
        public long rate_04; // [long  ,   12] 은행증감                        StartPos 316, Length 12
        public long svolume_04; // [long  ,   12] 은행순매수                      StartPos 329, Length 12
        public string tjjcode_02; // [string,    4] 보험투자자코드                  StartPos 342, Length 4
        public long ms_02; // [long  ,   12] 보험매수                        StartPos 347, Length 12
        public long md_02; // [long  ,   12] 보험매도                        StartPos 360, Length 12
        public long rate_02; // [long  ,   12] 보험증감                        StartPos 373, Length 12
        public long svolume_02; // [long  ,   12] 보험순매수                      StartPos 386, Length 12
        public string tjjcode_05; // [string,    4] 종금투자자코드                  StartPos 399, Length 4
        public long ms_05; // [long  ,   12] 종금매수                        StartPos 404, Length 12
        public long md_05; // [long  ,   12] 종금매도                        StartPos 417, Length 12
        public long rate_05; // [long  ,   12] 종금증감                        StartPos 430, Length 12
        public long svolume_05; // [long  ,   12] 종금순매수                      StartPos 443, Length 12
        public string tjjcode_06; // [string,    4] 기금투자자코드                  StartPos 456, Length 4
        public long ms_06; // [long  ,   12] 기금매수                        StartPos 461, Length 12
        public long md_06; // [long  ,   12] 기금매도                        StartPos 474, Length 12
        public long rate_06; // [long  ,   12] 기금증감                        StartPos 487, Length 12
        public long svolume_06; // [long  ,   12] 기금순매수                      StartPos 500, Length 12
        public string tjjcode_11; // [string,    4] 국가투자코드                    StartPos 513, Length 4
        public long ms_11; // [long  ,   12] 국가매수                        StartPos 518, Length 12
        public long md_11; // [long  ,   12] 국가매도                        StartPos 531, Length 12
        public long rate_11; // [long  ,   12] 국가증감                        StartPos 544, Length 12
        public long svolume_11; // [long  ,   12] 국가순매수                      StartPos 557, Length 12
        public string tjjcode_07; // [string,    4] 기타투자자코드                  StartPos 570, Length 4
        public long ms_07; // [long  ,   12] 기타매수                        StartPos 575, Length 12
        public long md_07; // [long  ,   12] 기타매도                        StartPos 588, Length 12
        public long rate_07; // [long  ,   12] 기타증감                        StartPos 601, Length 12
        public long svolume_07; // [long  ,   12] 기타순매수                      StartPos 614, Length 12
        public string tjjcode_00; // [string,    4] 사모펀드투자자코드              StartPos 627, Length 4
        public long ms_00; // [long  ,   12] 사모펀드매수                    StartPos 632, Length 12
        public long md_00; // [long  ,   12] 사모펀드매도                    StartPos 645, Length 12
        public long rate_00; // [long  ,   12] 사모펀드증감                    StartPos 658, Length 12
        public long svolume_00; // [long  ,   12] 사모펀드순매수                  StartPos 671, Length 12
    }
}