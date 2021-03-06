﻿namespace XingBot.res
{
    // ELW 거래량 상위 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1961InBlock
    {
        public string gubun{ get; set; } // [string,    1] 당일전일(0:당일1:전일)          StartPos 0, Length 1
        public string ggubun{ get; set; } // [string,    2] 권리유형구분(00:EX01:콜02:풋'': StartPos 2, Length 2
        public string itemcode{ get; set; } // [string,   12] 기초자산종목                    StartPos 5, Length 12
        public string lastdate{ get; set; } // [string,    8] 조회만기일                      StartPos 18, Length 8
        public string exgubun{ get; set; } // [string,    6] 대상제외                        StartPos 27, Length 6
        public long sprice{ get; set; } // [long  ,    8] 시작가격                        StartPos 34, Length 8
        public long eprice{ get; set; } // [long  ,    8] 종료가격                        StartPos 43, Length 8
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 52, Length 12
        public long sjanday{ get; set; } // [long  ,    8] 잔존시작일수                    StartPos 65, Length 8
        public long ejanday{ get; set; } // [long  ,    8] 잔존종료일수                    StartPos 74, Length 8
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 83, Length 4
    }

    public class _t1961OutBlock
    {
        public long idx{ get; set; } // [long  ,    4] IDX                             StartPos 0, Length 4
    }

    public class _t1961OutBlock1
    {
        public string hname{ get; set; } // [string,   40] 한글명                          StartPos 0, Length 40
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 41, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 50, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 52, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 61, Length 6
        public decimal volume{ get; set; } // [double,   12] 누적거래량                      StartPos 68, Length 12
        public decimal jnilvolume{ get; set; } // [double,   12] 전일거래량                      StartPos 81, Length 12
        public decimal elwexec{ get; set; } // [double, 10.2] 행사가                          StartPos 94, Length 10
        public decimal convrate{ get; set; } // [double, 12.4] 전환비율                        StartPos 105, Length 12
        public string lastdate{ get; set; } // [string,    8] 만기일                          StartPos 118, Length 8
        public string itemcode{ get; set; } // [string,   12] 기초자산종목코드                StartPos 127, Length 12
        public string itemshcode{ get; set; } // [string,    9] 기초자산단축코드                StartPos 140, Length 9
        public string itemname{ get; set; } // [string,   20] 기초자산종목명                  StartPos 150, Length 20
        public string itemprice{ get; set; } // [string,   10] 기초자산현재가                  StartPos 171, Length 10
        public string itemsign{ get; set; } // [string,    1] 기초자산대비구분                StartPos 182, Length 1
        public string itemchange{ get; set; } // [string,   10] 기초자산전일대비                StartPos 184, Length 10
        public decimal itemdiff{ get; set; } // [double,  6.2] 기초자산등락율                  StartPos 195, Length 6
        public string elwshcode{ get; set; } // [string,    6] ELW종목코드                     StartPos 202, Length 6
    }
}