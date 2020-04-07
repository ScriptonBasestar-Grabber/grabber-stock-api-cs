namespace XingBot.res
{
    // ELW 전광판 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1964InBlock
    {
        public string item{ get; set; } // [string,   12] 기초자산코드                    StartPos 0, Length 12
        public string issuercd{ get; set; } // [string,   12] 발행사                          StartPos 13, Length 12
        public string lastmonth{ get; set; } // [string,    6] 만기월물                        StartPos 26, Length 6
        public string elwopt{ get; set; } // [string,    1] 콜풋구분                        StartPos 33, Length 1
        public string atmgubun{ get; set; } // [string,    1] 머니구분                        StartPos 35, Length 1
        public string elwtype{ get; set; } // [string,    2] 권리행사방식                    StartPos 37, Length 2
        public string settletype{ get; set; } // [string,    2] 결제방법                        StartPos 40, Length 2
        public string elwexecgubun{ get; set; } // [string,    1] 행사기초자산구분                StartPos 43, Length 1
        public string fromrat{ get; set; } // [string,    5] 시작비율                        StartPos 45, Length 5
        public string torat{ get; set; } // [string,    5] 종료비율                        StartPos 51, Length 5
        public string volume{ get; set; } // [string,   12] 거래량                          StartPos 57, Length 12
    }

    public struct _t1964OutBlock1
    {
        public string shcode{ get; set; } // [string,    6] ELW코드                         StartPos 0, Length 6
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 7, Length 40
        public string item1{ get; set; } // [string,    6] 기초자산코드                    StartPos 48, Length 6
        public string itemnm{ get; set; } // [string,   20] 기초자산명                      StartPos 55, Length 20
        public string issuernmk{ get; set; } // [string,   40] 발행사                          StartPos 76, Length 40
        public string elwopt{ get; set; } // [string,    4] 콜풋구분                        StartPos 117, Length 4
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 122, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 131, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 133, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 142, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 149, Length 12
        public decimal elwexec{ get; set; } // [float , 10.2] 행사가                          StartPos 162, Length 10
        public long jandatecnt{ get; set; } // [long  ,    8] 잔존일수                        StartPos 173, Length 8
        public decimal convrate{ get; set; } // [float ,  8.4] 전환비율                        StartPos 182, Length 8
        public string lastdate{ get; set; } // [string,    8] 최종거래일                      StartPos 191, Length 8
        public string mmsdate{ get; set; } // [string,    8] 행사개시일                      StartPos 200, Length 8
        public string payday{ get; set; } // [string,    8] 지급일                          StartPos 209, Length 8
        public long listing{ get; set; } // [long  ,    8] 발행수량                        StartPos 218, Length 8
        public string atmgbnm{ get; set; } // [string,   10] 머니구분                        StartPos 227, Length 10
        public decimal parity{ get; set; } // [float ,  6.2] 패리티                          StartPos 238, Length 6
        public decimal preminum{ get; set; } // [float , 10.2] 프리미엄                        StartPos 245, Length 10
        public decimal spread{ get; set; } // [float ,  3.2] 스프래드                        StartPos 256, Length 3
        public decimal berate{ get; set; } // [float ,  6.2] 손익분기율                      StartPos 260, Length 6
        public decimal capt{ get; set; } // [float ,  6.2] 자본지지율                      StartPos 267, Length 6
        public decimal gearing{ get; set; } // [float ,  6.2] 기어링                          StartPos 274, Length 6
        public decimal egearing{ get; set; } // [float ,  6.2] e기어링                         StartPos 281, Length 6
        public long itemprice{ get; set; } // [long  ,    8] 기초자산현재가                  StartPos 288, Length 8
        public string itemsign{ get; set; } // [string,    1] 기초자산전일대비구분            StartPos 297, Length 1
        public long itemchange{ get; set; } // [long  ,    8] 기초자산전일대비                StartPos 299, Length 8
        public decimal itemdiff{ get; set; } // [float ,  6.2] 기초자산등락율                  StartPos 308, Length 6
        public long itemvolume{ get; set; } // [long  ,   12] 기초자산거래량                  StartPos 315, Length 12
        public long jnilvolume{ get; set; } // [long  ,   12] 전일거래량                      StartPos 328, Length 12
        public decimal theoryprice{ get; set; } // [float , 10.2] 이론가                          StartPos 341, Length 10
        public decimal lp_rate{ get; set; } // [float ,  5.2] LP보유비율                      StartPos 352, Length 5
        public decimal impv{ get; set; } // [float ,  6.2] 내재변동성                      StartPos 358, Length 6
        public decimal delta{ get; set; } // [float , 10.6] 델타                            StartPos 365, Length 10
        public decimal theta{ get; set; } // [float , 10.6] 쎄타                            StartPos 376, Length 10
    }
}