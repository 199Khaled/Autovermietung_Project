using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsHilfsMethoden
{
    public class clsNummerFormatierung
    {
        public static string FormatiereKundenNummer(int kundenNummer)
        {
            return $"#Fahr-{kundenNummer:D4}";  //D4 gibt an, dass die Zahl auf vier Stellen aufgefüllt wird.
        }
    }
}
