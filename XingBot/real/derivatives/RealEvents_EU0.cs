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
        public void InBlock_EU0(string optcode)
        {
            string szTrCode = "EU0";
            // _RealDict[szTrCode].SetFieldData("InBlock", "optcode", optcode);
        }

        private void OutBlock_EU0(string szTrCode)
        {
            _EU0_OutBlock outData;
            outData.lineseq = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lineseq"));
            outData.accno = _RealDict[szTrCode].GetFieldData("OutBlock", "accno");
            outData.user = _RealDict[szTrCode].GetFieldData("OutBlock", "user");
            outData.len = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "len"));
            outData.gubun = _RealDict[szTrCode].GetFieldData("OutBlock", "gubun");
            outData.compress = _RealDict[szTrCode].GetFieldData("OutBlock", "compress");
            outData.encrypt = _RealDict[szTrCode].GetFieldData("OutBlock", "encrypt");
            outData.offset = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "offset"));
            outData.trcode = _RealDict[szTrCode].GetFieldData("OutBlock", "trcode");
            outData.compid = _RealDict[szTrCode].GetFieldData("OutBlock", "compid");
            outData.userid = _RealDict[szTrCode].GetFieldData("OutBlock", "userid");
            outData.media = _RealDict[szTrCode].GetFieldData("OutBlock", "media");
            outData.ifid = _RealDict[szTrCode].GetFieldData("OutBlock", "ifid");
            outData.seq = _RealDict[szTrCode].GetFieldData("OutBlock", "seq");
            outData.trid = _RealDict[szTrCode].GetFieldData("OutBlock", "trid");
            outData.pubip = _RealDict[szTrCode].GetFieldData("OutBlock", "pubip");
            outData.prvip = _RealDict[szTrCode].GetFieldData("OutBlock", "prvip");
            outData.pcbpno = _RealDict[szTrCode].GetFieldData("OutBlock", "pcbpno");
            outData.bpno = _RealDict[szTrCode].GetFieldData("OutBlock", "bpno");
            outData.termno = _RealDict[szTrCode].GetFieldData("OutBlock", "termno");
            outData.lang = _RealDict[szTrCode].GetFieldData("OutBlock", "lang");
            outData.proctm = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "proctm"));
            outData.msgcode = _RealDict[szTrCode].GetFieldData("OutBlock", "msgcode");
            outData.outgu = _RealDict[szTrCode].GetFieldData("OutBlock", "outgu");
            outData.compreq = _RealDict[szTrCode].GetFieldData("OutBlock", "compreq");
            outData.funckey = _RealDict[szTrCode].GetFieldData("OutBlock", "funckey");
            outData.reqcnt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "reqcnt"));
            outData.filler = _RealDict[szTrCode].GetFieldData("OutBlock", "filler");
            outData.cont = _RealDict[szTrCode].GetFieldData("OutBlock", "cont");
            outData.contkey = _RealDict[szTrCode].GetFieldData("OutBlock", "contkey");
            outData.varlen = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "varlen"));
            outData.varhdlen = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "varhdlen"));
            outData.varmsglen = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "varmsglen"));
            outData.trsrc = _RealDict[szTrCode].GetFieldData("OutBlock", "trsrc");
            outData.eventid = _RealDict[szTrCode].GetFieldData("OutBlock", "eventid");
            outData.ifinfo = _RealDict[szTrCode].GetFieldData("OutBlock", "ifinfo");
            outData.filler1 = _RealDict[szTrCode].GetFieldData("OutBlock", "filler1");
            outData.trcode1 = _RealDict[szTrCode].GetFieldData("OutBlock", "trcode1");
            outData.firmno = _RealDict[szTrCode].GetFieldData("OutBlock", "firmno");
            outData.acntno = _RealDict[szTrCode].GetFieldData("OutBlock", "acntno");
            outData.acntno1 = _RealDict[szTrCode].GetFieldData("OutBlock", "acntno1");
            outData.acntnm = _RealDict[szTrCode].GetFieldData("OutBlock", "acntnm");
            outData.brnno = _RealDict[szTrCode].GetFieldData("OutBlock", "brnno");
            outData.ordmktcode = _RealDict[szTrCode].GetFieldData("OutBlock", "ordmktcode");
            outData.ordno1 = _RealDict[szTrCode].GetFieldData("OutBlock", "ordno1");
            outData.ordno = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ordno"));
            outData.orgordno1 = _RealDict[szTrCode].GetFieldData("OutBlock", "orgordno1");
            outData.orgordno = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "orgordno"));
            outData.prntordno = _RealDict[szTrCode].GetFieldData("OutBlock", "prntordno");
            outData.prntordno1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "prntordno1"));
            outData.isuno = _RealDict[szTrCode].GetFieldData("OutBlock", "isuno");
            outData.fnoIsuno = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno");
            outData.fnoIsunm = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsunm");
            outData.pdgrpcode = _RealDict[szTrCode].GetFieldData("OutBlock", "pdgrpcode");
            outData.fnoIsuptntp = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuptntp");
            outData.bnstp = _RealDict[szTrCode].GetFieldData("OutBlock", "bnstp");
            outData.mrctp = _RealDict[szTrCode].GetFieldData("OutBlock", "mrctp");
            outData.ordqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ordqty"));
            outData.hogatype = _RealDict[szTrCode].GetFieldData("OutBlock", "hogatype");
            outData.mmgb = _RealDict[szTrCode].GetFieldData("OutBlock", "mmgb");
            outData.ordprc = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ordprc"));
            outData.unercqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "unercqty"));
            outData.commdacode = _RealDict[szTrCode].GetFieldData("OutBlock", "commdacode");
            outData.peeamtcode = _RealDict[szTrCode].GetFieldData("OutBlock", "peeamtcode");
            outData.mgempno = _RealDict[szTrCode].GetFieldData("OutBlock", "mgempno");
            outData.fnotrdunitamt = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "fnotrdunitamt"));
            outData.trxtime = _RealDict[szTrCode].GetFieldData("OutBlock", "trxtime");
            outData.strtgcode = _RealDict[szTrCode].GetFieldData("OutBlock", "strtgcode");
            outData.grpId = _RealDict[szTrCode].GetFieldData("OutBlock", "grpId");
            outData.ordseqno = _RealDict[szTrCode].GetFieldData("OutBlock", "ordseqno");
            outData.ptflno = _RealDict[szTrCode].GetFieldData("OutBlock", "ptflno");
            outData.bskno = _RealDict[szTrCode].GetFieldData("OutBlock", "bskno");
            outData.trchno = _RealDict[szTrCode].GetFieldData("OutBlock", "trchno");
            outData.Itemno = _RealDict[szTrCode].GetFieldData("OutBlock", "Itemno");
            outData.OrderID = _RealDict[szTrCode].GetFieldData("OutBlock", "OrderID");
            outData.opdrtnno = _RealDict[szTrCode].GetFieldData("OutBlock", "opdrtnno");
            outData.rjtcode = _RealDict[szTrCode].GetFieldData("OutBlock", "rjtcode");
            outData.mrccnfqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mrccnfqty"));
            outData.orgordunercqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "orgordunercqty"));
            outData.orgordmrcqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "orgordmrcqty"));
            outData.ctrcttime = _RealDict[szTrCode].GetFieldData("OutBlock", "ctrcttime");
            outData.ctrctno = _RealDict[szTrCode].GetFieldData("OutBlock", "ctrctno");
            outData.execprc = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "execprc"));
            outData.execqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "execqty"));
            outData.newqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "newqty"));
            outData.qdtqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "qdtqty"));
            outData.lastqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lastqty"));
            outData.lallexecqty = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lallexecqty"));
            outData.allexecamt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "allexecamt"));
            outData.fnobalevaltp = _RealDict[szTrCode].GetFieldData("OutBlock", "fnobalevaltp");
            outData.bnsplamt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "bnsplamt"));
            outData.fnoIsuno1 = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno1");
            outData.bnstp1 = _RealDict[szTrCode].GetFieldData("OutBlock", "bnstp1");
            outData.execprc1 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "execprc1"));
            outData.newqty1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "newqty1"));
            outData.qdtqty1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "qdtqty1"));
            outData.allexecamt1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "allexecamt1"));
            outData.fnoIsuno2 = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno2");
            outData.bnstp2 = _RealDict[szTrCode].GetFieldData("OutBlock", "bnstp2");
            outData.execprc2 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "execprc2"));
            outData.newqty2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "newqty2"));
            outData.lqdtqty2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lqdtqty2"));
            outData.allexecamt2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "allexecamt2"));
            outData.dps = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "dps"));
            outData.ftsubtdsgnamt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ftsubtdsgnamt"));
            outData.mgn = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mgn"));
            outData.mnymgn = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mnymgn"));
            outData.ordableamt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "ordableamt"));
            outData.mnyordableamt = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "mnyordableamt"));
            outData.fnoIsuno_1 = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno_1");
            outData.bnstp_1 = _RealDict[szTrCode].GetFieldData("OutBlock", "bnstp_1");
            outData.unsttqty_1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "unsttqty_1"));
            outData.lqdtableqty_1 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lqdtableqty_1"));
            outData.avrprc_1 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "avrprc_1"));
            outData.fnoIsuno_2 = _RealDict[szTrCode].GetFieldData("OutBlock", "fnoIsuno_2");
            outData.bnstp_2 = _RealDict[szTrCode].GetFieldData("OutBlock", "bnstp_2");
            outData.unsttqty_2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "unsttqty_2"));
            outData.lqdtableqty_2 = long.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "lqdtableqty_2"));
            outData.avrprc_2 = double.Parse(_RealDict[szTrCode].GetFieldData("OutBlock", "avrprc_2"));
        }
    }
}
