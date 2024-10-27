using Data_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Busniss_Layer.clsPerson;

namespace Busniss_Layer
{
    public class clsKunde : clsPerson
    {
        public enum enMode { addnew = 0, update }
        private enMode _mode = enMode.addnew;

        public int kundeNummer { get; set; }
        public DateTime  kundeSeit { get; set; }
        public string lizenzNummer { get; set; }
        public DateTime ausstellungDatum { get; set; }
        public DateTime ablaufDatum { get; set; }
        public string lizenzFoto { get; set; }
        public bool istAktive { get; set; }

        private clsKunde(int personID,  string vorname, string nachname,
                  DateTime geburtsTag, enGeschlecht geschlecht, string strasse,
                  string postleitzahl, string ort,
                  int KundeNummer, DateTime kundeSeit, string lizenzNummer, 
                  DateTime ausstellungsDatum, DateTime ablaufDatum,
                  string lizenzFoto, bool istAktive)
            :base(personID,vorname, nachname,geburtsTag, geschlecht, strasse,  postleitzahl, ort)
        {
            this.kundeNummer = KundeNummer;
            this.kundeSeit = kundeSeit;
            this.lizenzNummer = lizenzNummer;
            this.ausstellungDatum = ausstellungsDatum;
            this.ablaufDatum = ablaufDatum;
            this.lizenzFoto = lizenzFoto;
            this.istAktive = istAktive;

            _mode = enMode.update;
        }

        public clsKunde()
        {
            this.kundeNummer = -1;
            this.kundeSeit = DateTime.Now;
            this.lizenzNummer = string.Empty;
            this.ausstellungDatum = DateTime.MinValue;
            this.ablaufDatum = DateTime.MinValue;
            this.lizenzFoto = string.Empty;
            this.istAktive = true;

            _mode = enMode.addnew;
        }

        public static clsKunde FindByKundenNummer(int kundenNummer)
        {
            //wir erzeugen zwei Objekte von stPerson und stKuden um die daten zu repräsentieren.

            clsKundeDatenzugriff.stPerson person = new clsKundeDatenzugriff.stPerson();
            clsKundeDatenzugriff.stKunde kunde = new clsKundeDatenzugriff.stKunde();

            bool isfound = clsKundeDatenzugriff.FindKundeByKundeNummer(kundenNummer, ref person, ref kunde);

            if (isfound)
            {
                return new clsKunde(person.PersonID, person.Name, person.Vorname, person.GeburtsDatum,
                    (enGeschlecht)person.Geschlecht, person.Straße,
                    person.Postleitzahl, person.Ort, kundenNummer, kunde.kundeSeit,
                    kunde.lizenzNummer, kunde.ausstellungDatum, kunde.ablaufDatum,
                    kunde.lizenzFoto, kunde.istAktive);
            }
            else
                return null;
        }
        private bool _Addnew()
        {
            clsKundeDatenzugriff.stKunde kundeDaten = new clsKundeDatenzugriff.stKunde()
            {
                personID = this.personID,
                kundeSeit = this.kundeSeit,
                lizenzNummer = this.lizenzNummer,
                ausstellungDatum = this.ausstellungDatum,
                ablaufDatum = this.ablaufDatum,
                lizenzFoto = this.lizenzFoto,
                istAktive = this.istAktive
            };

            this.kundeNummer = clsKundeDatenzugriff.AddNewKunde(kundeDaten);
            return (this.kundeNummer != -1);
        }

        public bool Save()
        {
            base._mode = (clsPerson.enMode)_mode;

            if (!base.Save()) // wenn die person daten nicht erfolgreich gespeichert wurden,wird der vorgang abgebrochen.
                return false; 

            switch(_mode)
            {
                case enMode.addnew:
                    if (_Addnew())
                    {
                        _mode = enMode.update;
                        return true;
                    }
                    else
                        return false;
            }

            return false;
        }
    }
}
