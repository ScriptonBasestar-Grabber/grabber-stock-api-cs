namespace XingBot.res
{
    // KOSPI200옵션실시간상하한가 ( ATTR, KEY=8, GROUP=1 )
    public struct _OD0_InBlock
    {
        public string optcode{ get; set; } // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _OD0_OutBlock
    {
        public string gubun{ get; set; } // [string,    1] 접속매매여부                    StartPos 0, Length 1
        public string dy_gubun{ get; set; } // [string,    1] 실시간가격제한여부              StartPos 2, Length 1
        public decimal dy_uplmtprice{ get; set; } // [float ,  8.2] 실시간상한가                    StartPos 4, Length 8
        public decimal dy_dnlmtprice{ get; set; } // [float ,  8.2] 실시간하한가                    StartPos 13, Length 8
        public string opttcode{ get; set; } // [string,    8] 단축코드                        StartPos 22, Length 8
    }
}