using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;
using XingBot.Properties;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        private readonly Dictionary<string, IXAReal> _realDict = new Dictionary<string, IXAReal>();

        public RealCtrl(string[] codes)
        {
            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid iidRealEvents = typeof(_IXARealEvents).GUID;

            foreach (var code in codes)
            {
                // dwCookie = 0;
                _realDict[code] = new XAReal
                {
                    ResFileName = Settings.Default.root_path + @"\res\" + code + ".res"
                };
                icpc = (IConnectionPointContainer) _realDict[code];
                icpc.FindConnectionPoint(ref iidRealEvents, out icp);
                icp.Advise(this, out dwCookie);
            }

            Console.WriteLine("RealEvents 생성자완료");
        }

        // Real
        void _IXARealEvents.ReceiveRealData(string szTrCode)
        {
            // OutBlock_FC0(szTrCode);
            // if (szTrCode == "FC0")
            // {
            // }
            // else if (szTrCode == "FH0")
            // {
            // }
            // else if (szTrCode == "OC0")
            // {
            // }
            // else if (szTrCode == "OH0")
            // {
            // }
        }

        void _IXARealEvents.RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
            throw new System.NotImplementedException();
        }
    }
}