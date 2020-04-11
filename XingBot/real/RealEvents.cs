using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using CsvHelper;
using DataLib.util;
using GrabberManager.util;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.real
{
    public class RealEvents : _IXARealEvents
    {
        private readonly IXAReal _ixa;
        private readonly ResModel _resModel;
        public RealEvents(string szTrCode)
        {
            _resModel = ReadResFile.Read(Path.Combine(Settings.Default.root_path, szTrCode));

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;

            _ixa = new XAReal
            {
                ResFileName = Settings.Default.root_path + @"\res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer) _ixa;
            Guid iidRealEvents = typeof(_IXARealEvents).GUID;
            icpc.FindConnectionPoint(ref iidRealEvents, out icp);
            icp.Advise(this, out dwCookie);

            Console.WriteLine("RealEvents 생성자완료");
        }

        public void Start(StringDict sdict)
        {
            var szTrCode = _resModel.Name;
            var block = _resModel.Blocks["InBlock"];
            block.Rows.ForEach(delegate (Row row) { _ixa.SetFieldData(block.Name, row.Name, sdict[row.Name]); });
            _ixa.AdviseRealData();
        }

        public void Stop()
        {
            _ixa.UnadviseRealData();
        }

        void _IXARealEvents.ReceiveRealData(string szTrCode)
        {
            Console.WriteLine("_IXARealEvents.ReceiveRealData " + szTrCode);
            OutBlock(szTrCode);
        }
        private void OutBlock(string szTrCode)
        {
            OutBlock(szTrCode);
            FileInfo fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv");
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }

            // using (var writer = new StreamWriter(fi.OpenWrite()))
            using (var writer = new StreamWriter(Settings.Default.data_path + "\\xing\\" + szTrCode + ".csv", true))
            {
                var block = _resModel.Blocks["OutBlock"];
                Hashtable table = new Hashtable();
                block.Rows.ForEach((row) =>
                {
                    var value = _ixa.GetFieldData(block.Name, row.Name);
                    writer.Write(value);
                    //11
                    // var prop = result.GetType().GetProperty(row.Name,
                    //     System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public |
                    //     System.Reflection.BindingFlags.SetProperty);
                    // if (null != prop && prop.CanWrite)
                    // {
                    //     prop.SetValue(result, CastingUtil.byStringType(value, row.DataType));
                    // }
                    //22
                    // PropertyInfo propertyInfo = result.GetType().GetProperty(row.Name);
                    // propertyInfo.SetValue(result, Convert.ChangeType(value, propertyInfo.PropertyType), null);
                    //33
                    // var field = result.GetType().GetField(row.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    // var jjiji = result.GetType().GetFields();
                    // var fjewioiewfj = result.GetType().GetDefaultMembers();
                    // var jiojwfeio = result.GetType().GetMembers();
                    // var fjew0iefwjio = result.GetType().GetProperties();
                    // Console.WriteLine(jjiji);
                    // // var field = typeof(_t1981OutBlock1).GetField(row.Name);
                    // // Console.WriteLine(result);
                    // Console.WriteLine(field.FieldType);
                    // Console.WriteLine(Convert.ChangeType(value, field.FieldType));
                    // field.SetValueDirect(__makeref(result), Convert.ChangeType(value, field.FieldType));
                    // System.Console.WriteLine(s.Field); //Prints 5
                });
                writer.WriteLine(table);
            }
        }
        void _IXARealEvents.RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
            throw new System.NotImplementedException();
        }
    }
}