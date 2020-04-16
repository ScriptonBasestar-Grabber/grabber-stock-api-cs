using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DataLib.util
{
    public class PrintUtil
    {
        public static string PrintProperties(object obj)
        {
            Type type = obj.GetType();
            StringBuilder sb = new StringBuilder(type.Name);
            PropertyInfo[] props = type.GetProperties();
            for (var i = 0; i< props.Length; i++)
            {
                sb.Append(props[i].Name).Append(":").Append(props[i].GetValue(obj, null));
                if(i < props.Length)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
        public static string PrintField(object obj)
        {
            Type type = obj.GetType();
            StringBuilder sb = new StringBuilder(type.Name);
            FieldInfo[] props = type.GetFields();
            for (var i = 0; i< props.Length; i++)
            {
                sb.Append(props[i].Name).Append(":").Append(props[i].GetValue(obj));
                if(i < props.Length)
                {
                    sb.Append(", ");
                }
            }
            return sb.ToString();
        }
    }
}
