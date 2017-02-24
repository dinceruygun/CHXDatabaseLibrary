﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseCommands
{
    public abstract class ICHXDatabaseCommand
    {
        CHXDatabase _database;

        public CHXDatabase Database
        {
            get
            {
                return _database;
            }
        }


        public ICHXDatabaseCommand(CHXDatabase database)
        {
            _database = database;
        }



        public abstract CHXQuery GetDependsTableList(string schemaName, string tableName);

        public abstract CHXQuery GetAllIndex();

        public abstract DatabaseFeatures.CHXConstraintType GetConstraintType(DatabaseFeatures.CHXConstraint constraint);

        public abstract CHXQuery GetAllConstraint();

        public abstract CHXQuery GetSequence(string sequenceName);

        public abstract CHXQuery GetAllSequence();

        public abstract CHXQuery GetAllTable();

        public abstract CHXQuery GetAllView();

        public abstract CHXQuery GetColumns(string schemaName, string tableName);

        public abstract CHXQuery GetAllGeometryColumns();
    }
}
