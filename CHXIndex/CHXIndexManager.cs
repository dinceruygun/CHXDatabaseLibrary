using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis;
using Lucene.Net.Index;
using Lucene.Net.Documents;
using Lucene.Net.Search;
using Lucene.Net.QueryParsers;
using System.Data;

namespace CHXIndex
{
    public class CHXIndexManager
    {
        string _rootFolder;
        string _indexName;
        private Lucene.Net.Store.Directory directory = null;

        

        private Lucene.Net.Analysis.Analyzer analyzer;
        private Lucene.Net.Index.IndexWriter writer;
        internal IndexSearcher _searcher;

        public string RootFolder
        {
            get
            {
                return _rootFolder;
            }
        }

        public IndexWriter Writer
        {
            get
            {
                return writer;
            }
        }

        public Analyzer Analyzer
        {
            get
            {
                return analyzer;
            }
        }

        public IndexSearcher Searcher
        {
            get
            {
                if (_searcher == null)
                    _searcher = new IndexSearcher(Directory, true);

                return _searcher;
            }
        }


        public Lucene.Net.Store.Directory Directory
        {
            get
            {
                return directory;
            }
        }

        public string IndexName
        {
            get
            {
                return _indexName;
            }
        }

        public CHXIndexManager(string indexName)
        {
            this._indexName = indexName;

            CheckDirectory();

            Initialize();
        }

        public CHXIndexManager():this("Root")
        {

        }


        internal void Initialize()
        {
            directory = SearchDirectory.DirectoryFactory.GetDirectory(RootFolder);
            analyzer = SearchAnalyzer.AnalyzerFactory.GetAnalyzer();
            writer = new IndexWriter(directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED);
        }


        internal bool CheckDirectory(string path)
        {
            var assemblyFolder = AppDomain.CurrentDomain.BaseDirectory;
            this._rootFolder = System.IO.Path.Combine(assemblyFolder, path);

            if (!System.IO.Directory.Exists(this.RootFolder))
                System.IO.Directory.CreateDirectory(this.RootFolder);


            return true;
        }


        internal bool CheckDirectory()
        {
            return CheckDirectory(System.IO.Path.Combine("CHXIndex", this.IndexName));
        }



        internal DataTable Search(Query query, int recordCount)
        {
            var documents = new List<Document>();
            var result = Searcher.Search(query, null, recordCount);
            foreach (var item in result.ScoreDocs)
            {
                documents.Add(Searcher.Doc(item.Doc));
            }

            var collections = DocumentsToTable(documents);

            return collections;
        }


        public DataTable Search(CHXFilters filters, int recordCount = 1000000)
        {
            var query = FilterToQuery(filters);
            if (query == null) return null;

            var result = Search(query, recordCount);

            return result;
        }


        internal Query FilterToQuery(CHXFilters filters)
        {
            if (filters == null) return null;
            if (filters.Count < 1) return null;

            var booleanQuery = new BooleanQuery();


            foreach (var filter in filters)
            {
                var _QueryParser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, filter.Field, Analyzer);
                var _Query = _QueryParser.Parse(filter.Value);

                booleanQuery.Add(_Query, filter.LuceneOperator);
            }

            return booleanQuery;
        }

        public void Index(Dictionary<string, string> values)
        {
            if (values == null) return;

            var doc = new Document();

            foreach (var value in values)
            {
                if (!doc.GetFields().Select(f => f.Name == value.Key).FirstOrDefault())
                {
                    doc.Add(new Field(value.Key, value.Value, Field.Store.YES, Field.Index.ANALYZED));
                }
            }

            Writer.AddDocument(doc);

            Writer.Optimize();
            Writer.Commit();
        }

        public void Index(string name, string value)
        {
            var doc = new Document();
            doc.Add(new Field(name, value, Field.Store.YES, Field.Index.ANALYZED));

            Writer.AddDocument(doc);

            Writer.Optimize();
            Writer.Commit();
        }

        public void Index(DataTable table)
        {
            var docs = TableToDocuments(table);

            foreach (var doc in docs)
            {
                Writer.AddDocument(doc);
            }

            Writer.Optimize();
            Writer.Commit();
        }


        public void Delete(CHXFilters filters)
        {
            var query = FilterToQuery(filters);
            if (query == null) return;
            Writer.DeleteDocuments(query);

            Writer.Optimize();
            Writer.Commit();
        }



        internal DataTable DocumentsToTable(List<Document> documents)
        {
            if (documents == null) return null;
            if (documents.Count < 1) return null;

            int tableId = 0;
            var table = new DataTable(tableId.ToString());

            foreach (var field in documents[0].GetFields())
                table.Columns.Add(field.Name);

            int counter = 0;
            foreach (var doc in documents)
            {
                table.Rows.Add(table.NewRow());

                foreach (DataColumn col in table.Columns)
                {
                    table.Rows[counter][col] = doc.GetField(col.ColumnName).StringValue;
                }

                counter++;
            }


            return table;
        }



        internal List<Document> TableToDocuments(DataTable table)
        {
            List<Document> docList = new List<Document>();


            foreach (DataRow row in table.Rows)
            {
                var doc = new Document();

                foreach (DataColumn col in table.Columns)
                {
                    doc.Add(new Field(col.ColumnName, row[col] == null ? "" : row[col].ToString(), Field.Store.YES, Field.Index.ANALYZED));
                }

                docList.Add(doc);
            }

            return docList;
        }

    }
}
