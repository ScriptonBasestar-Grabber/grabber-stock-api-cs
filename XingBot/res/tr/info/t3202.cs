namespace XingBot.res
{
    // 종목별 증시일정 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t3202InBlock
    {
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 0, Length 6
        public string date{ get; set; } // [string,    8] 조회일자                        StartPos 7, Length 8
    }

    public class _t3202OutBlock
    {
        public string recdt{ get; set; } // [string,    8] 기준일                          StartPos 0, Length 8
        public string tableid{ get; set; } // [string,    6] 테이블아이디                    StartPos 9, Length 6
        public string upgu{ get; set; } // [string,    2] 업무구분                        StartPos 16, Length 2
        public string custno{ get; set; } // [string,    5] 발행체번호                      StartPos 19, Length 5
        public string custnm{ get; set; } // [string,   80] 발행회사명                      StartPos 25, Length 80
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 106, Length 6
        public string upnm{ get; set; } // [string,   20] 업무명                          StartPos 113, Length 20
    }
}