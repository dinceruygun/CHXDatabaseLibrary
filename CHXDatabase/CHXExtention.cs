using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO
{
    public static class CHXExtention
    {
        /// <summary>
        /// Boşluk karakteri de dahil olmak üzere özel karakter içerip içermediği kontrol edilir
        /// </summary>
        /// <param name="yourString"></param>
        /// <returns></returns>
        public static bool HasSpecialChars(this string yourString)
        {
            return yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }
    }
}
