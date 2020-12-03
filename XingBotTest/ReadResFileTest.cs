using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using XingBot.res;

namespace XingBotTest
{
    [TestClass]
    public class ReadResFileTest
    {
        public static string GetProjectPath(params string[] testSubPaths)
        {
            //System.AppDomain.CurrentDomain.DynamicDirectory
            //string path = AppDomain.CurrentDomain.BaseDirectory;
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var pathItems = startupPath.Split(Path.DirectorySeparatorChar);
            var pos = pathItems.Reverse().ToList().FindIndex(x => string.Equals("bin", x));
            string projectPath = String.Join(Path.DirectorySeparatorChar.ToString(), pathItems.Take(pathItems.Length - pos - 1));
            var paths = new List<string> { projectPath };
            paths.AddRange(testSubPaths);
            return Path.Combine(paths.ToArray());
        }
        /*
        System.AppDomain.CurrentDomain.BaseDirectory
        "D:\\work\\ScriponBasestar-Grabber\\grabber-stock-api-cs\\XingBotTest\\bin\\Debug"
        AppDomain.CurrentDomain.BaseDirectory
        "D:\\work\\ScriponBasestar-Grabber\\grabber-stock-api-cs\\XingBotTest\\bin\\Debug"
         */
        [TestMethod]
        public void ReadTest_Real_H1_()
        {
            ResModel model = ReadResFile.Read(GetProjectPath("xing_resfile/H1_.res"));
            Console.WriteLine(model);
            Assert.IsTrue(model.Blocks["InBlock"].Rows.Count == 1);
            //Assert.IsTrue(model.Blocks["OutBlock"].Rows.Count == 0);
            Assert.IsTrue(model.Blocks["OutBlock"].Rows.First().Name == "hotime");
            Assert.IsTrue(model.Blocks["OutBlock"].Rows.Last().Name == "alloc_gubun");
        }


        [TestMethod]
        public void ReadTest_Real_HB_()
        {
            ResModel model = ReadResFile.Read(GetProjectPath("xing_resfile/HB_.res"));
            Console.WriteLine(model);

            Assert.IsTrue(model.Blocks["InBlock"].Rows.Count == 1);

            Assert.IsTrue(model.Blocks["OutBlock"].Rows.First().Name == "hotime");
            Assert.IsTrue(model.Blocks["OutBlock"].Rows.Last().Name == "shcode");
        }


        [TestMethod]
        public void ReadTest_Query_t1104()
        {
            ResModel model = ReadResFile.Read(GetProjectPath("xing_resfile/t1104.res"));
            Console.WriteLine(model);
            Assert.IsTrue(model.Blocks["t1104InBlock"].Rows.Count == 2);
            Assert.IsTrue(model.Blocks["t1104InBlock1"].Rows.Count == 4);

            Assert.IsTrue(model.Blocks["t1104OutBlock"].Rows.First().Name == "nrec");
            Assert.IsTrue(model.Blocks["t1104OutBlock1"].Rows.Last().Name == "vals");
        }


        [TestMethod]
        public void ReadTest_Query_t8407()
        {
            ResModel model = ReadResFile.Read(GetProjectPath("xing_resfile/t8407.res"));
            Console.WriteLine(model);

            Assert.IsTrue(model.Blocks["t8407InBlock"].Rows.Count == 2);

            Assert.IsTrue(model.Blocks["t8407OutBlock1"].Rows.First().Name == "shcode");
            Assert.IsTrue(model.Blocks["t8407OutBlock1"].Rows.Last().Name == "dnlmtprice");
        }
    }
}
