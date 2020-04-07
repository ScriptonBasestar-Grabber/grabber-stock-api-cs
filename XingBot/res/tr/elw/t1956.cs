namespace XingBot.res
{
    // ELW 현재가(확정지급액) 조회 ( ATTR,BLOCK,HEADTYPE=A )
    public struct _t1956InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _t1956OutBlock
    {
        public string hname{ get; set; } // [string,   40] 한글명                          StartPos 0, Length 40
        public string chetime{ get; set; } // [string,   10] 체결시간                        StartPos 41, Length 10
        public long price{ get; set; } // [long  ,    8] 현재가                          StartPos 52, Length 8
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 61, Length 1
        public long change{ get; set; } // [long  ,    8] 전일대비                        StartPos 63, Length 8
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 72, Length 6
        public long cvolume{ get; set; } // [long  ,   10] 체결량                          StartPos 79, Length 10
        public decimal volume{ get; set; } // [float ,   12] 누적거래량                      StartPos 90, Length 12
        public long recprice{ get; set; } // [long  ,    8] 기준가                          StartPos 103, Length 8
        public long avg{ get; set; } // [long  ,    8] 가중평균                        StartPos 112, Length 8
        public decimal jnilvolume{ get; set; } // [float ,   12] 전일거래량                      StartPos 121, Length 12
        public decimal jvolume{ get; set; } // [float ,   12] 전일동시간거래량                StartPos 134, Length 12
        public long jnilclose{ get; set; } // [long  ,    8] 전일종가                        StartPos 147, Length 8
        public decimal volumechg{ get; set; } // [float ,   12] 거래량차                        StartPos 156, Length 12
        public decimal volumediff{ get; set; } // [float ,  6.2] 거래량차등락율                  StartPos 169, Length 6
        public long open{ get; set; } // [long  ,    8] 시가                            StartPos 176, Length 8
        public decimal odiff{ get; set; } // [float ,  6.2] 시가등락율                      StartPos 185, Length 6
        public string opentime{ get; set; } // [string,    6] 시가시간                        StartPos 192, Length 6
        public long high{ get; set; } // [long  ,    8] 고가                            StartPos 199, Length 8
        public decimal hdiff{ get; set; } // [float ,  6.2] 고가등락율                      StartPos 208, Length 6
        public string hightime{ get; set; } // [string,    6] 고가시간                        StartPos 215, Length 6
        public long low{ get; set; } // [long  ,    8] 저가                            StartPos 222, Length 8
        public decimal ldiff{ get; set; } // [float ,  6.2] 저가등락율                      StartPos 231, Length 6
        public string lowtime{ get; set; } // [string,    6] 저가시간                        StartPos 238, Length 6
        public long high52w{ get; set; } // [long  ,    8] 52최고가                        StartPos 245, Length 8
        public decimal high52wdiff{ get; set; } // [float ,  6.2] 52최고가등락율                  StartPos 254, Length 6
        public string high52wdate{ get; set; } // [string,    8] 52최고가일                      StartPos 261, Length 8
        public long low52w{ get; set; } // [long  ,    8] 52최저가                        StartPos 270, Length 8
        public decimal low52wdiff{ get; set; } // [float ,  6.2] 52최저가등락율                  StartPos 279, Length 6
        public string low52wdate{ get; set; } // [string,    8] 52최저가일                      StartPos 286, Length 8
        public decimal exhratio{ get; set; } // [float ,  6.2] 소진율                          StartPos 295, Length 6
        public decimal listing{ get; set; } // [float ,   12] 상장주식수(천)                  StartPos 302, Length 12
        public string memedan{ get; set; } // [string,    5] 수량단위                        StartPos 315, Length 5
        public decimal vol{ get; set; } // [float ,  6.2] 회전율                          StartPos 321, Length 6
        public decimal parity{ get; set; } // [float ,  8.2] 패리티                          StartPos 328, Length 8
        public decimal berate{ get; set; } // [float ,  8.2] 손익분기                        StartPos 337, Length 8
        public decimal gearing{ get; set; } // [float ,  8.2] 기어링                          StartPos 346, Length 8
        public decimal elwexec{ get; set; } // [float ,  8.2] 행사가                          StartPos 355, Length 8
        public long issueprice{ get; set; } // [long  ,    8] 발행가                          StartPos 364, Length 8
        public decimal convrate{ get; set; } // [float , 12.4] 전환비율                        StartPos 373, Length 12
        public string lastdate{ get; set; } // [string,    8] 최종거래일                      StartPos 386, Length 8
        public decimal capt{ get; set; } // [float ,  8.2] 자본지지                        StartPos 395, Length 8
        public decimal egearing{ get; set; } // [float ,  8.2] e.기어링                        StartPos 404, Length 8
        public decimal premium{ get; set; } // [float ,  8.2] 프리미엄                        StartPos 413, Length 8
        public decimal spread{ get; set; } // [float ,  6.2] 스프레드                        StartPos 422, Length 6
        public decimal espread{ get; set; } // [float ,  6.2] 최대스프레드                    StartPos 429, Length 6
        public decimal theoryprice{ get; set; } // [float , 10.2] 이론가                          StartPos 436, Length 10
        public decimal impv{ get; set; } // [float ,  6.2] 내재변동성                      StartPos 447, Length 6
        public string moneyness{ get; set; } // [string,    1] 상태                            StartPos 454, Length 1
        public decimal delt{ get; set; } // [float ,  8.6] 델타                            StartPos 456, Length 8
        public decimal gama{ get; set; } // [float ,  8.6] 감마                            StartPos 465, Length 8
        public decimal vega{ get; set; } // [float , 13.6] 베가                            StartPos 474, Length 13
        public decimal ceta{ get; set; } // [float , 13.6] 쎄타                            StartPos 488, Length 13
        public decimal rhox{ get; set; } // [float , 13.6] 로                              StartPos 502, Length 13
        public long bjandatecnt{ get; set; } // [long  ,    4] 잔존일수                        StartPos 516, Length 4
        public string mmsdate{ get; set; } // [string,    8] 행사개시일                      StartPos 521, Length 8
        public string mmedate{ get; set; } // [string,    8] 행사종료일                      StartPos 530, Length 8
        public string payday{ get; set; } // [string,    8] 지급일                          StartPos 539, Length 8
        public string listdate{ get; set; } // [string,    8] 발행일                          StartPos 548, Length 8
        public string lpmem{ get; set; } // [string,   20] LP회원사                        StartPos 557, Length 20
        public decimal lp_holdvol{ get; set; } // [float ,   12] LP보유수량                      StartPos 578, Length 12
        public string bcode{ get; set; } // [string,    6] 기초자산코드                    StartPos 591, Length 6
        public string bgubun{ get; set; } // [string,    1] 기초자산구분                    StartPos 598, Length 1
        public long bprice{ get; set; } // [long  ,    8] 기초자산현재가                  StartPos 600, Length 8
        public string bsign{ get; set; } // [string,    1] 기초자산전일비구분              StartPos 609, Length 1
        public long bchange{ get; set; } // [long  ,    8] 기초자산전일비                  StartPos 611, Length 8
        public decimal bdiff{ get; set; } // [float ,  6.2] 기초자산등락율                  StartPos 620, Length 6
        public decimal bvolume{ get; set; } // [float ,   12] 기초자산거래량                  StartPos 627, Length 12
        public string info1{ get; set; } // [string,   10] 락구분                          StartPos 640, Length 10
        public string info2{ get; set; } // [string,   10] 관리/급등구분                   StartPos 651, Length 10
        public string info3{ get; set; } // [string,   10] 정지/연장구분                   StartPos 662, Length 10
        public string info4{ get; set; } // [string,   12] 투자/불성실구분                 StartPos 673, Length 12
        public string janginfo{ get; set; } // [string,   10] 장구분                          StartPos 686, Length 10
        public string basketgb{ get; set; } // [string,    1] 바스켓구분                      StartPos 697, Length 1
        public long basketcnt{ get; set; } // [long  ,    3] 바스켓갯수                      StartPos 699, Length 3
        public string elwtype{ get; set; } // [string,    2] ELW권리행사방식                 StartPos 703, Length 2
        public string settletype{ get; set; } // [string,    2] ELW결제방법                     StartPos 706, Length 2
        public string lpord{ get; set; } // [string,    2] LP사주문가능여부                StartPos 709, Length 2
        public string elwdetail{ get; set; } // [string,  100] 권리내용                        StartPos 712, Length 100
        public string valuation{ get; set; } // [string,  100] 만기평가가격방식                StartPos 813, Length 100
        public decimal givemoney{ get; set; } // [float ,  8.3] 확정지급액                      StartPos 914, Length 8
    }

    public struct _t1956OutBlock1
    {
        public string bskcode{ get; set; } // [string,    6] 기초자산코드                    StartPos 0, Length 6
        public long bskbno{ get; set; } // [long  ,    3] 기초자산비율                    StartPos 7, Length 3
        public long bskprice{ get; set; } // [long  ,    8] 기초자산현재가                  StartPos 11, Length 8
        public string bsksign{ get; set; } // [string,    1] 기초자산전일비구분              StartPos 20, Length 1
        public long bskchange{ get; set; } // [long  ,    8] 기초자산전일비                  StartPos 22, Length 8
        public decimal bskdiff{ get; set; } // [float ,  6.2] 기초자산등락율                  StartPos 31, Length 6
        public decimal bskvolume{ get; set; } // [float ,   12] 기초자산거래량                  StartPos 38, Length 12
        public long bskjnilclose{ get; set; } // [long  ,    8] 기초자산전일종가                StartPos 51, Length 8
    }
}