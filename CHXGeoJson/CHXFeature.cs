using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXGeoJson
{
    public class CHXFeature
    {
        public string type = "Feature";
        public CHXGeometry geometry { get; set; }
        public IDictionary<string, object> properties { get; set; }


        public CHXFeature()
        {

        }

    }
}
