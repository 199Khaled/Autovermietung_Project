using Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busniss_Layer
{
    public class clsPerson
    {
        public enum enMode { addnew = 0, update }
        protected enMode _mode = enMode.addnew;

        public enum enGeschlecht { männlich = 0, weiblich = 1 }


        public int personID { get; set; }
        public string name { get; set; }
        public string vorname { get; set; }
        public string vollname
        {
            get { return vorname + " " + name; }
        }
        public DateTime geburtsDatum { get; set; }
        public enGeschlecht geschlecht { get; set; }
        public string strasse { get; set; }
        public string postleitzahl { get; set; }
        public string ort { get; set; }

        protected clsPerson(int personID, string vorname, string nachname,
                  DateTime geburtsTag, enGeschlecht geschlecht, 
                  string strasse, string postleitzahl,string ort)
        {
            this.personID = personID;
            this.name = nachname;
            this.vorname = vorname;
            this.geburtsDatum = geburtsTag;
            this.geschlecht = geschlecht;
            this.strasse = strasse;
            this.postleitzahl = postleitzahl;
            this.ort = ort;

            _mode = enMode.update;
        }

        public clsPerson()
        {
            this.personID = -1;
            this.name = string.Empty;
            this.vorname = string.Empty;
            this.geburtsDatum = DateTime.Now;
            this.geschlecht = enGeschlecht.männlich;
            this.strasse = string.Empty;
            this.postleitzahl = string.Empty;
            this.ort = string.Empty;

            _mode = enMode.addnew;
        }

        public static clsPerson FindByID(int personID)
        {
            clsPersonDatenzugriff.stPerson person = new clsPersonDatenzugriff.stPerson();

            bool isfound = clsPersonDatenzugriff.FindPersonByID(personID, ref person);

            if (isfound)
            {
                return new clsPerson(personID, person.Name, person.Vorname, person.GeburtsDatum, (enGeschlecht)person.Geschlecht,
                    person.Straße, person.Postleitzahl, person.Ort);
            }
            else
                return null;
   
        }
        private bool _Addnew()
        {
            clsPersonDatenzugriff.stPerson person = new clsPersonDatenzugriff.stPerson
            {
                Name = this.name,
                Vorname = this.vorname,
                GeburtsDatum = this.geburtsDatum,
                Geschlecht = (byte)this.geschlecht,
                Straße = this.strasse,
                Postleitzahl = this.postleitzahl,
                Ort = this.ort,
            };

            this.personID = clsPersonDatenzugriff.AddnewPerson(person);
            return (this.personID != -1);
        }

        protected bool Save()
        {
            switch (_mode)
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
        public static DataTable GetAllPersonen()
        {
            return clsPersonDatenzugriff.GetAllPersonen();
        }
    }
}
