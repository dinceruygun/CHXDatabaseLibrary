using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json
{
    public abstract class ICHXJsonItemConverter
    {
        public abstract void Convert(dynamic jsonItem, ref QueryContainer query);
    }
}
