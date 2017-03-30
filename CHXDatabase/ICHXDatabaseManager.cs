using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO.DatabaseFeatures;

namespace CHXDatabase.IO
{
    public abstract class ICHXDatabaseManager
    {
        public abstract CHXIndexCollection Indexes { get; }
        public abstract CHXConstraintCollection Constraints { get; }
        public abstract CHXSequenceCollection Sequences { get; }
        public abstract CHXTableCollection Views { get; }
        public abstract CHXGeometryColumns GeometryColumnCollection { get; }
        public abstract CHXTableCollection Tables { get; }
        public abstract CHXDatabase Database { get; set; }
        public abstract ICHXCommandManager CommandManager { get; }
        public abstract bool Status { get; }
        public abstract string Version { get; }


        public abstract QueryContainer ConvertQuery<T>(T data, CHXQueryType queryType);

        public abstract IEnumerable<T> RunQuery<T>(QueryContainer queryContainer);

        public abstract IEnumerable<T> RunQuery<T>(CHXQuery query);

        public abstract void LoadGeometryColumnsContainer();
    }
}
