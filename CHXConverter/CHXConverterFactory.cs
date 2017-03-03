using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    public static class CHXConverterFactory
    {
        private static object _locker = new object();

        public static ICHXConverter GetConverter(CHXConverterType converterType)
        {
            lock (_locker)
            {
                switch (converterType)
                {
                    case CHXConverterType.CHXHttpRequest:
                        return new CHXHttpConverter.CHXHttpRequestConverter();
                    default:
                        return null;
                }
            }
        }
    }
}
