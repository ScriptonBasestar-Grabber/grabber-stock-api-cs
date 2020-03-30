using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;

namespace XingBot
{
    public partial class RealEvents : _IXARealEvents
    {
        private Dictionary<string, IXAReal> _RealDict = new Dictionary<string, IXAReal>();

        public RealEvents(string[] codes)
        {
            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid IID_RealEvents = typeof(_IXARealEvents).GUID;

            foreach (var code in codes)
            {
                // dwCookie = 0;
                _RealDict[code] = new XAReal
                {
                    ResFileName = Properties.Settings.Default.root_path + @"\res\" + code + ".res"
                };
                icpc = (IConnectionPointContainer)_RealDict[code];
                icpc.FindConnectionPoint(ref IID_RealEvents, out icp);
                icp.Advise(this, out dwCookie);
            }

            Console.WriteLine("RealEvents 생성자완료");
        }

        // Real
        void _IXARealEvents.ReceiveRealData(string szTrCode)
        {
            if (szTrCode == "FC0")
            {
                OutBlock_FC0(szTrCode);
            }
            else if (szTrCode == "FH0")
            {
            }
            else if (szTrCode == "OC0")
            {
            }
            else if (szTrCode == "OH0")
            {
            }
        }

        void _IXARealEvents.RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
            throw new System.NotImplementedException();
        }
    }
}