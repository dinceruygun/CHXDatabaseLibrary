using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXDatabaseParameter
    {
        private string _name;
        private string _value;

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

        public string Value
        {
            get
            {
                return _value;
            }

            set
            {
                this._value = value;
            }
        }

        public CHXDatabaseParameter()
        {

        }

        public CHXDatabaseParameter(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override string ToString()
        {
            return $"{Name}={Value}";
        }
    }
}
