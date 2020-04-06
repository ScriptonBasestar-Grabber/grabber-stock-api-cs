using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.real.res
{
    public class Row
    {
        public string Name;
        public string Length;
        public string DataType;
        public string Desc;
    }

    public class Block
    {
        public string Name;
        public string Desc;
        public List<Row> Rows = new List<Row>();
    }

    public class ResModel
    {
        public string Name;
        public string Desc;
        public Dictionary<string, Block> Blocks = new Dictionary<string, Block>();
    }
}
