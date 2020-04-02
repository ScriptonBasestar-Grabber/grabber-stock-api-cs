using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.elw
{
    // ELW 지표검색 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1955InBlock
    {
        public string chkitem; // [string,    1] 기초자산chk구분                 StartPos 0, Length 1
        public string cbitem; // [string,   12] 기초자산코드                    StartPos 2, Length 12
        public string chkissuer; // [string,    1] 발행사chk구분                   StartPos 15, Length 1
        public string cbissuer; // [string,   12] 발행사                          StartPos 17, Length 12
        public string chkcallput; // [string,    1] 권리chk구분                     StartPos 30, Length 1
        public string cbcallput; // [string,    2] 권리(call:01.put:02)            StartPos 32, Length 2
        public string chkexec; // [string,    1] 행사가chk구분                   StartPos 35, Length 1
        public string cbexec; // [string,    1] 행사가(>=:1.<=:2)               StartPos 37, Length 1
        public string chktype; // [string,    1] 행사방식chk구분                 StartPos 39, Length 1
        public string cbtype; // [string,    2] 행사방식                        StartPos 41, Length 2
        public string chksettle; // [string,    1] 결제방법chk구분                 StartPos 44, Length 1
        public string cbsettle; // [string,    2] 결제방법                        StartPos 46, Length 2
        public string chklast; // [string,    1] 만기chk구분                     StartPos 49, Length 1
        public string cblast; // [string,    6] 만기월별                        StartPos 51, Length 6
        public string chkelwexec; // [string,    1] 행사가격chk구분                 StartPos 58, Length 1
        public float elwexecs; // [float , 10.2] 행사가이상                      StartPos 60, Length 10
        public float elwexece; // [float , 10.2] 행사가이하                      StartPos 71, Length 10
        public string chkvolume; // [string,    1] 거래량chk구분                   StartPos 82, Length 1
        public float volumes; // [float ,   12] 거래량이상                      StartPos 84, Length 12
        public float volumee; // [float ,   12] 거래량이하                      StartPos 97, Length 12
        public string chkrate; // [string,    1] 등락율chk구분                   StartPos 110, Length 1
        public float rates; // [float ,  6.2] 등락율이상                      StartPos 112, Length 6
        public float ratee; // [float ,  6.2] 등락율이하                      StartPos 119, Length 6
        public string chkpremium; // [string,    1] 프리미엄chk구분                 StartPos 126, Length 1
        public float premiums; // [float ,  6.2] 프리미엄이상                    StartPos 128, Length 6
        public float premiume; // [float ,  6.2] 프리미엄이하                    StartPos 135, Length 6
        public string chkparity; // [string,    1] 패리티chk구분                   StartPos 142, Length 1
        public float paritys; // [float ,  6.2] 패리티이상                      StartPos 144, Length 6
        public float paritye; // [float ,  6.2] 패리티이하                      StartPos 151, Length 6
        public string chkberate; // [string,    1] 손익분기chk구분                 StartPos 158, Length 1
        public float berates; // [float ,  6.2] 손익분기이상                    StartPos 160, Length 6
        public float beratee; // [float ,  6.2] 손익분기이하                    StartPos 167, Length 6
        public string chkcapt; // [string,    1] 자본지지chk구분                 StartPos 174, Length 1
        public float capts; // [float ,  6.2] 자본지지이상                    StartPos 176, Length 6
        public float capte; // [float ,  6.2] 자본지지이하                    StartPos 183, Length 6
        public string chkegearing; // [string,    1] e.기어링chk구분                 StartPos 190, Length 1
        public float egearings; // [float ,  6.2] e.기어링이상                    StartPos 192, Length 6
        public float egearinge; // [float ,  6.2] e.기어링이하                    StartPos 199, Length 6
        public string chkgearing; // [string,    1] 기어링chk구분                   StartPos 206, Length 1
        public float gearings; // [float ,  6.2] 기어링이상                      StartPos 208, Length 6
        public float gearinge; // [float ,  6.2] 기어링이하                      StartPos 215, Length 6
        public string chkdelta; // [string,    1] 델타chk구분                     StartPos 222, Length 1
        public float deltas; // [float , 10.6] 델타이상                        StartPos 224, Length 10
        public float deltae; // [float , 10.6] 델타이하                        StartPos 235, Length 10
        public string chktheta; // [string,    1] 쎄타chk구분                     StartPos 246, Length 1
        public float thetas; // [float , 10.6] 쎄타이상                        StartPos 248, Length 10
        public float thetae; // [float , 10.6] 쎄타이하                        StartPos 259, Length 10
        public string chkduedate; // [string,    1] 최종거래일chk구분               StartPos 270, Length 1
        public string duedates; // [string,    8] 최종거래일이상                  StartPos 272, Length 8
        public string duedatee; // [string,    8] 최종거래일이하                  StartPos 281, Length 8
        public string chkkoba; // [string,    1] 조기종료chk구분                 StartPos 290, Length 1
        public string cbkoba; // [string,    1] 조기종료(0:전체1:조기종료만2:조 StartPos 292, Length 1
    }

    struct _t1955OutBlock
    {
        public long cnt; // [long  ,    4] 종목갯수                        StartPos 0, Length 4
    }

    struct _t1955OutBlock1
    {
        public string hname; // [string,   40] 종목명                          StartPos 0, Length 40
        public string shcode; // [string,    6] 종목코드                        StartPos 41, Length 6
        public string issuernmk; // [string,   40] 발행사                          StartPos 48, Length 40
        public string itemcode; // [string,   12] 기초자산코드                    StartPos 89, Length 12
        public string cpgubun; // [string,    2] 콜/풋구분                       StartPos 102, Length 2
        public long price; // [long  ,    8] 현재가                          StartPos 105, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 114, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 116, Length 8
        public float diff; // [float ,  6.2] 등락율                          StartPos 125, Length 6
        public float volume; // [float ,   12] 거래량                          StartPos 132, Length 12
        public float jnilvolume; // [float ,   12] 전일거래량                      StartPos 145, Length 12
        public float elwexec; // [float , 10.2] 행사가                          StartPos 158, Length 10
        public string item; // [string,   20] 기초자산명                      StartPos 169, Length 20
        public float bprice; // [float , 10.2] 기초자산가                      StartPos 190, Length 10
        public string bsign; // [string,    1] 기초전일대비구분                StartPos 201, Length 1
        public float bchange; // [float , 10.2] 기초전일대비                    StartPos 203, Length 10
        public float bdiff; // [float ,  6.2] 기초등락율                      StartPos 214, Length 6
        public float premium; // [float ,  6.2] 프리미엄                        StartPos 221, Length 6
        public float parity; // [float ,  6.2] 패리티                          StartPos 228, Length 6
        public float berate; // [float ,  6.2] 손익분기                        StartPos 235, Length 6
        public float capt; // [float ,  6.2] 자본지지                        StartPos 242, Length 6
        public float egearing; // [float ,  6.2] e.기어링                        StartPos 249, Length 6
        public float gearing; // [float ,  6.2] 기어링                          StartPos 256, Length 6
        public string lastdate; // [string,    8] 최종거래일                      StartPos 263, Length 8
        public float delta; // [float , 10.6] 델타                            StartPos 272, Length 10
        public float theta; // [float , 10.6] 쎄타                            StartPos 283, Length 10
    }
}