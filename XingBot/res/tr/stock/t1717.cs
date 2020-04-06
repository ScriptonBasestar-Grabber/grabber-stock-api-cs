namespace XingBot.res
{
    // 외인기관별종목별동항 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1717InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string gubun; // [string,    1] 구분(0:일간순매수1:기간누적순매 StartPos 7, Length 1
        public string fromdt; // [string,    8] 시작일자(일간조회일경우는space) StartPos 9, Length 8
        public string todt; // [string,    8] 종료일자                        StartPos 18, Length 8
    }

    public struct _t1717OutBlock
    {
        public string date; // [string,    8] 일자                            StartPos 0, Length 8
        public long close; // [long  ,    8] 종가                            StartPos 9, Length 8
        public string sign; // [string,    1] 전일대비구분                    StartPos 18, Length 1
        public long change; // [long  ,    8] 전일대비                        StartPos 20, Length 8
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 29, Length 6
        public long volume; // [long  ,   12] 누적거래량                      StartPos 36, Length 12
        public long tjj0000_vol; // [long  ,   12] 사모펀드(순매수량)              StartPos 49, Length 12
        public long tjj0001_vol; // [long  ,   12] 증권(순매수량)                  StartPos 62, Length 12
        public long tjj0002_vol; // [long  ,   12] 보험(순매수량)                  StartPos 75, Length 12
        public long tjj0003_vol; // [long  ,   12] 투신(순매수량)                  StartPos 88, Length 12
        public long tjj0004_vol; // [long  ,   12] 은행(순매수량)                  StartPos 101, Length 12
        public long tjj0005_vol; // [long  ,   12] 종금(순매수량)                  StartPos 114, Length 12
        public long tjj0006_vol; // [long  ,   12] 기금(순매수량)                  StartPos 127, Length 12
        public long tjj0007_vol; // [long  ,   12] 기타법인(순매수량)              StartPos 140, Length 12
        public long tjj0008_vol; // [long  ,   12] 개인(순매수량)                  StartPos 153, Length 12
        public long tjj0009_vol; // [long  ,   12] 등록외국인(순매수량)            StartPos 166, Length 12
        public long tjj0010_vol; // [long  ,   12] 미등록외국인(순매수량)          StartPos 179, Length 12
        public long tjj0011_vol; // [long  ,   12] 국가외(순매수량)                StartPos 192, Length 12
        public long tjj0018_vol; // [long  ,   12] 기관(순매수량)                  StartPos 205, Length 12
        public long tjj0016_vol; // [long  ,   12] 외인계(순매수량)(등록+미등록)   StartPos 218, Length 12
        public long tjj0017_vol; // [long  ,   12] 기타계(순매수량)(기타+국가)     StartPos 231, Length 12
        public long tjj0000_dan; // [long  ,   12] 사모펀드(단가)                  StartPos 244, Length 12
        public long tjj0001_dan; // [long  ,   12] 증권(단가)                      StartPos 257, Length 12
        public long tjj0002_dan; // [long  ,   12] 보험(단가)                      StartPos 270, Length 12
        public long tjj0003_dan; // [long  ,   12] 투신(단가)                      StartPos 283, Length 12
        public long tjj0004_dan; // [long  ,   12] 은행(단가)                      StartPos 296, Length 12
        public long tjj0005_dan; // [long  ,   12] 종금(단가)                      StartPos 309, Length 12
        public long tjj0006_dan; // [long  ,   12] 기금(단가)                      StartPos 322, Length 12
        public long tjj0007_dan; // [long  ,   12] 기타법인(단가)                  StartPos 335, Length 12
        public long tjj0008_dan; // [long  ,   12] 개인(단가)                      StartPos 348, Length 12
        public long tjj0009_dan; // [long  ,   12] 등록외국인(단가)                StartPos 361, Length 12
        public long tjj0010_dan; // [long  ,   12] 미등록외국인(단가)              StartPos 374, Length 12
        public long tjj0011_dan; // [long  ,   12] 국가외(단가)                    StartPos 387, Length 12
        public long tjj0018_dan; // [long  ,   12] 기관(단가)                      StartPos 400, Length 12
        public long tjj0016_dan; // [long  ,   12] 외인계(단가)(등록+미등록)       StartPos 413, Length 12
        public long tjj0017_dan; // [long  ,   12] 기타계(단가)(기타+국가)         StartPos 426, Length 12
    }
}