using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.info
{
    // FNG_요약 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t3320InBlock
    {
        public string gicode; // [string,    7] 종목코드                        StartPos 0, Length 7
    }

    struct _t3320OutBlock
    {
        public string upgubunnm; // [string,   20] 업종구분명                      StartPos 0, Length 20
        public string sijangcd; // [string,    1] 시장구분                        StartPos 21, Length 1
        public string marketnm; // [string,   10] 시장구분명                      StartPos 23, Length 10
        public string company; // [string,  100] 한글기업명                      StartPos 34, Length 100
        public string baddress; // [string,  100] 본사주소                        StartPos 135, Length 100
        public string btelno; // [string,   20] 본사전화번호                    StartPos 236, Length 20
        public string gsyyyy; // [string,    4] 최근결산년도                    StartPos 257, Length 4
        public string gsmm; // [string,    2] 결산월                          StartPos 262, Length 2
        public string gsym; // [string,    6] 최근결산년월                    StartPos 265, Length 6
        public long lstprice; // [long  ,   12] 주당액면가                      StartPos 272, Length 12
        public long gstock; // [long  ,   12] 주식수                          StartPos 285, Length 12
        public string homeurl; // [string,   50] Homepage                        StartPos 298, Length 50
        public string grdnm; // [string,   30] 그룹명                          StartPos 349, Length 30
        public float foreignratio; // [float ,  6.2] 외국인                          StartPos 380, Length 6
        public string irtel; // [string,   30] 주담전화                        StartPos 387, Length 30
        public float capital; // [float ,   12] 자본금                          StartPos 418, Length 12
        public float sigavalue; // [float ,   12] 시가총액                        StartPos 431, Length 12
        public float cashsis; // [float ,   12] 배당금                          StartPos 444, Length 12
        public float cashrate; // [float , 13.2] 배당수익율                      StartPos 457, Length 13
        public long price; // [long  ,    8] 현재가                          StartPos 471, Length 8
        public long jnilclose; // [long  ,    8] 전일종가                        StartPos 480, Length 8
    }

    struct _t3320OutBlock1
    {
        public string gicode; // [string,    7] 기업코드                        StartPos 0, Length 7
        public string gsym; // [string,    6] 결산년월                        StartPos 8, Length 6
        public string gsgb; // [string,    1] 결산구분                        StartPos 15, Length 1
        public float per; // [float , 13.2] PER                             StartPos 17, Length 13
        public float eps; // [float ,   13] EPS                             StartPos 31, Length 13
        public float pbr; // [float , 13.2] PBR                             StartPos 45, Length 13
        public float roa; // [float , 13.2] ROA                             StartPos 59, Length 13
        public float roe; // [float , 13.2] ROE                             StartPos 73, Length 13
        public float ebitda; // [float , 13.2] EBITDA                          StartPos 87, Length 13
        public float evebitda; // [float , 13.2] EVEBITDA                        StartPos 101, Length 13
        public float par; // [float , 13.2] 액면가                          StartPos 115, Length 13
        public float sps; // [float , 13.2] SPS                             StartPos 129, Length 13
        public float cps; // [float , 13.2] CPS                             StartPos 143, Length 13
        public float bps; // [float ,   13] BPS                             StartPos 157, Length 13
        public float t_per; // [float , 13.2] T.PER                           StartPos 171, Length 13
        public float t_eps; // [float ,   13] T.EPS                           StartPos 185, Length 13
        public float peg; // [float , 13.2] PEG                             StartPos 199, Length 13
        public float t_peg; // [float , 13.2] T.PEG                           StartPos 213, Length 13
        public string t_gsym; // [string,    6] 최근분기년도                    StartPos 227, Length 6
    }
}