using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter.CHXHttpConverter
{
    public class CHXHttpRequestConverter : ICHXConverter
    {
        public override object Run(object data)
        {
            return Run(data, null);
        }

        public override object Run(object data, string needProperty)
        {
            if(data is Request)
            {
                var request = (data as Request);
                var body = new System.IO.StreamReader(request.Body).ReadToEnd();

                var bodyConverter = CHXContentTypeFactory.GetBodyConverter(request.Headers.ContentType.GetContentType());

                return bodyConverter.Run(body);
            }
            else
            {
                throw new Exception("Data Request türünde değil");
            }
        }
    }
}
