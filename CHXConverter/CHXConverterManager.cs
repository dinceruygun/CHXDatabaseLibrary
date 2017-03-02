using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    public class CHXConverterManager
    {
        private CHXConverterType _convertType;

        public CHXConverterManager(CHXConverterType convertType)
        {
            this._convertType = convertType;
        }

        public CHXConverterType ConvertType
        {
            get
            {
                return _convertType;
            }

            set
            {
                _convertType = value;
            }
        }

        public void Convert(object data)
        {
            throw new NotImplementedException();
        }
    }
}
