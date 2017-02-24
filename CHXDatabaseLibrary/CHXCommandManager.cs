using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabaseLibrary.DatabaseCommands;

namespace CHXDatabaseLibrary
{
    public class CHXCommandManager
    {
        private CHXDatabase _database;
        private DatabaseCommands.ICHXDatabaseCommand _commands;

        public CHXDatabase Database
        {
            get
            {
                return _database;
            }
        }

        public ICHXDatabaseCommand Commands
        {
            get
            {
                return _commands;
            }
        }

        public CHXCommandManager()
        {

        }

        public CHXCommandManager(CHXDatabase _database)
        {
            this._database = _database;

            Init();
        }


        protected void Init()
        {
            _commands = DatabaseCommands.CHXDatabaseCommandFactory.GetDatabaseCommand(Database);

            if (_commands != null)
            {

            }
        }

    }
}
