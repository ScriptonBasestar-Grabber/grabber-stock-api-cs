using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;
using XingBot.real.res;

namespace XingBot.real
{
    public partial class RealCtrl : _IXARealEvents
    {
        public void InBlock_k1_4ELW(string shcode)
        {
            string szTrCode = "k1_4ELW";
            _realDict[szTrCode].SetFieldData("InBlock", "shcode", shcode);
        }

        private void OutBlock_k1_4ELW(string szTrCode)
        {
            _k1_4ELW_OutBlock outData;
            outData.offerno1 = _realDict[szTrCode].GetFieldData("OutBlock", "offerno1");
            outData.bidno1 = _realDict[szTrCode].GetFieldData("OutBlock", "bidno1");
            outData.offertrad1 = _realDict[szTrCode].GetFieldData("OutBlock", "offertrad1");
            outData.bidtrad1 = _realDict[szTrCode].GetFieldData("OutBlock", "bidtrad1");
            outData.tradmdvol1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdvol1"));
            outData.tradmsvol1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsvol1"));
            outData.tradmdrate1 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdrate1"));
            outData.tradmsrate1 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsrate1"));
            outData.tradmdcha1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdcha1"));
            outData.tradmscha1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmscha1"));

            outData.offerno2 = _realDict[szTrCode].GetFieldData("OutBlock", "offerno2");
            outData.bidno2 = _realDict[szTrCode].GetFieldData("OutBlock", "bidno2");
            outData.offertrad2 = _realDict[szTrCode].GetFieldData("OutBlock", "offertrad2");
            outData.bidtrad2 = _realDict[szTrCode].GetFieldData("OutBlock", "bidtrad2");
            outData.tradmdvol2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdvol2"));
            outData.tradmsvol2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsvol2"));
            outData.tradmdrate2 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdrate2"));
            outData.tradmsrate2 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsrate2"));
            outData.tradmdcha2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdcha2"));
            outData.tradmscha2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmscha2"));

            outData.offerno3 = _realDict[szTrCode].GetFieldData("OutBlock", "offerno3");
            outData.bidno3 = _realDict[szTrCode].GetFieldData("OutBlock", "bidno3");
            outData.offertrad3 = _realDict[szTrCode].GetFieldData("OutBlock", "offertrad3");
            outData.bidtrad3 = _realDict[szTrCode].GetFieldData("OutBlock", "bidtrad3");
            outData.tradmdvol3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdvol3"));
            outData.tradmsvol3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsvol3"));
            outData.tradmdrate3 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdrate3"));
            outData.tradmsrate3 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsrate3"));
            outData.tradmdcha3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdcha3"));
            outData.tradmscha3 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmscha3"));

            outData.offerno4 = _realDict[szTrCode].GetFieldData("OutBlock", "offerno4");
            outData.bidno4 = _realDict[szTrCode].GetFieldData("OutBlock", "bidno4");
            outData.offertrad4 = _realDict[szTrCode].GetFieldData("OutBlock", "offertrad4");
            outData.bidtrad4 = _realDict[szTrCode].GetFieldData("OutBlock", "bidtrad4");
            outData.tradmdvol4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdvol4"));
            outData.tradmsvol4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsvol4"));
            outData.tradmdrate4 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdrate4"));
            outData.tradmsrate4 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsrate4"));
            outData.tradmdcha4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdcha4"));
            outData.tradmscha4 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmscha4"));

            outData.offerno5 = _realDict[szTrCode].GetFieldData("OutBlock", "offerno5");
            outData.bidno5 = _realDict[szTrCode].GetFieldData("OutBlock", "bidno5");
            outData.offertrad5 = _realDict[szTrCode].GetFieldData("OutBlock", "offertrad5");
            outData.bidtrad5 = _realDict[szTrCode].GetFieldData("OutBlock", "bidtrad5");
            outData.tradmdvol5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdvol5"));
            outData.tradmsvol5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsvol5"));
            outData.tradmdrate5 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdrate5"));
            outData.tradmsrate5 = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmsrate5"));
            outData.tradmdcha5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmdcha5"));
            outData.tradmscha5 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "tradmscha5"));

            outData.ftradmdvol = _realDict[szTrCode].GetFieldData("OutBlock", "ftradmdvol");
            outData.ftradmsvol = _realDict[szTrCode].GetFieldData("OutBlock", "ftradmsvol");
            outData.ftradmdrate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ftradmdrate"));
            outData.ftradmsrate = float.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ftradmsrate"));
            outData.ftradmdcha = _realDict[szTrCode].GetFieldData("OutBlock", "ftradmdcha");
            outData.ftradmscha = _realDict[szTrCode].GetFieldData("OutBlock", "ftradmscha");
            outData.shcode = _realDict[szTrCode].GetFieldData("OutBlock", "shcode");
        }
    }
}