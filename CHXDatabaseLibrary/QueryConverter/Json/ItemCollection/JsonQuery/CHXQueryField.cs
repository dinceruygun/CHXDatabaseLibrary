using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public class CHXQueryField : ICHXJsonQuery
    {
        public override void Convert(dynamic jsonElement, ref QueryTable query)
        {
            if (jsonElement.Value == null) return;

            foreach (var f in jsonElement.Value)
            {
                string _tempVal = f.Value;

                if (_tempVal.IndexOf("=>") > -1) query.Field.Add(new QueryField((_tempVal.Substring(0, _tempVal.IndexOf("=>") - 1).Trim()), _tempVal.Substring(_tempVal.IndexOf("=>") + 2, _tempVal.Length - _tempVal.IndexOf("=>") - 2).Trim()));
                else
                    query.Field.Add(new QueryField(_tempVal));

            }
        }
    }
}
