namespace XingBot.res
{
    // 상/하한가진입 ( ATTR, KEY=1, GROUP=1 )
    struct _SHI_InBlock
    {
        string updnlmtgubun;    // [string,    1] 상/하한구분                     StartPos 0, Length 1
    }

    struct _SHI_OutBlock
    {
        string sijanggubun;    // [string,    1] 거래소/코스닥구분               StartPos 0, Length 1
        string hname;    // [string,   20] 종목명                          StartPos 2, Length 20
        long price;    // [long  ,    8] 현재가                          StartPos 23, Length 8
        string sign;    // [string,    1] 전일대비구분                    StartPos 32, Length 1
        long change;    // [long  ,    8] 전일대비                        StartPos 34, Length 8
        float drate;    // [float ,  6.2] 등락율                          StartPos 43, Length 6
        long volume;    // [long  ,   12] 누적거래량                      StartPos 50, Length 12
        float volincrate;    // [float , 12.2] 거래증가율                      StartPos 63, Length 12
        long totofferrem;    // [long  ,   12] 매도호가총수량                  StartPos 76, Length 12
        long totbidrem;    // [long  ,   12] 매수호가총수량                  StartPos 89, Length 12
        string updnlmtstime;    // [string,    6] 상한가/하한가최종진입시간       StartPos 102, Length 6
        long updnlmtdaycnt;    // [long  ,    3] 상한가/하한가연속일수           StartPos 109, Length 3
        long jnilvolume;    // [long  ,   12] 전일거래량                      StartPos 113, Length 12
        string shcode;    // [string,    6] 단축코드                        StartPos 126, Length 6
        string gwangubun;    // [string,    1] 관리구분                        StartPos 133, Length 1
        string undergubun;    // [string,    1] 이상급등구분                    StartPos 135, Length 1
        string tgubun;    // [string,    1] 투자유의구분                    StartPos 137, Length 1
        string wgubun;    // [string,    1] 우선주구분                      StartPos 139, Length 1
        string dishonest;    // [string,    1] 불성실구분                      StartPos 141, Length 1
        string jkrate;    // [string,    1] 증거금률                        StartPos 143, Length 1
    }
}