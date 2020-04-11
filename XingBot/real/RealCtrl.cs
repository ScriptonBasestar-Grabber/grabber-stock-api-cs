using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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
        public void RealStockALL(string[] shcodes)
        {
            CallReal("DVI", shcodes);
            CallReal("SHC", shcodes);
            CallReal("SHD", shcodes);
            CallReal("SHI", shcodes);
            CallReal("SHO", shcodes);
            CallReal("VI_", shcodes);
        }

        public void RealStockKOSPI(string[] shcodes)
        {
            CallReal("H1_", shcodes);
            CallReal("H2_", shcodes);
            CallReal("I5_", shcodes);
            CallReal("K1_", shcodes);
            CallReal("PH_", shcodes);
            CallReal("PM_", shcodes);
            CallReal("S2_", shcodes);
            CallReal("S3_", shcodes);
            CallReal("S4_", shcodes);
            // CallReal("SC0", shcodes);
            // CallReal("SC1", shcodes);
            // CallReal("SC2", shcodes);
            // CallReal("SC3", shcodes);
            // CallReal("SC4", shcodes);
            CallReal("YS3", shcodes);
        }

        public void RealStockKOSDAQ(string[] shcodes)
        {
            CallReal("B7_", shcodes);
            CallReal("HA_", shcodes);
            CallReal("HB_", shcodes);
            CallReal("K3_", shcodes);
            CallReal("KH_", shcodes);
            CallReal("KM_", shcodes);
            CallReal("KS_", shcodes);
            CallReal("OK_", shcodes);
            CallReal("YK3", shcodes);
        }

        public void RealStockSector(string[] seccodes)
        {
            CallReal("IJ_", seccodes);
            CallReal("YJ_", seccodes);
        }

        private void CallReal(string szTrCode, string[] codes)
        {
            foreach (var shcode in codes)
            {
                this._realDict[Tuple.Create(szTrCode, shcode)] = new RealEvents(szTrCode);
                this._realDict[Tuple.Create(szTrCode, shcode)].Start(new StringDict()
                {
                    ["shcode"] = shcode
                });
            }
        }
        public void RealDerivativesKospi200Futures(string[] shcodes)
        {
            CallReal("C01", shcodes);
            CallReal("CD0", shcodes);
            CallReal("CM0", shcodes);
            CallReal("CM1", shcodes);
            CallReal("CM2", shcodes);
            CallReal("EC0", shcodes);
            CallReal("EH0", shcodes);
            CallReal("EU0", shcodes);
            CallReal("EU1", shcodes);
            CallReal("EU2", shcodes);
            CallReal("FC0", shcodes);
            CallReal("FD0", shcodes);
            CallReal("FH0", shcodes);
            CallReal("FX0", shcodes);
            CallReal("H01", shcodes);
            CallReal("JC0", shcodes);
            CallReal("JD0", shcodes);
            CallReal("JH0", shcodes);
            CallReal("JX0", shcodes);
            CallReal("NC0", shcodes);
            CallReal("NH0", shcodes);
            CallReal("O01", shcodes);
            CallReal("OC0", shcodes);
            CallReal("OD0", shcodes);
            CallReal("OH0", shcodes);
            CallReal("OMG", shcodes);
            CallReal("OC0", shcodes);
            CallReal("YC3", shcodes);
            CallReal("YFC", shcodes);
            CallReal("YJC", shcodes);
            CallReal("YOC", shcodes);
        }
        public void RealDerivativesKospi200Options(string[] shcodes)
        {
            
        }

        public void RealDerivativesStockFutures(string[] fucodes)
        {

        }

        public void RealDerivativeCommodityFutures(string[] fucodes)
        {

        }

        public void RealDerivativesELW(string[] shcode)
        {

        }

    }
}