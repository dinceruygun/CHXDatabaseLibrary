using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex.SearchDirectory
{
    public class FileDirectory : IDirectory
    {
        string _path;

        public FileDirectory(string path)
        {
            _path = path;
        }

        public string Path
        {
            get
            {
                return _path;
            }

        }

        public override Directory Open()
        {
            if (!System.IO.Directory.Exists(Path)) System.IO.Directory.CreateDirectory(Path);

            var luceneDirectory = FSDirectory.Open(Path);

            return luceneDirectory;
        }

    }
}
