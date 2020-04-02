using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 업종현재가 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1511InBlock
    {
        public string upcode; // [string,    3] 업종코드                        StartPos 0, Length 3
    }

    struct _t1511OutBlock
    {
        public string gubun; // [string,    1] 업종구분                        StartPos 0, Length 1
        public string hname; // [string,   20] 업종명                          StartPos 2, Length 20
        public float pricejisu; // [float ,  7.2] 현재지수                        StartPos 23, Length 7
        public float jniljisu; // [float ,  7.2] 전일지수                        StartPos 31, Length 7
        public string sign; // [string,    1] 전일대비구분                    StartPos 39, Length 1
        public float change; // [float ,  7.2] 전일대비                        StartPos 41, Length 7
        public float diffjisu; // [float ,  6.2] 지수등락율                      StartPos 49, Length 6
        public long jnilvolume; // [long  ,   12] 전일거래량                      StartPos 56, Length 12
        public long volume; // [long  ,   12] 당일거래량                      StartPos 69, Length 12
        public long volumechange; // [long  ,   12] 거래량전일대비                  StartPos 82, Length 12
        public float volumerate; // [float ,  6.2] 거래량비율                      StartPos 95, Length 6
        public long jnilvalue; // [long  ,   12] 전일거래대금                    StartPos 102, Length 12
        public long value; // [long  ,   12] 당일거래대금                    StartPos 115, Length 12
        public long valuechange; // [long  ,   12] 거래대금전일대비                StartPos 128, Length 12
        public float valuerate; // [float ,  6.2] 거래대금비율                    StartPos 141, Length 6
        public float openjisu; // [float ,  7.2] 시가지수                        StartPos 148, Length 7
        public float opendiff; // [float ,  6.2] 시가등락율                      StartPos 156, Length 6
        public string opentime; // [string,    6] 시가시간                        StartPos 163, Length 6
        public float highjisu; // [float ,  7.2] 고가지수                        StartPos 170, Length 7
        public float highdiff; // [float ,  6.2] 고가등락율                      StartPos 178, Length 6
        public string hightime; // [string,    6] 고가시간                        StartPos 185, Length 6
        public float lowjisu; // [float ,  7.2] 저가지수                        StartPos 192, Length 7
        public float lowdiff; // [float ,  6.2] 저가등락율                      StartPos 200, Length 6
        public string lowtime; // [string,    6] 저가시간                        StartPos 207, Length 6
        public float whjisu; // [float ,  7.2] 52주최고지수                    StartPos 214, Length 7
        public float whchange; // [float ,  7.2] 52주최고현재가대비              StartPos 222, Length 7
        public string whjday; // [string,    8] 52주최고지수일자                StartPos 230, Length 8
        public float wljisu; // [float ,  7.2] 52주최저지수                    StartPos 239, Length 7
        public float wlchange; // [float ,  7.2] 52주최저현재가대비              StartPos 247, Length 7
        public string wljday; // [string,    8] 52주최저지수일자                StartPos 255, Length 8
        public float yhjisu; // [float ,  7.2] 연중최고지수                    StartPos 264, Length 7
        public float yhchange; // [float ,  7.2] 연중최고현재가대비              StartPos 272, Length 7
        public string yhjday; // [string,    8] 연중최고지수일자                StartPos 280, Length 8
        public float yljisu; // [float ,  7.2] 연중최저지수                    StartPos 289, Length 7
        public float ylchange; // [float ,  7.2] 연중최저현재가대비              StartPos 297, Length 7
        public string yljday; // [string,    8] 연중최저지수일자                StartPos 305, Length 8
        public string firstjcode; // [string,    3] 첫번째지수코드                  StartPos 314, Length 3
        public string firstjname; // [string,   20] 첫번째지수명                    StartPos 318, Length 20
        public float firstjisu; // [float ,  7.2] 첫번째지수                      StartPos 339, Length 7
        public string firsign; // [string,    1] 첫번째대비구분                  StartPos 347, Length 1
        public float firchange; // [float ,  7.2] 첫번째전일대비                  StartPos 349, Length 7
        public float firdiff; // [float ,  6.2] 첫번째등락율                    StartPos 357, Length 6
        public string secondjcode; // [string,    3] 두번째지수코드                  StartPos 364, Length 3
        public string secondjname; // [string,   20] 두번째지수명                    StartPos 368, Length 20
        public float secondjisu; // [float ,  7.2] 두번째지수                      StartPos 389, Length 7
        public string secsign; // [string,    1] 두번째대비구분                  StartPos 397, Length 1
        public float secchange; // [float ,  7.2] 두번째전일대비                  StartPos 399, Length 7
        public float secdiff; // [float ,  6.2] 두번째등락율                    StartPos 407, Length 6
        public string thirdjcode; // [string,    3] 세번째지수코드                  StartPos 414, Length 3
        public string thirdjname; // [string,   20] 세번째지수명                    StartPos 418, Length 20
        public float thirdjisu; // [float ,  7.2] 세번째지수                      StartPos 439, Length 7
        public string thrsign; // [string,    1] 세번째대비구분                  StartPos 447, Length 1
        public float thrchange; // [float ,  7.2] 세번째전일대비                  StartPos 449, Length 7
        public float thrdiff; // [float ,  6.2] 세번째등락율                    StartPos 457, Length 6
        public string fourthjcode; // [string,    3] 네번째지수코드                  StartPos 464, Length 3
        public string fourthjname; // [string,   20] 네번째지수명                    StartPos 468, Length 20
        public float fourthjisu; // [float ,  7.2] 네번째지수                      StartPos 489, Length 7
        public string forsign; // [string,    1] 네번째대비구분                  StartPos 497, Length 1
        public float forchange; // [float ,  7.2] 네번째전일대비                  StartPos 499, Length 7
        public float fordiff; // [float ,  6.2] 네번째등락율                    StartPos 507, Length 6
        public long highjo; // [long  ,    4] 상승종목수                      StartPos 514, Length 4
        public long upjo; // [long  ,    4] 상한종목수                      StartPos 519, Length 4
        public long unchgjo; // [long  ,    4] 보합종목수                      StartPos 524, Length 4
        public long lowjo; // [long  ,    4] 하락종목수                      StartPos 529, Length 4
        public long downjo; // [long  ,    4] 하한종목수                      StartPos 534, Length 4
    }
}