namespace XingBot.res
{
    public class t9945
    {
        struct _t9945InBlock
        {
            string gubun; // [string,    1] 구분(KSP:1KSD:2)               StartPos 0, Length 1
        }

        struct _t9945OutBlock
        {
            string hname; // [string,   40] 종목명                         StartPos 0, Length 40
            string shcode; // [string,    6] 단축코드                       StartPos 40, Length 6
            string expcode; // [string,   12] 확장코드                       StartPos 46, Length 12
            string etfchk; // [string,    1] ETF구분                        StartPos 58, Length 1
            string filler; // [string,    5] filler                         StartPos 59, Length 5
        }
    }
}