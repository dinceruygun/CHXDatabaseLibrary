using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXGeoJson
{
    public class CHXFeatureCollection
    {
        CHXFeatures _features;
        public string type { get; set; }
        public CHXFeatures features
        {
            get
            {
                return _features;
            }

            set
            {
                _features = value;
            }
        }

        

        public CHXFeatureCollection()
        {
            _features = new CHXFeatures();
        }
    }
}
