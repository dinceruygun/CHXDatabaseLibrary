using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter
{
    public abstract class ICHXConverter
    {
        public abstract object Recycle(object data, object target);
        public abstract object Run(object data);
        public abstract object Run(object data, string needProperty);
    }
}
