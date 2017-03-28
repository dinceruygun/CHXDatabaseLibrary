using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;


namespace CHXDatabaseLibrary
{
    public class CHXCommandManager: ICHXCommandManager
    {
        
        private CHXDatabase.IO.CHXDatabase _database;
        private ICHXDatabaseCommand _commands;

        public CHXDatabase.IO.CHXDatabase Database
        {
            get
            {
                return _database;
            }
        }

        public override ICHXDatabaseCommand Commands
        {
            get
            {
                return _commands;
            }
        }

        public CHXCommandManager()
        {

        }

        public CHXCommandManager(CHXDatabase.IO.CHXDatabase _database)
        {
            this._database = _database;

            Init();
        }


        protected void Init()
        {
            _commands = CHXDatabaseCommandFactory.GetDatabaseCommand(Database);

            if (_commands != null)
            {

            }
        }

    }
}
