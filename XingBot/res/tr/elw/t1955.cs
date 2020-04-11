namespace XingBot.res
{
    // ELW 지표검색 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t1955InBlock
    {
        public string chkitem{ get; set; } // [string,    1] 기초자산chk구분                 StartPos 0, Length 1
        public string cbitem{ get; set; } // [string,   12] 기초자산코드                    StartPos 2, Length 12
        public string chkissuer{ get; set; } // [string,    1] 발행사chk구분                   StartPos 15, Length 1
        public string cbissuer{ get; set; } // [string,   12] 발행사                          StartPos 17, Length 12
        public string chkcallput{ get; set; } // [string,    1] 권리chk구분                     StartPos 30, Length 1
        public string cbcallput{ get; set; } // [string,    2] 권리(call:01.put:02)            StartPos 32, Length 2
        public string chkexec{ get; set; } // [string,    1] 행사가chk구분                   StartPos 35, Length 1
        public string cbexec{ get; set; } // [string,    1] 행사가(>=:1.<=:2)               StartPos 37, Length 1
        public string chktype{ get; set; } // [string,    1] 행사방식chk구분                 StartPos 39, Length 1
        public string cbtype{ get; set; } // [string,    2] 행사방식                        StartPos 41, Length 2
        public string chksettle{ get; set; } // [string,    1] 결제방법chk구분                 StartPos 44, Length 1
        public string cbsettle{ get; set; } // [string,    2] 결제방법                        StartPos 46, Length 2
        public string chklast{ get; set; } // [string,    1] 만기chk구분                     StartPos 49, Length 1
        public string cblast{ get; set; } // [string,    6] 만기월별                        StartPos 51, Length 6
        public string chkelwexec{ get; set; } // [string,    1] 행사가격chk구분                 StartPos 58, Length 1
        public decimal elwexecs{ get; set; } // [float , 10.2] 행사가이상                      StartPos 60, Length 10
        public decimal elwexece{ get; set; } // [float , 10.2] 행사가이하                      StartPos 71, Length 10
        public string chkvolume{ get; set; } // [string,    1] 거래량chk구분                   StartPos 82, Length 1
        public decimal volumes{ get; set; } // [float ,   12] 거래량이상                      StartPos 84, Length 12
        public decimal volumee{ get; set; } // [float ,   12] 거래량이하                      StartPos 97, Length 12
        public string chkrate{ get; set; } // [string,    1] 등락율chk구분                   StartPos 110, Length 1
        public decimal rates{ get; set; } // [float ,  6.2] 등락율이상                      StartPos 112, Length 6
        public decimal ratee{ get; set; } // [float ,  6.2] 등락율이하                      StartPos 119, Length 6
        public string chkpremium{ get; set; } // [string,    1] 프리미엄chk구분                 StartPos 126, Length 1
        public decimal premiums{ get; set; } // [float ,  6.2] 프리미엄이상                    StartPos 128, Length 6
        public decimal premiume{ get; set; } // [float ,  6.2] 프리미엄이하                    StartPos 135, Length 6
        public string chkparity{ get; set; } // [string,    1] 패리티chk구분                   StartPos 142, Length 1
        public decimal paritys{ get; set; } // [float ,  6.2] 패리티이상                      StartPos 144, Length 6
        public decimal paritye{ get; set; } // [float ,  6.2] 패리티이하                      StartPos 151, Length 6
        public string chkberate{ get; set; } // [string,    1] 손익분기chk구분                 StartPos 158, Length 1
        public decimal berates{ get; set; } // [float ,  6.2] 손익분기이상                    StartPos 160, Length 6
        public decimal beratee{ get; set; } // [float ,  6.2] 손익분기이하                    StartPos 167, Length 6
        public string chkcapt{ get; set; } // [string,    1] 자본지지chk구분                 StartPos 174, Length 1
        public decimal capts{ get; set; } // [float ,  6.2] 자본지지이상                    StartPos 176, Length 6
        public decimal capte{ get; set; } // [float ,  6.2] 자본지지이하                    StartPos 183, Length 6
        public string chkegearing{ get; set; } // [string,    1] e.기어링chk구분                 StartPos 190, Length 1
        public decimal egearings{ get; set; } // [float ,  6.2] e.기어링이상                    StartPos 192, Length 6
        public decimal egearinge{ get; set; } // [float ,  6.2] e.기어링이하                    StartPos 199, Length 6
        public string chkgearing{ get; set; } // [string,    1] 기어링chk구분                   StartPos 206, Length 1
        public decimal gearings{ get; set; } // [float ,  6.2] 기어링이상                      StartPos 208, Length 6
        public decimal gearinge{ get; set; } // [float ,  6.2] 기어링이하                      StartPos 215, Length 6
        public string chkdelta{ get; set; } // [string,    1] 델타chk구분                     StartPos 222, Length 1
        public decimal deltas{ get; set; } // [float , 10.6] 델타이상                        StartPos 224, Length 10
        public decimal deltae{ get; set; } // [float , 10.6] 델타이하                        StartPos 235, Length 10
        public string chktheta{ get; set; } // [string,    1] 쎄타chk구분                     StartPos 246, Length 1
        public decimal thetas{ get; set; } // [float , 10.6] 쎄타이상                        StartPos 248, Length 10
        public decimal thetae{ get; set; } // [float , 10.6] 쎄타이하                        StartPos 259, Length 10
        public string chkduedate{ get; set; } // [string,    1] 최종거래일chk구분               StartPos 270, Length 1
        public string duedates{ get; set; } // [string,    8] 최종거래일이상                  StartPos 272, Length 8
        public string duedatee{ get; set; } // [string,    8] 최종거래일이하                  StartPos 281, Length 8
        public string chkkoba{ get; set; } // [string,    1] 조기종료chk구분                 StartPos 290, Length 1
        public string cbkoba{ get; set; } // [string,    1] 조기종료(0:전체1:조기종료만2:조 StartPos 292, Length 1
    }

    public class _t1955OutBlock
    {
        public long cnt{ get; set; } // [long  ,    4] 종목갯수                        StartPos 0, Length 4
    }

    public class _t1955OutBlock1
    {
        public string hname{ get; set; } // [string,   40] 종목명                          StartPos 0, Length 40
        public string shcode{ get; set; } // [string,    6] 종목코드                        StartPos 41, Length 6
        public string issuernmk{ get; set; } // [string,   40] 발행사                          StartPos 48, Length 40
        public string itemcode{ get; set; } // [string,   12] 기초자산코드                    StartPos 89, Length 12
        public string cpgubun{ get; set; } // [string,    2] 콜/풋구분                       StartPos 102, Length 2
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 105, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 114, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 116, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 125, Length 6
        public decimal volume{ get; set; } // [float ,   12] 거래량                          StartPos 132, Length 12
        public decimal jnilvolume{ get; set; } // [float ,   12] 전일거래량                      StartPos 145, Length 12
        public decimal elwexec{ get; set; } // [float , 10.2] 행사가                          StartPos 158, Length 10
        public string item{ get; set; } // [string,   20] 기초자산명                      StartPos 169, Length 20
        public decimal bprice{ get; set; } // [float , 10.2] 기초자산가                      StartPos 190, Length 10
        public string bsign{ get; set; } // [string,    1] 기초전일대비구분                StartPos 201, Length 1
        public decimal bchange{ get; set; } // [float , 10.2] 기초전일대비                    StartPos 203, Length 10
        public decimal bdiff{ get; set; } // [float ,  6.2] 기초등락율                      StartPos 214, Length 6
        public decimal premium{ get; set; } // [float ,  6.2] 프리미엄                        StartPos 221, Length 6
        public decimal parity{ get; set; } // [float ,  6.2] 패리티                          StartPos 228, Length 6
        public decimal berate{ get; set; } // [float ,  6.2] 손익분기                        StartPos 235, Length 6
        public decimal capt{ get; set; } // [float ,  6.2] 자본지지                        StartPos 242, Length 6
        public decimal egearing{ get; set; } // [float ,  6.2] e.기어링                        StartPos 249, Length 6
        public decimal gearing{ get; set; } // [float ,  6.2] 기어링                          StartPos 256, Length 6
        public string lastdate{ get; set; } // [string,    8] 최종거래일                      StartPos 263, Length 8
        public decimal delta{ get; set; } // [float , 10.6] 델타                            StartPos 272, Length 10
        public decimal theta{ get; set; } // [float , 10.6] 쎄타                            StartPos 283, Length 10
    }
}