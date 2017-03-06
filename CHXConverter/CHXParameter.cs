using CHXConverter.CHXParameterType;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXParameter: CHXParameterContainer
    {
        object _value;
        string _name;
        object _dataType;

        public object Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public object DataType
        {
            get
            {
                return _dataType;
            }

            set
            {
                _dataType = value;
            }
        }

        public CHXParameter()
        {

        }

        public static implicit operator CHXParameter(CHXValue op)
        {
            var exVal = new CHXParameter() { Value = op.Value, DataType = op.Value.GetType() };

            return exVal;
        }


        public override string ToString()
        {
            return $"{this.Name}:{this.Value}";
        }
    }
}
