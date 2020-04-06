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

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].TrimStart().StartsWith(".Feed") || lines[i].TrimStart().StartsWith(".Func"))
                {
                    Console.WriteLine("Feed before " + lines[i]);
                    var spline = Regex.Split(lines[i].Trim(), "[,\\s\t]+");
                    resModel.Name = spline[2];
                    resModel.Desc = spline[1];
                    // Console.WriteLine("feed after " + spline[2] + " " + spline[1]);
                }
                else if (lines[i].Contains("InBlock") || lines[i].Contains("OutBlock"))
                {
                    var spline = Regex.Split(lines[i].Trim(), "[,\\s\t]+");
                    Block block = new Block { Name = spline[0], Desc = spline[1] };
                    i++;
                    if (lines[i].TrimStart().StartsWith("begin"))
                    {
                        i++;
                        for (int j = i; j < lines.Length; j++)
                        {
                            if (lines[j].TrimStart().StartsWith("end"))
                            {
                                break;
                            }
                            var spline1 = Regex.Split(lines[i].Trim(), "[,\\s\t]+");
                            block.Rows.Add(new Row { Name = spline1[1], Desc = spline1[0], Length = spline1[4], DataType = spline1[3] });
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
