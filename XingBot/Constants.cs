using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot
{
    public class Constants
    {
        public static readonly string[] QueryInitialCodes =
        {
            "t8436", //주식 마스터
            "t8425", //주식 테마
            "t8432", //파생 지수선물
            "t8433", //파생 지수옵션
            "t8435", //파생 마스터
            "t8424", //업종
            "t1981", //Elw 기초자산
            "t9942", //Elw 마스터
            "t9907", //Elw 만기월
        };

        public static readonly string[] QueryEventNames =
        {
            "CACBQ21900", //개별계좌정보 조회
            "CFOAQ50400", //선물옵션 계좌잔고 및 평가현황2
            
            "CFOEQ82700", //선물옵션 주야간 통합 손익 조회
            "CSPAQ02200", //현물계좌예수금 주문가능금액 총평가조회
            "CSPAQ02300", //BEP단가조회
            "CSPAQ03700", //현물계좌주문체결내역조회
            // "O01",
            "o3117", //해외선물차트용NTick(o3117)-API용

            "t0431", //선물/옵션잔고평가(주문팝업)(t0431)
           
            "t1833", //종목검색(씽API용)(t1833)
            "TH_", //OTCBB호가잔량(TH)
            "TS_", //OTCBB체결(TS)
        };

        public static readonly string[] QueryEventStockNames =
        {
            "CDPCQ04700", //계좌 거래내역
            "ChartExcel", //챠트엑셀데이터조회
            "ChartIndex", //챠트지표데이터조회
            "CLNAQ00100", //예탁담보융자가능종목현황조회
            "CSPAQ00600", //계좌별신용한도조회
            "CSPAQ12200", "CSPAQ12300", "CSPAQ13700",
            "CSPAQ22200", //???
            "CSPAT00600", "CSPAT00700", "CSPAT00800",
            "CSPBQ00200",
            "FOCCQ33600",
            "t0150", "t0151", "t0424", "t0425",
            "t1101", "t1102", "t1104", "t1105", "t1301", "t1302",
            "t1305", "t1308", "t1310", "t1403", "t1404", "t1405",
            "t1410", //????
            "t1411", "t1422",
            "t1427", "t1442", "t1444", "t1449", "t1452", "t1463", "t1471", "t1475",
            "t1485", "t1486", "t1488", "t1489", "t1511", "t1516", "t1531",
            "t1532", "t1533", "t1537", "t1601", "t1602", "t1603", "t1615", "t1617",
            "t1621", "t1631", "t1632", "t1633", "t1636", "t1637", "t1638", "t1640",
            "t1662", "t1664", "t1665", "t1701", "t1702", "t1717", "t1752", "t1764",
            "t1771", "t1809", "t1825", "t1826",
            "t1857", //??
            "t1866", //??
            "t1901", "t1902", "t1903",
            "t1904", "t1906", "t1921", "t1926", "t1927", "t1941",
            "t4201", "t8407",
            "t8411", "t8412", "t8413",
            "t8425",  "t8430",
            "t8436", //??
            "t9945",
        };

        public static readonly string[] QueryEventDerivativesNames =
        {
            "CCEAQ01100",
            "CCEAQ06000",
            "CCEAQ10100",
            "CCEAQ50600", "CCEAT00100", "CCEAT00200", "CCEAT00300", "CCEBQ10500",
            "CEXAQ21100", "CEXAQ21200", "CEXAQ31100", "CEXAQ31200",
            "CEXAQ44200",//??
            "CEXAT11100", "CEXAT11200", "CEXAT11300", "CFOAQ00600", "CFOAQ10100",
            "CFOAT00100", "CFOAT00200", "CFOAT00300", "CFOBQ10500", "CFOBQ10800", "CFOEQ11100",
            "CFOEQ82600",
            "CFOFQ02400",
            "FOCCQ33700",
            "MMDAQ91200",
            "t0434", "t0441",
            "t2101", "t2105",
            "t2106", "t2201", "t2203", "t2209", "t2210", "t2301", "t2405", "t2421",
            "t2541", "t2545", "t2801", "t2802", "t2804", "t2805", "t2813", "t2814",
            "t2816", "t2830", "t2831", "t2832", "t2833", "t2835", "t8401",
            "t8402", "t8403", "t8404", "t8405", "t8406",
            "t8408", "t8409",
            "t8414", "t8415", "t8416",  "t8426", "t8427", "t8429",
            "t8432", "t8433", "t8434",
            "t8435",//??
            "t9943", "t9944",
        };

        public static readonly string[] QueryEventInfoNames =
        {
            "t3102", "t3202",
            "t3320", "t3341", "t3401", "t3518", "t3521", "t8428",
        };

        public static readonly string[] QueryEventCategoryNames =
        {
            "t1514", "t4203", "t8417", "t8418",
            "t8419", "t8424",
        };

        public static readonly string[] QueryEventElwNames =
        {
            "t1950", "t1951", "t1954", "t1955", "t1956", "t1958", "t1959", "t1960", "t1961", "t1964", "t1966", "t1971",
            "t1972", "t1973", "t1974", "t1981", "t8431", "t9905", "t9907", "t9942",
        };

        public static readonly string[] QueryEventEtcNames =
        {
            "t0167",
        };

        public static readonly string[] RealEventStockNames =
        {
            "B7_", "DVI", "H1_", "H2_", "HA_", "HB_", "I5_", "IJ_", "K1_", "K3_",
            "KH_", "KM_", "KS_", "OK_", "PH_", "PM_", "S2_", "S3_", "S4_", "SC0", "SC1", "SC2", "SC3", "SC4", "SHC",
            "SHD", "SHI", "SHO", "VI_", "YJ_", "YK3", "YS3"
        };

        public static readonly string[] RealEventDerivativesNames =
        {
            "C01", "CD0", "CM0", "CM1", "CM2", "EC0", "EH0", "EU0", "EU1", "EU2", "FC0", "FD0", "FH0", "FX0", "H01",
            "JC0", "JD0", "JH0", "JX0", "NC0", "NH0", "OC0", "OD0", "OH0", "OMG", "OX0", "YC3", "YFC", "YJC",
            "YOC",
        };

        public static readonly string[] RealEventElwNames =
        {
            "ESN", "h2_4ELW", "h3_4ELW", "k1_4ELW", "s2_4ELW", "s3_4ELW", "s4_ELW", "Ys3_4ELW",
        };

        public static readonly string[] RealEventEtcNames =
        {
            "JIF",
            "NWS",
        };


        public static readonly string[] RealEventInfoNames =
        {
            "BMT",
            "MK2",
        };


        public static readonly string[] RealEventCategoryNames =
        {
            "BM_",
        };
    }
}