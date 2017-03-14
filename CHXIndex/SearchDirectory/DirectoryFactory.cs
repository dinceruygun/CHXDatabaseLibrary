using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex.SearchDirectory
{
    public static class DirectoryFactory
    {
        private static object _locker = new object();

        public static Lucene.Net.Store.Directory GetDirectory(string Path)
        {
            lock (_locker)
            {
                SearchDirectory.IDirectory factoryDirectory;

                if (string.IsNullOrEmpty(Path))
                    factoryDirectory = new SearchDirectory.RamDirectory();
                else
                    factoryDirectory = new SearchDirectory.FileDirectory(Path);

                return factoryDirectory.Open();
            }
        }

        public static Lucene.Net.Store.Directory GetDirectory() => GetDirectory(null);
    }
}
