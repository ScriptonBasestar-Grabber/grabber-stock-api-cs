using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_KM_(string gubun)
        {
            string szTrCode = "KM_";
            _realDict[szTrCode].SetFieldData("InBlock", "gubun", gubun);
        }

        private void OutBlock_KM_(string szTrCode)
        {
            _KM__OutBlock outData;
            outData.time = _realDict[szTrCode].GetFieldData("OutBlock", "time");
            outData.cdhrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdhrem"));
            outData.cshrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cshrem"));
            outData.bdhrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdhrem"));
            outData.bshrem = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bshrem"));
            outData.cdhvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdhvolume"));
            outData.cshvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cshvolume"));
            outData.bdhvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdhvolume"));
            outData.bshvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bshvolume"));
            outData.cdwvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdwvolume"));

            outData.cdjvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdjvolume"));

            outData.cswvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cswvolume"));

            outData.csjvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "csjvolume"));

            outData.cwvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cwvol"));

            outData.cjvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cjvol"));

            outData.bdwvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdwvolume"));

            outData.bdjvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdjvolume"));

            outData.bswvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bswvolume"));

            outData.bsjvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bsjvolume"));

            outData.bwvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bwvol"));

            outData.bjvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bjvol"));

            outData.dwvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dwvolume"));

            outData.swvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "swvolume"));

            outData.wvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "wvol"));

            outData.djvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "djvolume"));

            outData.sjvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "sjvolume"));

            outData.jvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jvol"));

            outData.cdwvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdwvalue"));

            outData.cdjvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdjvalue"));


            outData.cswvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cswvalue"));

            outData.csjvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "csjvalue"));

            outData.cwval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cwval"));

            outData.cjval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cjval"));

            outData.bdwvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdwvalue"));

            outData.bdjvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdjvalue"));

            outData.bswvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bswvalue"));

            outData.bsjvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bsjvalue"));

            outData.bwval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bwval"));

            outData.bjval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bjval"));

            outData.dwvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dwvalue"));

            outData.swvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "swvalue"));

            outData.wval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "wval"));

            outData.djvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "djvalue"));

            outData.sjvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "sjvalue"));


            outData.jval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "jval"));

            outData.k50jisu = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "k50jisu"));

            outData.k50sign = _realDict[szTrCode].GetFieldData("OutBlock", "k50sign");
            outData.change = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "change"));

            outData.k50basis = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "k50basis"));

            outData.cdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdvolume"));

            outData.csvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "csvolume"));

            outData.cvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cvol"));

            outData.bdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdvolume"));

            outData.bsvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bsvolume"));

            outData.bvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bvol"));

            outData.tdvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tdvolume"));

            outData.tsvolume = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tsvolume"));

            outData.tvol = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tvol"));

            outData.cdvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cdvalue"));

            outData.csvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "csvalue"));

            outData.cval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "cval"));

            outData.bdvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bdvalue"));

            outData.bsvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bsvalue"));

            outData.bval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bval"));

            outData.tdvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tdvalue"));

            outData.tsvalue = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tsvalue"));

            outData.tval = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tval"));

            outData.p_cdvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_cdvolcha"));

            outData.p_csvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_csvolcha"));

            outData.p_cvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_cvolcha"));

            outData.p_bdvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bdvolcha"));

            outData.p_bsvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bsvolcha"));

            outData.p_bvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bvolcha"));

            outData.p_tdvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tdvolcha"));

            outData.p_tsvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tsvolcha"));

            outData.p_tvolcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tvolcha"));

            outData.p_cdvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_cdvalcha"));

            outData.p_csvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_csvalcha"));

            outData.p_cvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_cvalcha"));

            outData.p_bdvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bdvalcha"));

            outData.p_bsvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bsvalcha"));

            outData.p_bvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_bvalcha"));

            outData.p_tdvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tdvalcha"));

            outData.p_tsvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tsvalcha"));

            outData.p_tvalcha = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "p_tvalcha"));

            outData.gubun = _realDict[szTrCode].GetFieldData("OutBlock", "gubun");
        }
    }
}