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

    public class ReadResFile
    {
        public static ResModel Read(string resfile)
        {
            char[] delimiterChars = { Convert.ToChar(13), Convert.ToChar(10), ',',';' };
            int euckrCodepage = 51949;
            // System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(euckrCodepage);
            //'D:\work\ScriponBasestar-Grabber\grabber-stock-api-cs\XingBotTest\xing_resfile\H11.res
            ResModel resModel = new ResModel();
            var lines = File.ReadAllLines(resfile, euckr);

            for (var idxLine = 0; idxLine < lines.Length; idxLine++)
            {
                if (lines[idxLine].TrimStart().StartsWith(".Feed") || lines[idxLine].TrimStart().StartsWith(".Func"))
                {
                    Console.WriteLine("Feed before " + lines[idxLine]);
                    var words1 = lines[idxLine].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    resModel.Name = words1[2].Trim();
                    resModel.Desc = words1[1].Trim();
                }
                else if (lines[idxLine].Contains("InBlock") || lines[idxLine].Contains("OutBlock"))
                {
                    var words1= lines[idxLine].Trim().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    Block block = new Block { Name = words1[0], Desc = words1[1] };
                    idxLine++;
                    if (lines[idxLine].TrimStart().StartsWith("begin"))
                    {
                        idxLine++;
                        //for (int idxInner = idxLine; idxInner < lines[idxLine].Length; idxInner++)
                        for (int idxInner = idxLine; idxInner < lines.Length; idxInner++)
                            {
                            if (lines[idxInner].Trim().Length == 0)
                            {
                                continue;
                            }
                            else if (lines[idxInner].TrimStart().StartsWith("end"))
                            {
                                break;
                            }
                            var words2 = lines[idxInner].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                            block.Rows.Add(new Row { Name = words2[1].Trim(), Desc = words2[0].Trim(), Length = words2[4].Trim(), DataType = words2[3].Trim() });
                        }
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
