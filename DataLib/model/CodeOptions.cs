using System;
using System.Collections.Generic;
using System.Text;

namespace DataLib.model
{
    public class CodeOptions
    {
        /**
         * KOSPI200, KOSDAQ50, Stock
         */
        public string UnderlyingAssetsCategory;
        public string UnderlyingAssetsCode;
        public string Category;
        public string Code;
        public string ExpandedCode;
        public string Name;
        public string ListingDate;
        public string ExpirationDate;
        // C/P
        public char CallPutType;
        public decimal StrikePrice;
    }
}
