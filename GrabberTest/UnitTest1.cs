using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace GrabberTest
{
    public class Tests
    {
        private string res1;




        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test0()
        {
           
        }

        [Test]
        public void Test1()
        {
            // BEGIN_FUNCTION_MAP(res1.Split(
            //     new[] { Environment.NewLine },
            //     StringSplitOptions.None));
            // string blockStatus;
            // foreach (var line in res1.Split(
            //     new[] {Environment.NewLine},
            //     StringSplitOptions.None))
            // {
            //     if (line.StartsWith(".Feed"))
            //     {
            //     }
            // }
        }

        // private void BEGIN_FUNCTION_MAP(string[] res2, int lineNo, ref Result result, string blockName = "")
        // {
        //     if (res2[lineNo].StartsWith("BEGIN_FUNCTION_MAP"))
        //     {
        //         BEGIN_FUNCTION_MAP(res2, lineNo + 1, ref result, "BEGIN_FUNCTION_MAP");
        //     }
        //     else if (res2[lineNo].StartsWith(".Feed"))
        //     {
        //         var spline = res2[lineNo].Split("[,\\s]");
        //         if (spline[0].Equals(".Feed"))
        //         {
        //             BEGIN_FUNCTION_MAP(res2, lineNo + 1, ref result, blockName);
        //         }
        //     }
        //     else if (res2[lineNo].StartsWith("\\s"))
        //     {
        //         BEGIN_DATA_MAP(res2, lineNo, ref result, blockName);
        //     }
        //     else
        //     {
        //         BEGIN_FUNCTION_MAP(res2, lineNo + 1, ref result, blockName);
        //     }
        // }
        //
        // private void BEGIN_DATA_MAP(string[] res2, int lineNo, ref Result result, string blockName)
        // {
        //     if (res2[lineNo].TrimStart().StartsWith("BEGIN_DATA_MAP"))
        //     {
        //         BEGIN_DATA_MAP(res2, lineNo + 1, ref result, blockName);
        //     }
        //     else if (res2[lineNo].TrimStart().StartsWith("InBlock") ||
        //              res2[lineNo].TrimStart().StartsWith("OutBlock"))
        //     {
        //         BEGIN_DATA_MAP(res2, lineNo + 1, ref result, blockName);
        //     }
        //     else if (res2[lineNo].TrimStart().StartsWith("begin"))
        //     {
        //     }
        // }

        // private Row[] beginend(string[] res2, int lineNo, out Result result)
        // {
        // }
    }
}