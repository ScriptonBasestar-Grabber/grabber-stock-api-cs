namespace XingBot.real.res
{
    // 주식선물실시간상하한가 ( ATTR, KEY=8, GROUP=1 )
    public struct _JD0_InBlock
    {
        public string futcode; // [string,    8] 단축코드                        StartPos 0, Length 8
    }

    public struct _JD0_OutBlock
    {
        public string gubun; // [string,    1] 접속매매여부                    StartPos 0, Length 1
        public string dy_gubun; // [string,    1] 실시간가격제한여부              StartPos 2, Length 1
        public long dy_uplmtprice; // [long  ,   10] 실시간상한가                    StartPos 4, Length 10
        public long dy_dnlmtprice; // [long  ,   10] 실시간하한가                    StartPos 15, Length 10
        public string futcode; // [string,    8] 단축코드                        StartPos 26, Length 8
    }
}