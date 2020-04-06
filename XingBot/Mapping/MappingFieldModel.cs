using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.real.Mapping
{
    class MappingFieldModel
    {
        public MappingFieldModel(string fieldName, Type fieldType)
        {
            this.FieldName = fieldName;
            this.FieldType = fieldType;
        }

        public string FieldName { get; private set; }
        public Type FieldType { get; private set; }
    }
}
