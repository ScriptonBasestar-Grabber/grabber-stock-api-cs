namespace XingBot.res
{
    public class BM_
    {
        struct _BM__InBlock
        {
            string upcode; // [string,    3] 업종코드                       StartPos 0, Length 3
        }

        struct _BM__OutBlock
        {
            string tjjcode; // [string,    4] 투자자코드                     StartPos 0, Length 4
            string tjjtime; // [string,    8] 수신시간                       StartPos 5, Length 8
            long msvolume; // [long  ,    8] 매수 거래량                    StartPos 14, Length 8
            long mdvolume; // [long  ,    8] 매도 거래량                    StartPos 23, Length 8
            long msvol; // [long  ,    8] 거래량 순매수                  StartPos 32, Length 8
            long p_msvol; // [long  ,    8] 거래량 순매수 직전대비         StartPos 41, Length 8
            long msvalue; // [long  ,    6] 매수 거래대금                  StartPos 50, Length 6
            long mdvalue; // [long  ,    6] 매도 거래대금                  StartPos 57, Length 6
            long msval; // [long  ,    6] 거래대금 순매수                StartPos 64, Length 6
            long p_msval; // [long  ,    6] 거래대금 순매수 직전대비       StartPos 71, Length 6
            string upcode; // [string,    3] 업종코드                       StartPos 78, Length 3
        }
    }
}