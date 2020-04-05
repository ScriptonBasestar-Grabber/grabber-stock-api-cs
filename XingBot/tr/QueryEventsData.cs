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
    public delegate void InBlockQuery(IXAQuery query);
    public class QueryEventsData
    {
        private IXAQuery query;
        private Result result;
        public QueryEventsData(string szTrCode, IXAQuery query, Action<IXAQuery> action)
        {
            this.query = query;
            result = ReadResFile.read(Path.Combine(Settings.Default.root_path, szTrCode));
            action(query);
        }

        private void OutBlock(string szTrCode)
        {
            for (var i = 0; i < query.GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                foreach(Row row in result.Blocks["OutBlock"].rows)
                {
                    query.GetFieldData(szTrCode + "OutBlock", row.Name, i);
                }
            }
        }
    }
}