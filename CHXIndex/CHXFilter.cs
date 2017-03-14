using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXIndex
{

    public class CHXFilters : List<CHXFilter>
    {
    }


    public class CHXFilter
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public CHXQueryOperator Operator { get; set; }

        internal Occur LuceneOperator
        {
            get
            {
                switch (Operator)
                {
                    case CHXQueryOperator.AND:
                        return Occur.MUST;
                    case CHXQueryOperator.OR:
                        return Occur.SHOULD;
                    case CHXQueryOperator.NOTIN:
                        return Occur.MUST_NOT;
                    default:
                        return Occur.MUST;
                }
            }
        }
    }
}
