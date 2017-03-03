using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter.CHXHttpConverter
{
    public abstract class ICHXHtppRequestConverter
    {
        public abstract object Run(string data);
    }
}
