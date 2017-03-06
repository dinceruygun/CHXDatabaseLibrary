using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    public class CHXRequest
    {
        CHXParameter _parameters;
        TimeSpan _elapsed;

        public CHXParameter Parameters
        {
            get
            {
                return _parameters;
            }

            set
            {
                _parameters = value;
            }
        }

        public TimeSpan Elapsed
        {
            get
            {
                return _elapsed;
            }

            set
            {
                _elapsed = value;
            }
        }

        public CHXParameter Find(string key)
        {
            return findParameter(key, this.Parameters);
        }

        protected CHXParameter findParameter(string key, CHXParameter parameter)
        {
            if (parameter == null) return null;

            var result = parameter.Find(p => p.Name == key);

            if(result == null)
            {
                foreach (var item in parameter)
                {
                    result = findParameter(key, item);

                    if (result != null) return result;
                }
            }

            return result;
        }

        public CHXRequest()
        {
            _parameters = new CHXParameter();
        }
    }
}
