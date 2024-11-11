using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsHilfsMethoden
{
    public class clsNummerFormatierung
    {
        public static string FormatiereEingefügteNummer(string name, int kundenNummer)
        {        
              return $"#{name}-{kundenNummer:D5}";  //D4 gibt an, dass die Zahl auf vier Stellen aufgefüllt wird.
        }
    }
}
