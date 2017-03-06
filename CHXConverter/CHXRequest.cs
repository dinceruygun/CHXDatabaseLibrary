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

        public CHXRequest()
        {
            _parameters = new CHXParameter();
        }
    }
}
