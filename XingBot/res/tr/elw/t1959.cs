using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr.elw
{
    // LP 대상종목정보 조회 ( ATTR,BLOCK,HEADTYPE=A )
    struct _t1959InBlock
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
    }

    struct _t1959OutBlock1
    {
        public string shcode; // [string,    6] 종목코드                        StartPos 0, Length 6
        public string hname; // [string,   40] 종목명                          StartPos 7, Length 40
        public string price; // [string,   12] 현재가                          StartPos 48, Length 12
        public string sign; // [string,    1] 부호                            StartPos 61, Length 1
        public string change; // [string,   12] 대비                            StartPos 63, Length 12
        public float rate; // [float ,  5.2] 등락율                          StartPos 76, Length 5
        public string volume; // [string,   12] 누적거래량                      StartPos 82, Length 12
        public string value; // [string,   12] 누적거래대금                    StartPos 95, Length 12
        public string lp_gb; // [string,    4] LP주문가능여부                  StartPos 108, Length 4
        public string lp_mem_nm1; // [string,   20] LP회원사명1                     StartPos 113, Length 20
        public string lp_mem_nm2; // [string,   20] LP회원사명2                     StartPos 134, Length 20
        public string lp_mem_nm3; // [string,   20] LP회원사명3                     StartPos 155, Length 20
        public string lp_mem_nm4; // [string,   20] LP회원사명4                     StartPos 176, Length 20
        public string lp_mem_nm5; // [string,   20] LP회원사명5                     StartPos 197, Length 20
        public string lp_min_qty; // [string,   10] LP최소호가수량                  StartPos 218, Length 10
        public string lp_st_date; // [string,    8] LP시작일                        StartPos 229, Length 8
        public string lp_end_date; // [string,    8] LP종료일                        StartPos 238, Length 8
        public float lp_spread; // [float ,  5.2] LP스프레드                      StartPos 247, Length 5
    }
}