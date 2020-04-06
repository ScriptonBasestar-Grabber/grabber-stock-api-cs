using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.tr
{
    public delegate void InBlockQuery(string szTrCode, Block inBlock, IXAQuery query);
    public delegate void OutBlockQuery(string szTrCode, Block outBlock, IXAQuery query);
}
