using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXConverter.CHXHttpConverter
{
    public abstract class ICHXHtppRequestConverter
    {
        public abstract CHXRequest RunInnerMethod(object data);
        public abstract object RecycleInnerMethod(object data);


        public CHXRequest Run(object data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var result = RunInnerMethod(data);

            stopwatch.Stop();

            if (result != null)
                result.Elapsed = stopwatch.Elapsed;


            return result;
        }





        public object Recycle(object data)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var result = RecycleInnerMethod(data);

            stopwatch.Stop();


            return result;
        }
    }
}
