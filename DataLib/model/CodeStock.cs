using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.model
{
    public class CodeStock
    {
        public string Name;
        public string Code;
        public string ExpCode;
        // 1 ETC, 2 ETN
        public string EtfGubun;
        // Y N
        public string SpacGubun;
        // 1 KOSPI, 2 KOSDAQ
        public string MarketGubun;
        /**
         * 증권그룹
         * 01 주식
         * 03 예탁증서(DR)
         * 04: 증권투자회사(뮤추얼펀드)
         * 06: Reits종목
         * 08: 상장지수펀드(ETF)
         * 10: 선박투자회사
         * 12: 인프라투융회사
         * 13: 해외ETF
         * 14: 해외원주
         * 15: ETN
         */
        public string Bu12Gubun;
    }
}
