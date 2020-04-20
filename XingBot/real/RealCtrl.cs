using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using DataLib.model;
using DataLib.util;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.real
{
    public class RealCtrl
    {
        private readonly Dictionary<Tuple<string, string>, RealEvents> _realDict = new Dictionary<Tuple<string, string>, RealEvents>();

        /**
         * 주식 전종목
         */
        public void RealStockALL()
        {
            List<CodeStock> codeStocks = new List<CodeStock>(Constants.CodeStocks.Values);
            string[] shcodes = codeStocks.Select(codeStock => codeStock.Code).ToArray();
            var codeName = "shcode";
            CallReal("DVI", codeName, shcodes);
            CallReal("VI_", codeName, shcodes);
            //KOSPI
            CallReal("PM_", "gubun", "0");
            //KOSDAQ
            CallReal("PM_", "gubun", "1");
            //KOSPI
            CallReal("KM_", "gubun", "0");
            //KOSDAQ
            CallReal("KM_", "gubun", "1");
            //상한가 진입
            //CallReal("SHC", updnlmtgubun, "1");
            //CallReal("SHD", updnlmtgubun, "1");
            //CallReal("SHI", updnlmtgubun, "1");
            //CallReal("SHO", updnlmtgubun, "1");
            //하한가 진입
            //CallReal("SHC", updnlmtgubun, "4");
            //CallReal("SHD", updnlmtgubun, "4");
            //CallReal("SHI", updnlmtgubun, "4");
            //CallReal("SHO", updnlmtgubun, "4");
        }

        public void RealStockKOSPI()
        {
            List<CodeStock> codeStocks = new List<CodeStock>(Constants.CodeStocks.Values);
            string[] shcodes = codeStocks.Where(codeStock => codeStock.MarketGubun == "1").Select(codeStock => codeStock.Code).ToArray();
            var codeName = "shcode";
            CallReal("H1_", codeName, shcodes);
            CallReal("H2_", codeName, shcodes);
            CallReal("I5_", codeName, shcodes);
            CallReal("K1_", codeName, shcodes);
            CallReal("PH_", codeName, shcodes);
            CallReal("S2_", codeName, shcodes);
            CallReal("S3_", codeName, shcodes);
            CallReal("S4_", codeName, shcodes);
            // CallReal("SC0", codeName, shcodes);
            // CallReal("SC1", codeName, shcodes);
            // CallReal("SC2", codeName, shcodes);
            // CallReal("SC3", codeName, shcodes);
            // CallReal("SC4", codeName, shcodes);
            CallReal("YS3", codeName, shcodes);
        }

        public void RealStockKOSDAQ()
        {
            List<CodeStock> codeStocks = new List<CodeStock>(Constants.CodeStocks.Values);
            string[] shcodes = codeStocks.Where(codeStock => codeStock.MarketGubun == "2").Select(codeStock => codeStock.Code).ToArray();
            var codeName = "shcode";
            CallReal("B7_", codeName, shcodes);
            CallReal("HA_", codeName, shcodes);
            CallReal("HB_", codeName, shcodes);
            CallReal("K3_", codeName, shcodes);
            CallReal("KH_", codeName, shcodes);
            CallReal("KS_", codeName, shcodes);
            CallReal("OK_", codeName, shcodes);
            CallReal("YK3", codeName, shcodes);
        }

        public void RealStockSector()
        {
            List<CodeSector> codeSectors = new List<CodeSector>(Constants.CodeSectors.Values);
            string[] upcodes = codeSectors.Select(codeSector => codeSector.Code).ToArray();
            var codeName = "upcode";
            CallReal("IJ_", codeName, upcodes);
            CallReal("YJ_", codeName, upcodes);
            CallReal("BMT", codeName, upcodes);
            CallReal("BM_", codeName, upcodes);
        }
        private void CallReal(string szTrCode, string codeName, string code)
        {
            CallReal(szTrCode, codeName, new string[1] { code });
        }

        private void CallReal(string szTrCode, string codeName, string[] codes)
        {
            foreach (var shcode in codes)
            {
                this._realDict[Tuple.Create(szTrCode, shcode)] = new RealEvents(szTrCode);
                this._realDict[Tuple.Create(szTrCode, shcode)].Start(shcode, new StringDict()
                {
                    [codeName] = shcode
                });
            }
        }
        //private void CallReal(string szTrCode, string codeName, string code)
        //{
        //    CallReal(szTrCode, codeName, new string[1] { code });
        //}
        public void RealDerivativesKospi200Futures()
        {
            List<CodeFutures> codeK200Futures = new List<CodeFutures>(Constants.CodeFutures.Values);
            string[] fucodes = codeK200Futures.Select(code => code.Code).ToArray();
            var codeName = "fucode";
            //CallReal("C01",codeName, fucodes);
            //CallReal("CM0",codeName, fucodes);
            //CallReal("CM1",codeName, fucodes);
            //CallReal("CM2",codeName, fucodes);
            //CallReal("H01",codeName, fucodes);

            CallReal("FC0",codeName, fucodes);
            CallReal("FD0",codeName, fucodes);
            CallReal("FH0",codeName, fucodes);
            CallReal("FX0",codeName, fucodes);
            CallReal("NC0",codeName, fucodes);
            CallReal("NH0", codeName, fucodes);
            //CallReal("O01",codeName, fucodes);
            CallReal("YFC", codeName, fucodes);
        }
        public void RealDerivativesKospi200Options()
        {
            List<CodeOptions> codeK200Option = new List<CodeOptions>(Constants.CodeOptions.Values);
            string[] optcodes = codeK200Option.Select(code => code.Code).ToArray();
            var codeName = "optcode";
            CallReal("EC0", codeName, optcodes);
            CallReal("EH0", codeName, optcodes);
            //CallReal("EU0", codeName, optcodes);
            //CallReal("EU1", codeName, optcodes);
            //CallReal("EU2", codeName, optcodes);
            CallReal("OC0", codeName, optcodes);
            CallReal("OD0", codeName, optcodes);
            CallReal("OH0", codeName, optcodes);
            CallReal("OMG", codeName, optcodes);
            CallReal("OX0", codeName, optcodes);
            CallReal("YOC", codeName, optcodes);
        }

        //public void RealDerivativesStockFutures()
        //{
        //    var codeName = "fucode";
        //    CallReal("JC0", codeName, fucodes);
        //    CallReal("JD0", codeName, fucodes);
        //    CallReal("JH0", codeName, fucodes);
        //    CallReal("JX0", codeName, fucodes);
        //    CallReal("YJC", codeName, fucodes);
        //}

        //public void RealDerivativeCommodityFutures()
        //{
        //    var codeName = "fucode";
        //    CallReal("CD0", codeName, fucodes);
        //    CallReal("YC3", codeName, fucodes);
        //}

        //public void RealDerivativesELW()
        //{
        //    var codeName = "shcode";
        //    CallReal("ESN", codeName, shcodes);
        //    CallReal("h2_4ELW", codeName, shcodes);
        //    CallReal("h3_4ELW", codeName, shcodes);
        //    CallReal("k1_4ELW", codeName, shcodes);
        //    CallReal("s2_4ELW", codeName, shcodes);
        //    CallReal("s3_4ELW", codeName, shcodes);
        //    CallReal("s4_ELW", codeName, shcodes);
        //    CallReal("Ys3_4ELW", codeName, shcodes);
        //}

        public void Etc()
        {
            CallReal("JIF", "jangubun",  "0");
            CallReal("NWS", "nwcode", "NWS001");
        }

    }
}