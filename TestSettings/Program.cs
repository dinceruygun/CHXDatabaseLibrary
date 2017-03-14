using CHXSettings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new denemeList();
            list.Add(new deneme() { adi = "dinçer", soyadi = "uygun" });
            list.Add(new deneme() { adi = "netcad", soyadi = "yazılım" });


            var data = JsonConvert.SerializeObject(list);

            //CHXSettingsManager.Set("ayarlar", data);

            Console.WriteLine(CHXSettingsManager.Get("databaselist"));

            Console.ReadKey(true);
        }
    }


    class denemeList : List<deneme>
    {

    }


    class deneme
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
    }
}
