﻿namespace XingBot.res
{
    // 옵션 전광판 ( ATTR,BLOCK,HEADTYPE=A )
    public class _t2301InBlock
    {
        public string yyyymm{ get; set; } // [string,    6] 월물                            StartPos 0, Length 6
        public string gubun{ get; set; } // [string,    1] 미니구분(M:미니G:정규)          StartPos 7, Length 1
    }

    public class _t2301OutBlock
    {
        public long histimpv{ get; set; } // [long  ,    4] 역사적변동성                    StartPos 0, Length 4
        public long jandatecnt{ get; set; } // [long  ,    4] 옵션잔존일                      StartPos 5, Length 4
        public decimal cimpv{ get; set; } // [float ,  6.3] 콜옵션대표IV                    StartPos 10, Length 6
        public decimal pimpv{ get; set; } // [float ,  6.3] 풋옵션대표IV                    StartPos 17, Length 6
        public decimal gmprice{ get; set; } // [float ,  6.2] 근월물현재가                    StartPos 24, Length 6
        public string gmsign{ get; set; } // [string,    1] 근월물전일대비구분              StartPos 31, Length 1
        public decimal gmchange{ get; set; } // [float ,  6.2] 근월물전일대비                  StartPos 33, Length 6
        public decimal gmdiff{ get; set; } // [float ,  6.2] 근월물등락율                    StartPos 40, Length 6
        public long gmvolume{ get; set; } // [long  ,   12] 근월물거래량                    StartPos 47, Length 12
        public string gmshcode{ get; set; } // [string,    8] 근월물선물코드                  StartPos 60, Length 8
    }

    public class _t2301OutBlock1
    {
        public decimal actprice{ get; set; } // [float ,  6.2] 행사가                          StartPos 0, Length 6
        public string optcode{ get; set; } // [string,    8] 콜옵션코드                      StartPos 7, Length 8
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 16, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 23, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 25, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 32, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 39, Length 12
        public decimal iv{ get; set; } // [float ,  6.2] IV                              StartPos 52, Length 6
        public long mgjv{ get; set; } // [long  ,   12] 미결제약정                      StartPos 59, Length 12
        public long mgjvupdn{ get; set; } // [long  ,   12] 미결제약정증감                  StartPos 72, Length 12
        public decimal offerho1{ get; set; } // [float ,  6.2] 매도호가                        StartPos 85, Length 6
        public decimal bidho1{ get; set; } // [float ,  6.2] 매수호가                        StartPos 92, Length 6
        public long cvolume{ get; set; } // [long  ,   12] 체결량                          StartPos 99, Length 12
        public decimal delt{ get; set; } // [float ,  6.4] 델타                            StartPos 112, Length 6
        public decimal gama{ get; set; } // [float ,  6.4] 감마                            StartPos 119, Length 6
        public decimal vega{ get; set; } // [float ,  6.4] 베가                            StartPos 126, Length 6
        public decimal ceta{ get; set; } // [float ,  6.4] 쎄타                            StartPos 133, Length 6
        public decimal rhox{ get; set; } // [float ,  6.4] 로우                            StartPos 140, Length 6
        public decimal theoryprice{ get; set; } // [float ,  6.2] 이론가                          StartPos 147, Length 6
        public decimal impv{ get; set; } // [float ,  6.2] 내재가치                        StartPos 154, Length 6
        public decimal timevl{ get; set; } // [float ,  6.2] 시간가치                        StartPos 161, Length 6
        public long jvolume{ get; set; } // [long  ,   12] 잔고수량                        StartPos 168, Length 12
        public long parpl{ get; set; } // [long  ,   12] 평가손익                        StartPos 181, Length 12
        public long jngo{ get; set; } // [long  ,    6] 청산가능수량                    StartPos 194, Length 6
        public long offerrem1{ get; set; } // [long  ,   12] 매도잔량                        StartPos 201, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수잔량                        StartPos 214, Length 12
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 227, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 234, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 241, Length 6
        public string atmgubun{ get; set; } // [string,    1] ATM구분                         StartPos 248, Length 1
        public decimal jisuconv{ get; set; } // [float ,  6.2] 지수환산                        StartPos 250, Length 6
        public decimal value{ get; set; } // [float ,   12] 거래대금                        StartPos 257, Length 12
    }

    public class _t2301OutBlock2
    {
        public decimal actprice{ get; set; } // [float ,  6.2] 행사가                          StartPos 0, Length 6
        public string optcode{ get; set; } // [string,    8] 풋옵션코드                      StartPos 7, Length 8
        public decimal price{ get; set; } // [float ,  6.2] 현재가                          StartPos 16, Length 6
        public string sign{ get; set; } // [string,    1] 전일대비구분                    StartPos 23, Length 1
        public decimal change{ get; set; } // [float ,  6.2] 전일대비                        StartPos 25, Length 6
        public decimal diff{ get; set; } // [float ,  6.2] 등락율                          StartPos 32, Length 6
        public long volume{ get; set; } // [long  ,   12] 거래량                          StartPos 39, Length 12
        public decimal iv{ get; set; } // [float ,  6.2] IV                              StartPos 52, Length 6
        public long mgjv{ get; set; } // [long  ,   12] 미결제약정                      StartPos 59, Length 12
        public long mgjvupdn{ get; set; } // [long  ,   12] 미결제약정증감                  StartPos 72, Length 12
        public decimal offerho1{ get; set; } // [float ,  6.2] 매도호가                        StartPos 85, Length 6
        public decimal bidho1{ get; set; } // [float ,  6.2] 매수호가                        StartPos 92, Length 6
        public long cvolume{ get; set; } // [long  ,   12] 체결량                          StartPos 99, Length 12
        public decimal delt{ get; set; } // [float ,  6.4] 델타                            StartPos 112, Length 6
        public decimal gama{ get; set; } // [float ,  6.4] 감마                            StartPos 119, Length 6
        public decimal vega{ get; set; } // [float ,  6.4] 베가                            StartPos 126, Length 6
        public decimal ceta{ get; set; } // [float ,  6.4] 쎄타                            StartPos 133, Length 6
        public decimal rhox{ get; set; } // [float ,  6.4] 로우                            StartPos 140, Length 6
        public decimal theoryprice{ get; set; } // [float ,  6.2] 이론가                          StartPos 147, Length 6
        public decimal impv{ get; set; } // [float ,  6.2] 내재가치                        StartPos 154, Length 6
        public decimal timevl{ get; set; } // [float ,  6.2] 시간가치                        StartPos 161, Length 6
        public long jvolume{ get; set; } // [long  ,   12] 잔고수량                        StartPos 168, Length 12
        public long parpl{ get; set; } // [long  ,   12] 평가손익                        StartPos 181, Length 12
        public long jngo{ get; set; } // [long  ,    6] 청산가능수량                    StartPos 194, Length 6
        public long offerrem1{ get; set; } // [long  ,   12] 매도잔량                        StartPos 201, Length 12
        public long bidrem1{ get; set; } // [long  ,   12] 매수잔량                        StartPos 214, Length 12
        public decimal open{ get; set; } // [float ,  6.2] 시가                            StartPos 227, Length 6
        public decimal high{ get; set; } // [float ,  6.2] 고가                            StartPos 234, Length 6
        public decimal low{ get; set; } // [float ,  6.2] 저가                            StartPos 241, Length 6
        public string atmgubun{ get; set; } // [string,    1] ATM구분                         StartPos 248, Length 1
        public decimal jisuconv{ get; set; } // [float ,  6.2] 지수환산                        StartPos 250, Length 6
        public decimal value{ get; set; } // [float ,   12] 거래대금                        StartPos 257, Length 12
    }
}