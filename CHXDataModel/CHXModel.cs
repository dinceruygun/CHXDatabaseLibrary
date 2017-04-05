using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataModel
{
    public class CHXModel
    {
        string _name;
        string _queryString;
        

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string QueryString
        {
            get
            {
                return _queryString;
            }

            set
            {
                _queryString = value;
            }
        }
    }
}
