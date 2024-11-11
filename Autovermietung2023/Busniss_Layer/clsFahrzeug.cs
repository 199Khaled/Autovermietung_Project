using Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Layer
{
    public class clsFahrzeug
    {
        public enum enMode { addnew = 0, update = 1 }
        private enMode _mode = enMode.addnew;
        public int fahrzeugNummer { get; set; }
        public string bezeichnung { get; set; }
        public string kennzeichen { get; set; }
        public float preisProTag { get; set; }
        public string typ {  get; set; }
        public bool ausgeliehen { get; set; }
        public bool reserviert { get; set; }

        private clsFahrzeug(int fahzeugNummer, string bezeichnung, string kennzeichen, 
            float preisProTag, string typ, bool ausgeliehen, bool reserviert)
        {
            this.fahrzeugNummer = fahzeugNummer;
            this.bezeichnung = bezeichnung;
            this.kennzeichen = kennzeichen;
            this.preisProTag = preisProTag;
            this.typ = typ;
            this.ausgeliehen = ausgeliehen;
            this.reserviert = reserviert;

            _mode = enMode.update;
        }

        public clsFahrzeug()
        {
            this.fahrzeugNummer = -1;
            this.bezeichnung = string.Empty;
            this.kennzeichen = string.Empty;
            this.preisProTag = 0;
            this.typ = string.Empty;
            this.ausgeliehen = false;
            this.reserviert = false;
        }

        public static DataTable GetAllVerfügbareFahrzeuge()
        {
            return clsFahrzeugDatenzugriff.GetAllVerfügbareFahrzeuge();
        }

        public static DataTable GetAllFahrzeugType()
        {
            return clsFahrzeugDatenzugriff.GetAllFahrzeugType();
        }

        public static DataTable GetFahrzeugDatenByTyp(string typ)
        {
            return clsFahrzeugDatenzugriff.GetFahrzeugDatenByType(typ);
        }

        public static float GetPreisProTagByBezeichnung(string bezeichnung, string typ)
        {
            return clsFahrzeugDatenzugriff.GetPreisProTagByBezeichnungAndTyp(bezeichnung, typ);
        }

        public static clsFahrzeug GetFahrzeugDatenByBezeichnungAndTyp(string bezeichnung, string typ)
        {
            clsFahrzeugDatenzugriff.stFahrzeug fahrzeug = new clsFahrzeugDatenzugriff.stFahrzeug();

            fahrzeug.bezeichnung = bezeichnung;
            fahrzeug.typ = typ;

            bool isfound = clsFahrzeugDatenzugriff.GetFahrzeugDatenByBezeichnungAndTyp(ref fahrzeug);

            if (isfound)
            {
                return new clsFahrzeug(fahrzeug.fahrzeugNummer, fahrzeug.bezeichnung, fahrzeug.kennzeichen,
                    fahrzeug.preisProTag, fahrzeug.typ, fahrzeug.ausgeliehen, fahrzeug.reserviert);
            }
            else
                return null;
        }

        public static bool SetzeFahrzeugAlsReserviert(int fahrzeugNummer)
        {
            return clsFahrzeugDatenzugriff.SetzeFahrzeugAlsReserviert(fahrzeugNummer);
        }
    }
}
