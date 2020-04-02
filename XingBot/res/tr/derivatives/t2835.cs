using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // EUREX 야간옵션 시세전광판 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t2835InBlock
    {
        public string yyyymm; // [string,    6] 월물                            StartPos 0, Length 6
    }

    struct _t2835OutBlock
    {
        public float gmprice; // [float ,  6.2] 근월물현재가                    StartPos 0, Length 6
        public string gmsign; // [string,    1] 근월물전일대비구분              StartPos 7, Length 1
        public float gmchange; // [float ,  6.2] 근월물전일대비                  StartPos 9, Length 6
        public float gmdiff; // [float ,  6.2] 근월물등락율                    StartPos 16, Length 6
        public long gmvolume; // [long  ,   12] 근월물거래량                    StartPos 23, Length 12
        public string gmshcode; // [string,    8] 근월물선물코드                  StartPos 36, Length 8
    }

    struct _t2835OutBlock1
    {
        public float actprice; // [float ,  6.2] 행사가                          StartPos 0, Length 6
        public string optcode; // [string,    8] 콜옵션코드                      StartPos 7, Length 8
        public float price; // [float ,  6.2] 현재가                          StartPos 16, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 23, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 25, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 32, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 39, Length 12
        public float offerho1; // [float ,  6.2] 매도호가                        StartPos 52, Length 6
        public float bidho1; // [float ,  6.2] 매수호가                        StartPos 59, Length 6
        public long cvolume; // [long  ,   12] 체결량                          StartPos 66, Length 12
        public float impv; // [float ,  6.2] 내재가치                        StartPos 79, Length 6
        public float timevl; // [float ,  6.2] 시간가치                        StartPos 86, Length 6
        public long offerrem1; // [long  ,   12] 매도잔량                        StartPos 93, Length 12
        public long bidrem1; // [long  ,   12] 매수잔량                        StartPos 106, Length 12
        public float open; // [float ,  6.2] 시가                            StartPos 119, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 126, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 133, Length 6
        public string atmgubun; // [string,    1] ATM구분                         StartPos 140, Length 1
        public float jisuconv; // [float ,  6.2] 지수환산                        StartPos 142, Length 6
    }

    struct _t2835OutBlock2
    {
        public float actprice; // [float ,  6.2] 행사가                          StartPos 0, Length 6
        public string optcode; // [string,    8] 풋옵션코드                      StartPos 7, Length 8
        public float price; // [float ,  6.2] 현재가                          StartPos 16, Length 6
        public string sign; // [string,    1] 전일대비구분                    StartPos 23, Length 1
        public float change; // [float ,  6.2] 전일대비                        StartPos 25, Length 6
        public float diff; // [float ,  6.2] 등락율                          StartPos 32, Length 6
        public long volume; // [long  ,   12] 거래량                          StartPos 39, Length 12
        public float offerho1; // [float ,  6.2] 매도호가                        StartPos 52, Length 6
        public float bidho1; // [float ,  6.2] 매수호가                        StartPos 59, Length 6
        public long cvolume; // [long  ,   12] 체결량                          StartPos 66, Length 12
        public float impv; // [float ,  6.2] 내재가치                        StartPos 79, Length 6
        public float timevl; // [float ,  6.2] 시간가치                        StartPos 86, Length 6
        public long offerrem1; // [long  ,   12] 매도잔량                        StartPos 93, Length 12
        public long bidrem1; // [long  ,   12] 매수잔량                        StartPos 106, Length 12
        public float open; // [float ,  6.2] 시가                            StartPos 119, Length 6
        public float high; // [float ,  6.2] 고가                            StartPos 126, Length 6
        public float low; // [float ,  6.2] 저가                            StartPos 133, Length 6
        public string atmgubun; // [string,    1] ATM구분                         StartPos 140, Length 1
        public float jisuconv; // [float ,  6.2] 지수환산                        StartPos 142, Length 6
    }
}