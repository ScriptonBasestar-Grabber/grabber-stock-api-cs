namespace XingBot.res
{
    // FNG_요약 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t3320InBlock
    {
        public string gicode{ get; set; } // [string,    7] 종목코드                        StartPos 0, Length 7
    }

    public struct _t3320OutBlock
    {
        public string upgubunnm{ get; set; } // [string,   20] 업종구분명                      StartPos 0, Length 20
        public string sijangcd{ get; set; } // [string,    1] 시장구분                        StartPos 21, Length 1
        public string marketnm{ get; set; } // [string,   10] 시장구분명                      StartPos 23, Length 10
        public string company{ get; set; } // [string,  100] 한글기업명                      StartPos 34, Length 100
        public string baddress{ get; set; } // [string,  100] 본사주소                        StartPos 135, Length 100
        public string btelno{ get; set; } // [string,   20] 본사전화번호                    StartPos 236, Length 20
        public string gsyyyy{ get; set; } // [string,    4] 최근결산년도                    StartPos 257, Length 4
        public string gsmm{ get; set; } // [string,    2] 결산월                          StartPos 262, Length 2
        public string gsym{ get; set; } // [string,    6] 최근결산년월                    StartPos 265, Length 6
        public long lstprice{ get; set; } // [long  ,   12] 주당액면가                      StartPos 272, Length 12
        public long gstock{ get; set; } // [long  ,   12] 주식수                          StartPos 285, Length 12
        public string homeurl{ get; set; } // [string,   50] Homepage                        StartPos 298, Length 50
        public string grdnm{ get; set; } // [string,   30] 그룹명                          StartPos 349, Length 30
        public decimal foreignratio{ get; set; } // [float ,  6.2] 외국인                          StartPos 380, Length 6
        public string irtel{ get; set; } // [string,   30] 주담전화                        StartPos 387, Length 30
        public decimal capital{ get; set; } // [float ,   12] 자본금                          StartPos 418, Length 12
        public decimal sigavalue{ get; set; } // [float ,   12] 시가총액                        StartPos 431, Length 12
        public decimal cashsis{ get; set; } // [float ,   12] 배당금                          StartPos 444, Length 12
        public decimal cashrate{ get; set; } // [float , 13.2] 배당수익율                      StartPos 457, Length 13
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 471, Length 8
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 480, Length 8
    }

    public struct _t3320OutBlock1
    {
        public string gicode{ get; set; } // [string,    7] 기업코드                        StartPos 0, Length 7
        public string gsym{ get; set; } // [string,    6] 결산년월                        StartPos 8, Length 6
        public string gsgb{ get; set; } // [string,    1] 결산구분                        StartPos 15, Length 1
        public decimal per{ get; set; } // [float , 13.2] PER                             StartPos 17, Length 13
        public decimal eps{ get; set; } // [float ,   13] EPS                             StartPos 31, Length 13
        public decimal pbr{ get; set; } // [float , 13.2] PBR                             StartPos 45, Length 13
        public decimal roa{ get; set; } // [float , 13.2] ROA                             StartPos 59, Length 13
        public decimal roe{ get; set; } // [float , 13.2] ROE                             StartPos 73, Length 13
        public decimal ebitda{ get; set; } // [float , 13.2] EBITDA                          StartPos 87, Length 13
        public decimal evebitda{ get; set; } // [float , 13.2] EVEBITDA                        StartPos 101, Length 13
        public decimal par{ get; set; } // [float , 13.2] 액면가                          StartPos 115, Length 13
        public decimal sps{ get; set; } // [float , 13.2] SPS                             StartPos 129, Length 13
        public decimal cps{ get; set; } // [float , 13.2] CPS                             StartPos 143, Length 13
        public decimal bps{ get; set; } // [float ,   13] BPS                             StartPos 157, Length 13
        public decimal t_per{ get; set; } // [float , 13.2] T.PER                           StartPos 171, Length 13
        public decimal t_eps{ get; set; } // [float ,   13] T.EPS                           StartPos 185, Length 13
        public decimal peg{ get; set; } // [float , 13.2] PEG                             StartPos 199, Length 13
        public decimal t_peg{ get; set; } // [float , 13.2] T.PEG                           StartPos 213, Length 13
        public string t_gsym{ get; set; } // [string,    6] 최근분기년도                    StartPos 227, Length 6
    }
}