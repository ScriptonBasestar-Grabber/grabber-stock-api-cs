using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using XA_DATASETLib;
using XingBot.real.Properties;
using XingBot.real.res;
using XingBot.tr;

namespace XingBot.tr
{

    public class QueryEvents
    {
        private readonly IXAQuery _ixa;
        private readonly ResModel _resModel;
        private readonly string _szTrCode;

        public QueryEvents(string szTrCode)
        {
            this._szTrCode = szTrCode;

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;
            Guid iidQueryEvents = typeof(_IXAQueryEvents).GUID;

            this._ixa = new XAQuery
            {
                ResFileName = Settings.Default.root_path + @"\res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer) _ixa;
            icpc.FindConnectionPoint(ref iidQueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            _resModel = ReadResFile.Read(Path.Combine(Settings.Default.root_path, szTrCode));
        }

        public void InBlock(InBlockQuery action)
        {
            action(_szTrCode, _resModel.Blocks["InBlock"], _ixa);
        }

        public void OutBlock(string szTrCode, OutBlockQuery action, InBlockQuery inAction)
        {
            for (var i = 0; i < _ixa.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                action(szTrCode, _resModel.Blocks["OutBlock"], _ixa);
            }
            // InBlock1();
            inAction(_szTrCode, _resModel.Blocks["InBlock"], _ixa);
        }

        // public abstract void InBlock1();
    }
}