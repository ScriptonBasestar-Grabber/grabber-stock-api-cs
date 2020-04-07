using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabberManager.util
{
    public class CastingUtil
    {
        public static object byStringType(string value, string type)
        {
            switch (type)
            {
                case "int":
                case "long":
                    return long.Parse(value);
                case "float":
                case "double":
                    return decimal.Parse(value);
                case "char":
                    return value;
                default:
                    throw new System.ArgumentException("분류값이 없음 추가필요");
            }
        }
    }
}
