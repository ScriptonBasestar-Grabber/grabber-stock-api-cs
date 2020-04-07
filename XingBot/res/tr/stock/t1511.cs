namespace XingBot.res
{
    // 업종현재가 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1511InBlock
    {
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 0, Length 3
    }

    public struct _t1511OutBlock
    {
        public string gubun{ get; set; } // [string,    1] 업종구분                        StartPos 0, Length 1
        public string hname{ get; set; } // [string,   20] 업종명                          StartPos 2, Length 20
        public decimal pricejisu{ get; set; } // [float ,  7.2] 현재지수                        StartPos 23, Length 7
        public decimal jniljisu{ get; set; } // [float ,  7.2] 전일지수                        StartPos 31, Length 7
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 39, Length 1
        public decimal change{ get; set; } // [float ,  7.2] 전일대비                        StartPos 41, Length 7
        public decimal diffjisu{ get; set; } // [float ,  6.2] 지수등락율                      StartPos 49, Length 6
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 56, Length 12
        public long volume{ get; set; } // [long  ,   12] 당일거래량                      StartPos 69, Length 12
        public long volumechange{ get; set; } // [long  ,   12] 거래량전일대비                  StartPos 82, Length 12
        public decimal volumerate{ get; set; } // [float ,  6.2] 거래량비율                      StartPos 95, Length 6
        public long jnilvalue{ get; set; } // [long  ,   12] 전일거래대금                    StartPos 102, Length 12
        public long value{ get; set; } // [long  ,   12] 당일거래대금                    StartPos 115, Length 12
        public long valuechange{ get; set; } // [long  ,   12] 거래대금전일대비                StartPos 128, Length 12
        public decimal valuerate{ get; set; } // [float ,  6.2] 거래대금비율                    StartPos 141, Length 6
        public decimal openjisu{ get; set; } // [float ,  7.2] 시가지수                        StartPos 148, Length 7
        public decimal opendiff{ get; set; } // [float ,  6.2] 시가등락율                      StartPos 156, Length 6
        public string opentime{ get; set; } // [string,    6] 시가시간                        StartPos 163, Length 6
        public decimal highjisu{ get; set; } // [float ,  7.2] 고가지수                        StartPos 170, Length 7
        public decimal highdiff{ get; set; } // [float ,  6.2] 고가등락율                      StartPos 178, Length 6
        public string hightime{ get; set; } // [string,    6] 고가시간                        StartPos 185, Length 6
        public decimal lowjisu{ get; set; } // [float ,  7.2] 저가지수                        StartPos 192, Length 7
        public decimal lowdiff{ get; set; } // [float ,  6.2] 저가등락율                      StartPos 200, Length 6
        public string lowtime{ get; set; } // [string,    6] 저가시간                        StartPos 207, Length 6
        public decimal whjisu{ get; set; } // [float ,  7.2] 52주최고지수                    StartPos 214, Length 7
        public decimal whchange{ get; set; } // [float ,  7.2] 52주최고현재가대비              StartPos 222, Length 7
        public string whjday{ get; set; } // [string,    8] 52주최고지수일자                StartPos 230, Length 8
        public decimal wljisu{ get; set; } // [float ,  7.2] 52주최저지수                    StartPos 239, Length 7
        public decimal wlchange{ get; set; } // [float ,  7.2] 52주최저현재가대비              StartPos 247, Length 7
        public string wljday{ get; set; } // [string,    8] 52주최저지수일자                StartPos 255, Length 8
        public decimal yhjisu{ get; set; } // [float ,  7.2] 연중최고지수                    StartPos 264, Length 7
        public decimal yhchange{ get; set; } // [float ,  7.2] 연중최고현재가대비              StartPos 272, Length 7
        public string yhjday{ get; set; } // [string,    8] 연중최고지수일자                StartPos 280, Length 8
        public decimal yljisu{ get; set; } // [float ,  7.2] 연중최저지수                    StartPos 289, Length 7
        public decimal ylchange{ get; set; } // [float ,  7.2] 연중최저현재가대비              StartPos 297, Length 7
        public string yljday{ get; set; } // [string,    8] 연중최저지수일자                StartPos 305, Length 8
        public string firstjcode{ get; set; } // [string,    3] 첫번째지수코드                  StartPos 314, Length 3
        public string firstjname{ get; set; } // [string,   20] 첫번째지수명                    StartPos 318, Length 20
        public decimal firstjisu{ get; set; } // [float ,  7.2] 첫번째지수                      StartPos 339, Length 7
        public string firsign{ get; set; } // [string,    1] 첫번째대비구분                  StartPos 347, Length 1
        public decimal firchange{ get; set; } // [float ,  7.2] 첫번째전일대비                  StartPos 349, Length 7
        public decimal firdiff{ get; set; } // [float ,  6.2] 첫번째등락율                    StartPos 357, Length 6
        public string secondjcode{ get; set; } // [string,    3] 두번째지수코드                  StartPos 364, Length 3
        public string secondjname{ get; set; } // [string,   20] 두번째지수명                    StartPos 368, Length 20
        public decimal secondjisu{ get; set; } // [float ,  7.2] 두번째지수                      StartPos 389, Length 7
        public string secsign{ get; set; } // [string,    1] 두번째대비구분                  StartPos 397, Length 1
        public decimal secchange{ get; set; } // [float ,  7.2] 두번째전일대비                  StartPos 399, Length 7
        public decimal secdiff{ get; set; } // [float ,  6.2] 두번째등락율                    StartPos 407, Length 6
        public string thirdjcode{ get; set; } // [string,    3] 세번째지수코드                  StartPos 414, Length 3
        public string thirdjname{ get; set; } // [string,   20] 세번째지수명                    StartPos 418, Length 20
        public decimal thirdjisu{ get; set; } // [float ,  7.2] 세번째지수                      StartPos 439, Length 7
        public string thrsign{ get; set; } // [string,    1] 세번째대비구분                  StartPos 447, Length 1
        public decimal thrchange{ get; set; } // [float ,  7.2] 세번째전일대비                  StartPos 449, Length 7
        public decimal thrdiff{ get; set; } // [float ,  6.2] 세번째등락율                    StartPos 457, Length 6
        public string fourthjcode{ get; set; } // [string,    3] 네번째지수코드                  StartPos 464, Length 3
        public string fourthjname{ get; set; } // [string,   20] 네번째지수명                    StartPos 468, Length 20
        public decimal fourthjisu{ get; set; } // [float ,  7.2] 네번째지수                      StartPos 489, Length 7
        public string forsign{ get; set; } // [string,    1] 네번째대비구분                  StartPos 497, Length 1
        public decimal forchange{ get; set; } // [float ,  7.2] 네번째전일대비                  StartPos 499, Length 7
        public decimal fordiff{ get; set; } // [float ,  6.2] 네번째등락율                    StartPos 507, Length 6
        public long highjo{ get; set; } // [long  ,    4] 상승종목수                      StartPos 514, Length 4
        public long upjo{ get; set; } // [long  ,    4] 상한종목수                      StartPos 519, Length 4
        public long unchgjo{ get; set; } // [long  ,    4] 보합종목수                      StartPos 524, Length 4
        public long lowjo{ get; set; } // [long  ,    4] 하락종목수                      StartPos 529, Length 4
        public long downjo{ get; set; } // [long  ,    4] 하한종목수                      StartPos 534, Length 4
    }
}