namespace XingBot.res
{
    // 선물주문정정취소 ( KEY=8, GROUP=1 )
    public struct _H01_InBlock
    {
    }

    public struct _H01_OutBlock
    {
        public long lineseq; // [lineseq  ,   10] 라인일련번호                    StartPos 0, Length 10
        public string accno; // [accno,   11] 계좌번호                        StartPos 10, Length 11
        public string user; // [user,    8] 조작자ID                        StartPos 21, Length 8
        public long seq; // [seq  ,   11] 일련번호                        StartPos 29, Length 11
        public string trcode; // [trcode,   11] trcode                          StartPos 40, Length 11
        public string megrpno; // [megrpno,    2] 매칭그룹번호                    StartPos 51, Length 2
        public string boardid; // [boardid,    2] 보드ID                          StartPos 53, Length 2
        public string memberno; // [memberno,    5] 회원번호                        StartPos 55, Length 5
        public string bpno; // [bpno,    5] 지점번호                        StartPos 60, Length 5
        public string ordno; // [ordno,   10] 주문번호                        StartPos 65, Length 10
        public string orgordno; // [orgordno,   10] 원주문번호                      StartPos 75, Length 10
        public string expcode; // [expcode,   12] 종목코드                        StartPos 85, Length 12
        public string dosugb; // [dosugb,    1] 매도수구분                      StartPos 97, Length 1
        public string mocagb; // [mocagb,    1] 정정취소구분                    StartPos 98, Length 1
        public string accno1; // [accno1,   12] 계좌번호1                       StartPos 99, Length 12
        public long qty2; // [qty2  ,   10] 호가수량                        StartPos 111, Length 10
        public decimal price; // [price , 11.2] 호가가격                        StartPos 121, Length 11
        public string ordgb; // [ordgb,    1] 주문유형                        StartPos 132, Length 1
        public string hogagb; // [hogagb,    1] 호가구분                        StartPos 133, Length 1
        public string sihogagb; // [sihogagb,   11] 시장조성호가구분                StartPos 134, Length 11
        public string tradid; // [tradid,    5] 자사주신고서ID                  StartPos 145, Length 5
        public string treacode; // [treacode,    1] 자사주매매방법                  StartPos 150, Length 1
        public string askcode; // [askcode,    2] 매도유형코드                    StartPos 151, Length 2
        public string creditcode; // [creditcode,    2] 신용구분코드                    StartPos 153, Length 2
        public string jakigb; // [jakigb,    2] 위탁자기구분                    StartPos 155, Length 2
        public string trustnum; // [trustnum,    5] 위탁사번호                      StartPos 157, Length 5
        public string ptgb; // [ptgb,    2] 프로그램구분                    StartPos 162, Length 2
        public string substonum; // [substonum,   12] 대용주권계좌번호                StartPos 164, Length 12
        public string accgb; // [accgb,    2] 계좌구분코드                    StartPos 176, Length 2
        public string accmarggb; // [accmarggb,    2] 계좌증거금코드                  StartPos 178, Length 2
        public string nationcode; // [nationcode,    3] 국가코드                        StartPos 180, Length 3
        public string investgb; // [investgb,    4] 투자자구분                      StartPos 183, Length 4
        public string forecode; // [forecode,    2] 외국인코드                      StartPos 187, Length 2
        public string medcode; // [medcode,    1] 주문매체구분                    StartPos 189, Length 1
        public string ordid; // [ordid,   12] 주문식별자번호                  StartPos 190, Length 12
        public string macid; // [macid,   12] MAC주소                         StartPos 202, Length 12
        public string orddate; // [orddate,    8] 호가일자                        StartPos 214, Length 8
        public string rcvtime; // [rcvtime,    9] 회원사주문시각                  StartPos 222, Length 9
        public string mem_filler; // [mem_filler,    7] mem_filler                      StartPos 231, Length 7
        public string mem_accno; // [mem_accno,   11] mem_accno                       StartPos 238, Length 11
        public string mem_filler1; // [mem_filler1,   42] mem_filler1                     StartPos 249, Length 42
        public string ordacpttm; // [ordacpttm,    9] 매칭접수시간                    StartPos 291, Length 9
        public long qty; // [qty  ,   10] 실정정취소수량                  StartPos 300, Length 10
        public string autogb; // [autogb,    1] 자동취소구분                    StartPos 310, Length 1
        public string rejcode; // [rejcode,    4] 거부사유                        StartPos 311, Length 4
        public string prgordde; // [prgordde,    1] 프로그램호가신고                StartPos 315, Length 1
    }
}