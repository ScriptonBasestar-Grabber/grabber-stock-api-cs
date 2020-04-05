﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XingBot.res
{

    class Row
    {
        public string Name;
        public string Length;
        public string DataType;
        public string Desc;
    }

    class Block
    {
        public string Name;
        public string Desc;
        public List<Row> rows = new List<Row>();
    }

    class Result
    {
        public string Name;
        public string Desc;
        public Dictionary<string, Block> Blocks = new Dictionary<string, Block>();
    }

    class ReadResFile
    {
        public static Result read(string resfile)
        {
            int euckrCodepage = 51949;
            // System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);

            string blockName;
            Result result = new Result();
            var lines = File.ReadAllLines(resfile, euckr);

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].TrimStart().StartsWith(".Feed"))
                {
                    // Console.WriteLine("Feed before " + lines[i]);
                    var spline = Regex.Split(lines[i].Trim(), "[,\\s\t]+");
                    result.Name = spline[2];
                    result.Desc = spline[1];
                    // Console.WriteLine("feed after " + spline[2] + " " + spline[1]);
                }
                else if (lines[i].TrimStart().StartsWith("InBlock") || lines[i].TrimStart().StartsWith("OutBlock"))
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
                            block.rows.Add(new Row { Name = spline1[1], Desc = spline1[0], Length = spline1[4], DataType = spline1[3] });
                        }
                        // Console.WriteLine(block.Name);
                        result.Blocks.Add(block.Name, block);
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }

            return result;
        }
    }
}
