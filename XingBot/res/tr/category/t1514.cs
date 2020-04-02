using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.info
{

    // 업종기간별추이 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1514InBlock
    {
public string upcode; // [string,    3] 업종코드                        StartPos 0, Length 3
public string gubun1; // [string,    1] 구분1                           StartPos 4, Length 1
public string gubun2; // [string,    1] 구분2                           StartPos 6, Length 1
public string cts_date; // [string,    8] CTS_일자                        StartPos 8, Length 8
public string cnt; // [string,    4] 조회건수                        StartPos 17, Length 4
public string rate_gbn; // [string,    1] 비중구분                        StartPos 22, Length 1
    }
    struct _t1514OutBlock
    {
public string cts_date; // [string,    8] CTS_일자                        StartPos 0, Length 8
    }
    struct _t1514OutBlock1
    {
public string date; // [string,    8] 일자                            StartPos 0, Length 8
public float jisu; // [float , 12.2] 지수                            StartPos 9, Length 12
public string sign; // [string,    1] 전일대비구분                    StartPos 22, Length 1
public float change; // [float ,  7.2] 전일대비                        StartPos 24, Length 7
public float diff; // [float ,  6.2] 등락율                          StartPos 32, Length 6
public long volume; // [long  ,   12] 거래량                          StartPos 39, Length 12
public float diff_vol; // [float , 12.2] 거래증가율                      StartPos 52, Length 12
public long value1; // [long  ,   12] 거래대금1                       StartPos 65, Length 12
public long high; // [long  ,    4] 상승                            StartPos 78, Length 4
public long unchg; // [long  ,    4] 보합                            StartPos 83, Length 4
public long low; // [long  ,    4] 하락                            StartPos 88, Length 4
public float uprate; // [float ,  6.2] 상승종목비율                    StartPos 93, Length 6
public long frgsvolume; // [long  ,    8] 외인순매수                      StartPos 100, Length 8
public float openjisu; // [float , 12.2] 시가                            StartPos 109, Length 12
public float highjisu; // [float , 12.2] 고가                            StartPos 122, Length 12
public float lowjisu; // [float , 12.2] 저가                            StartPos 135, Length 12
public long value2; // [long  ,   12] 거래대금2                       StartPos 148, Length 12
public long up; // [long  ,    4] 상한                            StartPos 161, Length 4
public long down; // [long  ,    4] 하한                            StartPos 166, Length 4
public long totjo; // [long  ,    4] 종목수                          StartPos 171, Length 4
public long orgsvolume; // [long  ,    8] 기관순매수                      StartPos 176, Length 8
public string upcode; // [string,    3] 업종코드                        StartPos 185, Length 3
public float rate; // [float ,  7.2] 거래비중                        StartPos 189, Length 7
public float divrate; // [float ,  7.2] 업종배당수익률                  StartPos 197, Length 7
    }

}

