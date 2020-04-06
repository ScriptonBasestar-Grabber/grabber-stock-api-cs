namespace XingBot.real.res
{
    // ELW 종목비교 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1958InBlock
    {
        public string shcode1; // [string,    6] 종목코드1                       StartPos 0, Length 6
        public string shcode2; // [string,    6] 종목코드2                       StartPos 7, Length 6
    }

    public struct _t1958OutBlock
    {
        public string hname; // [string,   40] 종목명                          StartPos 0, Length 40
        public string item1; // [string,   12] 기초자산                        StartPos 41, Length 12
        public string issuernmk; // [string,   40] 발행사                          StartPos 54, Length 40
        public string elwopt; // [string,    2] 콜풋구분                        StartPos 95, Length 2
        public string elwtype; // [string,    2] 행사방식                        StartPos 98, Length 2
        public string settletype; // [string,    2] 결제방법                        StartPos 101, Length 2
        public decimal elwexec; // [float ,  8.2] 행사가                          StartPos 104, Length 8
        public decimal convrate; // [float , 12.4] 전환비율                        StartPos 113, Length 12
        public decimal listing; // [float ,   12] 발행수량                        StartPos 126, Length 12
        public string mmsdate; // [string,    8] 행사개시일                      StartPos 139, Length 8
        public string lastdate; // [string,    8] 최종거래일                      StartPos 148, Length 8
        public long nofdays; // [long  ,    4] 거래잔존일수                    StartPos 157, Length 4
        public string payday; // [string,    8] 지급일                          StartPos 162, Length 8
        public decimal parity; // [float ,  6.2] 패리티                          StartPos 171, Length 6
        public decimal premium; // [float ,  6.2] 프리미엄                        StartPos 178, Length 6
        public decimal berate; // [float ,  6.2] 손익분기                        StartPos 185, Length 6
        public decimal capt; // [float ,  6.2] 자본지지                        StartPos 192, Length 6
        public decimal gearing; // [float ,  6.2] 기어링                          StartPos 199, Length 6
        public decimal egearing; // [float ,  6.2] e.기어링                        StartPos 206, Length 6
        public long price; // [long  ,    8] 가격                            StartPos 213, Length 8
        public decimal volume; // [float ,   12] 거래량                          StartPos 222, Length 12
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 235, Length 6
    }

    public struct _t1958OutBlock1
    {
        public string hname; // [string,   40] 종목명                          StartPos 0, Length 40
        public string item1; // [string,   12] 기초자산                        StartPos 41, Length 12
        public string issuernmk; // [string,   40] 발행사                          StartPos 54, Length 40
        public string elwopt; // [string,    2] 콜풋구분                        StartPos 95, Length 2
        public string elwtype; // [string,    2] 행사방식                        StartPos 98, Length 2
        public string settletype; // [string,    2] 결제방법                        StartPos 101, Length 2
        public decimal elwexec; // [float ,  8.2] 행사가                          StartPos 104, Length 8
        public decimal convrate; // [float , 12.4] 전환비율                        StartPos 113, Length 12
        public decimal listing; // [float ,   12] 발행수량                        StartPos 126, Length 12
        public string mmsdate; // [string,    8] 행사개시일                      StartPos 139, Length 8
        public string lastdate; // [string,    8] 최종거래일                      StartPos 148, Length 8
        public long nofdays; // [long  ,    4] 거래잔존일수                    StartPos 157, Length 4
        public string payday; // [string,    8] 지급일                          StartPos 162, Length 8
        public decimal parity; // [float ,  6.2] 패리티                          StartPos 171, Length 6
        public decimal premium; // [float ,  6.2] 프리미엄                        StartPos 178, Length 6
        public decimal berate; // [float ,  6.2] 손익분기                        StartPos 185, Length 6
        public decimal capt; // [float ,  6.2] 자본지지                        StartPos 192, Length 6
        public decimal gearing; // [float ,  6.2] 기어링                          StartPos 199, Length 6
        public decimal egearing; // [float ,  6.2] e.기어링                        StartPos 206, Length 6
        public long price; // [long  ,    8] 가격                            StartPos 213, Length 8
        public decimal volume; // [float ,   12] 거래량                          StartPos 222, Length 12
        public decimal diff; // [float ,  6.2] 등락율                          StartPos 235, Length 6
    }

    public struct _t1958OutBlock2
    {
        public string hnamecmp; // [string,    6] 종목명비교                      StartPos 0, Length 6
        public string item1cmp; // [string,    6] 기초자산비교                    StartPos 7, Length 6
        public string issuernmkcmp; // [string,    6] 발행사비교                      StartPos 14, Length 6
        public string elwoptcmp; // [string,    6] 콜풋구분비교                    StartPos 21, Length 6
        public string elwtypecmp; // [string,    6] 행사방식비교                    StartPos 28, Length 6
        public string settlecmp; // [string,    6] 결제방법비교                    StartPos 35, Length 6
        public decimal elwexeccmp; // [float ,  8.2] 행사가비교                      StartPos 42, Length 8
        public decimal convcmp; // [float , 12.4] 전환비율비교                    StartPos 51, Length 12
        public decimal listingcmp; // [float ,   12] 발행수량비교                    StartPos 64, Length 12
        public string mmsdatecmp; // [string,    6] 행사개시일비교                  StartPos 77, Length 6
        public string lastdatecmp; // [string,    6] 최종거래일비교                  StartPos 84, Length 6
        public string nofdayscmp; // [string,    6] 거래잔존일수비교                StartPos 91, Length 6
        public string paydaycmp; // [string,    6] 지급일비교                      StartPos 98, Length 6
        public decimal paritycmp; // [float ,  6.2] 패리티비교                      StartPos 105, Length 6
        public decimal premiumcmp; // [float ,  6.2] 프리미엄비교                    StartPos 112, Length 6
        public decimal beratecmp; // [float ,  6.2] 손익분기비교                    StartPos 119, Length 6
        public decimal captcmp; // [float ,  6.2] 자본지지비교                    StartPos 126, Length 6
        public decimal gearingcmp; // [float ,  6.2] 기어링비교                      StartPos 133, Length 6
        public decimal egearingcmp; // [float ,  6.2] e.기어링비교                    StartPos 140, Length 6
        public long pricecmp; // [long  ,    8] 가격비교                        StartPos 147, Length 8
        public decimal volumecmp; // [float ,   12] 거래량비교                      StartPos 156, Length 12
        public decimal diffcmp; // [float ,  6.2] 등락율비교                      StartPos 169, Length 6
    }
}