namespace XingBot.res
{
    // 뉴ELW투자지표민감도 ( ATTR, KEY=6, GROUP=1 )
    public struct _ESN_InBlock
    {
        public string shcode; // [string,    6] 단축코드                        StartPos 0, Length 6
    }

    public struct _ESN_OutBlock
    {
        public string time; // [string,    6] 시간                            StartPos 0, Length 6
        public decimal theoryprice; // [float , 10.2] 장중이론가                      StartPos 7, Length 10
        public decimal delt; // [float ,  7.6] 델타                            StartPos 18, Length 7
        public decimal gama; // [float ,  7.6] 감마                            StartPos 26, Length 7
        public decimal ceta; // [float , 12.6] 세타                            StartPos 34, Length 12
        public decimal vega; // [float , 12.6] 베가                            StartPos 47, Length 12
        public decimal rhox; // [float , 12.6] 로우                            StartPos 60, Length 12
        public decimal impv; // [float ,  5.2] 내재변동성                      StartPos 73, Length 5
        public decimal egearing; // [float ,  8.2] E.기어링                        StartPos 79, Length 8
        public string shcode; // [string,    6] 단축코드                        StartPos 88, Length 6
        public long elwclose; // [long  ,    8] ELW현재가                       StartPos 95, Length 8
        public string sign; // [string,    1] ELW전일대비구분                 StartPos 104, Length 1
        public long change; // [long  ,    8] ELW전일대비                     StartPos 106, Length 8
        public string date; // [string,    8] 일자                            StartPos 115, Length 8
        public decimal tickvalue; // [float , 10.2] 틱환산                          StartPos 124, Length 10
        public decimal lp_impv; // [float ,  5.2] LP내재변동성                    StartPos 135, Length 5
    }
}