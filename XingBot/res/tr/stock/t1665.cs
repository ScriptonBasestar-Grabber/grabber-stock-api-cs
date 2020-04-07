namespace XingBot.res
{
    // 기간별투자자매매추이(챠트) ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1665InBlock
    {
        public string market{ get; set; } // [string,    1] 시장구분(1:kospi2:kp2003:kosdaq StartPos 0, Length 1
        public string upcode{ get; set; } // [string,    3] 업종코드                        StartPos 2, Length 3
        public string gubun2{ get; set; } // [string,    1] 수치구분(1:수치2:누적)          StartPos 6, Length 1
        public string gubun3{ get; set; } // [string,    1] 단위구분(1:일2:주3:월)          StartPos 8, Length 1
        public string from_date{ get; set; } // [string,    8] 시작날짜                        StartPos 10, Length 8
        public string to_date{ get; set; } // [string,    8] 종료날짜                        StartPos 19, Length 8
    }

    public struct _t1665OutBlock
    {
        public string mcode{ get; set; } // [string,    8] 시장코드                        StartPos 0, Length 8
        public string mname{ get; set; } // [string,   20] 시장명                          StartPos 9, Length 20
    }

    public struct _t1665OutBlock1
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public long sv_08{ get; set; } // [long  ,   12] 개인수량                        StartPos 9, Length 12
        public long sv_17{ get; set; } // [long  ,   12] 외인계수량(등록+미등록)         StartPos 22, Length 12
        public long sv_18{ get; set; } // [long  ,   12] 기관계수량                      StartPos 35, Length 12
        public long sv_01{ get; set; } // [long  ,   12] 증권수량                        StartPos 48, Length 12
        public long sv_03{ get; set; } // [long  ,   12] 투신수량                        StartPos 61, Length 12
        public long sv_04{ get; set; } // [long  ,   12] 은행수량                        StartPos 74, Length 12
        public long sv_02{ get; set; } // [long  ,   12] 보험수량                        StartPos 87, Length 12
        public long sv_05{ get; set; } // [long  ,   12] 종금수량                        StartPos 100, Length 12
        public long sv_06{ get; set; } // [long  ,   12] 기금수량                        StartPos 113, Length 12
        public long sv_07{ get; set; } // [long  ,   12] 기타수량                        StartPos 126, Length 12
        public long sv_00{ get; set; } // [long  ,   12] 사모펀드수량                    StartPos 139, Length 12
        public long sv_09{ get; set; } // [long  ,   12] 등록외국인수량                  StartPos 152, Length 12
        public long sv_10{ get; set; } // [long  ,   12] 미등록외국인수량                StartPos 165, Length 12
        public long sv_11{ get; set; } // [long  ,   12] 국가수량                        StartPos 178, Length 12
        public long sv_99{ get; set; } // [long  ,   12] 기타계수량(기타+국가)           StartPos 191, Length 12
        public decimal sa_08{ get; set; } // [double,   12] 개인금액                        StartPos 204, Length 12
        public decimal sa_17{ get; set; } // [double,   12] 외인계금액(등록+미등록)         StartPos 217, Length 12
        public decimal sa_18{ get; set; } // [double,   12] 기관계금액                      StartPos 230, Length 12
        public decimal sa_01{ get; set; } // [double,   12] 증권금액                        StartPos 243, Length 12
        public decimal sa_03{ get; set; } // [double,   12] 투신금액                        StartPos 256, Length 12
        public decimal sa_04{ get; set; } // [double,   12] 은행금액                        StartPos 269, Length 12
        public decimal sa_02{ get; set; } // [double,   12] 보험금액                        StartPos 282, Length 12
        public decimal sa_05{ get; set; } // [double,   12] 종금금액                        StartPos 295, Length 12
        public decimal sa_06{ get; set; } // [double,   12] 기금금액                        StartPos 308, Length 12
        public decimal sa_07{ get; set; } // [double,   12] 기타금액                        StartPos 321, Length 12
        public decimal sa_00{ get; set; } // [double,   12] 사모펀드금액                    StartPos 334, Length 12
        public decimal sa_09{ get; set; } // [double,   12] 등록외국인금액                  StartPos 347, Length 12
        public decimal sa_10{ get; set; } // [double,   12] 미등록외국인금액                StartPos 360, Length 12
        public decimal sa_11{ get; set; } // [double,   12] 국가금액                        StartPos 373, Length 12
        public decimal sa_99{ get; set; } // [double,   12] 기타계금액(기타+국가)           StartPos 386, Length 12
        public decimal jisu{ get; set; } // [float ,  7.2] 시장지수                        StartPos 399, Length 7
    }
}