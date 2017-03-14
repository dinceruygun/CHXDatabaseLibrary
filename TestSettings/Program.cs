using CHXSettings;
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
            CHXSettingsManager.Set("ayarlar", "deneme ayar");
        }
    }
}
