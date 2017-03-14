using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex.SearchAnalyzer
{
    public static class AnalyzerFactory
    {
        private static object _locker = new object();

        public static Analyzer GetAnalyzer()
        {
            lock (_locker)
            {
                return new StandardAnalyzer(Version);
            }
        }


        public static Lucene.Net.Util.Version Version
        {
            get { return Lucene.Net.Util.Version.LUCENE_30; }
        }
    }
}
