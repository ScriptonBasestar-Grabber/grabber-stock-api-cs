using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DataLib.util;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.tr
{
    public delegate void InBlockQuery(string szTrCode, IXAQuery query, Block inBlock, StringDict dict);

    public delegate void OutBlockQuery(string szTrCode, IXAQuery query, Block outBlock, CsvWriter writer);
}