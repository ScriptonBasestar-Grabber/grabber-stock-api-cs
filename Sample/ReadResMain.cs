using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sample
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

    class ReadResMain
    {
        static string res1 = @"
BEGIN_FUNCTION_MAP
.Feed, KOSPI프로그램매매종목별(PH), PH_, attr, key=6, group=1;
    BEGIN_DATA_MAP
    InBlock,입력,input;
    begin
        종목코드,                   shcode,         shcode,     char,   6;
    end
    OutBlock,출력,output;
    begin
        수신시간,                   time,           time,       char,   6;

        현재가,                     price,          price,      long,   8;
        전일대비구분,               sign,           sign,       long,   1;
        전일대비,                   change,         change,     long,   8;
        누적거래량,                 volume,         volume,     long,   10;
        등락율,                     drate,          drate,      float,  6.2;

        차익매도호가 잔량,          cdhrem,         cdhrem,     long,   9;
        차익매수호가 잔량,          cshrem,         cshrem,     long,   9;
        비차익매도호가 잔량,        bdhrem,         bdhrem,     long,   9;
        비차익매수호가 잔량,        bshrem,         bshrem,     long,   9;

        차익매도호가 수량,          cdhvolume,      cdhvolume,  long,   9;
        차익매수호가 수량,          cshvolume,      cshvolume,  long,   9;
        비차익매도호가 수량,        bdhvolume,      bdhvolume,  long,   9;
        비차익매수호가 수량,        bshvolume,      bshvolume,  long,   9;

        전체매도위탁체결수량,       dwcvolume,      dwcvolume,  long,   9;
        전체매수위탁체결수량,       swcvolume,      swcvolume,  long,   9;
        전체매도자기체결수량,       djcvolume,      djcvolume,  long,   9;
        전체매수자기체결수량,       sjcvolume,      sjcvolume,  long,   9;

        전체매도체결수량,           tdvolume,       tdvolume,   long,   9;
        전체매수체결수량,           tsvolume,       tsvolume,   long,   9;
        전체순매수 수량,            tvol,           tvol,       long,   9;

        전체매도위탁체결금액,       dwcvalue,       dwcvalue,   long,   12;
        전체매수위탁체결금액,       swcvalue,       swcvalue,   long,   12;
        전체매도자기체결금액,       djcvalue,       djcvalue,   long,   12;
        전체매수자기체결금액,       sjcvalue,       sjcvalue,   long,   12;

        전체매도체결금액,           tdvalue,        tdvalue,    long,   12;
        전체매수체결금액,           tsvalue,        tsvalue,    long,   12;
        전체순매수 금액,            tval,           tval,       long,   12;

        매도 사전공시수량,          pdgvolume,      pdgvolume,  long,   9;
        매수 사전공시수량,          psgvolume,      psgvolume,  long,   9;

        종목코드,                   shcode,         shcode,     char,   6;
    end
    END_DATA_MAP
END_FUNCTION_MAP

";

        static Result read(string resfile)
        {
            int euckrCodepage = 51949;
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);

            string blockName;
            Result result = new Result();
            var lines = File.ReadAllLines(resfile, euckr);

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].TrimStart().StartsWith(".Feed"))
                {
                    Console.WriteLine("Feed before " + lines[i]);
                    var spline = Regex.Split(lines[i].Trim(), "[,\\s\t]+");
                    result.Name = spline[2];
                    result.Desc = spline[1];
                    Console.WriteLine("feed after " + spline[2] + " " + spline[1]);
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
                        Console.WriteLine(block.Name);
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

        static void Main(string[] args)
        {
            Console.WriteLine("============================Start================================");
            var result1 = read(@"C:\eBEST\xingAPI\Res\B7_.res");
            Console.WriteLine("result1========================");
            Console.WriteLine(result1.Name);
            Console.WriteLine(string.Join(",", result1.Blocks));
            Console.WriteLine(string.Join(",", result1.Blocks["InBlock"].rows));
            // var result2 = read(@"C:\eBEST\xingAPI\Res\B7_.res");
            // var result3 = read(@"C:\eBEST\xingAPI\Res\B7_.res");
            // Console.WriteLine(result);
        }
    }
}