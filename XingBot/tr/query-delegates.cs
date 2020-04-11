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

namespace XingBot.tr
{
    public delegate void InBlockQuery(ResModel resModel, IXAQuery query, StringDict dict);

    public delegate void OutBlockQuery(ResModel resModel, IXAQuery query, CsvWriter writer);
}