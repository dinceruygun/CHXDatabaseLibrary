using CHXConverter.CHXParameterType;
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
        public override object Run(string jsonData)
        {
            var parameters = new CHXParameter();

            foreach (var item in JObject.Parse(jsonData).Children())
            {
                parameters.ItemList.Add(parselJsonData(item));
            }

            

            throw new NotImplementedException();
        }

        protected CHXParameter parselJsonData(object jsonElement)
        {
            var retParameter = new CHXParameter();

            if (jsonElement is JProperty)
            {
                retParameter.Name = (jsonElement as JProperty).Name;
                retParameter.Value = (jsonElement as JProperty).Value;
                retParameter.DataType = typeof(CHXProperty);

                foreach (var item in (jsonElement as JProperty).Children())
                {
                    var tempParams = parselJsonData(item);

                    if (tempParams != null)
                        if (tempParams.ItemList.Count > 0)
                        {
                            retParameter.ItemList.AddRange(tempParams.ItemList);
                            retParameter.DataType = typeof(CHXList);
                        }
                }

            }
            else if(jsonElement is JObject)
            {
                foreach (var item in (jsonElement as JObject).Children())
                {
                    retParameter.ItemList.Add(parselJsonData(item));
                    retParameter.DataType = typeof(CHXProperty);
                }
            }
            else if (jsonElement is JArray)
            {
                foreach (var item in (jsonElement as JArray).Children())
                {
                    retParameter.ItemList.Add(parselJsonData(item));
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
