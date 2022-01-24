using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetConverter
{
   static class Primer
    {
        public static string TranslateToLeet(string leetOutString ,char letter)
        {
            switch (letter)
            {

//Englist letters:

                case 'a': leetOutString += '4'; break;

                case 'b': leetOutString += '8'; break;

                case 'c': leetOutString += '<'; break;

                case 'd': leetOutString += "D"; break;

                case 'e': leetOutString += '3'; break;

                case 'f': leetOutString += 'F'; break;

                case 'g': leetOutString += '6'; break;

                case 'h': leetOutString += 'H'; break;

                case 'i': leetOutString += '!'; break;

                case 'j': leetOutString += 'J'; break;

                case 'k': leetOutString += 'K'; break;

                case 'l': leetOutString += '1'; break;

                case 'm': leetOutString += "nn"; break;

                case 'n': leetOutString += 'N'; break;

                case 'o': leetOutString += '0'; break;

                case 'p': leetOutString += 'P'; break;

                case 'q': leetOutString += 'Q'; break;

                case 'r': leetOutString += "|2"; break;

                case 's': leetOutString += '5'; break;

                case 't': leetOutString += '7'; break;

                case 'u': leetOutString += 'U'; break;

                case 'v': leetOutString += @"\/"; break;

                case 'w': leetOutString += "vv"; break;

                case 'x': leetOutString += "}{"; break;

                case 'y': leetOutString += 'Y'; break;

                case 'z': leetOutString += '2'; break;

//Russian letters:

                case 'а': leetOutString += '4'; break;

                case 'б': leetOutString += '6'; break;

                case 'в': leetOutString += '8'; break;

                case 'г': leetOutString += 'g'; break;

                case 'д': leetOutString += 'D'; break;

                case 'е': leetOutString += '3'; break;

                case 'ё': leetOutString += 'Ё'; break;

                case 'ж': leetOutString += "}|{"; break;

                case 'з': leetOutString += 'З'; break;

                case 'и': leetOutString += '1'; break;

                case 'й': leetOutString += "u*"; break;

                case 'к': leetOutString += 'K'; break;

                case 'л': leetOutString += "/|"; break;

                case 'м': leetOutString += "nn"; break;

                case 'н': leetOutString += 'Н'; break;

                case 'о': leetOutString += '0'; break;

                case 'п': leetOutString += 'n'; break;

                case 'р': leetOutString += 'P'; break;

                case 'с': leetOutString += '5'; break;

                case 'т': leetOutString += '7'; break;

                case 'у': leetOutString += "00"; break;

                case 'ф': leetOutString += "qp"; break;

                case 'х': leetOutString += "}{"; break;

                case 'ц': leetOutString += "L|"; break;

                case 'ч': leetOutString += "ch"; break;

                case 'ш': leetOutString += 'W'; break;

                case 'щ': leetOutString += "W"; break;

                case 'ъ': leetOutString += "'b"; break;

                case 'ы': leetOutString += "b|"; break;

                case 'ь': leetOutString += 'b'; break;

                case 'э': leetOutString += "-)"; break;

                case 'ю': leetOutString += "|0"; break;

                case 'я': leetOutString += "9|"; break;

                default: leetOutString += letter; break;
            }

            return leetOutString;
        }
    }

}
