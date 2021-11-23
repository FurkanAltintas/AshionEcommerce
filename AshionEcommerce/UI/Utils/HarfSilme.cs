using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.Utils
{
    public class Harfler
    {
        public static string HarfSil(string kelime)
        {
            if (kelime == "" || kelime == null) { return string.Empty; }

            //büyük sil
            kelime = kelime.Replace("A", "");
            kelime = kelime.Replace("B", "");
            kelime = kelime.Replace("C", "");
            kelime = kelime.Replace("Ç", "");
            kelime = kelime.Replace("D", "");
            kelime = kelime.Replace("E", "");
            kelime = kelime.Replace("F", "");
            kelime = kelime.Replace("G", "");
            kelime = kelime.Replace("Ğ", "");
            kelime = kelime.Replace("H", "");
            kelime = kelime.Replace("İ", "");
            kelime = kelime.Replace("I", "");
            kelime = kelime.Replace("J", "");
            kelime = kelime.Replace("K", "");
            kelime = kelime.Replace("L", "");
            kelime = kelime.Replace("M", "");
            kelime = kelime.Replace("N", "");
            kelime = kelime.Replace("O", "");
            kelime = kelime.Replace("Ö", "");
            kelime = kelime.Replace("P", "");
            kelime = kelime.Replace("R", "");
            kelime = kelime.Replace("S", "");
            kelime = kelime.Replace("Ş", "");
            kelime = kelime.Replace("T", "");
            kelime = kelime.Replace("U", "");
            kelime = kelime.Replace("Ü", "");
            kelime = kelime.Replace("V", "");
            kelime = kelime.Replace("Y", "");
            kelime = kelime.Replace("Z", "");

            //küçük sil
            kelime = kelime.Replace("a", "");
            kelime = kelime.Replace("b", "");
            kelime = kelime.Replace("c", "");
            kelime = kelime.Replace("ç", "");
            kelime = kelime.Replace("d", "");
            kelime = kelime.Replace("e", "");
            kelime = kelime.Replace("f", "");
            kelime = kelime.Replace("g", "");
            kelime = kelime.Replace("ğ", "");
            kelime = kelime.Replace("h", "");
            kelime = kelime.Replace("i", "");
            kelime = kelime.Replace("ı", "");
            kelime = kelime.Replace("j", "");
            kelime = kelime.Replace("k", "");
            kelime = kelime.Replace("l", "");
            kelime = kelime.Replace("m", "");
            kelime = kelime.Replace("n", "");
            kelime = kelime.Replace("o", "");
            kelime = kelime.Replace("ö", "");
            kelime = kelime.Replace("p", "");
            kelime = kelime.Replace("r", "");
            kelime = kelime.Replace("s", "");
            kelime = kelime.Replace("ş", "");
            kelime = kelime.Replace("t", "");
            kelime = kelime.Replace("u", "");
            kelime = kelime.Replace("ü", "");
            kelime = kelime.Replace("v", "");
            kelime = kelime.Replace("y", "");
            kelime = kelime.Replace("z", "");


            return kelime;
        }

    }
}