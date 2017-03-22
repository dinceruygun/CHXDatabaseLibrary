using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection
{
    public class CHXJsonJoin : ICHXJsonItemConverter
    {
        public override void Convert(dynamic jsonItem, ref QueryContainer query)
        {
            //Tablolar arası ilişkiler dönüştürülüyor
            if (jsonItem != null)
            {
                foreach (var j in jsonItem.Value)
                {
                    var _joinType = JoinType.INNER;

                    if (j.Name == "inner") _joinType = JoinType.INNER;
                    if (j.Name == "left") _joinType = JoinType.LEFT;
                    if (j.Name == "right") _joinType = JoinType.RIGHT;


                    if (j.Value != null)
                    {
                        foreach (var item in j.Value)
                        {
                            var join = new QueryJoin();
                            join.joinType = _joinType;
                            join.Destination = item.Name;
                            join.Target = item.Value;


                            query.Join.Add(join);
                        }
                    }
                }
            }
        }
    }
}
