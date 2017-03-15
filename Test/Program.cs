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
            parameters.Add("Database", "atakumgis");
            parameters.Add("User Id", "postgres");
            parameters.Add("Password", "ntc123*");


            var mydatabase = new CHXDatabaseLibrary.CHXDatabase(parameters, CHXDatabaseLibrary.CHXDatabaseType.PostgreSql);
            var manager = new CHXDatabaseLibrary.CHXDatabaseManager(mydatabase);



            var result = manager.RunQuery<string>(@"{ ""server"": ""kbb2"", ""schema"": ""public"", ""query"": { ""geoyol"": { ""type"": ""table"", ""addgeometry"": true, ""field"": [ ""objectid"", ""yol_adi"" ], ""find"": [ { ""yol_tipi_id"": 4, ""yol_turu_id"": 5 }, { ""yol_turu_id"": 4 } ] }, ""kod_yol_turu"": { ""type"": ""table"", ""field"": [ ""adi => yol_turu"" ] }, ""kod_yol_tipi"": { ""type"": ""table"", ""field"": [ ""adi => yol_tipi"" ] } }, ""join"": { ""inner"": [ { ""geoyol.yol_turu_id"": ""kod_yol_turu.objectid"" } ], ""left"": [ { ""geoyol.yol_tipi_id"": ""kod_yol_tipi.objectid"" } ] }, ""group"": [ ""geoyol.yol_adi"", ""kod_yol_turu.adi"" ] }", 
                                                    CHXDatabaseLibrary.CHXQueryType.Json);


        }
    }
}
