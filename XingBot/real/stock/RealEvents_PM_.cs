using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.res;

namespace XingBot
{
    public partial class RealEvents : _IXARealEvents
    {
        public void InBlock_PM_(string gubun)
        {
            string szTrCode = "PM_";
            _RealDict[szTrCode].SetFieldData("InBlock", "gubun", gubun);
        }

        private void OutBlock_PM_(string szTrCode)
        {
            _PM__OutBlock outData;
            outData.time = _RealDict[szTrCode].GetFieldData("OutBlock", "time");

            outData.cdhrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdhrem"));
            outData.cshrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cshrem"));
            outData.bdhrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdhrem"));
            outData.bshrem = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bshrem"));

            outData.cdhvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdhvolume"));
            outData.cshvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cshvolume"));
            outData.bdhvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdhvolume"));
            outData.bshvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bshvolume"));

            outData.cdwvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdwvolume"));
            outData.cdjvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdjvolume"));
            outData.cswvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cswvolume"));
            outData.csjvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "csjvolume"));
            outData.cwvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cwvol"));
            outData.cjvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cjvol"));
            outData.bdwvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdwvolume"));
            outData.bdjvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdjvolume"));
            outData.bswvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bswvolume"));
            outData.bsjvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bsjvolume"));
            outData.bwvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bwvol"));
            outData.bjvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bjvol"));
            outData.dwvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dwvolume"));
            outData.swvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "swvolume"));

            outData.wvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "wvol"));
            outData.djvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "djvolume"));
            outData.sjvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sjvolume"));
            outData.jvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jvol"));
            outData.cdwvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdwvalue"));
            outData.cdjvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdjvalue"));
            outData.cswvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cswvalue"));
            outData.csjvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "csjvalue"));
            outData.cwval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cwval"));
            outData.cjval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cjval"));
            outData.bdwvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdwvalue"));
            outData.bdjvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdjvalue"));
            outData.bswvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bswvalue"));
            outData.bsjvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bsjvalue"));
            outData.bwval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bwval"));
            outData.bjval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bjval"));
            outData.dwvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dwvalue"));
            outData.swvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "swvalue"));
            outData.wval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "wval"));
            outData.djvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "djvalue"));
            outData.sjvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "sjvalue"));
            outData.jval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "jval"));
            outData.k200jisu = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "k200jisu"));
            outData.k200sign = _RealDict[szTrCode].GetFieldData("OutBlock", "k200sign");
            outData.change = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "change"));
            outData.k200basis = float.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "k200basis"));

            outData.cdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdvolume"));
            outData.csvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "csvolume"));
            outData.cvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cvol"));
            outData.bdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdvolume"));
            outData.bsvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bsvolume"));
            outData.bvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bvol"));
            outData.tdvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tdvolume"));
            outData.tsvolume = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tsvolume"));
            outData.tvol = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tvol"));
            outData.cdvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cdvalue"));
            outData.csvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "csvalue"));
            outData.cval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "cval"));
            outData.bdvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bdvalue"));
            outData.bsvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bsvalue"));
            outData.bval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bval"));
            outData.tdvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tdvalue"));
            outData.tsvalue = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tsvalue"));
            outData.tval = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "tval"));

            outData.p_cdvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_cdvolcha"));
            outData.p_csvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_csvolcha"));
            outData.p_cvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_cvolcha"));
            outData.p_bdvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bdvolcha"));
            outData.p_bsvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bsvolcha"));
            outData.p_bvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bvolcha"));
            outData.p_tdvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tdvolcha"));
            outData.p_tsvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tsvolcha"));
            outData.p_tvolcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tvolcha"));
            outData.p_cdvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_cdvalcha"));
            outData.p_csvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_csvalcha"));
            outData.p_cvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_cvalcha"));
            outData.p_bdvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bdvalcha"));
            outData.p_bsvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bsvalcha"));
            outData.p_bvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_bvalcha"));
            outData.p_tdvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tdvalcha"));
            outData.p_tsvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tsvalcha"));
            outData.p_tvalcha = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "p_tvalcha"));

            outData.gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "gubun");
        }
    }
}