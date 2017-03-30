using CHXGeoJson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using CHXDatabase;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var tt = new CHXGeometry();
            tt.ReadWkt("MULTILINESTRING((31.4496904 36.7991082,31.4504789 36.7986288), (31.4496904 36.7991082,31.4504789 36.7986288))");

            var parameters = new CHXDatabaseParameters();

            parameters.Add("Server", "192.168.2.188");
            parameters.Add("Port", "5432");
            parameters.Add("Database", "atakumgis");
            parameters.Add("User Id", "postgres");
            parameters.Add("Password", "ntc123*");
            

            var mydatabase = new CHXDatabase.IO.CHXDatabase(parameters, CHXDatabaseType.PostgreSql);
            var manager = new CHXDatabaseLibrary.CHXDatabaseManager(mydatabase);



            //var query = manager.ConvertQuery<string>(@"{ ""server"": ""kbb2"", ""schema"": ""public"", ""query"": { ""geoyol"": { ""type"": ""table"", ""addgeometry"": true, ""field"": [ ""objectid"", ""yol_adi"" ], ""find"": [ { ""yol_tipi_id"": 4, ""yol_turu_id"": 5 }, { ""yol_turu_id"": 4 } ] }, ""kod_yol_turu"": { ""type"": ""table"", ""field"": [ ""adi => yol_turu"" ] }, ""kod_yol_tipi"": { ""type"": ""table"", ""field"": [ ""adi => yol_tipi"" ] } }, ""join"": { ""inner"": { ""kod_yol_turu.kod"": ""geoyol.yol_turu_id"" }, ""left"": { ""kod_yol_tipi.kod"": ""geoyol.yol_tipi_id"" } } }", 
            //                                        CHXDatabaseLibrary.CHXQueryType.Json);

            //var query = manager.ConvertQuery<string>(@"{ ""server"": ""atakumgis"", ""schema"": ""public"", ""query"": { ""parsel"": { ""type"": ""table"", ""addgeometry"": true, ""field"": [ ""objectid"", ""adaparsel"", ""alan"" ], ""find"": [ { ""tapu_mah_adi"": ""AKALAN"" } ], ""geo_shape"": { ""location"": { ""shape"": { ""type"": ""Point"", ""coordinates"" : [515458.256064797, 4585609.61491352] }, ""relation"": ""intersect"" } } } } }",
            //                                        CHXQueryType.Json);


            var query = manager.ConvertQuery<string>(@"{ ""server"": ""atakumgis"", ""schema"": ""public"", ""query"": { ""parsel"": { ""type"": ""table"", ""addgeometry"": true, ""field"": [ ""objectid"", ""adaparsel"", ""alan"" ], ""geo_shape"": { ""location"": { ""shape"": { ""type"": ""Point"", ""coordinates"" : [515458.256064797, 4585609.61491352] }, ""relation"": ""distance"", ""distance"" : 20 } } } } }",
                                                    CHXQueryType.Json);


            var result = manager.RunQuery<dynamic>(query);

            var json = JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented,
                new Newtonsoft.Json.JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
                );
        }
    }
}
