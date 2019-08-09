using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Slovo
    {
        // Dozvoljeni znakovi su samo slova uključujiući i Č Ć Ž Š Đ
        // Vraća true ako je prosledjeni parametar jedan od dozvoljenih znakova
        static public bool ProveriSlovo(int c)
        {
            if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122) || c == 268 || c == 269 ||
                c == 262 || c == 263 || c == 381 || c == 382 || c == 352 || c == 353 || c == 272 || c == 273)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
