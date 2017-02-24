using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var parameters = new CHXDatabaseLibrary.CHXDatabaseParameters();

            parameters.Add("Server", "192.168.2.188");
            parameters.Add("Port", "5432");
            parameters.Add("Database", "kbb_test");
            parameters.Add("User Id", "postgres");
            parameters.Add("Password", "ntc123*");


            var mydatabase = new CHXDatabaseLibrary.CHXDatabase(parameters, CHXDatabaseLibrary.CHXDatabaseType.PostgreSql);
            var manager = new CHXDatabaseLibrary.CHXDatabaseManager(mydatabase);



            //foreach (var cons in manager.Constraints)
            //{

            //}

            foreach (var table in manager.Views)
            {
                Console.WriteLine(table.ToString());
                Console.WriteLine(table.DependsTableList.Count.ToString());
            }


            //foreach (var seq in manager.Sequences)
            //{
            //    var i = seq.CurrentValue;
            //}


            Console.ReadKey(true);
        }
    }
}
