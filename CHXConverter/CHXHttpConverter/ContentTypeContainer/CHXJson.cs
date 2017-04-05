using CHXConverter.CHXParameterType;
using CHXDatabaseLibrary;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter.CHXHttpConverter.ContentTypeContainer
{
    public class CHXJson : ICHXHtppRequestConverter
    {
        public override object RecycleInnerMethod(object data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public override CHXRequest RunInnerMethod(object jsonData)
        {
            if (jsonData == null) return null;
            if (string.IsNullOrEmpty(jsonData.ToString())) return null;



            var result = new CHXRequest();

            foreach (var item in JObject.Parse(jsonData.ToString())?.Children())
            {
                result.Parameters.Add(parselJsonData(item));
            }

            result.Data = jsonData.ToString();
            result.ConvertData = JObject.Parse(jsonData.ToString());

            return result;
        }

        protected CHXParameter parselJsonData(object jsonElement)
        {
            var retParameter = new CHXParameter();

            if (jsonElement is JProperty)
            {
                retParameter.Name = (jsonElement as JProperty).Name;

                if ((jsonElement as JProperty).Value is JValue)
                {
                    retParameter.Value = ((jsonElement as JProperty).Value as JValue).Value;
                    retParameter.DataType = retParameter.Value.GetType();
                }
                else
                {
                    retParameter.DataType = typeof(CHXProperty);
                }

                foreach (var item in (jsonElement as JProperty).Children())
                {
                    var tempParams = parselJsonData(item);

                    if (tempParams != null)
                        if (tempParams.Count > 0)
                        {
                            retParameter.AddRange(tempParams);
                            retParameter.DataType = typeof(CHXList);
                        }
                }

            }
            else if(jsonElement is JObject)
            {
                foreach (var item in (jsonElement as JObject).Children())
                {
                    retParameter.Add(parselJsonData(item));
                    retParameter.DataType = typeof(CHXProperty);
                }
            }
            else if (jsonElement is JArray)
            {
                foreach (var item in (jsonElement as JArray).Children())
                {
                    retParameter.Add(parselJsonData(item));
                    retParameter.DataType = typeof(CHXArray);
                }
            }
            else if (jsonElement is JValue)
            {
                retParameter = new CHXValue() { Value = (jsonElement as JValue).Value };
            }

            return retParameter;

        }
    }



    
}
