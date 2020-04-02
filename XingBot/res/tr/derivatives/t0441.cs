using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.derivatives
{
    // 선물/옵션 잔고평가(이동평균) ( ATTR,TUXCODE=T0441,HEADTYPE=D )
    struct _t0441InBlock
    {
        public string accno; // [string,   11] 계좌번호                        StartPos 0, Length 11
        public string passwd; // [string,    8] 비밀번호                        StartPos 12, Length 8
        public string cts_expcode; // [string,    8] CTS_종목번호                    StartPos 21, Length 8
        public string cts_medocd; // [string,    1] CTS_매매구분                    StartPos 30, Length 1
    }

    struct _t0441OutBlock
    {
        public long tdtsunik; // [long  ,   18] 매매손익합계                    StartPos 0, Length 18
        public string cts_expcode; // [string,    8] CTS_종목번호                    StartPos 19, Length 8
        public string cts_medocd; // [string,    1] CTS_매매구분                    StartPos 28, Length 1
        public long tappamt; // [long  ,   18] 평가금액                        StartPos 30, Length 18
        public long tsunik; // [long  ,   18] 평가손익                        StartPos 49, Length 18
    }

    struct _t0441OutBlock1
    {
        public string expcode; // [string,    8] 종목번호                        StartPos 0, Length 8
        public string medosu; // [string,    4] 구분                            StartPos 9, Length 4
        public long jqty; // [long  ,   10] 잔고수량                        StartPos 14, Length 10
        public long cqty; // [long  ,   10] 청산가능수량                    StartPos 25, Length 10
        public float pamt; // [float , 10.2] 평균단가                        StartPos 36, Length 10
        public long mamt; // [long  ,   18] 총매입금액                      StartPos 47, Length 18
        public string medocd; // [string,    1] 매매구분                        StartPos 66, Length 1
        public long dtsunik; // [long  ,   18] 매매손익                        StartPos 68, Length 18
        public long sysprocseq; // [long  ,   10] 처리순번                        StartPos 87, Length 10
        public float price; // [float ,  9.2] 현재가                          StartPos 98, Length 9
        public long appamt; // [long  ,   18] 평가금액                        StartPos 108, Length 18
        public long dtsunik1; // [long  ,   18] 평가손익                        StartPos 127, Length 18
        public float sunikrt; // [float , 10.2] 수익율                          StartPos 146, Length 10
    }
}