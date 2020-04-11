namespace XingBot.res
{
    // 뉴ELW투자지표민감도 ( ATTR, KEY=6, GROUP=1 )
    public class _ESN_InBlock
    {
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public class _ESN_OutBlock
    {
        public string time{ get; set; } // [string,    6] 시간                            StartPos 0, Length 6
        public decimal theoryprice{ get; set; } // [float , 10.2] 장중이론가                      StartPos 7, Length 10
        public decimal delt{ get; set; } // [float ,  7.6] 델타                            StartPos 18, Length 7
        public decimal gama{ get; set; } // [float ,  7.6] 감마                            StartPos 26, Length 7
        public decimal ceta{ get; set; } // [float , 12.6] 세타                            StartPos 34, Length 12
        public decimal vega{ get; set; } // [float , 12.6] 베가                            StartPos 47, Length 12
        public decimal rhox{ get; set; } // [float , 12.6] 로우                            StartPos 60, Length 12
        public decimal impv{ get; set; } // [float ,  5.2] 내재변동성                      StartPos 73, Length 5
        public decimal egearing{ get; set; } // [float ,  8.2] E.기어링                        StartPos 79, Length 8
        public string shcode{ get; set; } // [string,    6] 단축코드                        StartPos 88, Length 6
        public long elwclose{ get; set; } // [long  ,    8] ELW현재가                       StartPos 95, Length 8
        public string sign{ get; set; } // [string,    1] ELW전일대비구분                 StartPos 104, Length 1
        public long change{ get; set; } // [long  ,    8] ELW전일대비                     StartPos 106, Length 8
        public string date{ get; set; } // [string,    8] 일자                            StartPos 115, Length 8
        public decimal tickvalue{ get; set; } // [float , 10.2] 틱환산                          StartPos 124, Length 10
        public decimal lp_impv{ get; set; } // [float ,  5.2] LP내재변동성                    StartPos 135, Length 5
    }
}