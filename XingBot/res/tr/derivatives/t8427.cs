﻿namespace XingBot.res
{
    // 선물옵션 과거데이터시간대별조회 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t8427InBlock
    {
        public string fo_gbn{ get; set; } // [string,    1] 선물옵션구분                    StartPos 0, Length 1
        public string yyyy{ get; set; } // [string,    4] 조회년도                        StartPos 2, Length 4
        public string mm{ get; set; } // [string,    2] 조회월                          StartPos 7, Length 2
        public string cp_gbn{ get; set; } // [string,    1] 옵션콜풋구분                    StartPos 10, Length 1
        public decimal actprice{ get; set; } // [float ,  6.2] 옵션행사가                      StartPos 12, Length 6
        public string focode{ get; set; } // [string,    8] 선물옵션코드                    StartPos 19, Length 8
        public string dt_gbn{ get; set; } // [string,    1] 일분구분                        StartPos 28, Length 1
        public string min_term{ get; set; } // [string,    2] 분간격                          StartPos 30, Length 2
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 33, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 42, Length 6
    }

    public class _t8427OutBlock
    {
        public string focode{ get; set; } // [string,    8] 선물옵션코드                    StartPos 0, Length 8
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 9, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 18, Length 6
    }

    public class _t8427OutBlock1
    {
        public string date{ get; set; } // [string,    8] 날짜                            StartPos 0, Length 8
        public string time{ get; set; } // [string,    6] 시간                            StartPos 9, Length 6
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 16, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 23, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 30, Length 6
        public decimal close{ get; set; } // [float ,  6.2] 종가                            StartPos 37, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 44, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 46, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 53, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 60, Length 12
        public decimal diff_vol{ get; set; } // [float , 10.2] 거래증가율                      StartPos 73, Length 10
        public long openyak{ get; set; } // [long  ,    8] 미결수량                        StartPos 84, Length 8
        public long openyakupdn{ get; set; } // [long  ,    8] 미결증감                        StartPos 93, Length 8
        public decimal value{ get; set; } // [float ,   12] 거래대금                        StartPos 102, Length 12
    }
}