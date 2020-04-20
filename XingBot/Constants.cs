using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.model;

namespace XingBot
{
    public class Constants
    {
        public static readonly Dictionary<string, CodeStock> CodeStocks = new Dictionary<string, CodeStock>();
        public static readonly Dictionary<string, CodeFutures> CodeFutures = new Dictionary<string, CodeFutures>();
        public static readonly Dictionary<string, CodeOptions> CodeOptions = new Dictionary<string, CodeOptions>();
        public static readonly Dictionary<string, CodeSector> CodeSectors = new Dictionary<string, CodeSector>();
        public static readonly Dictionary<string, CodeTheme> CodeThemes = new Dictionary<string, CodeTheme>();
        public static readonly Dictionary<string, CodeElw> CodeElws = new Dictionary<string, CodeElw>();
        public static readonly Dictionary<string, CodeElwBase> CodeElwBases = new Dictionary<string, CodeElwBase>();
    }
}