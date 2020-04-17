using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using CsvHelper;
using DataLib.util;
using GrabberManager.util;
using log4net;
using XA_DATASETLib;
using XingBot.Properties;
using XingBot.res;
using XingBot.tr;

namespace XingBot.real
{
    public class RealEvents : _IXARealEvents
    {
        protected static readonly ILog LOG = LogManager.GetLogger("RealEvents");
        private readonly IXAReal _ixa;
        private readonly ResModel _resModel;
        private FileInfo fi;
        public RealEvents(string szTrCode)
        {
            _resModel = ReadResFile.Read(Settings.Default.root_path + @"\res\" + szTrCode + ".res");

            int dwCookie = 0;
            IConnectionPoint icp;
            IConnectionPointContainer icpc;

            _ixa = new XAReal
            {
                ResFileName = Settings.Default.root_path + @"\res\" + szTrCode + ".res"
            };
            icpc = (IConnectionPointContainer)_ixa;
            Guid iidRealEvents = typeof(_IXARealEvents).GUID;
            icpc.FindConnectionPoint(ref iidRealEvents, out icp);
            icp.Advise(this, out dwCookie);

            Console.WriteLine("RealEvents 생성자완료");
        }

        public void Start(string separator, StringDict sdict)
        {
            var szTrCode = _resModel.Name;

            fi = new FileInfo(Settings.Default.data_path + "\\xing\\" + szTrCode + "-" + separator + ".csv");
            if (fi.Directory != null && !fi.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(fi.DirectoryName);
            }
            using (var writer = fi.AppendText())
            {
                StringBuilder sb = new StringBuilder();
                _resModel.Blocks["OutBlock"].Rows.ForEach(row =>
                {
                    sb.Append(row.Name).Append(',');
                });
                sb.Remove(sb.Length - 1, 1);
                writer.WriteLine(sb.ToString());
            }
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
            using (var writer = fi.AppendText())
            //using (var writer = new CsvWriter(writer0, CultureInfo.InvariantCulture))
            {
                var block = _resModel.Blocks["OutBlock"];
                StringBuilder sb = new StringBuilder();
                block.Rows.ForEach((row) =>
                {
                    var value = _ixa.GetFieldData(block.Name, row.Name);
                    sb.Append(value).Append(',');
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
                sb.Remove(sb.Length - 1, 1);
                writer.WriteLine(sb.ToString());
            }
        }
        void _IXARealEvents.RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
            throw new System.NotImplementedException();
        }
    }
}