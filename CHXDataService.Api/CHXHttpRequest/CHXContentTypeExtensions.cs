using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXHttpRequest
{
    public static class CHXContentTypeExtensions
    {
        private static object GetMetadata(CHXContentType ct)
        {
            var type = ct.GetType();
            MemberInfo[] info = type.GetMember(ct.ToString());
            if ((info != null) && (info.Length > 0))
            {
                object[] attrs = info[0].GetCustomAttributes(typeof(CHXMetadata), false);
                if ((attrs != null) && (attrs.Length > 0))
                {
                    return attrs[0];
                }
            }
            return null;
        }

        public static string ToValue(this CHXContentType ct)
        {
            var metadata = GetMetadata(ct);
            return (metadata != null) ? ((CHXMetadata)metadata).Value : ct.ToString();
        }

        public static bool IsText(this CHXContentType ct)
        {
            var metadata = GetMetadata(ct);
            return (metadata != null) ? ((CHXMetadata)metadata).IsText : true;
        }

        public static bool IsBinary(this CHXContentType ct)
        {
            var metadata = GetMetadata(ct);
            return (metadata != null) ? ((CHXMetadata)metadata).IsBinary : false;
        }
    }
}
