using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DataLib.util;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.real
{
    public delegate void InBlockQuery(ResModel resModel, IXAReal query, StringDict dict);

    public delegate void OutBlockQuery(ResModel resModel, IXAReal query, CsvWriter writer);
}