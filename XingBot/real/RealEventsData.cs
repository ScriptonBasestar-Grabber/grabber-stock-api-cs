using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.res;

namespace XingBot
{
    public delegate void InBlockReal(IXAReal query);
    public class RealEventsData
    {
        private IXAReal real;
        private Result result;
        public RealEventsData(string szTrCode, IXAReal query, Action<IXAReal> action)
        {
            this.real = query;
            result = ReadResFile.read(Path.Combine(Settings.Default.root_path, szTrCode));
            action(query);
        }

        private void OutBlock(string szTrCode)
        {
            foreach(Row row in result.Blocks["OutBlock"].rows)
            {
                real.GetFieldData("OutBlock", row.Name);
            }
        }
    }
}