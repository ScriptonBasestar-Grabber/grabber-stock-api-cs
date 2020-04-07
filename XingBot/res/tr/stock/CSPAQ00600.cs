namespace XingBot.res
{
    // 계좌별신용한도조회 ( SERVICE=CSPAQ00600,HEADTYPE=B,CREATOR=송우석,CREDATE=2018/09/17 15:17:35 )
    public struct _CSPAQ00600InBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string LoanDtlClssCode{ get; set; } // [LoanDtlClssCode,    2] 대출상세분류코드                StartPos 33, Length 2
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 35, Length 12
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 47, Length 13
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 60, Length 2
    }

    public struct _CSPAQ00600OutBlock1
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNo{ get; set; } // [AcntNo,   20] 계좌번호                        StartPos 5, Length 20
        public string InptPwd{ get; set; } // [InptPwd,    8] 입력비밀번호                    StartPos 25, Length 8
        public string LoanDtlClssCode{ get; set; } // [LoanDtlClssCode,    2] 대출상세분류코드                StartPos 33, Length 2
        public string IsuNo{ get; set; } // [IsuNo,   12] 종목번호                        StartPos 35, Length 12
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 47, Length 13
        public string CommdaCode{ get; set; } // [CommdaCode,    2] 통신매체코드                    StartPos 60, Length 2
    }

    public struct _CSPAQ00600OutBlock2
    {
        public long RecCnt{ get; set; } // [RecCnt  ,    5] 레코드갯수                      StartPos 0, Length 5
        public string AcntNm{ get; set; } // [AcntNm,   40] 계좌명                          StartPos 5, Length 40
        public decimal OrdPrc{ get; set; } // [OrdPrc, 13.2] 주문가                          StartPos 45, Length 13
        public long SloanLmtAmt{ get; set; } // [SloanLmtAmt  ,   16] 대주한도                        StartPos 58, Length 16
        public long SloanAmtSum{ get; set; } // [SloanAmtSum  ,   16] 대주금액합계                    StartPos 74, Length 16
        public long SloanNewAmt{ get; set; } // [SloanNewAmt  ,   16] 대주신규금액                    StartPos 90, Length 16
        public long SloanRfundAmt{ get; set; } // [SloanRfundAmt  ,   16] 대주상환금액                    StartPos 106, Length 16
        public long MktcplMloanLmtAmt{ get; set; } // [MktcplMloanLmtAmt  ,   16] 유통융자한도금액                StartPos 122, Length 16
        public long MktcplMloanAmtSum{ get; set; } // [MktcplMloanAmtSum  ,   16] 유통융자금액합계                StartPos 138, Length 16
        public long MktcplMloanNewAmt{ get; set; } // [MktcplMloanNewAmt  ,   16] 유통융자신규금액                StartPos 154, Length 16

        public long
            MktcplMloanRfundAmt{ get; set; } // [MktcplMloanRfundAmt  ,   16] 유통융자상환금액                StartPos 170, Length 16

        public long SfaccMloanLmtAmt{ get; set; } // [SfaccMloanLmtAmt  ,   16] 자기융자한도금액                StartPos 186, Length 16
        public long SfaccMloanAmtSum{ get; set; } // [SfaccMloanAmtSum  ,   16] 자기융자금액합계                StartPos 202, Length 16
        public long SfaccMloanNewAmt{ get; set; } // [SfaccMloanNewAmt  ,   16] 자기융자신규금액                StartPos 218, Length 16
        public long SfaccMloanRfundAmt{ get; set; } // [SfaccMloanRfundAmt  ,   16] 자기융자상환금액                StartPos 234, Length 16

        public long
            BrnMktcplMloanLmtAmt{ get; set; } // [BrnMktcplMloanLmtAmt  ,   16] 지점유통융자한도금액            StartPos 250, Length 16

        public long
            BrnMktcplMloanNewAmt{ get; set; } // [BrnMktcplMloanNewAmt  ,   16] 지점유통융자신규금액            StartPos 266, Length 16

        public long
            BrnMktcplMloanRfundAmt{ get; set; } // [BrnMktcplMloanRfundAmt  ,   16] 지점유통융자상환금액            StartPos 282, Length 16

        public long
            BrnMktcplMloanUseAmt{ get; set; } // [BrnMktcplMloanUseAmt  ,   16] 지점유통융자사용금액            StartPos 298, Length 16

        public long BrnSfaccMloanLmtAmt{ get; set; } // [BrnSfaccMloanLmtAmt  ,   16] 지점자기융자한도금액            StartPos 314, Length 16
        public long BrnSfaccMloanNewAmt{ get; set; } // [BrnSfaccMloanNewAmt  ,   16] 지점자기융자신규금액            StartPos 330, Length 16

        public long
            BrnSfaccMloanRfundAmt{ get; set; } // [BrnSfaccMloanRfundAmt  ,   16] 지점자기융자상환금액            StartPos 346, Length 16

        public long BrnSfaccMloanUseAmt{ get; set; } // [BrnSfaccMloanUseAmt  ,   16] 지점자기융자사용금액            StartPos 362, Length 16
        public string FirmMloanLmtMgmtYn{ get; set; } // [FirmMloanLmtMgmtYn,    1] 이용사융자한도관리여부          StartPos 378, Length 1
        public string FirmCrdtIsuRestrcTp{ get; set; } // [FirmCrdtIsuRestrcTp,    1] 이용사신용종목제한구분          StartPos 379, Length 1
        public decimal PldgMaintRat{ get; set; } // [PldgMaintRat,  7.4] 담보유지비율                    StartPos 380, Length 7
        public string FirmNm{ get; set; } // [FirmNm,   50] 이용사명                        StartPos 387, Length 50
        public decimal PldgRat{ get; set; } // [PldgRat,  7.4] 담보비율                        StartPos 437, Length 7
        public long DpsastSum{ get; set; } // [DpsastSum  ,   17] 예탁자산합계                    StartPos 444, Length 17
        public long LmtChgAbleAmt{ get; set; } // [LmtChgAbleAmt  ,   16] 한도변경가능금액                StartPos 461, Length 16
        public long OrdAbleAmt{ get; set; } // [OrdAbleAmt  ,   16] 주문가능금액                    StartPos 477, Length 16
        public long OrdAbleQty{ get; set; } // [OrdAbleQty  ,   16] 주문가능수량                    StartPos 493, Length 16
        public long RcvblUablOrdAbleQty{ get; set; } // [RcvblUablOrdAbleQty  ,   16] 미수불가주문가능수량            StartPos 509, Length 16
    }
}