using System;
using System.IO;
using System.Runtime.InteropServices;
using XA_DATASETLib;

namespace XingBot
{
    public partial class RealEvents: _IXARealEvents
    {
        private readonly IXAReal _real;

        public RealEvents()
        {
            UCOMIConnectionPoint icp;
            UCOMIConnectionPointContainer icpc;

            Guid IID_RealEvents = typeof(_IXARealEvents).GUID;//여기가다름

            _real = new XAReal[m_CodeArray.FUTURECNT];
            for (i = 0; i < m_CodeArray.FUTURECNT; i++)
            {
                m_RealFC0[i] = new XAReal();
                dwCookie = 0;
                m_RealFC0[i].ResFileName = "\\res\\FC0.res";     //KOSPI선물체결
                icpc = (UCOMIConnectionPointContainer)m_RealFC0[i];
                icpc.FindConnectionPoint(ref IID_RealEvents, out icp);
                icp.Advise(this, out dwCookie);
            }
        }

        // Real
        void _IXARealEvents.ReceiveRealData(string szTrCode)
        {
            if (szTrCode == "FC0")
            {
                for (i = 0; i < m_CodeArray.FUTURECNT; i++)
                {
                    if (m_RealFC0[i].GetFieldData("OutBlock", "futcode") == m_CodeArray.CodeFUArray[i])
                    {
                        break;
                    }
                }
                ////FC0 저장 선물전종목 코드구분으로저장
                FileStream fs = new FileStream(@"e:\price\FC0.csv", FileMode.Append);
                string[] TempArr = new string[m_CodeArray.strResFC0.Length];
                fs.Seek(0, SeekOrigin.End);
                {
                    for (int j = 0; j < m_CodeArray.strResFC0.Length;)
                    {
                        FileIOClass.WriteStringBytes(m_RealFC0[i].GetFieldData("OutBlock", m_CodeArray.strResFC0[j]), fs);
                        //TempArr[j] = m_RealFC0[i].GetFieldData("OutBlock", m_CodeArray.strResFC0[j]);
                        if (++j >= m_CodeArray.strResFC0.Length)
                        { break; }
                        FileIOClass.WriteStringBytes(",", fs);
                    }
                    FileIOClass.WriteStringBytes("\n", fs);
                }
                fs.Flush();
                fs.Close();
                //DBIOClass.InsertTable("FutureChe", m_CodeArray.strResFC0, TempArr);
                //Console.WriteLine(cntline++);
            }
            else if (szTrCode == "FH0")
            {
                for (i = 0; i < m_CodeArray.FUTURECNT; i++)
                {
                    if (m_RealFH0[i].GetFieldData("OutBlock", "futcode") == m_CodeArray.CodeFUArray[i])
                    { break; }
                }
                ////FH0 선물 전종목호가
                FileStream fs = new FileStream(@"e:\price\FH0.csv", FileMode.Append);
                fs.Seek(0, SeekOrigin.End);
                {
                    for (int j = 0; j < m_CodeArray.strResFH0.Length;)
                    {
                        FileIOClass.WriteStringBytes(m_RealFH0[i].GetFieldData("OutBlock", m_CodeArray.strResFH0[j]), fs);
                        if (++j >= m_CodeArray.strResFH0.Length)
                        { break; }
                        FileIOClass.WriteStringBytes(",", fs);
                    }
                    FileIOClass.WriteStringBytes("\n", fs);
                }
                fs.Flush();
                fs.Close();
                //Console.WriteLine(cntline++); ;
            }
            else if (szTrCode == "OC0")
            {
                for (i = 0; i < m_CodeArray.OPTIONCNT; i++)
                {
                    if (m_RealOC0[i].GetFieldData("OutBlock", "optcode") == m_CodeArray.CodeOPArray[i])
                        break;
                }
                ////OC0 옵션 종목체결
                FileStream fs = new FileStream(@"e:\price\OC0.txt", FileMode.Append);
                fs.Seek(0, SeekOrigin.End);
                {
                    for (int j = 0; j < m_CodeArray.strResOC0.Length;)
                    {
                        FileIOClass.WriteStringBytes(m_RealOC0[i].GetFieldData("OutBlock", m_CodeArray.strResOC0[j]), fs);
                        if (++j >= m_CodeArray.strResOC0.Length)
                        { break; }
                        FileIOClass.WriteStringBytes(",", fs);
                    }
                    FileIOClass.WriteStringBytes("\n", fs);
                }
                fs.Flush();
                fs.Close();
                //Console.WriteLine(cntline++); ;
            }
            else if (szTrCode == "OH0")
            {
                for (i = 0; i < m_CodeArray.OPTIONCNT; i++)
                {
                    if (m_RealOH0[i].GetFieldData("OutBlock", "optcode") == m_CodeArray.CodeOPArray[i])
                        break;
                }
                ////OH0 옵션 종목호가
                FileStream fs = new FileStream(@"e:\price\OH0.txt", FileMode.Append);
                fs.Seek(0, SeekOrigin.End);
                {
                    for (int j = 0; j < m_CodeArray.strResOH0.Length;)
                    {
                        FileIOClass.WriteStringBytes(m_RealOH0[i].GetFieldData("OutBlock", m_CodeArray.strResOH0[j]), fs);
                        if (++j >= m_CodeArray.strResOH0.Length)
                        { break; }
                        FileIOClass.WriteStringBytes(",", fs);
                    }
                    FileIOClass.WriteStringBytes("\n", fs);
                }
                fs.Flush();
                fs.Close();
                //Console.WriteLine(cntline++); ;
            }
        }

        void _IXARealEvents.RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
            throw new System.NotImplementedException();
        }
    }
}