using System;
using System.IO;
using System.Text;

namespace GrabberManager.io
{
    public class FileIO
    {

        //기본함수 형태
        //string [] ReadCSV(파일명, 원하는 라인)
        //1 파일받고
        //2라인수 세기
        //라인당콤마수 세기 (1~2라인 끝전~끝라인 세어보고 최대값 기준으로 결정)
        //x번째 ,부터 ,사이의 값을 추출,,앞뒤 공백제외
        //배열로 추출
        //return [] string
        public static string[,] ReadCSV(string str파일경로, string str파일명)//, int column, int row)
        {
            int cntline = 0;
            int cntcomma = 0;
            int i = 0, j = 0;
            string[] lines = System.IO.File.ReadAllLines(str파일경로 + str파일명);

            cntline = lines.Length;
            ////ReadresFile에 썼던 함수쓰면 더 쉽게된다근데 귀찮으니 방치
            for (i = 0; i < lines[0].Length; i++)
            {
                if (',' == lines[0][i])
                { cntcomma++; }
            }
            string[,] arrcode = new string[cntline, cntcomma + 1];

            i = 0;
            foreach (string line in lines)
            {
                j = 0;
                foreach (char line1 in line)
                {
                    if (line1 == ',')
                    {
                        j++;
                        continue;
                    }
                    arrcode[i, j] = arrcode[i, j] + line1;
                }
                i++;
            }
            return arrcode;
        }
        public static string[] ReadResFile(string str파일경로, string str파일명, string str블록구분, int int배열숫자)
        {//str블록구분=InBlock,OutBlock
            string[] text = System.IO.File.ReadAllLines(str파일경로 + str파일명);
            char[] delimiterChars = { Convert.ToChar(13), Convert.ToChar(10), ' ', ',', '.', ':', '\t', ';' };

            string[] str저장배열 = new string[100];
            //동적할당을 못해서 그냥
            int i = 0;
            int j = 0;
            string[] words;

            for (i = 0; i < text.Length; i++)
            {
                words = text[i].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (words[0] == str블록구분)
                {
                    i++;//begin으로 넘어감
                    i++;//begin다음에 값으로 넘어감
                    break;
                }
            }
            for (j = 0; i < text.Length; i++, j++)
            {
                words = text[i].Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                if (words[0] == "end")
                { break; }
                str저장배열[j] = words[int배열숫자];
            }
            Array.Resize(ref str저장배열, j);
            return str저장배열;
        }

        public static byte[] WriteStringBytes(string str, FileStream fs)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(str);
            fs.Write(info, 0, info.Length);
            return info;
        }
        public void Fileinput()
        {
            FileStream fs = new FileStream(@"e:\price\test.txt", FileMode.Append);
            fs.Seek(0, SeekOrigin.End);
            FileIO.WriteStringBytes("--------------\r\n", fs);
            fs.Flush();
            fs.Close();
        }
        public void Fileread()
        {
            byte[] b = new byte[1024];
            FileStream fs = File.OpenRead(@"e:\price\test.txt");
            UTF8Encoding utf8 = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(utf8.GetString(b));
            }
            fs.Close();
        }

        // public void MakeGround(string strRes파일명, string str블록구분)
        // {
        //     string[] str임시배열;
        //     int i = 0;
        //     CodeArrayClass m_CodeArray = new CodeArrayClass();
        //     str임시배열 = FileIO.ReadResFile(m_CodeArray.strRes파일경로, strRes파일명 + ".res", str블록구분, 2);
        //     FileStream fs = new FileStream(m_CodeArray.str파일경로 + strRes파일명 +/**str블록구분+**/".csv", FileMode.Create);
        //     fs.Seek(0, SeekOrigin.Begin);
        //     {
        //         for (i = 0; i < str임시배열.Length; i++)
        //         {
        //             FileIOClass.WriteStringBytes(str임시배열[i] + ",", fs);
        //         }
        //     }
        // }
        // public void InsertGround(string strRes파일명, string str블록구분)
        // {
        //     string[] str임시배열;
        //     int i = 0;
        //     CodeArrayClass m_CodeArray = new CodeArrayClass();
        //     str임시배열 = FileIO.ReadResFile(m_CodeArray.strRes파일경로, strRes파일명 + ".res", str블록구분, 2);
        //     FileStream fs = new FileStream(m_CodeArray.str파일경로 + strRes파일명 + str블록구분 + ".csv", FileMode.Create);
        //     fs.Seek(0, SeekOrigin.Begin);
        //     {
        //         for (i = 0; i < str임시배열.Length;)
        //         {
        //             FileIO.WriteStringBytes(str임시배열[i], fs);
        //             if (++i >= str임시배열.Length)
        //             { break; }
        //             FileIO.WriteStringBytes(",", fs);
        //         }
        //         FileIO.WriteStringBytes("\n", fs);
        //     }
        // }
    }//public class FileIOClass끝
}