using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetehanTopac_AdamAsmaca.Classes
{
    class Oyun
    {
        string[] kelimeler = new string[]
        {
            "M e r c a n ", "K a n g u r u ", "K e ç i ", "Z ü r a f a ", "A y ı ", "K a p l a n ", "O r n i t o r e n k ", "Ö r d e k ", "T ı r t ı l ", "Y e n g e ç "
        };
        Random random = new Random();
        byte kelimesecim;
        string kelime;
        public string KelimeSec()
        {
            kelimesecim = (byte)random.Next(1, 10);
            kelime = kelimeler[kelimesecim].ToLower();
            return kelime;
        }
        
    }
}
