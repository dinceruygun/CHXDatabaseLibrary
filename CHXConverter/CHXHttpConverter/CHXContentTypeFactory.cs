using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter.CHXHttpConverter
{
    public static class CHXContentTypeFactory
    {
        private static object _locker = new object();

        public static ICHXHtppRequestConverter GetBodyConverter(CHXContentType contentType)
        {
            if (contentType == CHXContentType.JSON)
            {
                return new ContentTypeContainer.CHXJson();
            }
            else { return null; }
        }

        internal static ICHXHtppRequestConverter GetRecycle(CHXContentType contentType)
        {
            if (contentType == CHXContentType.JSON)
            {
                return new ContentTypeContainer.CHXJson();
            }
            else { return null; }
        }
    }
}
