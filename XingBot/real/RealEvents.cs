using System;
using System.IO;
using XA_DATASETLib;
using XingBot.real.Properties;
using XingBot.real.res;

namespace XingBot.real
{
    public delegate void InBlockReal(IXAReal query);
    public class RealEvents
    {
        private readonly IXAReal _ixa;
        private readonly ResModel _resModel;
        public RealEvents(string szTrCode, IXAReal query, Action<IXAReal> action)
        {
            this._ixa = query;
            _resModel = ReadResFile.Read(Path.Combine(Settings.Default.root_path, szTrCode));
            action(query);
        }

        private void OutBlock(string szTrCode)
        {
            foreach(Row row in _resModel.Blocks["OutBlock"].Rows)
            {
                //TODO stream out
                _ixa.GetFieldData("OutBlock", row.Name);
            }
        }
    }
}