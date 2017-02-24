using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXTable: ICHXDatabaseFeature
    {
        string _tableName;
        string _schemaName;
        string _ownerName;
        CHXColumns _columns;
        CHXSequenceCollection _sequences;
        CHXConstraintCollection _constraints;
        CHXIndexCollection _indexes;
        CHXTableCollection _dependsTableList;
        bool _isView = false;


        public string TableName
        {
            get
            {
                return _tableName;
            }

            set
            {
                _tableName = value;
            }
        }

        public string SchemaName
        {
            get
            {
                return _schemaName;
            }

            set
            {
                _schemaName = value;
            }
        }

        public string OwnerName
        {
            get
            {
                return _ownerName;
            }

            set
            {
                _ownerName = value;
            }
        }

        public CHXColumns Columns
        {
            get
            {
                if (_columns == null)
                {
                    _columns = new CHXColumns();
                    _columns.AddRange(base.DatabaseManager.RunQuery<CHXColumn>(base.DatabaseManager.CommandManager.Commands.GetColumns(this.SchemaName, this.TableName)));
                    _columns.ForEach(t => t.SetDatabaseManager(base.DatabaseManager));
                    _columns.ForEach(t => t.Table = this);
                }

                return _columns;
            }

            set
            {
                _columns = value;
            }
        }

        public bool IsSpatial
        {
            get
            {
                return (GeometryColumn == null ? false : true);
            }
        }

        public CHXGeometryColumn GeometryColumn
        {
            get
            {
                return base.DatabaseManager.GeometryColumnCollection.Find(g => g.TableName == this.TableName && g.SchemaName == this.SchemaName);
            }
        }

        public CHXSequenceCollection Sequences
        {
            get
            {
                if (_sequences == null)
                {
                    _sequences = new CHXSequenceCollection();
                    _sequences.AddRange(base.DatabaseManager.Sequences.Where(s => s.TableName == this.TableName && s.SchemaName == this.SchemaName));
                }

                return _sequences;
            }
        }

        public CHXConstraintCollection Constraints
        {
            get
            {
                if (_constraints == null)
                {
                    _constraints = new CHXConstraintCollection();
                    _constraints.AddRange(base.DatabaseManager.Constraints.Where(c => c.TableName == this.TableName && c.SchemaName == this.SchemaName));
                }

                return _constraints;
            }
        }

        public CHXIndexCollection Indexes
        {
            get
            {
                if (_indexes == null)
                {
                    _indexes = new CHXIndexCollection();

                    _indexes.AddRange(base.DatabaseManager.Indexes.Where(i => i.TableName == this.TableName && i.SchemaName == this.SchemaName));
                }

                return _indexes;
            }
        }

        public CHXTableCollection DependsTableList
        {
            get
            {
                if (_dependsTableList == null)
                {
                    _dependsTableList = new CHXTableCollection();


                    if (!IsView)
                    {
                        var tempDependsTable = base.DatabaseManager.RunQuery<CHXTable>(base.DatabaseManager.CommandManager.Commands.GetDependsTableList(this.SchemaName, this.TableName));

                        foreach (var table in tempDependsTable)
                            _dependsTableList.AddRange(base.DatabaseManager.Views.Where(t => t.TableName == table.TableName && t.SchemaName == table.SchemaName));


                        tempDependsTable = null;
                    }
                    else
                    {
                        foreach (var table in base.DatabaseManager.Tables)
                        {
                            var temp = table.DependsTableList.Find(d => d.TableName == this.TableName && d.SchemaName == this.SchemaName);
                            if (temp != null)
                            {
                                _dependsTableList.Add(table);
                            }
                        }

                        //_dependsTableList.AddRange(base.DatabaseManager.Tables.Where(t => t.TableName == t.DependsTableList.Find(d => d.TableName == this.TableName && d.SchemaName == this.SchemaName)?.TableName && t.SchemaName == this.SchemaName));
                    }


                }

                return _dependsTableList;
            }
        }

        public bool IsView
        {
            get
            {
                return _isView;
            }

            set
            {
                _isView = value;
            }
        }

        public CHXTable()
        {
            
        }


        public override string ToString()
        {
            return $"{SchemaName}.{TableName}";
        }



    }
}
