using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.model
{
    /**
     * t9943 지수선물마스터조회API용 - "V","S",""
     * t8435 파생종목마스터조회API용 - 미니선물,미니옵션
     * t8426 상품선물 마스터 조회
     * t8401 주식선물 마스터조회
     */
    public class CodeFutures
    {
        /**
         * KOSPI200, Stock, KOADAQ50, 업종코드
         */
        public string UnderlyingAssetsCategory;
        public string UnderlyingAssetsCode;
        public string Category;
        public string Code;
        public string ExpandedCode;
        public string Name;
        public string ListingDate;
        public string ExpirationDate;
    }
}
