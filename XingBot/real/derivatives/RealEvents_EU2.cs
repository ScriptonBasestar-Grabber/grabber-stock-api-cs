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
        public void InBlock_EU2(string optcode)
        {
            string szTrCode = "EU2";
            // _realDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_EU2(string szTrCode)
        {
            _EU2_OutBlock outData;
            outData.lineseq = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lineseq"));
            outData.accno = _realDict[szTrCode].GetFieldData("OutBlock", "accno");
            outData.user = _realDict[szTrCode].GetFieldData("OutBlock", "user");
            outData.len = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "len"));
            outData.gubun = _realDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.compress = _realDict[szTrCode].GetFieldData("OutBlock", "compress");
            outData.encrypt = _realDict[szTrCode].GetFieldData("OutBlock", "encrypt");
            outData.offset = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "offset"));
            outData.trcode = _realDict[szTrCode].GetFieldData("OutBlock", "trcode");
            outData.compid = _realDict[szTrCode].GetFieldData("OutBlock", "compid");
            outData.userid = _realDict[szTrCode].GetFieldData("OutBlock", "userid");
            outData.media = _realDict[szTrCode].GetFieldData("OutBlock", "media");
            outData.ifid = _realDict[szTrCode].GetFieldData("OutBlock", "ifid");
            outData.seq = _realDict[szTrCode].GetFieldData("OutBlock", "seq");
            outData.trid = _realDict[szTrCode].GetFieldData("OutBlock", "trid");
            outData.pubip = _realDict[szTrCode].GetFieldData("OutBlock", "pubip");
            outData.prvip = _realDict[szTrCode].GetFieldData("OutBlock", "prvip");
            outData.pcbpno = _realDict[szTrCode].GetFieldData("OutBlock", "pcbpno");
            outData.bpno = _realDict[szTrCode].GetFieldData("OutBlock", "bpno");
            outData.termno = _realDict[szTrCode].GetFieldData("OutBlock", "termno");
            outData.lang = _realDict[szTrCode].GetFieldData("OutBlock", "lang");
            outData.proctm = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "proctm"));
            outData.msgcode = _realDict[szTrCode].GetFieldData("OutBlock", "msgcode");
            outData.outgu = _realDict[szTrCode].GetFieldData("OutBlock", "outgu");
            outData.compreq = _realDict[szTrCode].GetFieldData("OutBlock", "compreq");
            outData.funckey = _realDict[szTrCode].GetFieldData("OutBlock", "funckey");
            outData.reqcnt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "reqcnt"));
            outData.filler = _realDict[szTrCode].GetFieldData("OutBlock", "filler");
            outData.cont = _realDict[szTrCode].GetFieldData("OutBlock", "cont");
            outData.contkey = _realDict[szTrCode].GetFieldData("OutBlock", "contkey");
            outData.varlen = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "varlen"));
            outData.varhdlen = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "varhdlen"));
            outData.varmsglen = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "varmsglen"));
            outData.trsrc = _realDict[szTrCode].GetFieldData("OutBlock", "trsrc");
            outData.eventid = _realDict[szTrCode].GetFieldData("OutBlock", "eventid");
            outData.ifinfo = _realDict[szTrCode].GetFieldData("OutBlock", "ifinfo");
            outData.filler1 = _realDict[szTrCode].GetFieldData("OutBlock", "filler1");
            outData.trcode1 = _realDict[szTrCode].GetFieldData("OutBlock", "trcode1");
            outData.firmno = _realDict[szTrCode].GetFieldData("OutBlock", "firmno");
            outData.acntno = _realDict[szTrCode].GetFieldData("OutBlock", "acntno");
            outData.acntno1 = _realDict[szTrCode].GetFieldData("OutBlock", "acntno1");
            outData.acntnm = _realDict[szTrCode].GetFieldData("OutBlock", "acntnm");
            outData.brnno = _realDict[szTrCode].GetFieldData("OutBlock", "brnno");
            outData.ordmktcode = _realDict[szTrCode].GetFieldData("OutBlock", "ordmktcode");
            outData.ordno1 = _realDict[szTrCode].GetFieldData("OutBlock", "ordno1");
            outData.ordno = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ordno"));
            outData.orgordno1 = _realDict[szTrCode].GetFieldData("OutBlock", "orgordno1");
            outData.orgordno = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "orgordno"));
            outData.prntordno = _realDict[szTrCode].GetFieldData("OutBlock", "prntordno");
            outData.prntordno1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "prntordno1"));
            outData.isuno = _realDict[szTrCode].GetFieldData("OutBlock", "isuno");
            outData.fnoIsuno = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno");
            outData.fnoIsunm = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsunm");
            outData.pdgrpcode = _realDict[szTrCode].GetFieldData("OutBlock", "pdgrpcode");
            outData.fnoIsuptntp = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuptntp");
            outData.bnstp = _realDict[szTrCode].GetFieldData("OutBlock", "bnstp");
            outData.mrctp = _realDict[szTrCode].GetFieldData("OutBlock", "mrctp");
            outData.ordqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ordqty"));
            outData.hogatype = _realDict[szTrCode].GetFieldData("OutBlock", "hogatype");
            outData.mmgb = _realDict[szTrCode].GetFieldData("OutBlock", "mmgb");
            outData.ordprc = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ordprc"));
            outData.unercqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "unercqty"));
            outData.commdacode = _realDict[szTrCode].GetFieldData("OutBlock", "commdacode");
            outData.peeamtcode = _realDict[szTrCode].GetFieldData("OutBlock", "peeamtcode");
            outData.mgempno = _realDict[szTrCode].GetFieldData("OutBlock", "mgempno");
            outData.fnotrdunitamt = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "fnotrdunitamt"));
            outData.trxtime = _realDict[szTrCode].GetFieldData("OutBlock", "trxtime");
            outData.strtgcode = _realDict[szTrCode].GetFieldData("OutBlock", "strtgcode");
            outData.grpId = _realDict[szTrCode].GetFieldData("OutBlock", "grpId");
            outData.ordseqno = _realDict[szTrCode].GetFieldData("OutBlock", "ordseqno");
            outData.ptflno = _realDict[szTrCode].GetFieldData("OutBlock", "ptflno");
            outData.bskno = _realDict[szTrCode].GetFieldData("OutBlock", "bskno");
            outData.trchno = _realDict[szTrCode].GetFieldData("OutBlock", "trchno");
            outData.Itemno = _realDict[szTrCode].GetFieldData("OutBlock", "Itemno");
            outData.OrderID = _realDict[szTrCode].GetFieldData("OutBlock", "OrderID");
            outData.opdrtnno = _realDict[szTrCode].GetFieldData("OutBlock", "opdrtnno");
            outData.rjtcode = _realDict[szTrCode].GetFieldData("OutBlock", "rjtcode");
            outData.mrccnfqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mrccnfqty"));
            outData.orgordunercqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "orgordunercqty"));
            outData.orgordmrcqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "orgordmrcqty"));
            outData.ctrcttime = _realDict[szTrCode].GetFieldData("OutBlock", "ctrcttime");
            outData.ctrctno = _realDict[szTrCode].GetFieldData("OutBlock", "ctrctno");
            outData.execprc = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "execprc"));
            outData.execqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "execqty"));
            outData.newqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "newqty"));
            outData.qdtqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "qdtqty"));
            outData.lastqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lastqty"));
            outData.lallexecqty = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lallexecqty"));
            outData.allexecamt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "allexecamt"));
            outData.fnobalevaltp = _realDict[szTrCode].GetFieldData("OutBlock", "fnobalevaltp");
            outData.bnsplamt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "bnsplamt"));
            outData.fnoIsuno1 = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno1");
            outData.bnstp1 = _realDict[szTrCode].GetFieldData("OutBlock", "bnstp1");
            outData.execprc1 = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "execprc1"));
            outData.newqty1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "newqty1"));
            outData.qdtqty1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "qdtqty1"));
            outData.allexecamt1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "allexecamt1"));
            outData.fnoIsuno2 = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno2");
            outData.bnstp2 = _realDict[szTrCode].GetFieldData("OutBlock", "bnstp2");
            outData.execprc2 = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "execprc2"));
            outData.newqty2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "newqty2"));
            outData.lqdtqty2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lqdtqty2"));
            outData.allexecamt2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "allexecamt2"));
            outData.dps = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "dps"));
            outData.ftsubtdsgnamt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ftsubtdsgnamt"));
            outData.mgn = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mgn"));
            outData.mnymgn = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mnymgn"));
            outData.ordableamt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "ordableamt"));
            outData.mnyordableamt = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "mnyordableamt"));
            outData.fnoIsuno_1 = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno_1");
            outData.bnstp_1 = _realDict[szTrCode].GetFieldData("OutBlock", "bnstp_1");
            outData.unsttqty_1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "unsttqty_1"));
            outData.lqdtableqty_1 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lqdtableqty_1"));
            outData.avrprc_1 = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "avrprc_1"));
            outData.fnoIsuno_2 = _realDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno_2");
            outData.bnstp_2 = _realDict[szTrCode].GetFieldData("OutBlock", "bnstp_2");
            outData.unsttqty_2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "unsttqty_2"));
            outData.lqdtableqty_2 = long.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "lqdtableqty_2"));
            outData.avrprc_2 = decimal.Parse(_realDict[szTrCode].GetFieldData("OutBlock", "avrprc_2"));
        }
    }
}
