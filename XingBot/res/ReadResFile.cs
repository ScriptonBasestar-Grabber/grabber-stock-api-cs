using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using XingBot.res;

namespace XingBot.res
{

    class ReadResFile
    {
        public static ResModel Read(string resfile)
        {
            int euckrCodepage = 51949;
            // System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);

            ResModel resModel = new ResModel();
            var lines = File.ReadAllLines(resfile, euckr);

            for (var idxLine = 0; idxLine < lines.Length; idxLine++)
            {
                if (lines[idxLine].TrimStart().StartsWith(".Feed") || lines[idxLine].TrimStart().StartsWith(".Func"))
                {
                    Console.WriteLine("Feed before " + lines[idxLine]);
                    var spline = lines[idxLine].Trim().Split(',');
                    resModel.Name = spline[2];
                    resModel.Desc = spline[1];
                    // Console.WriteLine("feed after " + spline[2] + " " + spline[1]);
                }
                else if (lines[idxLine].Contains("InBlock") || lines[idxLine].Contains("OutBlock"))
                {
                    var spline = lines[idxLine].Trim().Split(',');
                    Block block = new Block { Name = spline[0], Desc = spline[1] };
                    idxLine++;
                    if (lines[idxLine].TrimStart().StartsWith("begin"))
                    {
                        idxLine++;
                        for (int idxInner = idxLine; idxInner < lines[idxLine].Length; idxInner++)
                        {
                            if (lines[idxInner].Trim().Length == 0)
                            {
                                continue;
                            }
                            else if (lines[idxInner].TrimStart().StartsWith("end"))
                            {
                                break;
                            }
                            //var spline1 = Regex.Split(lines[idxInner].Trim(), "[,;\\s\t]+");
                            var spline1 = Regex.Split(lines[idxInner].Trim(), "[,;]+");
                            //var spline1 = lines[idxInner].Split(',');
                            block.Rows.Add(new Row { Name = spline1[1].Trim(), Desc = spline1[0].Trim(), Length = spline1[4].Trim(), DataType = spline1[3].Trim() });
                        }
                        // Console.WriteLine(block.Name);
                        resModel.Blocks.Add(block.Name, block);
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }

            return resModel;
        }
    }
}
