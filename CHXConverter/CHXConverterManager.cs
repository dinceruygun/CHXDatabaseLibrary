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
        private ICHXConverter _converter;

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

        public ICHXConverter Converter
        {
            get
            {
                if (_converter == null)
                {
                    _converter = CHXConverterFactory.GetConverter(_convertType);
                }

                return _converter;
            }
        }


        public object Recycle(object data, object target)
        {
            var retData = Converter.Recycle(data, target);

            return retData;
        }


        public object Convert(object data)
        {
            var retData = Converter.Run(data);

            return retData;
        }


        public object Convert(object data, string needProperty)
        {
            var retData = Converter.Run(data, needProperty);

            return retData;
        }
    }
}
