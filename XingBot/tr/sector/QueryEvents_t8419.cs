using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot
{


    public partial class QueryCtrl : _IXAQueryEvents
    {
        public void InBlock_t8419()
        {
            string szTrCode = "t8419";
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "shcode", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "gubun", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "qrycnt", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "sdate", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "edate", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "cts_date", 0, "");
            _QueryDict[szTrCode].SetFieldData(szTrCode + "InBlock", "comp_yn", 0, "");
        }

        private void OutBlock_t8419(string szTrCode)
        {
            for (var i = 0; i < _QueryDict[szTrCode].GetBlockCount(szTrCode + "OutBlock"); i++)
            {
                _t8419OutBlock outData;
                outData.shcode = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "shcode", i);
                outData.jisiga = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jisiga", i));
                outData.jihigh = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jihigh", i));
                outData.jilow = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jilow", i));
                outData.jiclose = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jiclose", i));
                outData.jivolume = long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "jivolume", i));
                outData.disiga = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "disiga", i));
                outData.dihigh = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "dihigh", i));
                outData.dilow = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "dilow", i));
                outData.diclose = float.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "diclose", i));
                outData.disvalue = long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "disvalue", i));
                outData.cts_date = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "cts_date", i);
                outData.s_time = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "s_time", i);
                outData.e_time = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "e_time", i);
                outData.dshmin = _QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "dshmin", i);
                outData.rec_count = long.Parse(_QueryDict[szTrCode].GetFieldData(szTrCode + "OutBlock", "rec_count", i));
            }
        }

        private void OutBlock1_t8419(string szTrCode)
        {

        }
    }
}