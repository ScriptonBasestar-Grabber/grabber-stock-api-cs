﻿namespace XingBot.res
{
    // 외인/기관 종목별동향 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1701InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    1] 구분                            StartPos 7, Length 1
        public string fromdt{ get; set; } // [string,    8] 시작일자                        StartPos 9, Length 8
        public string todt{ get; set; } // [string,    8] 종료일자                        StartPos 18, Length 8
        public long prapp{ get; set; } // [long  ,    3] PR적용                          StartPos 27, Length 3
        public string prgubun{ get; set; } // [string,    1] PR적용구분                      StartPos 31, Length 1
        public string orggubun{ get; set; } // [string,    1] 기관적용                        StartPos 33, Length 1
        public string frggubun{ get; set; } // [string,    1] 외인적용                        StartPos 35, Length 1
    }

    public class _t1701OutBlock
    {
        public string date{ get; set; } // [string,    8] 일자                            StartPos 0, Length 8
        public long close{ get; set; } // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume{ get; set; } // [long  ,   12] 누적거래량                      StartPos 36, Length 12
        public long psnvolume{ get; set; } // [long  ,   12] 개인                            StartPos 49, Length 12
        public long orgvolume{ get; set; } // [long  ,   12] 기관                            StartPos 62, Length 12
        public long frgvolume{ get; set; } // [long  ,   12] 외국인                          StartPos 75, Length 12
        public long frgvolumesum{ get; set; } // [long  ,   12] 외국계                          StartPos 88, Length 12
        public long pgmvolume{ get; set; } // [long  ,   12] 프로그램                        StartPos 101, Length 12
        public long listing{ get; set; } // [long  ,   12] 보유주식수                      StartPos 114, Length 12
        public long listupdn{ get; set; } // [long  ,   12] 발행증감                        StartPos 127, Length 12
        public decimal sjrate{ get; set; } // [float ,  6.2] 소진율                          StartPos 140, Length 6
    }
}